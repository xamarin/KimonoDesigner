#KimonoCore.Mac API Documentation

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

Kimono Designer allows a developer to graphically edit Skia based graphic objects that can can be converted to code and included in any cross-platform language and OS that SkiaSharp supports. Kimono.Mac is the Xamarin.Mac specific of the Kimono cross-platform library that provides a helper interface to SkiaSharp.

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

<a name="6103df7f-d3a3-42a9-9a56-16cdd4d8fcda"></a>
##KimonoCore

###Summary

Provides the core Kimono objects that provide a high level interface to the SkiaSharp library.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#046b6991-7999-46f9-88a0-e5abdf7d8361'>Kimono</a></td><td style='width:75%' ><p>Holds a set of shared utilities that are used across the Kimono classes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fae21e79-93eb-42b6-b762-561f41464dce'>KimonoBlur</a></td><td style='width:75%' class='def'><p>Defines a blur effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#639c6397-7290-4595-a07f-28187ab889ac'>KimonoBounds</a></td><td style='width:75%' ><p>Defines the outter bounding box for a <code>KimonoShape</code> and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41122ae8-4826-48b0-8e4a-ee3184785b85'>KimonoColor</a></td><td style='width:75%' class='def'><p>The public <code>KimonoColor</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 17 fields, 72 properties, 94 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b165c88b-a830-4f7a-849f-eeecab4d05cb'>KimonoGradient</a></td><td style='width:75%' ><p>Defines a gradient as a collection of either <code>SKColor</code> or linked <code>KimonoColors</code> that can be applied to a <code>KimonoStyle</code> and used when drawing a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8669bb8-85ff-41f6-ab12-12c36ca8e95b'>KimonoGradientType</a></td><td style='width:75%' class='def'><p>Kimono gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3a2ffd3-76f2-4474-98da-a70eef7c09d8'>KimonoHandle</a></td><td style='width:75%' ><p>Defines an edit handle that the user manipulates to edit the bounds of a <code>KimonoShape</code> or the control points of a Bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a25d8ed1-6332-46d5-8b7d-5aad70e52f50'>KimonoHandleConstraint</a></td><td style='width:75%' class='def'><p>Constrains the movement of a <code>KimonoHandle</code> when it is being moved by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70c2ef11-f148-4072-b31b-fc357aaca407'>KimonoHandleType</a></td><td style='width:75%' ><p>Defines the type of a <code>KimonoHandle</code> that can be used as a general purpose control point to adjust the bounds of a <code>KimonoShape</code> or as a point for a vector or bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#195f0884-2949-40da-ab6c-5df36b4f88a0'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p>A Kimono Portfolio holds a collection of <code>KimonoSketches</code>, <code>KimonoStyles</code> and <code>KimonoColors</code> that define a given Kimono Designer project.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68d5259e-c294-48fc-bed4-4590fa128565'>KimonoShadow</a></td><td style='width:75%' ><p>Defines a shadow effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e0e6705-6811-444f-99e3-3670c315a4b5'>KimonoShape</a></td><td style='width:75%' class='def'><p>Defines the based shape that all other Kimono Shape types will inherit from.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae7d9bfe-d26d-4656-b90e-3c234e3fb535'>KimonoShapeArrow</a></td><td style='width:75%' ><p>Draws either an outlined or single line arrow with heads on one or both ends.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4396bdd6-990a-4ec6-9417-494b96ad9978'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p>A <code>KimonoShapeGroup</code> holds a collection of <code>KimonoShapes</code> that can be acted upon as a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157'>KimonoShapeGroupType</a></td><td style='width:75%' ><p>Defines the type of a <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7849552a-49ed-4035-a1df-0fa7bfe40516'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p>Draws a line on the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd'>KimonoShapeOval</a></td><td style='width:75%' ><p>Draws an oval into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#503226d4-73b7-4ece-8096-a9cc509a2752'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p>Draws a multi-sided polygon into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85d708a0-1446-4e21-9ba3-961994114384'>KimonoShapeRect</a></td><td style='width:75%' ><p>Draws a rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#429ac09f-fc9f-44ab-a634-e41870b8350a'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>Draws a rounded rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dea1abbc-1d3b-4c51-9ef9-257afde86f76'>KimonoShapeStar</a></td><td style='width:75%' ><p>Draws a multi-sided star shape into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#628fb735-c63a-41df-98d5-2353b7bb4b3d'>KimonoShapeState</a></td><td style='width:75%' class='def'><p>Holds the current state of a <code>KimonoShape</code> while it is being edited by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf'>KimonoShapeText</a></td><td style='width:75%' ><p>Draws a block of text into the Design Surface within the specifid bounds of this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5df8659c-9e94-4a72-8cbf-d6e33a87da2b'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p>Draws a triangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb84c492-9888-473d-932e-a6bb3e440850'>KimonoShapeVector</a></td><td style='width:75%' ><p>A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aec876fe-5a0c-43d7-830e-67738d4a5435'>KimonoSketch</a></td><td style='width:75%' class='def'><p>Holds a collection of <code>KimonoShapes</code> that are used to create a given image using Skia.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c441c4bb-a1b4-455f-aaca-18aa873ff2cf'>KimonoStyle</a></td><td style='width:75%' ><p>Defines as style that can be applied to a <code>KimonoShape</code> to control its appearance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#123b85c2-002f-4b58-8208-8b0fda7d825f'>KimonoStyleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoStyle</code> that will be used to draw a given <code>KimonoShape</code> in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb899de9-c57c-45d2-8438-cb8855487811'>KimonoTool</a></td><td style='width:75%' ><p>Defines the current tool that is active in a <code>KimonoSketch</code> that the user can use to create or modify a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7da2536-e17c-44b8-8f70-5065503d7de4'>KimonoUndoHandler</a></td><td style='width:75%' class='def'><p>Handles the undo/redo state for a <code>KimonoDesignSurface</code>.</p>
</td></tr></table></p>


---

<a name="70c34338-e489-4b85-b9d8-dee99ba79e31"></a>
##KimonoCore.Kimono

###Summary

Provides a set of common routines used throughout the KimonoCore classes.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#25985d5b-a2ce-424e-be45-441f59aa7c43'>ColorEventDelegate</a></td><td style='width:75%' ><p>Color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c8be89d-0395-4113-848e-8d6c6db2db41'>GradientEventDelegate</a></td><td style='width:75%' class='def'><p>Gradient event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c64185a8-24f9-4e70-a52a-7bb1c7ac80a2'>GroupEventDelegate</a></td><td style='width:75%' ><p>Group event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5436152c-1852-4971-8005-73d9893d5536'>HandleEventDelegate</a></td><td style='width:75%' class='def'><p>Handle event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3116afc-96a9-44b4-b4c7-2e30d9a194ef'>PortfolioEventDelegate</a></td><td style='width:75%' ><p>Portfolio event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d433a563-8929-4467-a4a2-cec7dd75d576'>ShapeEventDelegate</a></td><td style='width:75%' class='def'><p>Shape event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7beb193-d36a-4580-843e-5cf6a6983896'>SketchEventDelegate</a></td><td style='width:75%' ><p>Sketch event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#279cd13d-6307-48fe-9691-b3cf4cbafc18'>SkiaColorEventDelegate</a></td><td style='width:75%' class='def'><p>Skia color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfbe96be-6e35-47b9-a948-05247f47ad11'>SkiaPointEventDelegate</a></td><td style='width:75%' ><p>Skia point event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2aaf4313-c5a8-46c4-ba3e-028f99e9950e'>StyleEventDelegate</a></td><td style='width:75%' class='def'><p>Style event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a5cb542-03c0-4c45-b57f-4528c185e19f'>ToolEventDelegate</a></td><td style='width:75%' ><p>Tool event delegate.</p>
</td></tr></table></p>


---

<a name="178f98f2-a11f-4d79-8001-b25fb9e65211"></a>
##KimonoCore.Mac

###Summary

Kimono.Mac is the Xamarin.Mac specific of the Kimono cross-platform library that provides a helper interface to SkiaSharp.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e7e0780e-ee1f-4f5e-b65e-65dc1523314f'>KimonoDesignSurface</a></td><td style='width:75%' ><p>The Kimono Design Surface is a Xamarin.Mac specific editing surface that allows the user to modify a given <code>KimonoPortfolio</code> and the collection of <code>KimonoSketches</code> that it maintains.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#280365ed-8698-43da-8044-88ca04124c8f'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p>The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#add08d63-303c-40cb-84f2-e7c69c7c114f'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p>The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="25985d5b-a2ce-424e-be45-441f59aa7c43"></a>
##ColorEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Color event delegate.

---

<a name="6c8be89d-0395-4113-848e-8d6c6db2db41"></a>
##GradientEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Gradient event delegate.

---

<a name="c64185a8-24f9-4e70-a52a-7bb1c7ac80a2"></a>
##GroupEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Group event delegate.

---

<a name="5436152c-1852-4971-8005-73d9893d5536"></a>
##HandleEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Handle event delegate.

---

<a name="046b6991-7999-46f9-88a0-e5abdf7d8361"></a>
##Public Static Class Kimono

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Holds a set of shared utilities that are used across the Kimono classes.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#88459f85-0f11-4fde-8e33-5af3084a6112'>CharIsNumber</a></td><td style='width:75%' ><p>Test to see if the given character is a number character.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fec15414-9b53-473b-83e6-c57d9e30639e'>CloneSKPoint</a></td><td style='width:75%' class='def'><p>Clones the given <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6413b188-542c-4973-b31c-59f4a1015fed'>IncrementName</a></td><td style='width:75%' ><p>Increments the name by appending a number to the end or incrementing an existing number count.</p>
</td></tr></table></p>


---

<a name="fae21e79-93eb-42b6-b762-561f41464dce"></a>
##Public Class KimonoBlur

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Defines a blur effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b4a91635-8a77-41b0-b347-7b686d0bc2f9'>_horizontalBlurAmount</a></td><td style='width:75%' ><p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0ab5fcf-3927-456f-8081-c2168fb051a0'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ab86c0f-d8a5-4775-9cf0-1433a5470b91'>BlurModified</a></td><td style='width:75%' ><p>The private <code>BlurModified</code> field of the <code>KimonoBlur</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3394d753-1cfe-4d68-a16b-faf1767e59b8'>BlurFilter</a></td><td style='width:75%' ><p>Gets the blur filter represented by this blur effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00274501-463e-4e8e-b439-45cf57d4edf3'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p>Gets or sets the horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bea92c7-556d-4ae6-acec-818a9d649392'>VerticalBlurAmount</a></td><td style='width:75%' ><p>Gets or sets the vertical blur amount.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8167a45f-e54d-4d09-91fa-4cda5bd921bf'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7466906-8bc4-4519-a046-ce33784c2840'>KimonoBlur</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#fae21e79-93eb-42b6-b762-561f41464dce">KimonoBlur</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af208db0-838b-4135-ab9d-4e06afe5dc06'>KimonoBlur</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#fae21e79-93eb-42b6-b762-561f41464dce">KimonoBlur</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2249794f-9407-4289-a5cc-149f596105e0'>RaiseBlurModified</a></td><td style='width:75%' class='def'><p>Raises the blur modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4f08637d-4bbc-4fca-bbd1-9ec1e4cc23dd'>BlurModified</a></td><td style='width:75%' ><p>Occurs when the blur is modified.</p>
</td></tr></table></p>


---

<a name="639c6397-7290-4595-a07f-28187ab889ac"></a>
##Public Class KimonoBounds

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Defines the outter bounding box for a `KimonoShape` and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#afa0d6db-545e-4628-b65a-b9d80774c0d7'>PreviousCenter</a></td><td style='width:75%' ><p>Holds the previous center used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63615b92-e6df-4b24-95f3-8eed1632dab1'>PreviousRect</a></td><td style='width:75%' class='def'><p>Holds the previous rect used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#159fe11d-c9c4-45ed-8a56-6e5c48cbd8e6'>Rect</a></td><td style='width:75%' ><p>The base <code>SkRect</code> that holds the internal bounds of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#468eaf3d-39e6-4db2-a7e5-38636a9a29e9'>Bottom</a></td><td style='width:75%' ><p>Gets or sets the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfc67205-1f06-41c3-8661-ff6ffeaca662'>BottomHandle</a></td><td style='width:75%' class='def'><p>Gets or sets the bottom handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8578b5f4-9a2a-431e-83b7-cb97cb7e8bf3'>BottomLeftHandle</a></td><td style='width:75%' ><p>Gets or sets the bottom left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#932ac158-b1ce-4f96-9a47-c6906662428c'>BottomRightHandle</a></td><td style='width:75%' class='def'><p>Gets or sets the bottom right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40c29cbd-a580-434d-a574-858a4058988a'>Center</a></td><td style='width:75%' ><p>Gets the center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f766524-01e2-4542-bcd2-fd0d21ef59cf'>Height</a></td><td style='width:75%' class='def'><p>Gets or sets the height.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b56783c-b182-4b90-b26b-bbf341753c8b'>HitHandle</a></td><td style='width:75%' ><p>Gets or sets the hit handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05971f26-8ead-49d7-995f-dc641f8ae395'>HitOffset</a></td><td style='width:75%' class='def'><p>Gets or sets the hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24d8c7bd-b59f-4597-a041-fae20e60ffcc'>HorizontalCenter</a></td><td style='width:75%' ><p>Gets the horizontal center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebf31efb-467a-47e5-8ba3-258ae2f904e7'>Left</a></td><td style='width:75%' class='def'><p>Gets or sets the left.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4282e356-ee57-45ef-9a26-b679121a35c3'>LeftHandle</a></td><td style='width:75%' ><p>Gets or sets the left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cc8d718-799c-4a16-bfd5-71820bbbffec'>Right</a></td><td style='width:75%' class='def'><p>Gets or sets the right.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e841c0b-fc16-476c-ba34-b405dc13ccb7'>RightHandle</a></td><td style='width:75%' ><p>Gets or sets the right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87e50b21-ff2d-41d5-bda6-0d86504dd6c9'>RotationDegrees</a></td><td style='width:75%' class='def'><p>Gets or sets the rotation degrees.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04afcf7c-a25b-4d52-946f-7928fb28bed8'>State</a></td><td style='width:75%' ><p>Gets the current edit state of the <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed742916-2fbd-42af-a218-20fdeb316f4d'>Top</a></td><td style='width:75%' class='def'><p>Gets or sets the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16de6f21-40cf-436c-a35e-5d614c75afb3'>TopHandle</a></td><td style='width:75%' ><p>Gets or sets the top handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#857ea0a3-d4e2-4cac-88c7-77e6d959cb33'>TopLeftHandle</a></td><td style='width:75%' class='def'><p>Gets or sets the top left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddb9ac26-db0a-4b14-b8b4-6d92bd6da22e'>TopRightHandle</a></td><td style='width:75%' ><p>Gets or sets the top right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c3e86a6-27e7-41dc-8c37-7e41c68572e8'>UniqueID</a></td><td style='width:75%' class='def'><p>Gets or sets the unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ddac4b1-e198-4b16-a74e-b3d2691b7c3a'>VerticalCenter</a></td><td style='width:75%' ><p>Gets the vertical center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77534c49-02e9-436d-a041-bd0b21246cbe'>Width</a></td><td style='width:75%' class='def'><p>Gets or sets the width.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#89a8716a-3d5c-40f1-bc90-09fab1576cfd'>AddHandles</a></td><td style='width:75%' ><p>Adds the control handles to the bounds</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa07a6a5-91f3-4f88-bb8e-fb60aec17e61'>BoundsChanged</a></td><td style='width:75%' class='def'><p>Updates the location of the edit handles when the bounds has been relocated or resized.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2901840-7380-40fd-a41a-dcf38a0eae73'>ChangeBounds</a></td><td style='width:75%' ><p>Changes the bounds to match the given values.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6706bff2-d136-4973-8b53-bef835f762c4'>Clone</a></td><td style='width:75%' class='def'><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b919d47-a06e-4342-b67f-b1b2120521a5'>DragBounds</a></td><td style='width:75%' ><p>Drags the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49a675cb-5cb1-4123-9ae8-38c60c7e43e6'>Draw</a></td><td style='width:75%' class='def'><p>Draws the bounding box and its edit handles into the given canvas</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4f0b727-2043-40a6-b9e8-850cda128bbc'>GrowBounds</a></td><td style='width:75%' ><p>Adjusts the size of the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e7bb0e1-4a78-458c-8cd0-ea16a58a0def'>KimonoBounds</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#639c6397-7290-4595-a07f-28187ab889ac">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dac0bb2b-cc96-4f4d-924f-500622e97972'>KimonoBounds</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#639c6397-7290-4595-a07f-28187ab889ac">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b7db6bb-a21f-4940-9b9d-4cb203bd3e81'>KimonoBounds</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#639c6397-7290-4595-a07f-28187ab889ac">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#111b6f2b-084a-4169-8655-d19216cbb8a5'>MoveBounds</a></td><td style='width:75%' ><p>Moves the bounds to the given point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95dfdbbe-df39-4cb8-a891-b65698e1154d'>PlaceUnderConstruction</a></td><td style='width:75%' class='def'><p>Places the bounds under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#908692e6-318f-4628-9f3c-4153f3ab917c'>PointInBound</a></td><td style='width:75%' ><p>Test to see if the given point is inside of the current bounds</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1aae215-bc94-4775-bbbb-d1cbf2464f05'>RemoveHandles</a></td><td style='width:75%' class='def'><p>Removes the control handles from the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a52a98f-94f7-4736-b393-4d04a5c5707d'>SavePreviousBounds</a></td><td style='width:75%' ><p>Saves the previous bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fdfc2a71-3bd1-46ce-a7b3-d9295a2dacfd'>Select</a></td><td style='width:75%' class='def'><p>Puts the <code>KimonoShape</code> into the edit mode and creates the edit handles as required.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73d48c96-d7fb-41fd-ad9f-9dbeded2296f'>StartGrouping</a></td><td style='width:75%' ><p>Starts the bounds grouping.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54d12fdb-3ab8-41ee-bb4c-518561f4bb2c'>Unselect</a></td><td style='width:75%' class='def'><p>Unselects the <code>KimonoShape</code> as the current edit target and removes any edit handles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47672832-44cd-421c-8616-b23b691af103'>ValueBetween</a></td><td style='width:75%' ><p>Checks to see if the given value is between the two given points.</p>
</td></tr></table></p>


---

<a name="41122ae8-4826-48b0-8e4a-ee3184785b85"></a>
##Public Class KimonoColor

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

The public `KimonoColor` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 17 fields, 72 properties, 94 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9a4d6549-19dd-4c34-9612-82d27ebfe30e'>_adjustAlpha</a></td><td style='width:75%' ><p>Should adjust alpha transparency.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#418ee6d5-ed0e-4233-9641-ccb578e72af8'>_adjustBrightness</a></td><td style='width:75%' class='def'><p>Should adjust brightness.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85efa7d6-54a9-4179-82a3-d061c8b35e4c'>_adjustHue</a></td><td style='width:75%' ><p>Should adjust hue.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a18e52c-288f-4452-ad11-b210c941e7d9'>_adjustSaturation</a></td><td style='width:75%' class='def'><p>Should adjust saturation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cb6a07b-ea02-46f6-bf64-636904243c35'>_alphaAdjustment</a></td><td style='width:75%' ><p>The alpha adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d3e4982-a7d1-4ed9-b185-7c0c75fd1c1a'>_baseColor</a></td><td style='width:75%' class='def'><p>The <code>KiminoColor</code> this color is based off of.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e7d5016-2166-4e17-95aa-b0661288a918'>_brightnessAdjustment</a></td><td style='width:75%' ><p>The brightness adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#198b7f77-ac7e-49d9-a49a-724157c5ea08'>_color</a></td><td style='width:75%' class='def'><p>The color value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9405e5c-93e0-4d8a-bddf-ad4bfe573ab2'>_hueAdjustment</a></td><td style='width:75%' ><p>The hue adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c176c438-2e6b-40af-87fa-63839aa57707'>_saturationAdjustment</a></td><td style='width:75%' class='def'><p>The saturation adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6b4a0d5-27b5-4dba-b04b-1a04ed019ffa'>Alpha</a></td><td style='width:75%' ><p>The base alpha transparency value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84029c19-a92d-4aaa-bf0e-d8cd30d8cafb'>Brightness</a></td><td style='width:75%' class='def'><p>The base brightness.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#903e4838-a1c3-471e-865d-fef233acc1e0'>ColorChanged</a></td><td style='width:75%' ><p>The private <code>ColorChanged</code> field of the <code>KimonoColor</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd29945d-86be-47ae-92a8-759e240be7d2'>Hue</a></td><td style='width:75%' class='def'><p>The base hue.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eeb1f365-18be-472d-9080-a1ab3d7d4af9'>Saturation</a></td><td style='width:75%' ><p>The base saturation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a6de35ac-f5b8-4fbd-bba7-ffead4ae446c'>AdjustsAlpha</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#41122ae8-4826-48b0-8e4a-ee3184785b85">KimonoColor</a> adjusts alpha.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9faabd1-9363-41ce-a09f-c3bbae6f4a8d'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#41122ae8-4826-48b0-8e4a-ee3184785b85">KimonoColor</a> adjusts brightness.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22a69651-f07f-45ab-ac5b-4fae6b7d0905'>AdjustsHue</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#41122ae8-4826-48b0-8e4a-ee3184785b85">KimonoColor</a> adjusts hue.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13a88711-3743-463f-be3c-9bc3f846b168'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#41122ae8-4826-48b0-8e4a-ee3184785b85">KimonoColor</a> adjusts saturation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdd38a88-fc7f-4a2e-b332-697cd8a3ef86'>AlphaAdjustment</a></td><td style='width:75%' ><p>Gets or sets the alpha adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e35c6381-1f8d-47b7-bac5-ba2071c4c260'>Aluminum</a></td><td style='width:75%' class='def'><p>The public static read only <code>Aluminum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8335004c-8ec5-4169-b166-6979d8002eb9'>Aqua</a></td><td style='width:75%' ><p>The public static read only <code>Aqua</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1bc88c9a-812c-443b-b6b7-a375abf38c58'>Asparagus</a></td><td style='width:75%' class='def'><p>The public static read only <code>Asparagus</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5056df6-8fa5-4244-9ad4-5745d5470508'>Banana</a></td><td style='width:75%' ><p>The public static read only <code>Banana</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a9e5d9b-7a79-447c-8456-5caff609a803'>BaseColor</a></td><td style='width:75%' class='def'><p>Gets or sets the <code>KimonoColor</code> that this color is based off of.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dbfa235-3e02-40ca-9f6f-d6680c9f2f4d'>Black</a></td><td style='width:75%' ><p>The public static read only <code>Black</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b29a72ed-b46a-4874-a76f-4e492425fe30'>Blue</a></td><td style='width:75%' class='def'><p>The public static read only <code>Blue</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97bec9ad-7a99-4d84-9eb6-f0bba64fdee8'>Blueberry</a></td><td style='width:75%' ><p>The public static read only <code>Blueberry</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd450fed-5e5b-4514-aa58-ff54bcd9f248'>BrightnessAdjustment</a></td><td style='width:75%' class='def'><p>Gets or sets the brightness adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce48cc9d-14e6-4f02-8ca0-af4c83ad6ca4'>Bubblegum</a></td><td style='width:75%' ><p>The public static read only <code>Bubblegum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ee12196-2c50-4fdb-9018-9647278040a1'>Cantalope</a></td><td style='width:75%' class='def'><p>The public static read only <code>Cantalope</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb86e513-ff2c-4263-9816-8c87be0f9c05'>Carnation</a></td><td style='width:75%' ><p>The public static read only <code>Carnation</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3087f03b-7f84-4156-b25c-eb211e2afd43'>Cayenne</a></td><td style='width:75%' class='def'><p>The public static read only <code>Cayenne</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f50f1ffd-0d06-4682-bfee-c7af43d9e6b1'>Clover</a></td><td style='width:75%' ><p>The public static read only <code>Clover</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5afde92-f893-433d-8d9c-21c81867af2c'>Color</a></td><td style='width:75%' class='def'><p>Gets or sets the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06cec119-1370-4543-b8fc-6e28110597db'>DarkGray</a></td><td style='width:75%' ><p>The public static read only <code>DarkGray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c1cd35f-9112-44af-9d18-71461943c695'>Eggplant</a></td><td style='width:75%' class='def'><p>The public static read only <code>Eggplant</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c6c6470-6bec-48f1-9c35-be2b866a645a'>Fern</a></td><td style='width:75%' ><p>The public static read only <code>Fern</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e2a722a-6532-43de-bc4c-9571a8b04ef6'>Flora</a></td><td style='width:75%' class='def'><p>The public static read only <code>Flora</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a078778-a453-49e8-8e03-69f669748aeb'>Grape</a></td><td style='width:75%' ><p>The public static read only <code>Grape</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c15e780-95ab-44f6-a7a6-f6eb3a82f7e5'>Gray</a></td><td style='width:75%' class='def'><p>The public static read only <code>Gray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#262659dd-2571-454a-b45d-3cf9b8cd1052'>Green</a></td><td style='width:75%' ><p>The public static read only <code>Green</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df80b8fe-25ff-4fc9-a852-1715637418de'>Honeydew</a></td><td style='width:75%' class='def'><p>The public static read only <code>Honeydew</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac5bad60-3e48-4553-a417-165f28a46246'>HueAdjustment</a></td><td style='width:75%' ><p>Gets or sets the hue adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00648d93-330c-45d8-80df-b1763ded0fe2'>Ice</a></td><td style='width:75%' class='def'><p>The public static read only <code>Ice</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#196d0f9a-aa75-4188-b30e-bf85d71071e0'>Iron</a></td><td style='width:75%' ><p>The public static read only <code>Iron</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5b277e7-7afe-4496-b80b-027d7ffa8f1c'>Lavender</a></td><td style='width:75%' class='def'><p>The public static read only <code>Lavender</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76e3ac0a-226a-44bc-a3b8-b3d96703aa17'>Lead</a></td><td style='width:75%' ><p>The public static read only <code>Lead</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#355b877e-f1e0-4ab4-a0f6-394e77faae0b'>Lemon</a></td><td style='width:75%' class='def'><p>The public static read only <code>Lemon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5d0a321-d82a-4935-b0c4-b1a6da407a9f'>Licorice</a></td><td style='width:75%' ><p>The public static read only <code>Licorice</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#577962b7-7829-48ae-b390-89ed6be3500c'>LightGray</a></td><td style='width:75%' class='def'><p>The public static read only <code>LightGray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac5626e4-3cc9-48b6-aaad-c8e8ae6dee20'>Lime</a></td><td style='width:75%' ><p>The public static read only <code>Lime</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72ccb2ef-6775-40f7-ad3b-e96b81f6a6a5'>Magenta</a></td><td style='width:75%' class='def'><p>The public static read only <code>Magenta</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#330c91b4-e237-41ff-82de-195844ade69c'>Magnesium</a></td><td style='width:75%' ><p>The public static read only <code>Magnesium</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73629165-a85e-402a-89eb-19b61ddf2e5b'>Maraschino</a></td><td style='width:75%' class='def'><p>The public static read only <code>Maraschino</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94dfb6a1-888a-4e34-a37f-46e89b793356'>Maroon</a></td><td style='width:75%' ><p>The public static read only <code>Maroon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#331c56dc-d835-4e3c-933f-7297e9bb3a61'>Mercury</a></td><td style='width:75%' class='def'><p>The public static read only <code>Mercury</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8268eb1-4244-42ad-b0dd-1af693425f70'>Midnight</a></td><td style='width:75%' ><p>The public static read only <code>Midnight</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#921deb1f-be32-4bff-b3e8-8f3ee49785f5'>Mocha</a></td><td style='width:75%' class='def'><p>The public static read only <code>Mocha</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0bd6f18-babb-46d3-8670-3fe26078e259'>Moss</a></td><td style='width:75%' ><p>The public static read only <code>Moss</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f3964d4-77da-4833-b36d-c359364cd4da'>Name</a></td><td style='width:75%' class='def'><p>Gets or sets the name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ae1a474-dd79-49f2-8f45-79b5651d27ca'>Nickle</a></td><td style='width:75%' ><p>The public static read only <code>Nickle</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2af8986-4233-4a57-a731-eda74317ca0c'>Ocean</a></td><td style='width:75%' class='def'><p>The public static read only <code>Ocean</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3aed5bfb-4392-45fe-8e3b-e3dc7d42b6a6'>Orange</a></td><td style='width:75%' ><p>The public static read only <code>Orange</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6cdd16d-a440-43d4-bb40-97ad319d5e32'>Orchid</a></td><td style='width:75%' class='def'><p>The public static read only <code>Orchid</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#533fb82c-3d3a-4956-aeb9-16a307fec987'>Pink</a></td><td style='width:75%' ><p>The public static read only <code>Pink</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#daf9b7dd-9ef2-43ed-a35d-90aa42d40146'>Plum</a></td><td style='width:75%' class='def'><p>The public static read only <code>Plum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7058f0c-2f55-48cd-86bf-9791fd2b7189'>Purple</a></td><td style='width:75%' ><p>The public static read only <code>Purple</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae6ec7c2-e041-4900-8bc8-7f2c855f73ed'>Red</a></td><td style='width:75%' class='def'><p>The public static read only <code>Red</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5f7425e-fb63-4a28-afe2-cecb4a815d8f'>Salmon</a></td><td style='width:75%' ><p>The public static read only <code>Salmon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46c46cb7-b417-4c99-87b4-e5459f02e4d3'>SaturationAdjustment</a></td><td style='width:75%' class='def'><p>Gets or sets the saturation adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22bd1b05-1400-4f87-b528-ef02eb9020d8'>SeaFoam</a></td><td style='width:75%' ><p>The public static read only <code>SeaFoam</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afafe5d3-1464-4bc7-a049-023396554a83'>Silver</a></td><td style='width:75%' class='def'><p>The public static read only <code>Silver</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f48b851-8e92-4b19-b361-f7c321885f2f'>Sky</a></td><td style='width:75%' ><p>The public static read only <code>Sky</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c7bbebe-6aa0-406b-a623-10742966147a'>Snow</a></td><td style='width:75%' class='def'><p>The public static read only <code>Snow</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39a3d103-4823-4c4b-8e05-f80d98412723'>Spindrift</a></td><td style='width:75%' ><p>The public static read only <code>Spindrift</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b297857-5c46-4db1-9bc0-ac8f278877af'>Spring</a></td><td style='width:75%' class='def'><p>The public static read only <code>Spring</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a704c479-e5f5-4fd7-b78a-a06daa94e3f6'>Steel</a></td><td style='width:75%' ><p>The public static read only <code>Steel</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#988fb347-c593-4add-9d33-b7190caccb37'>Strawberry</a></td><td style='width:75%' class='def'><p>The public static read only <code>Strawberry</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae8f36cf-4388-40ff-aa5c-5de58b021b4b'>Tangerine</a></td><td style='width:75%' ><p>The public static read only <code>Tangerine</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d797727-aea7-4a61-a326-8ae0176a3a60'>Teal</a></td><td style='width:75%' class='def'><p>The public static read only <code>Teal</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43e7b82c-c034-4a02-ae24-95ad8741da44'>Tin</a></td><td style='width:75%' ><p>The public static read only <code>Tin</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9b9a0b1-f516-4101-944b-aef58b38b2e4'>Tungsten</a></td><td style='width:75%' class='def'><p>The public static read only <code>Tungsten</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#804b5554-431a-4d1d-b28f-0fed787e99b3'>Turquoise</a></td><td style='width:75%' ><p>The public static read only <code>Turquoise</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4838ec8b-32b6-4f38-891c-ff72552db575'>UniqueID</a></td><td style='width:75%' class='def'><p>Gets or sets the unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2cf1792-75e0-4259-912a-908b322ffc4a'>White</a></td><td style='width:75%' ><p>The public static read only <code>White</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0da3eab8-6def-4bd1-ae47-d0fe1a060770'>Yellow</a></td><td style='width:75%' class='def'><p>The public static read only <code>Yellow</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#05ec92a2-d108-460b-907d-db4a35a1ba2c'>BaseColorChanged</a></td><td style='width:75%' ><p>Handles the base color being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f209ebe0-66e1-4f88-b734-66fa5934f769'>Clone</a></td><td style='width:75%' class='def'><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60e348a3-83b0-4289-858c-f384a6aba6c3'>CloneColor</a></td><td style='width:75%' ><p>Clones the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a742a000-845f-4934-83af-918869efccec'>KimonoColor</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#41122ae8-4826-48b0-8e4a-ee3184785b85">KimonoColor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98c2b614-1f16-4cf5-9427-2ff7a4ab4516'>KimonoColor</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#41122ae8-4826-48b0-8e4a-ee3184785b85">KimonoColor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#704e80de-5d21-4146-bb77-de8b26bfc563'>KimonoColor</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#41122ae8-4826-48b0-8e4a-ee3184785b85">KimonoColor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f4e1a58-e510-4328-9372-78070125cf0d'>MixColor</a></td><td style='width:75%' ><p>Mixes the color based on the base values and any adjustment that have been applied.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#284ad5e6-e263-4ab4-ae68-95172a823e29'>RaiseColorChanged</a></td><td style='width:75%' class='def'><p>Raises the color changed event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9197a98a-f3f7-468a-9fdb-2d6814d653ef'>ColorChanged</a></td><td style='width:75%' ><p>Occurs when color changed.</p>
</td></tr></table></p>


---

<a name="e7e0780e-ee1f-4f5e-b65e-65dc1523314f"></a>
##Public Class KimonoDesignSurface

###Namespace

[KimonoCore.Mac](#178f98f2-a11f-4d79-8001-b25fb9e65211)

###Inherits From

`AppKit.NSImageView`

###Summary

The Kimono Design Surface is a Xamarin.Mac specific editing surface that allows the user to modify a given `KimonoPortfolio` and the collection of `KimonoSketches` that it maintains.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#35e8fc5a-ac64-4e14-9376-d6f6e2e1f22b'>_portfolio</a></td><td style='width:75%' ><p>The portfolio currently being worked on.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#460ccaa7-925b-4524-9e89-ab2dc7d45678'>ColorsModified</a></td><td style='width:75%' class='def'><p>The private <code>ColorsModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cd17f21-f979-4b57-ab3e-8a8c6e99c553'>GradientsModified</a></td><td style='width:75%' ><p>The private <code>GradientsModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42e201a1-6a7a-490d-84fd-11527a47c19c'>ReloadUI</a></td><td style='width:75%' class='def'><p>The private <code>ReloadUI</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44563e09-1650-48fb-aae2-7eaf047b9fab'>SelectedShapeModified</a></td><td style='width:75%' ><p>The private <code>SelectedShapeModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b081ac6-be9e-47d5-83e6-4f1755e56747'>SelectionChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectionChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e854e3f-d612-4a6f-89d7-47f2c3e7dee1'>SketchesModified</a></td><td style='width:75%' ><p>The private <code>SketchesModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e9c30b6-acc3-4ee9-bd8c-56b6cd93c221'>SketchModified</a></td><td style='width:75%' class='def'><p>The private <code>SketchModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13312ffc-e168-4e60-9541-91d3baa6c642'>SketchSizeChanged</a></td><td style='width:75%' ><p>The private <code>SketchSizeChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d42c0aac-3ede-4689-b8f9-c73693a7afa7'>StylesModified</a></td><td style='width:75%' class='def'><p>The private <code>StylesModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#039f0813-db8e-455d-b4f6-7a2984407d1a'>ToolChanged</a></td><td style='width:75%' ><p>The private <code>ToolChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cba2a4df-1aff-4134-a253-614742c48d1d'>UndoHandler</a></td><td style='width:75%' class='def'><p>The <code>KimonoUndoHandler</code> that handles undo and redo events for the  Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58023f7e-6582-40cf-8ae2-467c90f7032a'>UndoStateChanged</a></td><td style='width:75%' ><p>The private <code>UndoStateChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b77fbbab-6900-4bc9-b9e4-54f14eaa0be7'>CanRedo</a></td><td style='width:75%' ><p>Gets a value indicating whether the user can redo their last action.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4695609-3909-4ea0-81bb-2c168a3c3aee'>CanUndo</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether the user can undo their last action.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#faca4c4a-49d5-4c45-885e-07f2af96c0e6'>DeeplySelectedGroup</a></td><td style='width:75%' ><p>Gets the deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87a395ab-747e-4e80-8dd2-e7600b718f41'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p>Gets the deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bcef765-da78-472d-a118-32b199628b23'>Portfolio</a></td><td style='width:75%' ><p>Gets or sets the portfolio currently being worked on.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35195391-30f4-40c6-b1bf-3140107b045a'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#141aecb3-b1ef-43a2-83b2-f9a685c1b833'>SelectedSketch</a></td><td style='width:75%' ><p>Gets or sets the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b0ee87b-77e5-4275-81f6-d2aa72853170'>Tool</a></td><td style='width:75%' class='def'><p>Gets or sets the tool.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1eb123b5-eeee-4363-b422-241669bbe7cf'>AcceptsFirstResponder</a></td><td style='width:75%' ><p>Acceptses the first responder.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#727103f5-5d4b-4f4b-88fa-c6220d6c5892'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p>Converts a raw macOS mouse event point into the coordinates of the currently selected sketch's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3187a1bf-c4e1-49a6-ae2d-d45ba5b6d337'>DeleteSelectedShape</a></td><td style='width:75%' ><p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aae64c00-8141-43e7-9d1b-2b09d9b6acea'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89232dbe-0b34-4fb3-900a-fa9a0e20ab10'>HandleSketchChanging</a></td><td style='width:75%' ><p>Handles the currently selected sketch changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd4c85f1-f5fc-402e-bede-2a1642a1fade'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#030459db-0bfc-4ba2-afc3-378c476c0f0a'>KimonoDesignSurface</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#e7e0780e-ee1f-4f5e-b65e-65dc1523314f">KimonoDesignSurface</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06ee8aa4-f43c-4c15-ac44-b0adcd8c0c9a'>KimonoDesignSurface</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#e7e0780e-ee1f-4f5e-b65e-65dc1523314f">KimonoDesignSurface</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff10cb5d-6d1f-4f62-b4f7-f9fc89f3bea7'>KimonoDesignSurface</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#e7e0780e-ee1f-4f5e-b65e-65dc1523314f">KimonoDesignSurface</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e71edeb-76ac-40c7-95d2-1cb81d1c32b7'>KimonoDesignSurface</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#e7e0780e-ee1f-4f5e-b65e-65dc1523314f">KimonoDesignSurface</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#321a8fb7-4b86-4793-8082-94ccf4d091f6'>MouseDown</a></td><td style='width:75%' ><p>Handles the user clicking the mouse</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39156aeb-61ff-41c5-947d-b3ce03d835a7'>MouseDragged</a></td><td style='width:75%' class='def'><p>Handles the user dragging the mouse.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52546b43-ca67-408d-a3bb-29a9dc4517ad'>MouseMoved</a></td><td style='width:75%' ><p>Handles the user moving the mouse.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#626e6c8c-c1c9-4fd5-b945-487721bfda91'>MouseUp</a></td><td style='width:75%' class='def'><p>Handles the user releasing a mouse button.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e7e2ac5-0682-4a50-8543-5c7c434805fa'>RaiseColorsModified</a></td><td style='width:75%' ><p>Raises the colors modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ab90732-02f6-4f4b-a098-934a373fef1e'>RaiseGradientsModified</a></td><td style='width:75%' class='def'><p>Raises the gradients modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a018b084-2c40-4ddd-876c-3f94a555322a'>RaiseReloadUI</a></td><td style='width:75%' ><p>Raises the reload user interface event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb45e31c-8a93-42d1-89be-d6b70d212abb'>RaiseSelectedShapeModified</a></td><td style='width:75%' class='def'><p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#702e07f6-e5b3-4c8a-9847-a1685bf03e17'>RaiseSelectionChanged</a></td><td style='width:75%' ><p>Raises the selection changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4816e90c-db04-47f8-bef1-38d0151e3443'>RaiseSketchesModified</a></td><td style='width:75%' class='def'><p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e71d83b-23bb-47ae-965a-36965c240c50'>RaiseSketchModified</a></td><td style='width:75%' ><p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c1e5c4d-9989-4811-b1cc-623ac416916f'>RaiseSketchSizeChanged</a></td><td style='width:75%' class='def'><p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a48ebba8-f27f-4d50-9064-4d5e1847b7cd'>RaiseStylesModified</a></td><td style='width:75%' ><p>Raises the styles modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7571b28-6acf-4eec-b86d-74d90396901c'>RaiseToolChanged</a></td><td style='width:75%' class='def'><p>Raises the tool changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5db34ede-6d39-41e8-9078-2106b0f207a6'>RaiseUndoStateChanged</a></td><td style='width:75%' ><p>Raises the undo state changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5145c4c-e9b2-4ac6-b673-98ab0c3378ff'>Redo</a></td><td style='width:75%' class='def'><p>Redoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#baaf9a9b-fe57-47e9-bf8b-fb9b27a2b66f'>RedoChange</a></td><td style='width:75%' ><p>Redoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#367f9497-ecf8-4cf9-85b2-60482d020e46'>RefreshView</a></td><td style='width:75%' class='def'><p>Refreshs the Design Surface's view by redrawing the currently selected <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d37055c9-93a5-44cd-9b11-d87eee032243'>ReplaceUndoPoint</a></td><td style='width:75%' ><p>Replaces the last undo point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d53b768-d46a-4197-a3f2-7c1bccb17359'>SaveUndoPoint</a></td><td style='width:75%' class='def'><p>Saves a new undo point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd8e9aba-81d7-41b2-8138-d9d02aff5e54'>Undo</a></td><td style='width:75%' ><p>Udoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c20936fd-4570-47d8-a75c-d2fa6e2d9a04'>UndoChange</a></td><td style='width:75%' class='def'><p>Undoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2aa59cb-3368-49c5-8afc-21fadaa72880'>UnwirePortfolioEvents</a></td><td style='width:75%' ><p>Unwires the portfolio events from this Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b539a0a3-d40b-4050-9d90-718ca0bc99b7'>UnwireSketchEvents</a></td><td style='width:75%' class='def'><p>Unwires the sketch events from this Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95e7ae76-a456-4e74-9950-3ad463534baf'>WireupPortfolioEvents</a></td><td style='width:75%' ><p>Wireups the portfolio events to this Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b898744-6182-47ba-80dd-39fc7b83639d'>WireUpSketchEvents</a></td><td style='width:75%' class='def'><p>Wires up sketch events to this Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e37968b1-adfc-410d-bf49-46508369282f'>ColorsModified</a></td><td style='width:75%' ><p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e42ff13-7b6e-4499-ab7a-83d24e82f8bb'>GradientsModified</a></td><td style='width:75%' class='def'><p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#945cda63-4b44-44a6-9062-7126d18a7eff'>ReloadUI</a></td><td style='width:75%' ><p>Occurs when the user interface needs to be fully reloaded.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e147e22a-8c1c-4c5f-853b-020b17d4df95'>SelectedShapeModified</a></td><td style='width:75%' class='def'><p>Occurs when the selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccbef80f-c2f2-42cc-af42-95cdc14fdfaa'>SelectionChanged</a></td><td style='width:75%' ><p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2a2ea53-8a83-4cb6-8b75-766a396cbe91'>SketchesModified</a></td><td style='width:75%' class='def'><p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7940b021-0660-4307-8eba-0fa0b6fa708e'>SketchModified</a></td><td style='width:75%' ><p>Occurs when a sketch is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#939730ae-1c7d-48c2-833a-277d4f5f2f31'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#892c64c3-fce5-4e2a-8d2d-1b3a61ba8b6f'>StylesModified</a></td><td style='width:75%' ><p>Occurs when styles collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a392ed6-6439-4b3c-bd25-2728f5ac3f8f'>ToolChanged</a></td><td style='width:75%' class='def'><p>Occurs when tool changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#352a7d11-44db-46ef-b568-6c693ebafb13'>UndoStateChanged</a></td><td style='width:75%' ><p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="b165c88b-a830-4f7a-849f-eeecab4d05cb"></a>
##Public Class KimonoGradient

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Defines a gradient as a collection of either `SKColor` or linked `KimonoColors` that can be applied to a `KimonoStyle` and used when drawing a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cd8d8bb7-33fa-4081-8441-5ea3cbb12182'>_endPoint</a></td><td style='width:75%' ><p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d6a52e5-d72b-4521-8e2b-f17602043b4d'>_gradientType</a></td><td style='width:75%' class='def'><p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb566344-1f24-442e-bf7f-15d085f113d7'>_radius</a></td><td style='width:75%' ><p>The radius for radial and conical gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01f498e0-95ab-4153-8c0f-08eff3912e7e'>_selectedHandle</a></td><td style='width:75%' class='def'><p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fceef44-c192-49e8-8ed7-7e43bf875686'>_startPoint</a></td><td style='width:75%' ><p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afdf5970-ea46-42b1-9dd4-68b8454b1342'>_tileMode</a></td><td style='width:75%' class='def'><p>The gradient tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce3e4538-e789-4f32-8012-c031e3856844'>GradientModified</a></td><td style='width:75%' ><p>The private <code>GradientModified</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6ce8609-1553-45a2-a262-a46f00a7e46d'>HandleSelected</a></td><td style='width:75%' class='def'><p>The private <code>HandleSelected</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de53bfc5-9168-4819-83df-28c711ff6915'>PerformingDrag</a></td><td style='width:75%' ><p>Is the user performing a drag operation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6b360cc6-8ecc-4f78-8307-3329d5924c96'>BarHeight</a></td><td style='width:75%' ><p>Gets or sets the height of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a48a6ff7-03b8-4968-b461-ba4609e8bba9'>BarWidth</a></td><td style='width:75%' class='def'><p>Gets or sets the width of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c059426d-b6ed-4966-bd69-35e613073b83'>ControlPoints</a></td><td style='width:75%' ><p>Gets or sets the control points that define the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#825b266e-792b-451a-b92f-2709d7fcc57c'>EndPoint</a></td><td style='width:75%' class='def'><p>Gets or sets the end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e55ef72-2e3b-41e2-a68e-b0871023be4c'>GradientType</a></td><td style='width:75%' ><p>Gets or sets the type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91131a05-002e-4539-bcf8-dede9113b817'>Name</a></td><td style='width:75%' class='def'><p>Gets or sets the name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1847c555-d7d2-44cf-b07d-0c240c57c414'>PreviewHeight</a></td><td style='width:75%' ><p>Gets or sets the height of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e60d24c-d131-49b4-b615-950069aca001'>PreviewWidth</a></td><td style='width:75%' class='def'><p>Gets or sets the width of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9ec180a-8d4c-4817-a38a-37b4ddc9934b'>Radius</a></td><td style='width:75%' ><p>Gets or sets the radius used by radial and conical gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28276812-4d1e-4195-84c5-13698bd52e55'>SelectedColor</a></td><td style='width:75%' class='def'><p>Gets the color of the selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fe459cd-e350-4efa-b44f-d8760dd2d3b0'>SelectedHandle</a></td><td style='width:75%' ><p>Gets or sets the selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#312c5aa2-6f7b-4fab-a2f1-3afbd03ce86a'>Shader</a></td><td style='width:75%' class='def'><p>Gets the Skia Shader that represents this gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c5aa616-ee64-42fd-b9ab-b6d20517db77'>StartPoint</a></td><td style='width:75%' ><p>Gets or sets the start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5861d01f-8673-423b-bec7-c190e661ced7'>TileMode</a></td><td style='width:75%' class='def'><p>Gets or sets the tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cd14ce6-ad42-45f8-87bf-47d9c7072e5c'>UniqueID</a></td><td style='width:75%' ><p>Gets or sets the unique identifier.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fe5dae5d-2ed7-4cf5-8b59-fd5b40774137'>AddControlPoint</a></td><td style='width:75%' ><p>Adds a new control point to the gradients collection and makes it the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38be0ece-fa23-4bef-92e2-ab9207eb4d90'>BarToolDown</a></td><td style='width:75%' class='def'><p>Handles the user clicking a control point in the gradient design bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92c6a7bd-1a85-40f9-b832-66681f0f65e3'>BarToolDrag</a></td><td style='width:75%' ><p>Handles the user draging a control point in the gradient design bar. </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e047c4ed-15e8-4490-9e0a-83f4bc1e42af'>BarToolUp</a></td><td style='width:75%' class='def'><p>Handles the user releasing a control point in the gradient design bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#696afe93-6dfd-44f9-9a47-24a3aa88ddb3'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3761ed6d-5618-4433-9ecf-0b27a778a48b'>ConformingShader</a></td><td style='width:75%' class='def'><p>Generates a shader that conforms to a given start and end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12b56973-811e-4b06-8495-b7b22b893004'>DeleteSelectedControlPoint</a></td><td style='width:75%' ><p>Deletes the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ce6ddd2-5bad-4641-95be-fcaf228272fe'>DrawBar</a></td><td style='width:75%' class='def'><p>Draws the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67e988a7-00cf-4d11-8d15-7320462a58cf'>DrawPreview</a></td><td style='width:75%' ><p>Draws the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7b819d1-3e86-4f9c-b1fd-136b1d9303d1'>DuplicateSelectedControlPoint</a></td><td style='width:75%' class='def'><p>Duplicates the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16e676a8-75b7-456c-80e2-2e69a3d68e78'>FindHandle</a></td><td style='width:75%' ><p>Finds the handle matching the given unique ID.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6662db47-314e-4473-97ca-c8d90a49e52c'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86edabf5-be0f-431e-ab92-87fe2c966be0'>KimonoGradient</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#b165c88b-a830-4f7a-849f-eeecab4d05cb">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#176c22e3-f979-4715-9084-1ff195d33e26'>KimonoGradient</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#b165c88b-a830-4f7a-849f-eeecab4d05cb">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5a30340-4fed-4202-90e2-d1eb4c0fe940'>KimonoGradient</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#b165c88b-a830-4f7a-849f-eeecab4d05cb">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#938369db-4f4b-46f2-aab4-e9e40ceeb6c8'>PreviewToolDown</a></td><td style='width:75%' class='def'><p>Handles the user clicking a control point in the gradient preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3542c564-4471-4041-bdbf-18ec53a24664'>PreviewToolDrag</a></td><td style='width:75%' ><p>Handles the user draging a control point in the gradient preview. </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6967bed2-cc92-4902-8a7a-70c37123ac99'>PreviewToolUp</a></td><td style='width:75%' class='def'><p>Handles the user releasing a control point in the gradient preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb04dc7f-3c80-4f88-8534-34e67fdb1268'>RaiseGradientModified</a></td><td style='width:75%' ><p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#582988a3-91a5-494b-8274-c6ce1a1716db'>RaiseHandleSelected</a></td><td style='width:75%' class='def'><p>Raises the handle selected event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76ebd85b-4bee-48c0-bd35-11c8bb73172a'>SortedColors</a></td><td style='width:75%' ><p>Returns a list of sorted colors by their "X" location inside the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#455367ef-a628-4bdd-b8eb-0479489020bb'>SortedWeights</a></td><td style='width:75%' class='def'><p>Returns a list a color weights by their "X" location in the gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7c6ed5c3-3667-4149-b746-5d46a43e20d9'>GradientModified</a></td><td style='width:75%' ><p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#addc346e-1564-40ec-a52c-9254dd268c6b'>HandleSelected</a></td><td style='width:75%' class='def'><p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="280365ed-8698-43da-8044-88ca04124c8f"></a>
##Public Class KimonoGradientDesignBar

###Namespace

[KimonoCore.Mac](#178f98f2-a11f-4d79-8001-b25fb9e65211)

###Inherits From

`AppKit.NSImageView`

###Summary

The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#44469641-1133-4492-9254-60db286dbb35'>_gradient</a></td><td style='width:75%' ><p>The private <code>_gradient</code> field of the <code>KimonoGradientDesignBar</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec77d40a-c559-4c9b-87e9-060bffa60207'>HandleSelected</a></td><td style='width:75%' class='def'><p>The private <code>HandleSelected</code> field of the <code>KimonoGradientDesignBar</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f0bb608c-0e99-47c3-a952-392b7a2ccb46'>Gradient</a></td><td style='width:75%' ><p>Gets or sets the gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0f352456-f80d-44f5-a605-a144f13ce3d0'>AcceptsFirstResponder</a></td><td style='width:75%' ><p>Acceptses the first responder.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e65e1209-a190-4ab6-9c6b-90b220aeaac9'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p>Converts a raw macOS mouse event point into the coordinates of the currently selected bar's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99f84ed7-4a65-49ba-9e05-67e28b60aab6'>HandleGradientModified</a></td><td style='width:75%' ><p>Handles the gradient being modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a50f479-8fac-4103-b2f3-f24d7310c25a'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1647a9f1-9664-4ddd-b089-b604c90608b6'>KimonoGradientDesignBar</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29781c74-00c0-4879-82c2-a2b2ed0e7d16'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a608def7-4e88-4630-9e74-1a519831a916'>KimonoGradientDesignBar</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abdc500e-e94b-4662-9e90-3a2bdb8952e1'>MouseDown</a></td><td style='width:75%' class='def'><p>Handles the user clicking the mouse</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a19cba97-b16a-408d-9fa7-e3d1eea4fd41'>MouseDragged</a></td><td style='width:75%' ><p>Handles the user dragging the mouse.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5521dc9-02da-4ccf-ab2d-02b9ed0c7ec5'>MouseMoved</a></td><td style='width:75%' class='def'><p>Handles the user moving the mouse.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62aa29f1-efde-409a-a57e-30e5fb6a67db'>MouseUp</a></td><td style='width:75%' ><p>Handles the user releasing a mouse button.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95b8307b-736d-4716-8a45-92d895497730'>RaiseHandleSelected</a></td><td style='width:75%' class='def'><p>Raises the handle selected event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1aff2631-1223-42ad-9272-20f5490d2ecc'>RefreshView</a></td><td style='width:75%' ><p>Refreshs the view by redrawing the gradient design bar.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#872a9106-1fbb-4870-91f2-88ddd18c76df'>HandleSelected</a></td><td style='width:75%' ><p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="add08d63-303c-40cb-84f2-e7c69c7c114f"></a>
##Public Class KimonoGradientDesignPreview

###Namespace

[KimonoCore.Mac](#178f98f2-a11f-4d79-8001-b25fb9e65211)

###Inherits From

`AppKit.NSImageView`

###Summary

The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1d4c2b82-ab62-4b35-a8d7-7925312d104b'>_gradient</a></td><td style='width:75%' ><p>The private <code>_gradient</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c872c60e-b1f8-467e-9e93-91e812b33c08'>GradientModified</a></td><td style='width:75%' class='def'><p>The private <code>GradientModified</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1156ebb-23ea-4ea8-a45a-326bc6bdbb49'>HandleSelected</a></td><td style='width:75%' ><p>The private <code>HandleSelected</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#11d9372e-d95c-4d34-932a-3ffb4badd70f'>Gradient</a></td><td style='width:75%' ><p>Gets or sets the gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#824c01d7-8483-4534-8cb3-045e9a9024fc'>AcceptsFirstResponder</a></td><td style='width:75%' ><p>Acceptses the first responder.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bf9d26d-887b-4df6-95a5-69d39b6a3a65'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p>Converts a raw macOS mouse event point into the coordinates of the currently selected bar's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5990744e-dcaa-421e-88ed-f5341d9ef889'>HandleGradientModified</a></td><td style='width:75%' ><p>Handles the gradient being modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4899a667-c111-4676-85f9-4c44c2c37165'>KimonoGradientDesignPreview</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ed5c459-cd28-4956-993b-38f6ace92392'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5589cd1d-2e18-4b1c-ac52-19c8cd123bb4'>KimonoGradientDesignPreview</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5cf4c5ac-794f-41ac-abfc-54f6e2abe0ca'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#280365ed-8698-43da-8044-88ca04124c8f">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eee09301-ad33-46d3-9f4a-418f91f6a822'>MouseDown</a></td><td style='width:75%' class='def'><p>Handles the user clicking the mouse</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2dd1d2d-fed9-4fab-a37f-5f985f1ddb99'>MouseDragged</a></td><td style='width:75%' ><p>Handles the user dragging the mouse.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e74e6bc-0f7c-4acf-aa84-197427bc27c8'>MouseMoved</a></td><td style='width:75%' class='def'><p>Handles the user moving the mouse.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#848d424c-0b25-4b83-98d4-b84aed0f7f30'>MouseUp</a></td><td style='width:75%' ><p>Handles the user releasing a mouse button.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#053bc160-15a8-48c3-8b22-efa7d0aebfa4'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc3d318c-65d9-40ff-af2f-81b939ea750f'>RaiseHandleSelected</a></td><td style='width:75%' ><p>Raises the handle selected event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3466be51-b652-4f37-9646-68aa7617730a'>RefreshView</a></td><td style='width:75%' class='def'><p>Refreshs the view by redrawing the gradient design bar.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2a20f97f-45f9-4d9e-971f-4aad99e9dc9f'>GradientModified</a></td><td style='width:75%' ><p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15e2ddcf-834e-4631-a0d5-cdc1dc68ffaf'>HandleSelected</a></td><td style='width:75%' class='def'><p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="c8669bb8-85ff-41f6-ab12-12c36ca8e95b"></a>
##Public Enum KimonoGradientType

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Enum`

###Summary

Kimono gradient type.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0dc0514c-2965-44e4-a5fc-a70491d17480'>ConicalGradient</a></td><td style='width:75%' ><p>The conical gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4745336-7b9e-47e0-9617-8f4e2114e5ea'>LinearGradient</a></td><td style='width:75%' class='def'><p>The linear gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fb90bee-3803-4cfb-a9e8-fb97e7bef8bf'>RadialGradient</a></td><td style='width:75%' ><p>The radial gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a81aa54-4fbf-4bb2-8453-8a38bc77de26'>SweepGradient</a></td><td style='width:75%' class='def'><p>The sweep gradient.</p>
</td></tr></table></p>


---

<a name="d3a2ffd3-76f2-4474-98da-a70eef7c09d8"></a>
##Public Class KimonoHandle

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Defines an edit handle that the user manipulates to edit the bounds of a `KimonoShape` or the control points of a Bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#29a32ccf-bbce-4946-aa45-5e445c67b6bb'>DrawOffset</a></td><td style='width:75%' ><p>The draw offset of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a453ec07-5aa4-4fe2-848d-4a9eab095f38'>DrawWidth</a></td><td style='width:75%' class='def'><p>The width of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afd3b700-ac34-4740-999b-08db50117f39'>Moved</a></td><td style='width:75%' ><p>The private <code>Moved</code> field of the <code>KimonoHandle</code> class holds a <code>KimonoCore.Kimono.SkiaPointEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7ce416db-cdfd-48c8-9e98-c06b8706aab3'>Color</a></td><td style='width:75%' ><p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, this color will be used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b800687-66a6-4367-affc-d3a41af271d8'>Constraint</a></td><td style='width:75%' class='def'><p>Gets or sets the edit constraint.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#239e6e7e-30f1-4249-8cd4-5be514edce43'>HandleType</a></td><td style='width:75%' ><p>Gets or sets the type of the handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db71a5e9-6e0d-4258-91b8-e692f2a393d8'>HitOffset</a></td><td style='width:75%' class='def'><p>Gets or sets the hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6004b0ee-5439-4121-98a9-68bcb57dc673'>Index</a></td><td style='width:75%' ><p>Gets or sets the index.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f766397-6fee-4ed2-91bb-b42bef2dd3d4'>LinkedColor</a></td><td style='width:75%' class='def'><p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, the <code>Color</code> property will  be used instead.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7797d30-0c73-44d2-b538-d4a07c23ce12'>Rect</a></td><td style='width:75%' ><p>Gets the rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68e16773-012f-4d19-9d88-534ac51c41cd'>RepresentedColor</a></td><td style='width:75%' class='def'><p>Gets the color that this handle represents.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35d2ad7d-bf77-487b-85c6-afe5b42471c1'>State</a></td><td style='width:75%' ><p>Gets the edit state of the <code>KimonoHandle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0722acfd-3ace-427f-827d-8476240a4e49'>UniqueID</a></td><td style='width:75%' class='def'><p>Gets or sets the unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a78fc769-e53d-4eda-abb9-a5aebccf4cdc'>X</a></td><td style='width:75%' ><p>Gets or sets the x value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36cd876c-505e-4b34-a602-209501c81790'>Y</a></td><td style='width:75%' class='def'><p>Gets or sets the y value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3114f3a0-85a5-4a74-9240-91b0925f265e'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d946cec8-e2a5-48f3-92e7-5c1ce71b87ee'>DragHandle</a></td><td style='width:75%' class='def'><p>Drags the handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2fc3ffa-7a04-487f-a647-ab21b3fc49c6'>Draw</a></td><td style='width:75%' ><p>Draws the hanled into the given Skia canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78da86a5-6f40-47e9-adba-f42e3d1d790d'>KimonoHandle</a></td><td style='width:75%' class='def'><p>The private static <code>KimonoHandle ()</code> constructor for the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f83fd58-c4fa-42e0-8ad2-85f592401109'>KimonoHandle</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#d3a2ffd3-76f2-4474-98da-a70eef7c09d8">KimonoHandle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69d167a4-4d46-4b90-b528-21de635162d7'>KimonoHandle</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#d3a2ffd3-76f2-4474-98da-a70eef7c09d8">KimonoHandle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af4d32a6-c75a-44b9-8e30-2f5150b5d189'>KimonoHandle</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#d3a2ffd3-76f2-4474-98da-a70eef7c09d8">KimonoHandle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30b55d08-620f-452a-887f-121079b1a9af'>KimonoHandle</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#d3a2ffd3-76f2-4474-98da-a70eef7c09d8">KimonoHandle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94ecbd32-b618-4e86-beed-34e2f9f61c53'>MoveTo</a></td><td style='width:75%' ><p>Moves the handle to the given coordinates.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7c204cb-f7ca-44f6-8b27-68eb9b255359'>PointInBound</a></td><td style='width:75%' class='def'><p>Test to see if the given point is inside of the current bounds</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a421db20-36bb-4293-a157-e9f27a99bf05'>RaiseMoved</a></td><td style='width:75%' ><p>Raises the moved event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0d100c12-157d-4d71-a49f-fc852e68fc13'>Moved</a></td><td style='width:75%' ><p>Occurs when moved.</p>
</td></tr></table></p>


---

<a name="a25d8ed1-6332-46d5-8b7d-5aad70e52f50"></a>
##Public Enum KimonoHandleConstraint

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Enum`

###Summary

Constrains the movement of a `KimonoHandle` when it is being moved by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eb68afe1-2a3e-4780-8d3d-d82aaf12cdf7'>Horizontal</a></td><td style='width:75%' ><p>The handle can only be moved horizontally.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7086f8ff-4e16-49e8-a4e6-b322088f6211'>Locked</a></td><td style='width:75%' class='def'><p>The handle is locked in place and cannot be moved.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f07438a1-4340-4ab5-9321-9c5dab9d0838'>None</a></td><td style='width:75%' ><p>No movement constraint.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f56756b-3f24-4720-85a6-fb1bdc97602f'>Vertical</a></td><td style='width:75%' class='def'><p>The handle can only be moved vertically.</p>
</td></tr></table></p>


---

<a name="70c2ef11-f148-4072-b31b-fc357aaca407"></a>
##Public Enum KimonoHandleType

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Enum`

###Summary

Defines the type of a `KimonoHandle` that can be used as a general purpose control point to adjust the bounds of a `KimonoShape` or as a point for a vector or bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f795e98f-e7c2-4f88-8ea3-d6d66683ce59'>ControlPoint</a></td><td style='width:75%' ><p>A general purpose handle for a shape's bound or a control point on a  vector or bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf50e74d-7e15-4617-9706-3c4f72b6df21'>GradientColor</a></td><td style='width:75%' class='def'><p>Defines a color inside of a gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b12f9c25-cb5e-424e-a087-a7b0f07b3b72'>GradientPosition</a></td><td style='width:75%' ><p>Defines the position of a gradient in a shape object.</p>
</td></tr></table></p>


---

<a name="195f0884-2949-40da-ab6c-5df36b4f88a0"></a>
##Public Class KimonoPortfolio

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

A Kimono Portfolio holds a collection of `KimonoSketches`, `KimonoStyles` and `KimonoColors` that define a given Kimono Designer project.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#94606723-3ad2-4f6f-a186-2961f4abf970'>_selectedSketch</a></td><td style='width:75%' ><p>The currently selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9a5b230-930e-45d8-8159-d7f103bfa3cf'>ColorsModified</a></td><td style='width:75%' class='def'><p>The private <code>ColorsModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdafb91b-f0c7-4fdd-ae25-5639d95942b6'>GradientsModified</a></td><td style='width:75%' ><p>The private <code>GradientsModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#156df400-a324-4953-84fa-e743d48936ad'>NewSketchNumber</a></td><td style='width:75%' class='def'><p>Holds the number that will be assigned to the next new <code>KimonoSketch</code> created in this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9e8361a-5eec-4c72-9ef4-3da18562fb2b'>RequestNewUndoPoint</a></td><td style='width:75%' ><p>The private <code>RequestNewUndoPoint</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d371f28-9e17-4aa7-aad5-fcfbd9b53945'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectedShapeChanged</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d22775e-b753-4c87-8b65-5d63e700709c'>SelectedSketchDidChange</a></td><td style='width:75%' ><p>The private <code>SelectedSketchDidChange</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46e18a7e-faef-4ba4-91c2-4a1add217b2f'>SelectedSketchWillChange</a></td><td style='width:75%' class='def'><p>The private <code>SelectedSketchWillChange</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afb20ba4-1ed7-454b-9df6-75a3aba3d0fd'>SketchesModified</a></td><td style='width:75%' ><p>The private <code>SketchesModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a20d883-5617-4490-9137-6cabce6329fc'>StylesModified</a></td><td style='width:75%' class='def'><p>The private <code>StylesModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6e3416f3-eba6-4a8f-bc41-88e530c5ddab'>Colors</a></td><td style='width:75%' ><p>Gets or sets the colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51377f0c-bc80-46e8-ad79-01925cc28c2e'>Gradients</a></td><td style='width:75%' class='def'><p>Gets or sets the gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42f86b9c-2bb1-4af8-a42a-87e1c305f8af'>SelectedSketch</a></td><td style='width:75%' ><p>Gets or sets the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#477b6f3c-92f0-476b-b89b-ce19a51dda88'>Sketches</a></td><td style='width:75%' class='def'><p>Gets or sets the sketches.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b07422c-b878-425f-974f-b7ad32a86d43'>Styles</a></td><td style='width:75%' ><p>Gets or sets the styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7db1c2e9-8d4f-477c-b894-e43eb61d3a7e'>UniqueID</a></td><td style='width:75%' class='def'><p>Gets or sets the unique identifier.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c32168ca-39c3-4c74-9f80-16b21f48841e'>AddNewColor</a></td><td style='width:75%' ><p>Adds a new <code>KimonoColor</code> to this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bd29f74-10ba-47ac-b9d7-691e669d47e8'>AddNewColor</a></td><td style='width:75%' class='def'><p>Adds a new <code>KimonoColor</code> to this portfolio based off of a given <code>SKColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84209fbc-0bde-426c-8cd2-b2fcf9c7c5b5'>AddNewGradient</a></td><td style='width:75%' ><p>Adds the new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbc58116-b638-4c7c-84bf-ca4384e3810e'>AddNewSketch</a></td><td style='width:75%' class='def'><p>Adds the a new <code>KimonoSketch</code> to this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#044c1edc-8059-47e8-bf2d-90d4a5f2fdbe'>AddNewStyle</a></td><td style='width:75%' ><p>Adds the a new <code>KimonoStyle</code> to the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3d7fd22-37bb-4ffd-a191-a21c78cba680'>Clone</a></td><td style='width:75%' class='def'><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c54b2241-4df5-4fb6-9f92-8a5e9595cc36'>ConvertSelectedShapeToStyle</a></td><td style='width:75%' ><p>Takes the custom <code>KimonoStyle</code> of the currently selected <code>KimonoShape</code>, converts it to a named, shared style and adds it to the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52292738-ddf0-4d63-8f6b-309c3cd2e5b5'>DeleteColor</a></td><td style='width:75%' class='def'><p>Deletes the given <code>KimonoColor</code> from the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1e6ebde-c469-416d-bfb3-54f788a8bd21'>DeleteGradient</a></td><td style='width:75%' ><p>Deletes the given gradient from the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6a7aef5-89bc-4a73-803a-51ad422cc5a6'>DeleteSelectedSketch</a></td><td style='width:75%' class='def'><p>Deletes the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd6d57fb-4129-4158-b705-00716c78cb22'>DeleteStyle</a></td><td style='width:75%' ><p>Deletes the given <code>KimonoStyle</code> from the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8e6aa99-4a69-4564-9028-d28b4e892e59'>DuplicateColor</a></td><td style='width:75%' class='def'><p>Duplicates the given <code>KimonoColor</code> and adds it to the portfolio's collection of colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cc70dd1-9087-4fec-8f2e-aec307d80c4f'>DuplicateGradient</a></td><td style='width:75%' ><p>The public <code>DuplicateGradient (KimonoCore.KimonoGradient)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0098d5c6-4f31-45fd-8e77-8168c3d04501'>DuplicateSelectedSketch</a></td><td style='width:75%' class='def'><p>Duplicates the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2914c27-039e-43f5-8454-8b7c265c253b'>DuplicateStyle</a></td><td style='width:75%' ><p>Duplicates the given <code>KimonoStyle</code> adding it to the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64c7d5c1-2f83-4e0c-93ea-d76994ce847a'>FindColor</a></td><td style='width:75%' class='def'><p>Finds the given <code>KimonoColor</code> by its unique ID.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a14c461b-92eb-4030-a40d-57f36a8b5ab9'>FindGradient</a></td><td style='width:75%' ><p>Finds the gradient by its unique ID.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47747538-416c-4e31-bb34-a4d289e41663'>FindSketch</a></td><td style='width:75%' class='def'><p>Finds the given <code>KimonoSketch</code> by its Unique ID.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a7eff20-be05-4cb6-9c72-06dd8bced676'>FindStyle</a></td><td style='width:75%' ><p>Finds the given <code>KimonoStyle</code> by its Unique ID.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec80e9c7-a92e-4d27-8b62-f09b7d264fe2'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8685aa0e-5576-4d83-b91a-9124a3d3f90c'>KimonoPortfolio</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#195f0884-2949-40da-ab6c-5df36b4f88a0">KimonoPortfolio</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8dac4f41-1777-48bc-b2a3-25f65af9dd98'>RaiseColorsModified</a></td><td style='width:75%' class='def'><p>Raises the colors modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5a0df3d-1348-47fd-a8ee-b8efe779d0bc'>RaiseGradientsModified</a></td><td style='width:75%' ><p>Raises the gradients modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0d27747-35ab-4820-a96d-621244273ef3'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec6a6466-b9b1-40ea-a3da-4587c14d978d'>RaiseSelectedShapeChanged</a></td><td style='width:75%' ><p>Raises the selected shape changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0938b09-4b96-438b-b985-2d63e18e7a76'>RaiseSelectedSketchDidChange</a></td><td style='width:75%' class='def'><p>Raises the selected sketch did change event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fd107a3-15f0-4ca3-a478-fb19db06b565'>RaiseSelectedSketchWillChange</a></td><td style='width:75%' ><p>Raises the selected sketch will change event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0741924-a677-4feb-bfa3-32dbe7f8f054'>RaiseSketchesModified</a></td><td style='width:75%' class='def'><p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da3b8cfe-b594-4f96-b4ee-21e36b4162f5'>RaiseStylesModified</a></td><td style='width:75%' ><p>Raises the styles modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91955ef4-d030-4139-9ca1-3e083a1b3b30'>RelinkColors</a></td><td style='width:75%' class='def'><p>Relinks the colors after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80fda76d-f2b8-4851-a034-2f0a8f4d4b21'>RelinkGradient</a></td><td style='width:75%' ><p>Relinks the gradient after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#735421e6-15a4-456c-a746-84773194cf79'>RelinkShape</a></td><td style='width:75%' class='def'><p>Relinks the given <code>KimonoShape</code> after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f466d50d-208a-4784-a006-ce665cb8d6f8'>RelinkSketch</a></td><td style='width:75%' ><p>Relinks the given <code>KimonoSketch</code> after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c36665f0-73de-47df-8780-ba60545cbb9f'>RelinkStyle</a></td><td style='width:75%' class='def'><p>Relinks the given <code>KimonoStyle</code> after a clone operation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0a1a982d-8789-4000-9b9a-8e118c2504fd'>ColorsModified</a></td><td style='width:75%' ><p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6b766e6-e4d4-431a-831f-e814201fed73'>GradientsModified</a></td><td style='width:75%' class='def'><p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20c91322-0579-4cb8-bf40-d1e98bcf84b7'>RequestNewUndoPoint</a></td><td style='width:75%' ><p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e123802c-a03d-4df2-bbcc-44bb5bd2737a'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p>Occurs when selected shape changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c09ac749-25db-49eb-b6ec-8a4193df5e16'>SelectedSketchDidChange</a></td><td style='width:75%' ><p>Occurs when selected sketch did change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d35c9a3-67c0-4f0b-88fb-da546eb5cd73'>SelectedSketchWillChange</a></td><td style='width:75%' class='def'><p>Occurs when selected sketch will change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2af98e1e-fec0-40c2-8cab-7ae7d82d0c4d'>SketchesModified</a></td><td style='width:75%' ><p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac1ffa01-ac9a-4fb7-9a61-79c32dd2e51f'>StylesModified</a></td><td style='width:75%' class='def'><p>Occurs when styles collection is modified.</p>
</td></tr></table></p>


---

<a name="68d5259e-c294-48fc-bed4-4590fa128565"></a>
##Public Class KimonoShadow

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Defines a shadow effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#90cfcc62-e0fc-4951-b76d-7cc3dce4d488'>_color</a></td><td style='width:75%' ><p>The color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c50bc5d-26df-4ab8-a548-7909f5a03ae0'>_horizontalBlurAmount</a></td><td style='width:75%' class='def'><p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d007efb-e072-44af-a249-34f3d714857d'>_horizontalOffset</a></td><td style='width:75%' ><p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#080898cb-6ed0-4c41-b87f-44351f947dac'>_linkedColor</a></td><td style='width:75%' class='def'><p>A linked <code>KimonoColor</code> to use as the shadow color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82f6951f-46d8-4d35-acb9-dff08ff927af'>_verticalBlurAmount</a></td><td style='width:75%' ><p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34a7ff8f-575e-4cc5-82ec-2bafdc4dfb2d'>_verticalOffset</a></td><td style='width:75%' class='def'><p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dbbedbb-ec02-4354-bc26-d72c6a21a0d1'>ShadowModified</a></td><td style='width:75%' ><p>The private <code>ShadowModified</code> field of the <code>KimonoShadow</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1e0754e3-0d0e-4113-b217-93c9065dd4fa'>Color</a></td><td style='width:75%' ><p>Gets or sets the color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2e8e573-afc3-4198-a343-11bd3742eda1'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p>Gets or sets the horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0970600-c61b-472e-ad83-57323ff5825c'>HorizontalOffset</a></td><td style='width:75%' ><p>Gets or sets the horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#953c0dd0-d766-462a-b05f-4f51cf4d5a83'>LinkedColor</a></td><td style='width:75%' class='def'><p>Gets or sets the color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#594cb038-89d3-41e8-ac52-35c9f0a64804'>ShadowColor</a></td><td style='width:75%' ><p>Gets the color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eadc19d9-8270-4671-ae0d-fc2db41857e5'>ShadowFilter</a></td><td style='width:75%' class='def'><p>Gets the shadoe filter represented by this shadow effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b44dd95-7f2f-4bc7-b676-ddcfb5a72e24'>VerticalBlurAmount</a></td><td style='width:75%' ><p>Gets or sets the vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81d708bc-2aeb-48c7-8d53-cd2d7fcb3c0a'>VerticalOffset</a></td><td style='width:75%' class='def'><p>Gets or sets the vertical offset.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c5fec200-8f9e-4014-92f7-e242eb17e8de'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcb2a2f4-38de-47b1-ac95-9e105f42517f'>HandleLinkedColorChanged</a></td><td style='width:75%' class='def'><p>Handles the linked color changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01491009-13b5-4536-a4aa-8fbffbb171b1'>KimonoShadow</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#68d5259e-c294-48fc-bed4-4590fa128565">KimonoShadow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a284970-72ef-4beb-983f-1e56e25811b1'>KimonoShadow</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#68d5259e-c294-48fc-bed4-4590fa128565">KimonoShadow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15af7e34-1e34-4455-8c0a-1055bb924bbf'>RaiseShadowModified</a></td><td style='width:75%' ><p>Raises the shadow modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#292efbbe-8921-468d-b1d8-e88d0a66806c'>ShadowModified</a></td><td style='width:75%' ><p>Occurs when the shadow is modified.</p>
</td></tr></table></p>


---

<a name="4e0e6705-6811-444f-99e3-3670c315a4b5"></a>
##Public Class KimonoShape

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Defines the based shape that all other Kimono Shape types will inherit from.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#042e24f4-a0d4-4896-af14-2cab8785f48b'>_name</a></td><td style='width:75%' ><p>The default name of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b244474d-d231-4061-b2ec-7d6e1e25152c'>_style</a></td><td style='width:75%' class='def'><p>The default, custom <code>KimonoStyle</code> that is attached to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e82d1389-432d-4140-97ba-47940af173e6'>_visible</a></td><td style='width:75%' ><p>The visibility of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ccdcf08a-c5eb-475c-a53a-5bcf74a2b6fd'>ControlPoints</a></td><td style='width:75%' ><p>Gets or sets the control points that define the path of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11016306-d842-45b1-8953-fc2db710d7e7'>IsEditable</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether this <a href="#4e0e6705-6811-444f-99e3-3670c315a4b5">KimonoShape</a> is editable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ec35931-538b-4930-9287-f7ca0489254c'>LayerDepth</a></td><td style='width:75%' ><p>Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping on the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#824332e8-3663-45f6-9bc7-5c8e30b8331b'>Name</a></td><td style='width:75%' class='def'><p>Gets or sets the name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e3fa4fb-b794-4ecd-9776-07e65b9ae357'>Style</a></td><td style='width:75%' ><p>Gets or sets the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dd56e99-84be-4f10-b608-4e9c1c113304'>Visible</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#4e0e6705-6811-444f-99e3-3670c315a4b5">KimonoShape</a> is visible.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a046e75d-4b86-4863-8566-ab5c10ac30b4'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ba0f7ca-0cd5-424c-a094-fc943d6b6aaa'>CloneAttachedStyle</a></td><td style='width:75%' class='def'><p>Clones the attached style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68df1608-c1fc-4755-8db5-23106912cc3f'>ConformGradientToShape</a></td><td style='width:75%' ><p>Conforms the gradient to shape by fitting it to the bounds of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91a1aaea-856f-4d13-94d8-84e902f969a9'>EndEditing</a></td><td style='width:75%' class='def'><p>Ends the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad60d043-2d92-4333-a476-6ebc38d3a0f1'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75b27eaf-c3b0-45d0-b26d-70c61d229aeb'>KimonoShape</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#4e0e6705-6811-444f-99e3-3670c315a4b5">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f94f6b0-3b7d-4e4c-88d3-5f12ce4c7ff3'>KimonoShape</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#4e0e6705-6811-444f-99e3-3670c315a4b5">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c77c295-9729-41d7-bbe9-aaa58770895a'>KimonoShape</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#4e0e6705-6811-444f-99e3-3670c315a4b5">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab0ae3ee-1f0e-4623-991c-1702ac8bf8f4'>StartEditing</a></td><td style='width:75%' ><p>Places the shape in the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62d9879c-e27a-4afe-89c0-8badbe0fc119'>ToPath</a></td><td style='width:75%' class='def'><p>Converts the current shape to a path.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#323ce27d-5a1a-41d1-91fa-fb41386bb459'>ToVector</a></td><td style='width:75%' ><p>Converts the current shape to a vector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b89f7a43-bed8-4982-a12b-ee76147478af'>UncoupleDeletedStyle</a></td><td style='width:75%' class='def'><p>Uncouples the deleted style from the shape.</p>
</td></tr></table></p>


---

<a name="ae7d9bfe-d26d-4656-b90e-3c234e3fb535"></a>
##Public Class KimonoShapeArrow

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws either an outlined or single line arrow with heads on one or both ends.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#915c77d9-eb48-4e8d-b423-57f1aee39544'>HasEndHead</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#ae7d9bfe-d26d-4656-b90e-3c234e3fb535">KimonoShapeArrow</a> has end head.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20b2c4ea-89ba-445a-9ac8-d8de36d11e64'>HasStartHead</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#ae7d9bfe-d26d-4656-b90e-3c234e3fb535">KimonoShapeArrow</a> has start head.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#701c90cb-c19c-47f9-84d5-76c29f8c0d40'>HeadInnerRatio</a></td><td style='width:75%' ><p>Gets or sets the head inner ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4f5ed6c-2df5-494b-b22b-e89625911764'>HeadOuterRatio</a></td><td style='width:75%' class='def'><p>Gets or sets the head outer ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#428e1104-c1bd-473e-9883-3a4f1630cbec'>IsStreamlined</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#ae7d9bfe-d26d-4656-b90e-3c234e3fb535">KimonoShapeArrow</a> is streamlined.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#03af743e-3624-4c26-8766-e47540b95ee3'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d49ec2da-a23c-4b51-bd5a-f3875ed92278'>DragBounds</a></td><td style='width:75%' class='def'><p>Drags the bounds of the arrow to a new location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4e6039f-e5d0-465c-80b3-ad5d4f9606a5'>Draw</a></td><td style='width:75%' ><p>Draws the arrow into the specified Skia canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b1ce2be-515c-4ae2-9d95-87e46ed15d8c'>GrowBounds</a></td><td style='width:75%' class='def'><p>Grows the bounds of the arrow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d8631d9-4ba3-49fa-8d03-f32e3afcd171'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8a754db-a507-4756-bcb4-95b509d7f55c'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#ae7d9bfe-d26d-4656-b90e-3c234e3fb535">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35b152e2-a414-4da5-8bee-c04afaa4a0f8'>KimonoShapeArrow</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#ae7d9bfe-d26d-4656-b90e-3c234e3fb535">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d6e04cc-25c7-4c9e-a065-f393c149001a'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#ae7d9bfe-d26d-4656-b90e-3c234e3fb535">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36662fb8-e588-4ff6-983b-2ff8fdcdbd61'>ToPath</a></td><td style='width:75%' ><p>Converts the arrow to a path.</p>
</td></tr></table></p>


---

<a name="4396bdd6-990a-4ec6-9417-494b96ad9978"></a>
##Public Class KimonoShapeGroup

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

A `KimonoShapeGroup` holds a collection of `KimonoShapes` that can be acted upon as a group.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5f5dc9e8-1367-4d79-9108-e52ad1b82745'>_isMaskedGroup</a></td><td style='width:75%' ><p>If <code>true</code>, the top most shape in the group will act as a mask for the shapes below it.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#324e0b28-53b1-4f7d-8dc2-c5934669ebbe'>_selectedShape</a></td><td style='width:75%' class='def'><p>The currently selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74e9a1b2-03f7-455f-a1aa-f357d27b7abb'>Dragging</a></td><td style='width:75%' ><p>Marks if the group itself is being moved be the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#597323b2-a672-4b80-b0d0-bbf49689fce7'>IgnoreDrag</a></td><td style='width:75%' class='def'><p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32e0c72f-a2f3-40d8-8ec2-8555837b03b5'>PerformingDrag</a></td><td style='width:75%' ><p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e167a600-a106-43cc-9c26-6614a90ccdde'>ShapeUnderConstruction</a></td><td style='width:75%' class='def'><p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#033fe23a-9906-4c51-9cc2-363fbd881cc3'>ToolDownAt</a></td><td style='width:75%' ><p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a55c98b7-12e8-4d06-a27d-cac1313d2f23'>BooleanOperation</a></td><td style='width:75%' ><p>Gets or sets the boolean operation that will be applied to this group of objects.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b8f8894-5653-4ffc-97af-e8fbe91f1da1'>DeeplySelectedGroup</a></td><td style='width:75%' class='def'><p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06322882-c5b4-42a3-b60b-5181268e5d1f'>DeeplySelectedShape</a></td><td style='width:75%' ><p>Gets the deepest selected shape in a chain of groups.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4f56d00-e409-4471-b626-fcd49ea7da29'>GroupType</a></td><td style='width:75%' class='def'><p>Gets or sets the type of the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8929f45d-c5e3-43fc-800a-551d48aa3665'>IsBooleanConstruct</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#4396bdd6-990a-4ec6-9417-494b96ad9978">KimonoShapeGroup</a> is a boolean construct.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c897ff7-f0bb-4af1-8cb9-4a2aa576d429'>IsEditable</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether this <a href="#4396bdd6-990a-4ec6-9417-494b96ad9978">KimonoShapeGroup</a> is editable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9981b47-d6ca-4a79-b62d-9123e94ef389'>IsMaskedGroup</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#4396bdd6-990a-4ec6-9417-494b96ad9978">KimonoShapeGroup</a> is masked group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd146f41-9553-40e3-803e-93a36c9db6c4'>Mask</a></td><td style='width:75%' class='def'><p>Gets or sets the <code>KimonoShape</code> that is acting as a mask for this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e11f6ff-72b9-46c4-bfc6-1e56864de0a2'>Parent</a></td><td style='width:75%' ><p>Gets or sets the parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code> that this <code>KimonoShapeGroup</code> belongs to.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1d91032-026a-4dd4-a731-ad864c619d87'>ParentSketch</a></td><td style='width:75%' class='def'><p>Gets the parent sketch by scanning backwards through the chain of parent objects until a <code>KimonoSketch</code> is reached.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf4c0b05-fb95-4b5f-a83e-c07aefbfd122'>Path</a></td><td style='width:75%' ><p>Gets the full path from this group back to the parent <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#019550b0-c8d6-41d7-9f09-f61308af385d'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#998e77a0-ef6a-434d-97c0-50884921677b'>SelectedShapeAtBottom</a></td><td style='width:75%' ><p>Gets a value indicating whether the selected shape is at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b81ba2dc-7f90-4a2f-9dae-1cd3ae133df9'>SelectedShapeAtTop</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether the selected shape is at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e50e8dea-d6f3-499c-b7b0-6d15ddc7320d'>Shapes</a></td><td style='width:75%' ><p>Gets or sets the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d4b02ed-32cb-49ff-ae9f-e4a8b66fd9bd'>Style</a></td><td style='width:75%' class='def'><p>Gets or sets the style of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#677da7b2-1645-41b1-a0bd-cc57017f2bce'>Visible</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#4396bdd6-990a-4ec6-9417-494b96ad9978">KimonoShapeGroup</a> is visible.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#87a5f838-e2c2-4c34-b5f3-20a7bb17ea94'>AddShape</a></td><td style='width:75%' ><p>Adds the given <code>KimonoShape</code> to the group if it isn't already a part of the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#533bd3a2-1b34-4f0b-b620-6aa1e0994c79'>AlignAllBottom</a></td><td style='width:75%' class='def'><p>Aligns all shapes in the group at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dbe0e24-5ca5-456a-868e-2e3360166603'>AlignAllCenter</a></td><td style='width:75%' ><p>Centers all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c33c3da-1d5b-4bb2-a2ba-2476e959fc2b'>AlignAllCenterHorizontal</a></td><td style='width:75%' class='def'><p>Center horizontal all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39311a21-168a-4c8c-a75a-9d6577b769d8'>AlignAllCenterVertical</a></td><td style='width:75%' ><p>Center vertical all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cde7a972-1c73-4bb9-8261-422d4d72491c'>AlignAllLeft</a></td><td style='width:75%' class='def'><p>Aligns all shapes in the group to the left.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a4c8b70-4bf3-42f5-8549-84b90ac36e12'>AlignAllRight</a></td><td style='width:75%' ><p>Aligns all shapes in the group to the right.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd36883a-6a36-46fe-bd2e-2259c68153e3'>AlignAllTop</a></td><td style='width:75%' class='def'><p>Aligns all shapes in the group at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d507e5ca-213e-4795-9356-73a1b9a7279f'>ApplyMoveAndScale</a></td><td style='width:75%' ><p>Applies the move and scale adjustments to all <code>KimonoShapes</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac677dfd-46a9-44f4-93d7-c84edb6f1320'>BoundsChanged</a></td><td style='width:75%' class='def'><p>Update the bouds of this group when they have changed from either a move or a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66790971-3083-412f-9a14-5b790a67dc9d'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd8ec18b-9e99-41e6-ba38-a928b5823fb6'>DeleteColor</a></td><td style='width:75%' class='def'><p>Deletes the given <code>KimonoColor</code> from this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56f86159-38f2-462d-a5b8-85673d43313f'>DeleteGradient</a></td><td style='width:75%' ><p>Deletes the given gradient from the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bc0ae67-e907-4753-8ec3-f21e9b3832ba'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98700e00-5931-4c23-8af0-59e86503f7a0'>DeleteShapes</a></td><td style='width:75%' ><p>Deletes the shapes in this selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb9718fe-d635-4b80-87b7-34753e26826e'>DeleteShapes</a></td><td style='width:75%' class='def'><p>Deletes the shapes in this selection group from the parent group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffe5af3c-70c8-4140-93df-edc5477463f5'>DeleteShapes</a></td><td style='width:75%' ><p>Deletes the shapes in this selection group from the parent sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9fe54fb-9244-4dc5-b05d-e5c49c7db403'>DeselectAll</a></td><td style='width:75%' class='def'><p>Deselects all shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75f1193c-1940-471d-8c6a-cf773966dad3'>DragBounds</a></td><td style='width:75%' ><p>Drags the bounds of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6e29673-364f-435d-82fb-c4e45f7a6a41'>Draw</a></td><td style='width:75%' class='def'><p>Draw all the <code>KimonoShapes</code> that are part of this group into the given Skia canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ec4460c-91c4-4d86-ab51-54fde61d2424'>DuplicateSelectedShape</a></td><td style='width:75%' ><p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9faa4b33-0a8e-4b4d-8698-0be3ad11a44a'>DuplicateShapes</a></td><td style='width:75%' class='def'><p>Duplicates the shapes in a selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3acc7256-6da9-42e5-a95a-d1641cb81871'>DuplicateShapes</a></td><td style='width:75%' ><p>Duplicates the shapes in this selection group into the parent group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffbdb738-26ba-49cb-80ab-2f0900d750ab'>DuplicateShapes</a></td><td style='width:75%' class='def'><p>Duplicates the shapes in this selection group into the parent sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2eaf0d04-a6c0-4517-9682-b95995e64c82'>EndEditing</a></td><td style='width:75%' ><p>Ends editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25557052-61c2-458c-a626-6d391f8f0d4e'>FindShape</a></td><td style='width:75%' class='def'><p>Finds a given shape by its Unique ID.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7d8f1ac-c9e3-4c9c-89fd-e1c29ddab14d'>GroupShapes</a></td><td style='width:75%' ><p>Groups the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39b24f68-34fa-4270-933b-bb4fc9ef7d95'>GroupShapes</a></td><td style='width:75%' class='def'><p>Groups the shapes in the parent group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aba82e44-474c-4e60-9055-82111f9faa7c'>GroupShapes</a></td><td style='width:75%' ><p>Groups the shapes in the parent sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fa181da-28e3-4fa2-8fe1-265d45bb1437'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize the specified parent.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff09ff18-f1ad-4898-9c21-12116c7a515e'>KimonoShapeGroup</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#4396bdd6-990a-4ec6-9417-494b96ad9978">KimonoShapeGroup</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#721f5dc9-c255-479e-9737-e6411c28f394'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#4396bdd6-990a-4ec6-9417-494b96ad9978">KimonoShapeGroup</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec6a8f65-0a10-46d6-8a57-e129eb7a452e'>KimonoShapeGroup</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#4396bdd6-990a-4ec6-9417-494b96ad9978">KimonoShapeGroup</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fa648db-e2ff-4798-b953-7149538301cb'>MoveSelectedShapeBackwards</a></td><td style='width:75%' class='def'><p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7f1c2a1-e865-4f27-9f7e-fcbd0cbf0747'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc010cc3-e1ae-4ace-b6ce-6f39df119ab5'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2e0ae0d-4c21-49ab-ba2d-2bb1058a9247'>MoveSelectedShapeToTop</a></td><td style='width:75%' ><p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41dfa140-a26d-4417-8070-774cea380a39'>PointInBound</a></td><td style='width:75%' class='def'><p>Test to see if the given point is inside the bounds of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2756574-fd9a-4258-8b23-a586859834ec'>RecalculateGroupBounds</a></td><td style='width:75%' ><p>Recalculates the group bounds to encompass every <code>KimonoShape</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9378c715-cb15-42c2-9d50-467a68b10dfa'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p>Recalculates the layer depths.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25048fcf-276b-44d9-ae33-c75d60402c1b'>RelinkShape</a></td><td style='width:75%' ><p>Relinks the shape after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65534f18-0956-4e0d-8082-8d034cbb7c1e'>RemoveShape</a></td><td style='width:75%' class='def'><p>Removes the given <code>KimonoShape</code> from the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c0ce1f2-5ed8-4cf6-8ee6-baf130ae1bd4'>ReturnToSketch</a></td><td style='width:75%' ><p>Returns to base parent <code>KimonoSketch</code> for this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#088ee476-9519-4fc7-ae07-c6a8552993ce'>SelectShape</a></td><td style='width:75%' class='def'><p>Selects the given <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e64e8fe-9611-4ba5-b611-1126d99beee8'>ShapeInGroup</a></td><td style='width:75%' ><p>Test to see if the given <code>KimonoShape</code> is a part of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb38d4ea-8314-44e7-bb0d-9d2310e8300d'>StartEditing</a></td><td style='width:75%' class='def'><p>Starts editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#979c02a6-1655-48f4-b78c-7a28290763c1'>ToolDown</a></td><td style='width:75%' ><p>Handles the user placing the current <code>KimonoTool</code> down on the group's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#695765c3-7cd3-43d2-a8f3-13a0068aa18f'>ToolDrag</a></td><td style='width:75%' class='def'><p>The public <code>ToolDrag (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27c43834-3700-4bca-bf7e-f10bf7bebcb0'>ToolUp</a></td><td style='width:75%' ><p>The public <code>ToolUp (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#109851b6-23bd-4df4-a20b-e6f178e015fc'>ToPath</a></td><td style='width:75%' class='def'><p>Converts the group of shapes to a path.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80205958-ba80-4035-86d8-3aeeab3bb2ff'>UngroupShapes</a></td><td style='width:75%' ><p>Ungroups the shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e15a5c9-6d49-4abe-bacb-ca55444ca889'>UngroupShapes</a></td><td style='width:75%' class='def'><p>Ungroups the shapes in the parent group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa334db9-e5da-4a42-9e08-fd4a4b68358a'>UngroupShapes</a></td><td style='width:75%' ><p>Ungroups the shapes in the parent sketch.</p>
</td></tr></table></p>


---

<a name="cb6efc63-2b26-4cf8-82ea-9f0ed99cc157"></a>
##Public Enum KimonoShapeGroupType

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Enum`

###Summary

Defines the type of a `KimonoShapeGroup`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6f96a8a7-e132-4dfb-999e-29e5db3d0e6f'>Collection</a></td><td style='width:75%' ><p>The group is a collection of shape that have been grouped together and are treated as a single object in the editor.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e241083b-310f-4341-8d69-2f88dd4c9382'>DragSelect</a></td><td style='width:75%' class='def'><p>The group is a drag to select selection that is underway.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6e18d1f-4af5-4967-8955-e7ab87bbc338'>Selection</a></td><td style='width:75%' ><p>The group is a current active selection.</p>
</td></tr></table></p>


---

<a name="7849552a-49ed-4035-a1df-0fa7bfe40516"></a>
##Public Class KimonoShapeLine

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws a line on the design surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8e665e4c-71a6-4982-857d-c1dacdab11ab'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e99e7864-d141-4945-97de-0bb297ca57bc'>Draw</a></td><td style='width:75%' class='def'><p>Draws the line into the given Skia canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c8a3eda-45eb-4d20-baf7-3def104e57d0'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51dc0bb7-e718-47b7-8bd0-bdf9759cba51'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#7849552a-49ed-4035-a1df-0fa7bfe40516">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76a38bce-e52a-41ff-a8bf-110f527fbf67'>KimonoShapeLine</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#7849552a-49ed-4035-a1df-0fa7bfe40516">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da47403e-fbf4-4f3a-adab-320500605534'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#7849552a-49ed-4035-a1df-0fa7bfe40516">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30fe722b-4af6-4005-a0af-cc0002b5505c'>ToPath</a></td><td style='width:75%' ><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd"></a>
##Public Class KimonoShapeOval

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws an oval into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#62511d1a-ab16-460b-a8fd-7df0e7aaadfd'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3f87d97-08d0-436b-ac7b-2d89aae07dc7'>Draw</a></td><td style='width:75%' class='def'><p>Draw the oval into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edde0a22-4c8c-4ad3-866d-773b48581b8a'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43ffd78b-7efe-40a3-a50a-398872c66b17'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#070aec9e-bd6b-4497-9d45-0f655dcf47cd'>KimonoShapeOval</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bd92b5d-8a98-4502-891b-c652085cde27'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc114963-aa32-48e0-8872-9653d1b0f727'>ToPath</a></td><td style='width:75%' ><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="503226d4-73b7-4ece-8096-a9cc509a2752"></a>
##Public Class KimonoShapePolygon

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws a multi-sided polygon into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d93a996a-88c1-4490-bdd7-7ec2d82fbaf2'>NumberOfSides</a></td><td style='width:75%' ><p>Gets or sets the number of sides.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#063a46d6-739c-4901-845e-cb9f6d12abbd'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31bb06d5-4efb-4fab-b896-4875367cf095'>Draw</a></td><td style='width:75%' class='def'><p>Draws the polygon into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbd34e86-7381-42aa-b8a5-47c0284938f2'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8867556b-cfde-4fbe-8b1e-0ff94d310030'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#503226d4-73b7-4ece-8096-a9cc509a2752">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83b6a1f0-e297-4b5d-8580-f0040ce0a91e'>KimonoShapePolygon</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#503226d4-73b7-4ece-8096-a9cc509a2752">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b759519-548f-40f5-96e1-081b295f872b'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#503226d4-73b7-4ece-8096-a9cc509a2752">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6147ca8b-f83a-4124-8802-28bf4e2282a7'>MakeSidePoints</a></td><td style='width:75%' ><p>Makes the star points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#999827cd-4058-45e4-97b3-76f4ef4b95a3'>ToPath</a></td><td style='width:75%' class='def'><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="85d708a0-1446-4e21-9ba3-961994114384"></a>
##Public Class KimonoShapeRect

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws a rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5e7b5ba7-d3ac-4b42-a09e-b4e7d24899ef'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f897b401-2e1b-406f-b5b5-6518b29c0817'>Draw</a></td><td style='width:75%' class='def'><p>Draws the rectangle into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b6ab5bf-3314-43ce-bff5-2d77ead48270'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#362494fd-04fc-4788-a6e2-576bac793043'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#85d708a0-1446-4e21-9ba3-961994114384">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb7bf51d-75ec-4ed3-b963-bc753b3789cd'>KimonoShapeRect</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#85d708a0-1446-4e21-9ba3-961994114384">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a106c3d2-3c7f-433e-bb5d-896959502e73'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#85d708a0-1446-4e21-9ba3-961994114384">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a5ab9c7-9d6d-4eee-9b3b-fd209ba39a47'>ToPath</a></td><td style='width:75%' ><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="429ac09f-fc9f-44ab-a634-e41870b8350a"></a>
##Public Class KimonoShapeRoundRect

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws a rounded rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#61134be2-97e6-4cc4-aae4-5ba79e25781a'>CornerRadius</a></td><td style='width:75%' ><p>Gets or sets the corner radius.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e467502b-3662-46f2-bef5-dd3b7d55f604'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88fba7f1-9a38-4557-9912-186bd4c4f217'>Draw</a></td><td style='width:75%' class='def'><p>Draws the round rectangle into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aabc6b94-f281-428a-94b7-bef864f05824'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d30edcc7-27a6-48ce-bce7-5f9f36d9e812'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#429ac09f-fc9f-44ab-a634-e41870b8350a">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a3433f9-92aa-4e15-a77b-7525edb9bcf4'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#429ac09f-fc9f-44ab-a634-e41870b8350a">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbdaa685-fe48-46bd-a78e-27f8392338f0'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#429ac09f-fc9f-44ab-a634-e41870b8350a">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eda27429-5d80-49b5-bfe4-d0faf293d7ab'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#429ac09f-fc9f-44ab-a634-e41870b8350a">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a9c6c8c-3a93-4d7b-bb5d-78f4c8dcdc6e'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#429ac09f-fc9f-44ab-a634-e41870b8350a">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a9c4ac0-4e82-4923-a9fd-66d688ecaf7d'>ToPath</a></td><td style='width:75%' ><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="dea1abbc-1d3b-4c51-9ef9-257afde86f76"></a>
##Public Class KimonoShapeStar

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws a multi-sided star shape into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2c1dde6e-54cf-41a4-b0f2-03546a85a543'>DepthOffset</a></td><td style='width:75%' ><p>Gets or sets the depth offset for the individual points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53c198c8-8c2f-48c2-a12d-1a52ca006d47'>NumberOfPoints</a></td><td style='width:75%' class='def'><p>Gets or sets the number of points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ab1ce34-ee33-4bd0-839f-215562e7aff8'>SkipPoints</a></td><td style='width:75%' ><p>Gets or sets the skip points.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#29839d55-0481-4a8b-abcf-3fea372ae62b'>CalculateConcaveRadius</a></td><td style='width:75%' ><p>Calculates the concave radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9cddbc30-08dc-48f7-91ee-ae2aabb09c94'>Clone</a></td><td style='width:75%' class='def'><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#555dc59d-464f-4ca4-8af7-4f02b5e22f5c'>Draw</a></td><td style='width:75%' ><p>Draws the star into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d985a13-c5f3-41ea-bb55-b0fc1679f8e3'>FindIntersection</a></td><td style='width:75%' class='def'><p>Finds the intersection.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03c3b7c7-f15f-43fe-a7f6-6c6bceefeb38'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#272ee9b5-5c46-4e41-96d3-f7fe3992483d'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#dea1abbc-1d3b-4c51-9ef9-257afde86f76">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e820937e-f849-4302-91da-3b98c71e5bd9'>KimonoShapeStar</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#dea1abbc-1d3b-4c51-9ef9-257afde86f76">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f48efed9-41d9-45b3-9100-c253be70b454'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#dea1abbc-1d3b-4c51-9ef9-257afde86f76">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d57410d3-c70d-4729-879d-5a512c016a21'>MakeStarPoints</a></td><td style='width:75%' ><p>Makes the star points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#680186bf-3718-462c-bffd-0506c3083015'>ToPath</a></td><td style='width:75%' class='def'><p>Converts the current shape to a path.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f23f0f7-0615-4356-bd47-e286c312190b'>ToVector</a></td><td style='width:75%' ><p>Converts the star into a vector.</p>
</td></tr></table></p>


---

<a name="628fb735-c63a-41df-98d5-2353b7bb4b3d"></a>
##Public Enum KimonoShapeState

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Enum`

###Summary

Holds the current state of a `KimonoShape` while it is being edited by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#65f759bd-1097-409f-8b8a-091681528d25'>Constructing</a></td><td style='width:75%' ><p>The shape is in the process of being built. For example, a set of shapes being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96d128df-68cb-4d92-a9fc-440d6a48b32c'>Editing</a></td><td style='width:75%' class='def'><p>The shape is in the edit mode and individual control points can be added, deleted, moved or adjusted.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e82a4a38-0254-4110-a698-4d3a319c33d4'>Finalizing</a></td><td style='width:75%' ><p>The shape is leaving the edit mode and needs to be completed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf1ead7c-8156-475f-8b1d-ae8e4caedbd4'>Grouping</a></td><td style='width:75%' class='def'><p>The shape is being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d56c7e6f-0560-43c4-b704-266d41251588'>Selected</a></td><td style='width:75%' ><p>The shape is being selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bed28aa-f397-44e2-9582-1b603cbcd811'>Unselected</a></td><td style='width:75%' class='def'><p>The shape is unselected.</p>
</td></tr></table></p>


---

<a name="d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf"></a>
##Public Class KimonoShapeText

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws a block of text into the Design Surface within the specifid bounds of this shape.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e68bd565-9ff8-4a71-8426-316133911a4a'>FontFamilyName</a></td><td style='width:75%' ><p>Gets or sets the name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d91bccf4-bf3b-4d8e-b8ca-29e55166e3ba'>FontMetrics</a></td><td style='width:75%' class='def'><p>Gets the font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f64f885-007b-492c-9768-c5b164b206a1'>IsLinearText</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf">KimonoShapeText</a> is linear text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0ff990f-a955-4849-a7c2-a55675f2db86'>IsVerticalText</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf">KimonoShapeText</a> is vertical text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49e11ae3-12c7-4302-a78c-278c27927921'>StrikeThruText</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf">KimonoShapeText</a> strike thru text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c17932c4-7221-44f1-8061-3d174bee5c65'>Text</a></td><td style='width:75%' class='def'><p>Gets or sets the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4c01df1-287c-46aa-9030-382ff4303448'>TextAlign</a></td><td style='width:75%' ><p>Gets or sets the text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a9f2fe2-dde8-4fde-910a-ba9981acdb90'>TextEncoding</a></td><td style='width:75%' class='def'><p>Gets or sets the text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ec3fb0e-0c21-423c-b504-71d664e3d554'>TextScaleX</a></td><td style='width:75%' ><p>Gets or sets the text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f972c61f-58b9-4414-af3d-5fe490c9f880'>TextSize</a></td><td style='width:75%' class='def'><p>Gets or sets the size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9eb82d70-3c13-4dea-b8c0-3813e7779d58'>TextSkewX</a></td><td style='width:75%' ><p>Gets or sets the text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90334331-55cf-4fd0-a502-7b86e4ce69b1'>Typeface</a></td><td style='width:75%' class='def'><p>Gets or sets the typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d740c753-3942-4490-b0d5-7fa52fb7631b'>TypefaceStyle</a></td><td style='width:75%' ><p>Gets or sets the typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1b8bfed-fd77-412c-accc-ec786b7727b2'>UnderlineText</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf">KimonoShapeText</a> underline text.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#811ba04c-5c8b-4caf-9a57-c64e8aef2b18'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2b546ee-53fd-42e1-b507-1af9533d1c73'>DragBounds</a></td><td style='width:75%' class='def'><p>Drags the bounds of the text block.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b230cfcd-a868-4759-8702-61c913a4d3d6'>Draw</a></td><td style='width:75%' ><p>Draws the text block into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ffe204d-e7fa-4eaf-a75a-d3a01e5695a5'>GrowBounds</a></td><td style='width:75%' class='def'><p>Grows the bounds of the text block.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96fd7c72-e3da-424e-9396-fae86fbab80e'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9db4ba06-7aea-434c-9218-d5c71df0009f'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8466faf5-34f4-46d2-b5cc-c43c50786bfd'>KimonoShapeText</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fd9571f-fc3d-4327-ba63-ec3eba870520'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4823dbd6-8568-4466-9b40-ff270f8f0856'>ToPath</a></td><td style='width:75%' ><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="5df8659c-9e94-4a72-8cbf-d6e33a87da2b"></a>
##Public Class KimonoShapeTriangle

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Draws a triangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f4aa7452-bf4e-442c-aa79-645588301138'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3117b6d-1b10-449e-aee2-0230dfa35bf3'>Draw</a></td><td style='width:75%' class='def'><p>Draws the triangle into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85494a45-71d7-4b32-85bb-1c667e523fb6'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#571d8440-321e-4581-af18-c0827c78104c'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#5df8659c-9e94-4a72-8cbf-d6e33a87da2b">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb03f043-0094-459d-9303-629301a5514a'>KimonoShapeTriangle</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#5df8659c-9e94-4a72-8cbf-d6e33a87da2b">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d10518a4-ed89-4b4a-a39a-5a403cf4f59d'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#5df8659c-9e94-4a72-8cbf-d6e33a87da2b">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3afd1d7f-3967-4006-a425-c988a85ec2b7'>ToPath</a></td><td style='width:75%' ><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="fb84c492-9888-473d-932e-a6bb3e440850"></a>
##Public Class KimonoShapeVector

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8d1780b0-5acc-4bb9-a8e3-7e45374019c3'>Closed</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#fb84c492-9888-473d-932e-a6bb3e440850">KimonoShapeVector</a> is closed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#019cc36d-d8a1-41d7-8c94-1176f7e9c099'>IsEditable</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether this <a href="#fb84c492-9888-473d-932e-a6bb3e440850">KimonoShapeVector</a> is editable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56c6d1f9-346d-48ad-8850-0d8e72688de6'>Points</a></td><td style='width:75%' ><p>Gets or sets the points that define the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#66a5c10d-0076-4b61-ac8a-6fe7eb5a7670'>AddPoint</a></td><td style='width:75%' ><p>Adds the given point to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f073db5-7f3b-4228-a16e-29b1dc9474e5'>AddPoint</a></td><td style='width:75%' class='def'><p>Adds a point to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1242fa00-c3a6-445e-85cb-23f8eeac94dd'>ApplyMoveAndScale</a></td><td style='width:75%' ><p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#344e271d-fa3b-454d-b58d-08d62abe63ef'>BoundsChanged</a></td><td style='width:75%' class='def'><p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d80d33b5-c99a-4e3f-993d-5a8b5b421099'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fca392f8-5573-4791-a509-6f1be8211722'>DragBounds</a></td><td style='width:75%' class='def'><p>Drags the bounds of the shape to a new location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#464e90bd-46ce-48d7-9bb9-65a7d685b0c4'>Draw</a></td><td style='width:75%' ><p>Draws the shape into the given Skia Canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ec7042c-9f82-4e19-b608-431aaefa94fc'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#245d843c-45e5-4144-9206-9416beda6c8a'>KimonoShapeVector</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#fb84c492-9888-473d-932e-a6bb3e440850">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2487c6e7-663a-48c8-8e11-6778e56aac0d'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#fb84c492-9888-473d-932e-a6bb3e440850">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f0e2914-452a-41ad-a518-e9614eac720a'>KimonoShapeVector</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#fb84c492-9888-473d-932e-a6bb3e440850">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c149f55b-7788-4af6-8200-f230c83d7053'>MoveLastPoint</a></td><td style='width:75%' class='def'><p>Moves the last point added to the new position.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0214361-2a90-4cc4-bc84-779105caed23'>PointInBound</a></td><td style='width:75%' ><p>Tests to see if the given point is inside the bounds of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#780b4f80-0980-49f9-b69b-71940000ec98'>RecalculateVectorBounds</a></td><td style='width:75%' class='def'><p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#988ef738-80be-4655-8f41-bfdccc5eb231'>RemovePoint</a></td><td style='width:75%' ><p>Removes the given point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc0fdfe3-a004-454a-8be7-a597e96b1471'>StartEditing</a></td><td style='width:75%' class='def'><p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6007cd4-7d1a-4d47-8b88-8ecf26d9b076'>ToPath</a></td><td style='width:75%' ><p>Converts the current shape to a path.</p>
</td></tr></table></p>


---

<a name="aec876fe-5a0c-43d7-830e-67738d4a5435"></a>
##Public Class KimonoSketch

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Holds a collection of `KimonoShapes` that are used to create a given image using Skia.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#df88c54f-f2d5-4977-aaff-89b95f920af2'>_canvasColor</a></td><td style='width:75%' ><p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a76b532-3089-48b4-8d5d-dcbbb1f5e993'>_selectedShape</a></td><td style='width:75%' class='def'><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e84fc32-5744-463f-8abf-672918298e85'>_tool</a></td><td style='width:75%' ><p>The currently <code>KimonoTool</code> that will be used to edit the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a50337ff-e69a-47d8-9b57-42fc06cba97d'>IgnoreDrag</a></td><td style='width:75%' class='def'><p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d4bf755-6717-40d6-b165-7affbc3bfc31'>ImageBufferNeedsRefresh</a></td><td style='width:75%' ><p>The private <code>ImageBufferNeedsRefresh</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8408629a-c472-4134-86f1-da4add771fd8'>PerformingDrag</a></td><td style='width:75%' class='def'><p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3893c215-b852-4b6f-9d17-0f210ad3be73'>PreviousSize</a></td><td style='width:75%' ><p>The size of the previous of a sketch for a rezise operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84b54f60-0a8e-424a-a5fc-fda32fd05c5c'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>The private <code>RequestNewUndoPoint</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da4d6fd9-c9c5-4a39-8f3a-da4312fd57b4'>SelectedShapeModified</a></td><td style='width:75%' ><p>The private <code>SelectedShapeModified</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79c32ed8-27d2-46b5-b134-2e43409f1c80'>SelectionChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectionChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d30e152-5115-4523-b613-f24cd3c4c3d1'>ShapeUnderConstruction</a></td><td style='width:75%' ><p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd61fbff-e3ec-488b-8a66-e165479346ca'>Size</a></td><td style='width:75%' class='def'><p>The current size of the sketch</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d940edef-eec2-4e99-8cbf-7b20dc836a46'>SketchModified</a></td><td style='width:75%' ><p>The private <code>SketchModified</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92f601a3-f8e1-4a45-8d92-fcf82b3a2e23'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p>The private <code>SketchSizeChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#454921ad-352c-4689-b2ba-109e612b1273'>ToolChanged</a></td><td style='width:75%' ><p>The private <code>ToolChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb32857b-bf1e-4fc5-b8fa-85a9d352ecd0'>ToolDownAt</a></td><td style='width:75%' class='def'><p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5f4f82cf-fc23-456c-a896-0ea31def5e2c'>CanAlignShapes</a></td><td style='width:75%' ><p>Gets a value indicating whether alignment can be applied on a set of shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60eb721a-7fda-4a49-8359-cbc08880c838'>CanGroupShapes</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether the selection of shapes can be grouped.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d474aa51-6ad9-4499-b55e-6d07302f6889'>CanUngroupShapes</a></td><td style='width:75%' ><p>Gets a value indicating whether the selection of shapes can be ungrouped.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88827503-bab9-44a1-b710-f026ea3b0e70'>CanvasColor</a></td><td style='width:75%' class='def'><p>Gets or sets the color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c28e0b4-594f-48b7-a952-b544603b131c'>DeeplySelectedGroup</a></td><td style='width:75%' ><p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4e67c94-b337-4cfb-8f4b-4b5bd4aba143'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p>Gets the deepest selected shape in a chain of groups.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77e34450-fa7d-4297-a295-c4b4b05d65e2'>DrawCanvas</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#aec876fe-5a0c-43d7-830e-67738d4a5435">KimonoSketch</a> should draw  the canvas when it is included in another sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f3b3d4c-439c-4557-af92-ea87f14b02f5'>Height</a></td><td style='width:75%' class='def'><p>Gets or sets the height.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#308c5d6b-4a91-41a5-a4a2-5a22a9ee0b2f'>Name</a></td><td style='width:75%' ><p>Gets or sets the name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94077057-8c9e-4828-a74f-f8b745cf79f9'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33e4eca6-6178-4295-884f-6e4bda9ed6bc'>SelectedShapeAtBottom</a></td><td style='width:75%' ><p>Gets a value indicating whether the selected shape is at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aabb8869-6430-4366-b5cb-4f2b9752fd64'>SelectedShapeAtTop</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether the selected shape is at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c160657b-e8ca-4947-bd50-35f46bdd525b'>Shapes</a></td><td style='width:75%' ><p>Gets or sets the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#282cfdf5-e4ba-4770-806d-7563fb32caaf'>Tool</a></td><td style='width:75%' class='def'><p>Gets or sets the tool.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8080e962-f997-4dd1-828b-d196c781a23d'>UniqueID</a></td><td style='width:75%' ><p>Gets or sets the unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e34f26f-7edf-4a36-86d7-6a1e3cd8ab7b'>Width</a></td><td style='width:75%' class='def'><p>Gets or sets the width.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d3bf44e0-faab-4fd4-85f4-b009a9f5f50f'>AddShape</a></td><td style='width:75%' ><p>Adds the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8455954-74d8-4b28-a033-244a91bfa399'>ApplySizeChange</a></td><td style='width:75%' class='def'><p>Applies the size change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d9df035-73a7-48ba-ace7-687c83489e0e'>Clone</a></td><td style='width:75%' ><p>Clone this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#792aa1f6-27af-4f1c-b375-d4835ed4ba39'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aca8d3f9-c94d-44c3-ae04-7151ae55414f'>DeselectAll</a></td><td style='width:75%' ><p>Deselects all shapes in the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f2b6b03-2ddb-4d81-ad99-4260e75ad83a'>Draw</a></td><td style='width:75%' class='def'><p>The public <code>Draw ()</code> member of the <code>KimonoSketch</code> class returns a <code>SkiaSharp.SKData</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab27018c-843c-4bea-a6cb-4e0c58556304'>DuplicateSelectedShape</a></td><td style='width:75%' ><p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56578c01-f978-4e70-b39c-9325b6d6c5f9'>FindShape</a></td><td style='width:75%' class='def'><p>Finds the shape specified by its unique ID.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53af411c-1620-4038-9daf-f36544df12f5'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77697730-bd99-4cd5-97c1-76c39b6c26c3'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e77a3856-dbf9-4672-bfc4-a26cf89de41f'>KimonoSketch</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#aec876fe-5a0c-43d7-830e-67738d4a5435">KimonoSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69b5245b-3c9a-4f3d-97e7-92a1e8e5a4e3'>KimonoSketch</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#aec876fe-5a0c-43d7-830e-67738d4a5435">KimonoSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e67413e-ea98-485c-8d91-0bca71968f68'>MoveSelectedShapeBackwards</a></td><td style='width:75%' ><p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d84b626c-965a-4294-b2f6-d3417aaaa768'>MoveSelectedShapeForwards</a></td><td style='width:75%' class='def'><p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#162ed250-dce5-491a-ac82-841e1c2d8a8c'>MoveSelectedShapeToBottom</a></td><td style='width:75%' ><p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61367b3c-83d9-4f8d-99b2-0ddcc87703a1'>MoveSelectedShapeToTop</a></td><td style='width:75%' class='def'><p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#805aaeaf-ccf4-4506-b6e5-c98a349edb53'>RaiseImageBufferNeedsRefresh</a></td><td style='width:75%' ><p>Raises the image buffer needs refresh event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f118e99a-7767-4244-b6d4-4271c3a0e9d2'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#119ca242-04cd-4263-b145-c11edb20200d'>RaiseSelectedShapeModified</a></td><td style='width:75%' ><p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0fa28ea7-b26f-48c1-bfae-c223d6f4527c'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p>Raises the selection changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31addf06-c564-46c4-83e3-df82d3e662b3'>RaiseSketchModified</a></td><td style='width:75%' ><p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2f04fe7-1238-4e27-b6b6-010cc1aa6bfb'>RaiseSketchSizeChanged</a></td><td style='width:75%' class='def'><p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76dc0b14-79c0-44eb-949b-b1940c765f05'>RaiseToolChanged</a></td><td style='width:75%' ><p>Raises the tool changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bebc0de4-f909-4860-b2db-6e5d2c92fa42'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p>Recalculates the layer depths.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbbecdc6-032e-47bc-bffd-ece0c509929b'>RelinkShape</a></td><td style='width:75%' ><p>Relinks the given shape after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42cf8f62-b989-4b70-8170-f2dce3a078c5'>SavePreviousSize</a></td><td style='width:75%' class='def'><p>Saves the previous size of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e3dca59-6793-4429-85ed-b349e20c1333'>SelectShape</a></td><td style='width:75%' ><p>Selects the given shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6158396f-f6a5-426d-bfc9-a136bbfda960'>ToolDown</a></td><td style='width:75%' class='def'><p>Handles the user placing the current <code>KimonoTool</code> down on the sketch's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55e09c92-9be7-4e9f-912f-1853f54793a6'>ToolDrag</a></td><td style='width:75%' ><p>Handle the user dragging the selected <code>KimonoTool</code> on the sketch's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2286c8fe-5ce2-4ec7-9cbd-c282577efd9d'>ToolUp</a></td><td style='width:75%' class='def'><p>Handles the user lifting the current <code>KimonoTool</code> off of the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a7d0b8b7-1b8d-4087-9d51-220a4b86d74d'>ImageBufferNeedsRefresh</a></td><td style='width:75%' ><p>Occurs when image buffer needs refresh.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13304b3a-7b6a-4c92-bfeb-0aa7216634b1'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f203ebcb-64a8-46fd-9bf7-30e271c4db9c'>SelectedShapeModified</a></td><td style='width:75%' ><p>Occurs when selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f02037b8-a122-4d12-9c90-4f856a13dfdd'>SelectionChanged</a></td><td style='width:75%' class='def'><p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25cee5d5-fcd6-45c2-b90a-3b60261ba9b0'>SketchModified</a></td><td style='width:75%' ><p>Occurs when sketch modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70c9add0-f113-4356-aef2-b5570b386311'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44454a9c-ecde-43e1-8c34-84aea2837d92'>ToolChanged</a></td><td style='width:75%' ><p>Occurs when tool changed.</p>
</td></tr></table></p>


---

<a name="c441c4bb-a1b4-455f-aaca-18aa873ff2cf"></a>
##Public Class KimonoStyle

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Defines as style that can be applied to a `KimonoShape` to control its appearance.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b1d42396-5fa2-498c-b4ca-dc34ef2f533c'>_fillBlur</a></td><td style='width:75%' ><p>The fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#beaa5f6e-d3a4-4b68-93e2-9bd2b7bdf743'>_fillColor</a></td><td style='width:75%' class='def'><p>Holds a named <code>KimonoColor</code> attached to the style's fill color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39056d94-9eb4-42ac-95ec-23373c2a4ea3'>_fillGradient</a></td><td style='width:75%' ><p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#903954de-022f-4eac-9820-697cd3c56fac'>_fillJitterDeviation</a></td><td style='width:75%' class='def'><p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a56494a8-c642-4874-846e-cd317fe700c0'>_fillJitterLength</a></td><td style='width:75%' ><p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7c62e0c-19b1-4119-a625-3fb2f1eb5298'>_fillShadow</a></td><td style='width:75%' class='def'><p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a30a9ae-527b-4a9f-a32b-3af7071c35df'>_frameBlur</a></td><td style='width:75%' ><p>The frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#182bbc95-0dc6-4bbe-9af8-e56f5b93f986'>_frameColor</a></td><td style='width:75%' class='def'><p>Holds a named <code>KimonoColor</code> attached to the style's frame color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bde1ef09-0c26-41e3-8f10-ffab26cd41d3'>_frameGradient</a></td><td style='width:75%' ><p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d335d4c-1960-46de-b5ed-967ddea4977a'>_frameJitterDeviation</a></td><td style='width:75%' class='def'><p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f238b2ed-6228-4e51-9b5e-1492fb08e6d2'>_frameJitterLength</a></td><td style='width:75%' ><p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81746182-b3dc-433a-88fa-8d3008b5a680'>_frameShadow</a></td><td style='width:75%' class='def'><p>The frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68eb49a6-5c9d-47d5-a983-ad2fea515af0'>_hasFillBlur</a></td><td style='width:75%' ><p>The has fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d13cc029-d9fb-4a8f-9a6c-d2c69e203cf6'>_hasFillJitter</a></td><td style='width:75%' class='def'><p>If <code>true</code>, the fill uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6135b83-6f8c-4252-9e5e-66f3867986ac'>_hasFillShadow</a></td><td style='width:75%' ><p>The has fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1275dcf1-88d9-4f01-9451-340c5647710b'>_hasFrameBlur</a></td><td style='width:75%' class='def'><p>The has frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d5258c4-0d10-44a7-982e-b1e6e0b8f842'>_hasFrameDash</a></td><td style='width:75%' ><p>If <code>true</code>, the frame has a dash effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89ea90e6-ddef-4c2f-93d8-363b8e703f00'>_hasFrameJitter</a></td><td style='width:75%' class='def'><p>If <code>true</code>, the frame uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd2003aa-0970-4ef3-b9f3-df1909dbbfc8'>_hasFrameShadow</a></td><td style='width:75%' ><p>The has frame shadow.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ca0265a5-cd00-487b-8c3d-a9a9f1e91097'>DashPattern</a></td><td style='width:75%' ><p>Gets or sets the dash pattern.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d74b9d78-bb9c-4cdc-b6cd-6181846db04b'>Fill</a></td><td style='width:75%' class='def'><p>Gets or sets the fill paint style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a83165ed-811b-48a2-8469-484850376011'>FillBlur</a></td><td style='width:75%' ><p>Gets or sets the fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40e93e0b-dc03-4c53-b4cd-530657ba2fc2'>FillColor</a></td><td style='width:75%' class='def'><p>Gets or sets the color of the fill as a named Kimono Color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13aa2701-8c78-4ed0-a3bc-33402e764b1e'>FillGradient</a></td><td style='width:75%' ><p>Gets or sets the fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3343ac48-596b-445a-a1bb-a1c98a26c8be'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p>Gets or sets the fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03e6ebea-fb37-40c9-b72e-b9699758cf0c'>FillJitterLength</a></td><td style='width:75%' ><p>Gets or sets the length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e58ccff1-7f2d-47e0-a651-a878263785a0'>FillShadow</a></td><td style='width:75%' class='def'><p>Gets or sets the fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f49fa6b-cd1d-4f15-872b-45c5d19ce778'>FontFamilyName</a></td><td style='width:75%' ><p>Gets or sets the name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30d1a260-b499-4f89-a598-cadf3eedabf4'>FontMetrics</a></td><td style='width:75%' class='def'><p>Gets the font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f892e623-f7b7-44b9-9117-9d9b0aefee25'>Frame</a></td><td style='width:75%' ><p>Gets or sets the frame paint style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5eb63539-e2eb-4dc9-9fc9-542d528fb495'>FrameBlur</a></td><td style='width:75%' class='def'><p>Gets or sets the frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b52e4de-5048-4356-9d1e-b81a134ffe53'>FrameColor</a></td><td style='width:75%' ><p>Gets or sets the color of the frame as a named Kimono Color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f64fd41-6e84-4aa2-8867-2fb4aa3000e1'>FrameGradient</a></td><td style='width:75%' class='def'><p>Gets or sets the frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6bd796f-7841-494f-acbb-bd68f9ce7c60'>FrameJitterDeviation</a></td><td style='width:75%' ><p>Gets or sets the frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#707e9336-85be-4fb5-8a7b-c897498ffeb1'>FrameJitterLength</a></td><td style='width:75%' class='def'><p>Gets or sets the length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1bf2f5d5-217c-454b-a1cf-00919ed496a5'>FrameShadow</a></td><td style='width:75%' ><p>Gets or sets the frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0316fbc9-d91f-4a75-a26c-9659b54ef9bb'>HasFill</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> has fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce851df2-df99-496a-9b5d-5e13c03a3ef4'>HasFillBlur</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> has fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2c9c146-a23f-4b14-8d1b-7b7b2d4015a9'>HasFillJitter</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether the fill jitter is used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efe1b6bf-e1ad-4a4b-ba0e-1b1075472f7d'>HasFillShadow</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> has fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b7a9e3a-e4c4-40dd-9883-318f9bf593f1'>HasFrame</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> has a frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edeb13b3-b825-427e-b403-470a1ee93307'>HasFrameBlur</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> has frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e6c604f-f16f-450d-b38c-2bc57d496628'>HasFrameDash</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether the frame has a dash.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#139f43f5-c334-4eed-b09d-2677c5586740'>HasFrameJitter</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether the frame jitter is used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e45b00e-63d8-4b34-9eb6-1fbb057148df'>HasFrameShadow</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> has frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7625ac96-3928-48eb-bdaa-98873317bd82'>IsLinearText</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> is linear text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50d8fbd8-8a8a-45ed-9d9f-996ead3fb453'>IsVerticalText</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> is vertical text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8afeb82-0e4c-4648-b5e6-0f1c6361fb76'>Name</a></td><td style='width:75%' ><p>Gets or sets the name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74d12e0b-f9c0-4f31-86c1-5aeaa9f02fb4'>StrikeThruText</a></td><td style='width:75%' class='def'><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> strike thru text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7e21b13-87e8-4ebb-9691-ffcf14218752'>StyleType</a></td><td style='width:75%' ><p>Gets or sets the type of the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bcb6d2d-45b7-4232-b96b-4dce7d9284c6'>TextAlign</a></td><td style='width:75%' class='def'><p>Gets or sets the text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81a5da59-8f2d-42f2-9140-f184346ad6b2'>TextEncoding</a></td><td style='width:75%' ><p>Gets or sets the text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc6d6490-64fd-49b9-935f-6bfba315737b'>TextScaleX</a></td><td style='width:75%' class='def'><p>Gets or sets the text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#435c2737-288b-4133-8e20-0a060ae4a6c9'>TextSize</a></td><td style='width:75%' ><p>Gets or sets the size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a76c2e7d-0bce-4525-a7c5-16be82a2bd34'>TextSkewX</a></td><td style='width:75%' class='def'><p>Gets or sets the text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#496e1d14-6f1f-4f8c-af7b-d381827cc406'>Typeface</a></td><td style='width:75%' ><p>Gets or sets the typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4706f55d-c293-43e6-8f3f-987ed0368f88'>TypefaceStyle</a></td><td style='width:75%' class='def'><p>Gets or sets the typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d139fcc-5840-4f29-96b7-5847fa6b6448'>UnderlineText</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> underline text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cf66664-02a8-45cd-ab27-f569064afdd5'>UniqueID</a></td><td style='width:75%' class='def'><p>Gets or sets the unique identifier.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#24d8a393-2c40-4b11-8902-d0852aed30c3'>ApplyFillEffects</a></td><td style='width:75%' ><p>Applies the fill effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e76159f9-fbb8-4457-a834-af21875f9f09'>ApplyFrameEffects</a></td><td style='width:75%' class='def'><p>Applies the frame effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe03c2f0-7cf7-400b-b9fc-23b0e7d93d23'>Clone</a></td><td style='width:75%' ><p>Clones the <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9977fc9a-b628-43df-9a21-66ca00f8bf60'>ClonePaint</a></td><td style='width:75%' class='def'><p>Clones the given <code>SKPaint</code> object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6faceadd-a027-4c40-878a-fcd260161180'>HandleFillBlurOrShadowChange</a></td><td style='width:75%' ><p>Handles the fill blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14328d15-e792-41f7-bb02-d144efce443f'>HandleFillColorChange</a></td><td style='width:75%' class='def'><p>Handles the fill color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bedc32b-0fd3-4407-a98d-e03b397abea4'>HandleFillGradientChange</a></td><td style='width:75%' ><p>Handles the fill gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17010e68-c63c-4a7d-a83a-2dc53fcc1268'>HandleFrameBlurOrShadowChange</a></td><td style='width:75%' class='def'><p>Handles the frame blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89a52c1f-6a29-453f-b867-47eb5f90f433'>HandleFrameColorChange</a></td><td style='width:75%' ><p>Handles the frame color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcd706e2-9e86-48a3-a2f3-73d2cc7210c3'>HandleFrameGradientChange</a></td><td style='width:75%' class='def'><p>Handles the frame gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edae8d40-ee54-4148-9baf-bf9445b38299'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#622f894e-2300-4197-bba7-9f4aa2283086'>KimonoStyle</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#c441c4bb-a1b4-455f-aaca-18aa873ff2cf">KimonoStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b51209c8-e73d-4fae-8a31-b45117fcf9ed'>MakeDashInterval</a></td><td style='width:75%' ><p>Makes the dash interval from the dash pattern.</p>
</td></tr></table></p>


---

<a name="123b85c2-002f-4b58-8208-8b0fda7d825f"></a>
##Public Enum KimonoStyleType

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Enum`

###Summary

Defines the type of a `KimonoStyle` that will be used to draw a given `KimonoShape` in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#894dd3bd-a97b-4cd6-9f0b-ec49a49d29d9'>Custom</a></td><td style='width:75%' ><p>A custom style that belongs only to an individual shape instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5abe698-8988-4d28-a8ac-7557457c020b'>CustomText</a></td><td style='width:75%' class='def'><p>A custom text style that belongs only to an individual <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d7c34d9-d152-4813-98d8-7d76791dbfc3'>Default</a></td><td style='width:75%' ><p>The default style for new shapes. This style cannot be deleted or renamed by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#533a83b8-ff6e-42c8-85d4-424294f66e56'>Standard</a></td><td style='width:75%' class='def'><p>A shared style that can be applied to multiple <code>Kimonoshape</code> instances.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9541ebd4-70cb-4335-9b21-014ffd64d336'>Text</a></td><td style='width:75%' ><p>A shared text style that can be applied to multiple <code>KimonoShapeText</code> instances.</p>
</td></tr></table></p>


---

<a name="cb899de9-c57c-45d2-8438-cb8855487811"></a>
##Public Enum KimonoTool

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Enum`

###Summary

Defines the current tool that is active in a `KimonoSketch` that the user can use to create or modify a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#313f2f84-ac88-4105-9910-771a682a3fa4'>Arrow</a></td><td style='width:75%' ><p>Use the Arrow tool to add a new <code>KimonoShapeArrow</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2483ae9f-1880-4965-9245-d1c319f39dde'>Bezier</a></td><td style='width:75%' class='def'><p>Use the Bezier tool to add a new <code>KimonoShapeBezier</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#964af6bf-74d2-4417-8361-d4457dfa450e'>Cursor</a></td><td style='width:75%' ><p>Use the Cursor tool to modify an existing <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#897f8416-aafb-49a5-8aa0-257518eff9b7'>Line</a></td><td style='width:75%' class='def'><p>Use the Line tool to add a new <code>KimonoShapeLine</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17055952-fd40-4564-8ed1-fa39434fd903'>Oval</a></td><td style='width:75%' ><p>Use the Oval tool to add a new <code>KimonoShapeOval</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96b76010-48a3-465d-90e4-d8494ef758ef'>Polygon</a></td><td style='width:75%' class='def'><p>Use the Polygon tool to add a new <code>KimonoShapePolygon</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27b04fe0-d769-4bf4-a805-d6fffdb4a541'>Rectangle</a></td><td style='width:75%' ><p>Use the Rectangle tool to add a new <code>KimonoShapeRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef2c043b-2e8f-4907-9f24-426008114c8a'>RoundRect</a></td><td style='width:75%' class='def'><p>Use the Round Rect tool to add a new <code>KimonoShapeRoundRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84399508-7947-4f3a-9cb2-670b78d9ff2f'>Star</a></td><td style='width:75%' ><p>Use the Star tool to add a new <code>KimonoShapeStar</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c1082eb-9220-42af-8406-71ff6d126d92'>Text</a></td><td style='width:75%' class='def'><p>Use the Text tool to add a new <code>KimonoShapeText</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cde26956-bf05-419c-8f3e-0607cc2b996c'>Triangle</a></td><td style='width:75%' ><p>Use the Triangle tool to add a new <code>KimonoShapeTriangle</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a0d7ac8-9cb1-45ce-a36c-df64c43dd217'>Vector</a></td><td style='width:75%' class='def'><p>Use the Vector tool to add a new <code>KimonoShapeVector</code> to the sketch.</p>
</td></tr></table></p>


---

<a name="e7da2536-e17c-44b8-8f70-5065503d7de4"></a>
##Public Class KimonoUndoHandler

###Namespace

[KimonoCore](#6103df7f-d3a3-42a9-9a56-16cdd4d8fcda)

###Inherits From

`System.Object`

###Summary

Handles the undo/redo state for a `KimonoDesignSurface`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#157a0adf-853e-4273-b0a1-d9b38c201fcf'>UndoStateChanged</a></td><td style='width:75%' ><p>The private <code>UndoStateChanged</code> field of the <code>KimonoUndoHandler</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cd46c52b-469d-483c-97ae-f2c7bb8b9764'>CanRedo</a></td><td style='width:75%' ><p>Gets a value indicating whether the user can redo their last action.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e740698f-0cea-4f9f-a8ad-eb7e9562d7ef'>CanUndo</a></td><td style='width:75%' class='def'><p>Gets a value indicating whether the user can undo their last action.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bba35d42-292c-4d60-9124-a60f65fc756a'>MaximumUndoPoints</a></td><td style='width:75%' ><p>Gets or sets the maximum undo points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1e3a13d-b1e1-456e-9a1e-711535d88fdb'>RedoStack</a></td><td style='width:75%' class='def'><p>Gets or sets the redo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e626cc7-a1cb-47a8-b270-7d327573999a'>UndoStack</a></td><td style='width:75%' ><p>Gets or sets the undo stack.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#75dc4ab0-226e-4aff-877d-0d35cc18e026'>KimonoUndoHandler</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#e7da2536-e17c-44b8-8f70-5065503d7de4">KimonoUndoHandler</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff4c2324-f4e8-444f-b84f-481b3b2e6f8f'>PopRedoPoint</a></td><td style='width:75%' class='def'><p>Pops the redo point off the stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd9d4508-7d9b-4cd2-b6d1-3ffa9f880e07'>PopUndoPoint</a></td><td style='width:75%' ><p>Pops the undo point off the stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35b7f7c0-e823-4a89-b454-e2909b0616b1'>PushUndoPoint</a></td><td style='width:75%' class='def'><p>Pushes the undo point onto the stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05a485fa-32c7-4ed4-a2f0-71a0d4a35c45'>RaiseUndoStateChanged</a></td><td style='width:75%' ><p>Raises the undo state changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24c33c3c-36ef-4912-9147-a174d6b901e6'>ReplaceLastUndoPoint</a></td><td style='width:75%' class='def'><p>Replaces the last undo point with the one being passed in.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5dfa405a-a3ef-43c2-905f-d0f526ae4759'>UndoStateChanged</a></td><td style='width:75%' ><p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="d3116afc-96a9-44b4-b4c7-2e30d9a194ef"></a>
##PortfolioEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Portfolio event delegate.

---

<a name="d433a563-8929-4467-a4a2-cec7dd75d576"></a>
##ShapeEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Shape event delegate.

---

<a name="a7beb193-d36a-4580-843e-5cf6a6983896"></a>
##SketchEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Sketch event delegate.

---

<a name="279cd13d-6307-48fe-9691-b3cf4cbafc18"></a>
##SkiaColorEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Skia color event delegate.

---

<a name="bfbe96be-6e35-47b9-a948-05247f47ad11"></a>
##SkiaPointEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Skia point event delegate.

---

<a name="2aaf4313-c5a8-46c4-ba3e-028f99e9950e"></a>
##StyleEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Style event delegate.

---

<a name="4a5cb542-03c0-4c45-b57f-4528c185e19f"></a>
##ToolEventDelegate

###Namespace

[KimonoCore.Kimono](#70c34338-e489-4b85-b9d8-dee99ba79e31)

###Summary

Tool event delegate.
<a name="Fields"></a>
#Fields


---

<a name="9a4d6549-19dd-4c34-9612-82d27ebfe30e"></a>
##`System.Boolean` _adjustAlpha

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Should adjust alpha transparency.

---

<a name="418ee6d5-ed0e-4233-9641-ccb578e72af8"></a>
##`System.Boolean` _adjustBrightness

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Should adjust brightness.

---

<a name="85efa7d6-54a9-4179-82a3-d061c8b35e4c"></a>
##`System.Boolean` _adjustHue

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Should adjust hue.

---

<a name="5a18e52c-288f-4452-ad11-b210c941e7d9"></a>
##`System.Boolean` _adjustSaturation

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Should adjust saturation.

---

<a name="7cb6a07b-ea02-46f6-bf64-636904243c35"></a>
##`System.Int32` _alphaAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The alpha adjustment.

---

<a name="9d3e4982-a7d1-4ed9-b185-7c0c75fd1c1a"></a>
##[KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) _baseColor

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The `KiminoColor` this color is based off of.

---

<a name="2e7d5016-2166-4e17-95aa-b0661288a918"></a>
##`System.Single` _brightnessAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The brightness adjustment.

---

<a name="df88c54f-f2d5-4977-aaff-89b95f920af2"></a>
##Private `SkiaSharp.SKColor` _canvasColor

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The color of the canvas.

---

<a name="198b7f77-ac7e-49d9-a49a-724157c5ea08"></a>
##`SkiaSharp.SKColor` _color

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The color value.

---

<a name="90cfcc62-e0fc-4951-b76d-7cc3dce4d488"></a>
##Private `SkiaSharp.SKColor` _color

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

The color of the shadow.

---

<a name="cd8d8bb7-33fa-4081-8441-5ea3cbb12182"></a>
##Private [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) _endPoint

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The end point.

---

<a name="b1d42396-5fa2-498c-b4ca-dc34ef2f533c"></a>
##Private [KimonoCore.KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce) _fillBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The fill blur.

---

<a name="beaa5f6e-d3a4-4b68-93e2-9bd2b7bdf743"></a>
##Private [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) _fillColor

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Holds a named `KimonoColor` attached to the style's fill color.

---

<a name="39056d94-9eb4-42ac-95ec-23373c2a4ea3"></a>
##Private [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) _fillGradient

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The fill gradient.

---

<a name="903954de-022f-4eac-9820-697cd3c56fac"></a>
##Private `System.Single` _fillJitterDeviation

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The fill jitter deviation.

---

<a name="a56494a8-c642-4874-846e-cd317fe700c0"></a>
##Private `System.Single` _fillJitterLength

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The length of the fill jitter.

---

<a name="b7c62e0c-19b1-4119-a625-3fb2f1eb5298"></a>
##Private [KimonoCore.KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565) _fillShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The fill shadow.

---

<a name="3a30a9ae-527b-4a9f-a32b-3af7071c35df"></a>
##Private [KimonoCore.KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce) _frameBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The frame blur.

---

<a name="182bbc95-0dc6-4bbe-9af8-e56f5b93f986"></a>
##Private [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) _frameColor

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Holds a named `KimonoColor` attached to the style's frame color.

---

<a name="bde1ef09-0c26-41e3-8f10-ffab26cd41d3"></a>
##Private [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) _frameGradient

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The frame gradient.

---

<a name="0d335d4c-1960-46de-b5ed-967ddea4977a"></a>
##Private `System.Single` _frameJitterDeviation

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The frame jitter deviation.

---

<a name="f238b2ed-6228-4e51-9b5e-1492fb08e6d2"></a>
##Private `System.Single` _frameJitterLength

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The length of the frame jitter.

---

<a name="81746182-b3dc-433a-88fa-8d3008b5a680"></a>
##Private [KimonoCore.KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565) _frameShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The frame shadow.

---

<a name="1d4c2b82-ab62-4b35-a8d7-7925312d104b"></a>
##Private [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) _gradient

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

The private `_gradient` field of the `KimonoGradientDesignPreview` class holds a `KimonoCore.KimonoGradient` value.

---

<a name="44469641-1133-4492-9254-60db286dbb35"></a>
##Private [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) _gradient

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

The private `_gradient` field of the `KimonoGradientDesignBar` class holds a `KimonoCore.KimonoGradient` value.

---

<a name="4d6a52e5-d72b-4521-8e2b-f17602043b4d"></a>
##Private [KimonoCore.KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b) _gradientType

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The type of the gradient.

---

<a name="68eb49a6-5c9d-47d5-a983-ad2fea515af0"></a>
##Private `System.Boolean` _hasFillBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The has fill blur.

---

<a name="d13cc029-d9fb-4a8f-9a6c-d2c69e203cf6"></a>
##Private `System.Boolean` _hasFillJitter

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

If `true`, the fill uses the jitter effect.

---

<a name="c6135b83-6f8c-4252-9e5e-66f3867986ac"></a>
##Private `System.Boolean` _hasFillShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The has fill shadow.

---

<a name="1275dcf1-88d9-4f01-9451-340c5647710b"></a>
##Private `System.Boolean` _hasFrameBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The has frame blur.

---

<a name="4d5258c4-0d10-44a7-982e-b1e6e0b8f842"></a>
##Private `System.Boolean` _hasFrameDash

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

If `true`, the frame has a dash effect.

---

<a name="89ea90e6-ddef-4c2f-93d8-363b8e703f00"></a>
##Private `System.Boolean` _hasFrameJitter

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

If `true`, the frame uses the jitter effect.

---

<a name="bd2003aa-0970-4ef3-b9f3-df1909dbbfc8"></a>
##Private `System.Boolean` _hasFrameShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

The has frame shadow.

---

<a name="b4a91635-8a77-41b0-b347-7b686d0bc2f9"></a>
##Private `System.Single` _horizontalBlurAmount

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

The horizontal blur amount.

---

<a name="0c50bc5d-26df-4ab8-a548-7909f5a03ae0"></a>
##Private `System.Single` _horizontalBlurAmount

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

The horizontal blur amount.

---

<a name="2d007efb-e072-44af-a249-34f3d714857d"></a>
##Public `System.Single` _horizontalOffset

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

The horizontal offset.

---

<a name="e9405e5c-93e0-4d8a-bddf-ad4bfe573ab2"></a>
##`System.Single` _hueAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The hue adjustment.

---

<a name="5f5dc9e8-1367-4d79-9108-e52ad1b82745"></a>
##Private `System.Boolean` _isMaskedGroup

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

If `true`, the top most shape in the group will act as a mask for the shapes below it.

---

<a name="080898cb-6ed0-4c41-b87f-44351f947dac"></a>
##Private [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) _linkedColor

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

A linked `KimonoColor` to use as the shadow color.

---

<a name="042e24f4-a0d4-4896-af14-2cab8785f48b"></a>
##Private `System.String` _name

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

The default name of the shape.

---

<a name="35e8fc5a-ac64-4e14-9376-d6f6e2e1f22b"></a>
##Private [KimonoCore.KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0) _portfolio

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The portfolio currently being worked on.

---

<a name="bb566344-1f24-442e-bf7f-15d085f113d7"></a>
##Private `System.Single` _radius

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The radius for radial and conical gradients.

---

<a name="c176c438-2e6b-40af-87fa-63839aa57707"></a>
##`System.Single` _saturationAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The saturation adjustment.

---

<a name="01f498e0-95ab-4153-8c0f-08eff3912e7e"></a>
##Private [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) _selectedHandle

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The selected handle.

---

<a name="324e0b28-53b1-4f7d-8dc2-c5934669ebbe"></a>
##Private [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) _selectedShape

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

The currently selected shape.

---

<a name="9a76b532-3089-48b4-8d5d-dcbbb1f5e993"></a>
##Private [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) _selectedShape

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The selected shape.

---

<a name="94606723-3ad2-4f6f-a186-2961f4abf970"></a>
##[KimonoCore.KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) _selectedSketch

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The currently selected sketch.

---

<a name="5fceef44-c192-49e8-8ed7-7e43bf875686"></a>
##Private [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) _startPoint

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The start point.

---

<a name="b244474d-d231-4061-b2ec-7d6e1e25152c"></a>
##[KimonoCore.KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) _style

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

The default, custom `KimonoStyle` that is attached to the shape.

---

<a name="afdf5970-ea46-42b1-9dd4-68b8454b1342"></a>
##Private `SkiaSharp.SKShaderTileMode` _tileMode

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The gradient tile mode.

---

<a name="5e84fc32-5744-463f-8abf-672918298e85"></a>
##Private [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) _tool

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The currently `KimonoTool` that will be used to edit the sketch.

---

<a name="f0ab5fcf-3927-456f-8081-c2168fb051a0"></a>
##Private `System.Single` _verticalBlurAmount

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

The vertical blur amount.

---

<a name="82f6951f-46d8-4d35-acb9-dff08ff927af"></a>
##Private `System.Single` _verticalBlurAmount

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

The vertical blur amount.

---

<a name="34a7ff8f-575e-4cc5-82ec-2bafdc4dfb2d"></a>
##Public `System.Single` _verticalOffset

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

The vertical offset.

---

<a name="e82d1389-432d-4140-97ba-47940af173e6"></a>
##`System.Boolean` _visible

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

The visibility of the shape.

---

<a name="d6b4a0d5-27b5-4dba-b04b-1a04ed019ffa"></a>
##`System.Int32` Alpha

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The base alpha transparency value.

---

<a name="313f2f84-ac88-4105-9910-771a682a3fa4"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Arrow = `2`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Arrow tool to add a new `KimonoShapeArrow` to the sketch.

---

<a name="2483ae9f-1880-4965-9245-d1c319f39dde"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Bezier = `10`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Bezier tool to add a new `KimonoShapeBezier` to the sketch.

---

<a name="0ab86c0f-d8a5-4775-9cf0-1433a5470b91"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) BlurModified

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

The private `BlurModified` field of the `KimonoBlur` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="84029c19-a92d-4aaa-bf0e-d8cd30d8cafb"></a>
##`System.Single` Brightness

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The base brightness.

---

<a name="6f96a8a7-e132-4dfb-999e-29e5db3d0e6f"></a>
##Public Static Constant [KimonoCore.KimonoShapeGroupType](#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157) Collection = `2`

###Member of Type

[KimonoShapeGroupType](#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157)

###Summary

The group is a collection of shape that have been grouped together and are treated as a single object in the editor.

---

<a name="903e4838-a1c3-471e-865d-fef233acc1e0"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ColorChanged

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The private `ColorChanged` field of the `KimonoColor` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="e9a5b230-930e-45d8-8159-d7f103bfa3cf"></a>
##Private [KimonoCore.Kimono.ColorEventDelegate](#25985d5b-a2ce-424e-be45-441f59aa7c43) ColorsModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `ColorsModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="460ccaa7-925b-4524-9e89-ab2dc7d45678"></a>
##Private [KimonoCore.Kimono.ColorEventDelegate](#25985d5b-a2ce-424e-be45-441f59aa7c43) ColorsModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `ColorsModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="0dc0514c-2965-44e4-a5fc-a70491d17480"></a>
##Public Static Constant [KimonoCore.KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b) ConicalGradient = `3`

###Member of Type

[KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b)

###Summary

The conical gradient.

---

<a name="65f759bd-1097-409f-8b8a-091681528d25"></a>
##Public Static Constant [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) Constructing = `4`

###Member of Type

[KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d)

###Summary

The shape is in the process of being built. For example, a set of shapes being added to a group.

---

<a name="f795e98f-e7c2-4f88-8ea3-d6d66683ce59"></a>
##Public Static Constant [KimonoCore.KimonoHandleType](#70c2ef11-f148-4072-b31b-fc357aaca407) ControlPoint = `0`

###Member of Type

[KimonoHandleType](#70c2ef11-f148-4072-b31b-fc357aaca407)

###Summary

A general purpose handle for a shape's bound or a control point on a  vector or bezier.

---

<a name="964af6bf-74d2-4417-8361-d4457dfa450e"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Cursor = `0`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Cursor tool to modify an existing `KimonoShape`.

---

<a name="894dd3bd-a97b-4cd6-9f0b-ec49a49d29d9"></a>
##Public Static Constant [KimonoCore.KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f) Custom = `1`

###Member of Type

[KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f)

###Summary

A custom style that belongs only to an individual shape instance.

---

<a name="a5abe698-8988-4d28-a8ac-7557457c020b"></a>
##Public Static Constant [KimonoCore.KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f) CustomText = `2`

###Member of Type

[KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f)

###Summary

A custom text style that belongs only to an individual `KimonoShapeText` instance.

---

<a name="3d7c34d9-d152-4813-98d8-7d76791dbfc3"></a>
##Public Static Constant [KimonoCore.KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f) Default = `0`

###Member of Type

[KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f)

###Summary

The default style for new shapes. This style cannot be deleted or renamed by the user.

---

<a name="74e9a1b2-03f7-455f-a1aa-f357d27b7abb"></a>
##Private `System.Boolean` Dragging

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Marks if the group itself is being moved be the user.

---

<a name="e241083b-310f-4341-8d69-2f88dd4c9382"></a>
##Public Static Constant [KimonoCore.KimonoShapeGroupType](#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157) DragSelect = `1`

###Member of Type

[KimonoShapeGroupType](#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157)

###Summary

The group is a drag to select selection that is underway.

---

<a name="29a32ccf-bbce-4946-aa45-5e445c67b6bb"></a>
##Public Static `System.Single` DrawOffset

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

The draw offset of the drag handle.

---

<a name="a453ec07-5aa4-4fe2-848d-4a9eab095f38"></a>
##Public Static `System.Single` DrawWidth

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

The width of the drag handle.

---

<a name="96d128df-68cb-4d92-a9fc-440d6a48b32c"></a>
##Public Static Constant [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) Editing = `2`

###Member of Type

[KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d)

###Summary

The shape is in the edit mode and individual control points can be added, deleted, moved or adjusted.

---

<a name="e82a4a38-0254-4110-a698-4d3a319c33d4"></a>
##Public Static Constant [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) Finalizing = `3`

###Member of Type

[KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d)

###Summary

The shape is leaving the edit mode and needs to be completed.

---

<a name="bf50e74d-7e15-4617-9706-3c4f72b6df21"></a>
##Public Static Constant [KimonoCore.KimonoHandleType](#70c2ef11-f148-4072-b31b-fc357aaca407) GradientColor = `1`

###Member of Type

[KimonoHandleType](#70c2ef11-f148-4072-b31b-fc357aaca407)

###Summary

Defines a color inside of a gradient.

---

<a name="c872c60e-b1f8-467e-9e93-91e812b33c08"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) GradientModified

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

The private `GradientModified` field of the `KimonoGradientDesignPreview` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="ce3e4538-e789-4f32-8012-c031e3856844"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) GradientModified

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The private `GradientModified` field of the `KimonoGradient` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="b12f9c25-cb5e-424e-a087-a7b0f07b3b72"></a>
##Public Static Constant [KimonoCore.KimonoHandleType](#70c2ef11-f148-4072-b31b-fc357aaca407) GradientPosition = `2`

###Member of Type

[KimonoHandleType](#70c2ef11-f148-4072-b31b-fc357aaca407)

###Summary

Defines the position of a gradient in a shape object.

---

<a name="4cd17f21-f979-4b57-ab3e-8a8c6e99c553"></a>
##Private [KimonoCore.Kimono.GradientEventDelegate](#6c8be89d-0395-4113-848e-8d6c6db2db41) GradientsModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `GradientsModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="bdafb91b-f0c7-4fdd-ae25-5639d95942b6"></a>
##Private [KimonoCore.Kimono.GradientEventDelegate](#6c8be89d-0395-4113-848e-8d6c6db2db41) GradientsModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `GradientsModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="cf1ead7c-8156-475f-8b1d-ae8e4caedbd4"></a>
##Public Static Constant [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) Grouping = `5`

###Member of Type

[KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d)

###Summary

The shape is being added to a group.

---

<a name="c6ce8609-1553-45a2-a262-a46f00a7e46d"></a>
##Private [KimonoCore.Kimono.HandleEventDelegate](#5436152c-1852-4971-8005-73d9893d5536) HandleSelected

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

The private `HandleSelected` field of the `KimonoGradient` class holds a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="ec77d40a-c559-4c9b-87e9-060bffa60207"></a>
##Private [KimonoCore.Kimono.HandleEventDelegate](#5436152c-1852-4971-8005-73d9893d5536) HandleSelected

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

The private `HandleSelected` field of the `KimonoGradientDesignBar` class holds a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="a1156ebb-23ea-4ea8-a45a-326bc6bdbb49"></a>
##Private [KimonoCore.Kimono.HandleEventDelegate](#5436152c-1852-4971-8005-73d9893d5536) HandleSelected

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

The private `HandleSelected` field of the `KimonoGradientDesignPreview` class holds a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="eb68afe1-2a3e-4780-8d3d-d82aaf12cdf7"></a>
##Public Static Constant [KimonoCore.KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50) Horizontal = `1`

###Member of Type

[KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50)

###Summary

The handle can only be moved horizontally.

---

<a name="dd29945d-86be-47ae-92a8-759e240be7d2"></a>
##`System.Single` Hue

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The base hue.

---

<a name="a50337ff-e69a-47d8-9b57-42fc06cba97d"></a>
##Private `System.Boolean` IgnoreDrag

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

If `true`, the next drag event will be ignored.

---

<a name="597323b2-a672-4b80-b0d0-bbf49689fce7"></a>
##Private `System.Boolean` IgnoreDrag

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

If `true`, the next drag event will be ignored.

---

<a name="3d4bf755-6717-40d6-b165-7affbc3bfc31"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ImageBufferNeedsRefresh

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The private `ImageBufferNeedsRefresh` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="897f8416-aafb-49a5-8aa0-257518eff9b7"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Line = `1`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Line tool to add a new `KimonoShapeLine` to the sketch.

---

<a name="c4745336-7b9e-47e0-9617-8f4e2114e5ea"></a>
##Public Static Constant [KimonoCore.KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b) LinearGradient = `0`

###Member of Type

[KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b)

###Summary

The linear gradient.

---

<a name="7086f8ff-4e16-49e8-a4e6-b322088f6211"></a>
##Public Static Constant [KimonoCore.KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50) Locked = `3`

###Member of Type

[KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50)

###Summary

The handle is locked in place and cannot be moved.

---

<a name="afd3b700-ac34-4740-999b-08db50117f39"></a>
##Private [KimonoCore.Kimono.SkiaPointEventDelegate](#bfbe96be-6e35-47b9-a948-05247f47ad11) Moved

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

The private `Moved` field of the `KimonoHandle` class holds a `KimonoCore.Kimono.SkiaPointEventDelegate` value.

---

<a name="156df400-a324-4953-84fa-e743d48936ad"></a>
##`System.Int32` NewSketchNumber

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Holds the number that will be assigned to the next new `KimonoSketch` created in this portfolio.

---

<a name="f07438a1-4340-4ab5-9321-9c5dab9d0838"></a>
##Public Static Constant [KimonoCore.KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50) None = `0`

###Member of Type

[KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50)

###Summary

No movement constraint.

---

<a name="17055952-fd40-4564-8ed1-fa39434fd903"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Oval = `4`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Oval tool to add a new `KimonoShapeOval` to the sketch.

---

<a name="32e0c72f-a2f3-40d8-8ec2-8555837b03b5"></a>
##Private `System.Boolean` PerformingDrag

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

If `true`, the user is performing a drag operation.

---

<a name="8408629a-c472-4134-86f1-da4add771fd8"></a>
##Private `System.Boolean` PerformingDrag

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

If `true`, the user is performing a drag operation.

---

<a name="de53bfc5-9168-4819-83df-28c711ff6915"></a>
##Private `System.Boolean` PerformingDrag

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Is the user performing a drag operation.

---

<a name="96b76010-48a3-465d-90e4-d8494ef758ef"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Polygon = `7`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Polygon tool to add a new `KimonoShapePolygon` to the sketch.

---

<a name="afa0d6db-545e-4628-b65a-b9d80774c0d7"></a>
##`SkiaSharp.SKPoint` PreviousCenter

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Holds the previous center used in scaling operations.

---

<a name="63615b92-e6df-4b24-95f3-8eed1632dab1"></a>
##`SkiaSharp.SKRect` PreviousRect

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Holds the previous rect used in scaling operations.

---

<a name="3893c215-b852-4b6f-9d17-0f210ad3be73"></a>
##Private `SkiaSharp.SKSize` PreviousSize

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The size of the previous of a sketch for a rezise operation.

---

<a name="7fb90bee-3803-4cfb-a9e8-fb97e7bef8bf"></a>
##Public Static Constant [KimonoCore.KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b) RadialGradient = `1`

###Member of Type

[KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b)

###Summary

The radial gradient.

---

<a name="159fe11d-c9c4-45ed-8a56-6e5c48cbd8e6"></a>
##`SkiaSharp.SKRect` Rect

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

The base `SkRect` that holds the internal bounds of the shape.

---

<a name="27b04fe0-d769-4bf4-a805-d6fffdb4a541"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Rectangle = `3`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Rectangle tool to add a new `KimonoShapeRect` to the sketch.

---

<a name="42e201a1-6a7a-490d-84fd-11527a47c19c"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ReloadUI

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `ReloadUI` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="a9e8361a-5eec-4c72-9ef4-3da18562fb2b"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) RequestNewUndoPoint

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `RequestNewUndoPoint` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="84b54f60-0a8e-424a-a5fc-fda32fd05c5c"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) RequestNewUndoPoint

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The private `RequestNewUndoPoint` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="ef2c043b-2e8f-4907-9f24-426008114c8a"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) RoundRect = `5`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Round Rect tool to add a new `KimonoShapeRoundRect` to the sketch.

---

<a name="eeb1f365-18be-472d-9080-a1ab3d7d4af9"></a>
##`System.Single` Saturation

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The base saturation.

---

<a name="d56c7e6f-0560-43c4-b704-266d41251588"></a>
##Public Static Constant [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) Selected = `1`

###Member of Type

[KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d)

###Summary

The shape is being selected.

---

<a name="8d371f28-9e17-4aa7-aad5-fcfbd9b53945"></a>
##Private [KimonoCore.Kimono.ShapeEventDelegate](#d433a563-8929-4467-a4a2-cec7dd75d576) SelectedShapeChanged

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `SelectedShapeChanged` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="44563e09-1650-48fb-aae2-7eaf047b9fab"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SelectedShapeModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `SelectedShapeModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="da4d6fd9-c9c5-4a39-8f3a-da4312fd57b4"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SelectedShapeModified

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The private `SelectedShapeModified` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="4d22775e-b753-4c87-8b65-5d63e700709c"></a>
##Private [KimonoCore.Kimono.SketchEventDelegate](#a7beb193-d36a-4580-843e-5cf6a6983896) SelectedSketchDidChange

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `SelectedSketchDidChange` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="46e18a7e-faef-4ba4-91c2-4a1add217b2f"></a>
##Private [KimonoCore.Kimono.SketchEventDelegate](#a7beb193-d36a-4580-843e-5cf6a6983896) SelectedSketchWillChange

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `SelectedSketchWillChange` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="d6e18d1f-4af5-4967-8955-e7ab87bbc338"></a>
##Public Static Constant [KimonoCore.KimonoShapeGroupType](#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157) Selection = `0`

###Member of Type

[KimonoShapeGroupType](#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157)

###Summary

The group is a current active selection.

---

<a name="79c32ed8-27d2-46b5-b134-2e43409f1c80"></a>
##Private [KimonoCore.Kimono.ShapeEventDelegate](#d433a563-8929-4467-a4a2-cec7dd75d576) SelectionChanged

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The private `SelectionChanged` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="1b081ac6-be9e-47d5-83e6-4f1755e56747"></a>
##Private [KimonoCore.Kimono.ShapeEventDelegate](#d433a563-8929-4467-a4a2-cec7dd75d576) SelectionChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `SelectionChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="2dbbedbb-ec02-4354-bc26-d72c6a21a0d1"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ShadowModified

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

The private `ShadowModified` field of the `KimonoShadow` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="8d30e152-5115-4523-b613-f24cd3c4c3d1"></a>
##[KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) ShapeUnderConstruction

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The shape under construction.

---

<a name="e167a600-a106-43cc-9c26-6614a90ccdde"></a>
##Private [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) ShapeUnderConstruction

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

The shape under construction.

---

<a name="fd61fbff-e3ec-488b-8a66-e165479346ca"></a>
##Private `SkiaSharp.SKSize` Size

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The current size of the sketch

---

<a name="2e854e3f-d612-4a6f-89d7-47f2c3e7dee1"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchesModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `SketchesModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="afb20ba4-1ed7-454b-9df6-75a3aba3d0fd"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchesModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `SketchesModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="6e9c30b6-acc3-4ee9-bd8c-56b6cd93c221"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `SketchModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="d940edef-eec2-4e99-8cbf-7b20dc836a46"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchModified

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The private `SketchModified` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="13312ffc-e168-4e60-9541-91d3baa6c642"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchSizeChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `SketchSizeChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="92f601a3-f8e1-4a45-8d92-fcf82b3a2e23"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchSizeChanged

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The private `SketchSizeChanged` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="533a83b8-ff6e-42c8-85d4-424294f66e56"></a>
##Public Static Constant [KimonoCore.KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f) Standard = `3`

###Member of Type

[KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f)

###Summary

A shared style that can be applied to multiple `Kimonoshape` instances.

---

<a name="84399508-7947-4f3a-9cb2-670b78d9ff2f"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Star = `6`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Star tool to add a new `KimonoShapeStar` to the sketch.

---

<a name="5a20d883-5617-4490-9137-6cabce6329fc"></a>
##Private [KimonoCore.Kimono.StyleEventDelegate](#2aaf4313-c5a8-46c4-ba3e-028f99e9950e) StylesModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The private `StylesModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="d42c0aac-3ede-4689-b8f9-c73693a7afa7"></a>
##Private [KimonoCore.Kimono.StyleEventDelegate](#2aaf4313-c5a8-46c4-ba3e-028f99e9950e) StylesModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `StylesModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="7a81aa54-4fbf-4bb2-8453-8a38bc77de26"></a>
##Public Static Constant [KimonoCore.KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b) SweepGradient = `2`

###Member of Type

[KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b)

###Summary

The sweep gradient.

---

<a name="9541ebd4-70cb-4335-9b21-014ffd64d336"></a>
##Public Static Constant [KimonoCore.KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f) Text = `4`

###Member of Type

[KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f)

###Summary

A shared text style that can be applied to multiple `KimonoShapeText` instances.

---

<a name="7c1082eb-9220-42af-8406-71ff6d126d92"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Text = `11`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Text tool to add a new `KimonoShapeText` to the sketch.

---

<a name="039f0813-db8e-455d-b4f6-7a2984407d1a"></a>
##Private [KimonoCore.Kimono.ToolEventDelegate](#4a5cb542-03c0-4c45-b57f-4528c185e19f) ToolChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `ToolChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.ToolEventDelegate` value.

---

<a name="454921ad-352c-4689-b2ba-109e612b1273"></a>
##Private [KimonoCore.Kimono.ToolEventDelegate](#4a5cb542-03c0-4c45-b57f-4528c185e19f) ToolChanged

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The private `ToolChanged` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.ToolEventDelegate` value.

---

<a name="bb32857b-bf1e-4fc5-b8fa-85a9d352ecd0"></a>
##Private `SkiaSharp.SKPoint` ToolDownAt

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The last point that a `KimonoTool` went down on the sketch's Design Surface.

---

<a name="033fe23a-9906-4c51-9cc2-363fbd881cc3"></a>
##Private `SkiaSharp.SKPoint` ToolDownAt

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

The last point that a `KimonoTool` went down on the sketch's Design Surface.

---

<a name="cde26956-bf05-419c-8f3e-0607cc2b996c"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Triangle = `8`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Triangle tool to add a new `KimonoShapeTriangle` to the sketch.

---

<a name="cba2a4df-1aff-4134-a253-614742c48d1d"></a>
##Private [KimonoCore.KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4) UndoHandler

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The `KimonoUndoHandler` that handles undo and redo events for the  Design Surface.

---

<a name="58023f7e-6582-40cf-8ae2-467c90f7032a"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) UndoStateChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

The private `UndoStateChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="157a0adf-853e-4273-b0a1-d9b38c201fcf"></a>
##Private [KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) UndoStateChanged

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

The private `UndoStateChanged` field of the `KimonoUndoHandler` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="6bed28aa-f397-44e2-9582-1b603cbcd811"></a>
##Public Static Constant [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) Unselected = `0`

###Member of Type

[KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d)

###Summary

The shape is unselected.

---

<a name="4a0d7ac8-9cb1-45ce-a36c-df64c43dd217"></a>
##Public Static Constant [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Vector = `9`

###Member of Type

[KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811)

###Summary

Use the Vector tool to add a new `KimonoShapeVector` to the sketch.

---

<a name="1f56756b-3f24-4720-85a6-fb1bdc97602f"></a>
##Public Static Constant [KimonoCore.KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50) Vertical = `2`

###Member of Type

[KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50)

###Summary

The handle can only be moved vertically.
<a name="Properties"></a>
#Properties


---

<a name="a6de35ac-f5b8-4fbd-bba7-ffead4ae446c"></a>
##Public `System.Boolean` AdjustsAlpha

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets a value indicating whether this [KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) adjusts alpha.
###Return Value

`true` if adjusts alpha; otherwise, `false`.

---

<a name="c9faabd1-9363-41ce-a09f-c3bbae6f4a8d"></a>
##Public `System.Boolean` AdjustsBrightness

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets a value indicating whether this [KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) adjusts brightness.
###Return Value

`true` if adjusts brightness; otherwise, `false`.

---

<a name="22a69651-f07f-45ab-ac5b-4fae6b7d0905"></a>
##Public `System.Boolean` AdjustsHue

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets a value indicating whether this [KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) adjusts hue.
###Return Value

`true` if adjusts hue; otherwise, `false`.

---

<a name="13a88711-3743-463f-be3c-9bc3f846b168"></a>
##Public `System.Boolean` AdjustsSaturation

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets a value indicating whether this [KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) adjusts saturation.
###Return Value

`true` if adjusts saturation; otherwise, `false`.

---

<a name="cdd38a88-fc7f-4a2e-b332-697cd8a3ef86"></a>
##Public `System.Int32` AlphaAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the alpha adjustment.
###Return Value

The alpha adjustment.

---

<a name="e35c6381-1f8d-47b7-bac5-ba2071c4c260"></a>
##Public Static Read Only `SkiaSharp.SKColor` Aluminum

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Aluminum` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="8335004c-8ec5-4169-b166-6979d8002eb9"></a>
##Public Static Read Only `SkiaSharp.SKColor` Aqua

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Aqua` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="1bc88c9a-812c-443b-b6b7-a375abf38c58"></a>
##Public Static Read Only `SkiaSharp.SKColor` Asparagus

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Asparagus` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="f5056df6-8fa5-4244-9ad4-5745d5470508"></a>
##Public Static Read Only `SkiaSharp.SKColor` Banana

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Banana` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="6b360cc6-8ecc-4f78-8307-3329d5924c96"></a>
##Public `System.Single` BarHeight

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the height of the bar.
###Return Value

The height of the bar.

---

<a name="a48a6ff7-03b8-4968-b461-ba4609e8bba9"></a>
##Public `System.Single` BarWidth

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the width of the bar.
###Return Value

The width of the bar.

---

<a name="7a9e5d9b-7a79-447c-8456-5caff609a803"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) BaseColor

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the `KimonoColor` that this color is based off of.
###Return Value

The base color.

---

<a name="0dbfa235-3e02-40ca-9f6f-d6680c9f2f4d"></a>
##Public Static Read Only `SkiaSharp.SKColor` Black

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Black` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="b29a72ed-b46a-4874-a76f-4e492425fe30"></a>
##Public Static Read Only `SkiaSharp.SKColor` Blue

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Blue` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="97bec9ad-7a99-4d84-9eb6-f0bba64fdee8"></a>
##Public Static Read Only `SkiaSharp.SKColor` Blueberry

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Blueberry` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="3394d753-1cfe-4d68-a16b-faf1767e59b8"></a>
##Public Read Only `SkiaSharp.SKImageFilter` BlurFilter

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Gets the blur filter represented by this blur effect.
###Return Value

The `SKImageFilter` for the blur filter.

---

<a name="a55c98b7-12e8-4d06-a27d-cac1313d2f23"></a>
##Public `SkiaSharp.SKPathOp` BooleanOperation

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets the boolean operation that will be applied to this group of objects.
###Return Value

The boolean operation as a `SKPathOp`.

---

<a name="468eaf3d-39e6-4db2-a7e5-38636a9a29e9"></a>
##Public `System.Single` Bottom

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the bottom.
###Return Value

The bottom coord location.

---

<a name="bfc67205-1f06-41c3-8661-ff6ffeaca662"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) BottomHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the bottom handle.
###Return Value

The bottom handle.

---

<a name="8578b5f4-9a2a-431e-83b7-cb97cb7e8bf3"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) BottomLeftHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the bottom left handle.
###Return Value

The bottom left handle.

---

<a name="932ac158-b1ce-4f96-9a47-c6906662428c"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) BottomRightHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the bottom right handle.
###Return Value

The bottom right handle.

---

<a name="fd450fed-5e5b-4514-aa58-ff54bcd9f248"></a>
##Public `System.Single` BrightnessAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the brightness adjustment.
###Return Value

The brightness adjustment.

---

<a name="ce48cc9d-14e6-4f02-8ca0-af4c83ad6ca4"></a>
##Public Static Read Only `SkiaSharp.SKColor` Bubblegum

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Bubblegum` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="5f4f82cf-fc23-456c-a896-0ea31def5e2c"></a>
##Public Read Only `System.Boolean` CanAlignShapes

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets a value indicating whether alignment can be applied on a set of shapes.
###Return Value

`true` if can align shapes; otherwise, `false`.

---

<a name="60eb721a-7fda-4a49-8359-cbc08880c838"></a>
##Public Read Only `System.Boolean` CanGroupShapes

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets a value indicating whether the selection of shapes can be grouped.
###Return Value

`true` if can group shapes; otherwise, `false`.

---

<a name="cd46c52b-469d-483c-97ae-f2c7bb8b9764"></a>
##Public Read Only `System.Boolean` CanRedo

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Gets a value indicating whether the user can redo their last action.
###Return Value

`true` if can redo; otherwise, `false`.

---

<a name="b77fbbab-6900-4bc9-b9e4-54f14eaa0be7"></a>
##Public Read Only `System.Boolean` CanRedo

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets a value indicating whether the user can redo their last action.
###Return Value

`true` if can redo; otherwise, `false`.

---

<a name="1ee12196-2c50-4fdb-9018-9647278040a1"></a>
##Public Static Read Only `SkiaSharp.SKColor` Cantalope

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Cantalope` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="c4695609-3909-4ea0-81bb-2c168a3c3aee"></a>
##Public Read Only `System.Boolean` CanUndo

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets a value indicating whether the user can undo their last action.
###Return Value

`true` if can undo; otherwise, `false`.

---

<a name="e740698f-0cea-4f9f-a8ad-eb7e9562d7ef"></a>
##Public Read Only `System.Boolean` CanUndo

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Gets a value indicating whether the user can undo their last action.
###Return Value

`true` if can undo; otherwise, `false`.

---

<a name="d474aa51-6ad9-4499-b55e-6d07302f6889"></a>
##Public Read Only `System.Boolean` CanUngroupShapes

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets a value indicating whether the selection of shapes can be ungrouped.
###Return Value

`true` if can group shapes; otherwise, `false`.

---

<a name="88827503-bab9-44a1-b710-f026ea3b0e70"></a>
##Public `SkiaSharp.SKColor` CanvasColor

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the color of the canvas.
###Return Value

The color of the canvas.

---

<a name="eb86e513-ff2c-4263-9816-8c87be0f9c05"></a>
##Public Static Read Only `SkiaSharp.SKColor` Carnation

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Carnation` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="3087f03b-7f84-4156-b25c-eb211e2afd43"></a>
##Public Static Read Only `SkiaSharp.SKColor` Cayenne

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Cayenne` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="40c29cbd-a580-434d-a574-858a4058988a"></a>
##Public Read Only `SkiaSharp.SKPoint` Center

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets the center.
###Return Value

The center.

---

<a name="8d1780b0-5acc-4bb9-a8e3-7e45374019c3"></a>
##Public `System.Boolean` Closed

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Gets or sets a value indicating whether this [KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850) is closed.
###Return Value

`true` if closed; otherwise, `false`.

---

<a name="f50f1ffd-0d06-4682-bfee-c7af43d9e6b1"></a>
##Public Static Read Only `SkiaSharp.SKColor` Clover

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Clover` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="1e0754e3-0d0e-4113-b217-93c9065dd4fa"></a>
##Public `SkiaSharp.SKColor` Color

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets or sets the color of the shadow.
###Return Value

The color.

---

<a name="7ce416db-cdfd-48c8-9e98-c06b8706aab3"></a>
##Public `SkiaSharp.SKColor` Color

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the color that this handle represents in a gradient. If the `LinkedColor` property is `null`, this color will be used.
###Return Value

The `SKColor`.

---

<a name="d5afde92-f893-433d-8d9c-21c81867af2c"></a>
##Public `SkiaSharp.SKColor` Color

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the color.
###Return Value

The color.

---

<a name="6e3416f3-eba6-4a8f-bc41-88e530c5ddab"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoColor>` Colors

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Gets or sets the colors.
###Return Value

The colors.

---

<a name="8b800687-66a6-4367-affc-d3a41af271d8"></a>
##Public [KimonoCore.KimonoHandleConstraint](#a25d8ed1-6332-46d5-8b7d-5aad70e52f50) Constraint

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the edit constraint.
###Return Value

The edit constraint as a `KimonoHandleConstraint`.

---

<a name="c059426d-b6ed-4966-bd69-35e613073b83"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoHandle>` ControlPoints

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the control points that define the color.
###Return Value

The control points.

---

<a name="ccdcf08a-c5eb-475c-a53a-5bcf74a2b6fd"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoHandle>` ControlPoints

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Gets or sets the control points that define the path of the shape.
###Return Value

A collection of `KimonoHandle` objects.

---

<a name="61134be2-97e6-4cc4-aae4-5ba79e25781a"></a>
##Public `System.Single` CornerRadius

###Member of Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Gets or sets the corner radius.
###Return Value

The corner radius.

---

<a name="06cec119-1370-4543-b8fc-6e28110597db"></a>
##Public Static Read Only `SkiaSharp.SKColor` DarkGray

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `DarkGray` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="ca0265a5-cd00-487b-8c3d-a9a9f1e91097"></a>
##Public `System.Boolean[]` DashPattern

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the dash pattern.
###Return Value

The dash pattern.

---

<a name="1b8f8894-5653-4ffc-97af-e8fbe91f1da1"></a>
##Public Read Only [KimonoCore.KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) DeeplySelectedGroup

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets the deepest selected group in a chain of groups that is in the edit mode.
###Return Value

The deeply selected group.

---

<a name="faca4c4a-49d5-4c45-885e-07f2af96c0e6"></a>
##Public Read Only [KimonoCore.KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) DeeplySelectedGroup

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets the deeply selected group.
###Return Value

The deeply selected `KimonoGroup`.

---

<a name="0c28e0b4-594f-48b7-a952-b544603b131c"></a>
##Public Read Only [KimonoCore.KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) DeeplySelectedGroup

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets the deepest selected group in a chain of groups that is in the edit mode.
###Return Value

The deeply selected group.

---

<a name="87a395ab-747e-4e80-8dd2-e7600b718f41"></a>
##Public Read Only [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) DeeplySelectedShape

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets the deeply selected shape.
###Return Value

The deeply selected `KimonoShape`.

---

<a name="f4e67c94-b337-4cfb-8f4b-4b5bd4aba143"></a>
##Public Read Only [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) DeeplySelectedShape

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets the deepest selected shape in a chain of groups.
###Return Value

The deeply selected shape.

---

<a name="06322882-c5b4-42a3-b60b-5181268e5d1f"></a>
##Public Read Only [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) DeeplySelectedShape

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets the deepest selected shape in a chain of groups.
###Return Value

The deeply selected shape.

---

<a name="2c1dde6e-54cf-41a4-b0f2-03546a85a543"></a>
##Public `System.Int32` DepthOffset

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Gets or sets the depth offset for the individual points.
###Return Value

The depth offset.

---

<a name="77e34450-fa7d-4297-a295-c4b4b05d65e2"></a>
##Public `System.Boolean` DrawCanvas

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets a value indicating whether this [KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) should draw  the canvas when it is included in another sketch.
###Return Value

`true` if draw canvas; otherwise, `false`.

---

<a name="7c1cd35f-9112-44af-9d18-71461943c695"></a>
##Public Static Read Only `SkiaSharp.SKColor` Eggplant

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Eggplant` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="825b266e-792b-451a-b92f-2709d7fcc57c"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) EndPoint

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the end point.
###Return Value

The end point.

---

<a name="6c6c6470-6bec-48f1-9c35-be2b866a645a"></a>
##Public Static Read Only `SkiaSharp.SKColor` Fern

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Fern` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="d74b9d78-bb9c-4cdc-b6cd-6181846db04b"></a>
##Public `SkiaSharp.SKPaint` Fill

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the fill paint style.
###Return Value

The `SKPaint` style for the fill.

---

<a name="a83165ed-811b-48a2-8469-484850376011"></a>
##Public [KimonoCore.KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce) FillBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the fill blur.
###Return Value

The `KimonoBlur` applied to the fill.

---

<a name="40e93e0b-dc03-4c53-b4cd-530657ba2fc2"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) FillColor

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the color of the fill as a named Kimono Color.
###Return Value

The color of the fill.

---

<a name="13aa2701-8c78-4ed0-a3bc-33402e764b1e"></a>
##Public [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) FillGradient

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the fill gradient.
###Return Value

The fill gradient.

---

<a name="3343ac48-596b-445a-a1bb-a1c98a26c8be"></a>
##Public `System.Single` FillJitterDeviation

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the fill jitter deviation.
###Return Value

The fill jitter deviation.

---

<a name="03e6ebea-fb37-40c9-b72e-b9699758cf0c"></a>
##Public `System.Single` FillJitterLength

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the length of the fill jitter.
###Return Value

The length of the fill jitter.

---

<a name="e58ccff1-7f2d-47e0-a651-a878263785a0"></a>
##Public [KimonoCore.KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565) FillShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the fill shadow.
###Return Value

The fill shadow.

---

<a name="4e2a722a-6532-43de-bc4c-9571a8b04ef6"></a>
##Public Static Read Only `SkiaSharp.SKColor` Flora

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Flora` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="3f49fa6b-cd1d-4f15-872b-45c5d19ce778"></a>
##Public `System.String` FontFamilyName

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the name of the font family.
###Return Value

The name of the font family.

---

<a name="e68bd565-9ff8-4a71-8426-316133911a4a"></a>
##Public `System.String` FontFamilyName

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the name of the font family.
###Return Value

The name of the font family.

---

<a name="30d1a260-b499-4f89-a598-cadf3eedabf4"></a>
##Public Read Only `SkiaSharp.SKFontMetrics` FontMetrics

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets the font metrics.
###Return Value

The font metrics.

---

<a name="d91bccf4-bf3b-4d8e-b8ca-29e55166e3ba"></a>
##Public Read Only `SkiaSharp.SKFontMetrics` FontMetrics

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets the font metrics.
###Return Value

The font metrics.

---

<a name="f892e623-f7b7-44b9-9117-9d9b0aefee25"></a>
##Public `SkiaSharp.SKPaint` Frame

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the frame paint style.
###Return Value

The `SKPaint` style for the frame.

---

<a name="5eb63539-e2eb-4dc9-9fc9-542d528fb495"></a>
##Public [KimonoCore.KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce) FrameBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the frame blur.
###Return Value

The `KimonoBlur` applied to the frame.

---

<a name="1b52e4de-5048-4356-9d1e-b81a134ffe53"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) FrameColor

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the color of the frame as a named Kimono Color.
###Return Value

The color of the frame.

---

<a name="2f64fd41-6e84-4aa2-8867-2fb4aa3000e1"></a>
##Public [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) FrameGradient

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the frame gradient.
###Return Value

The frame gradient.

---

<a name="d6bd796f-7841-494f-acbb-bd68f9ce7c60"></a>
##Public `System.Single` FrameJitterDeviation

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the frame jitter deviation.
###Return Value

The frame jitter deviation.

---

<a name="707e9336-85be-4fb5-8a7b-c897498ffeb1"></a>
##Public `System.Single` FrameJitterLength

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the length of the frame jitter.
###Return Value

The length of the frame jitter.

---

<a name="1bf2f5d5-217c-454b-a1cf-00919ed496a5"></a>
##Public [KimonoCore.KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565) FrameShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the frame shadow.
###Return Value

The frame shadow as a `KimonoShadow`.

---

<a name="f0bb608c-0e99-47c3-a952-392b7a2ccb46"></a>
##Public [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) Gradient

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Gets or sets the gradient.
###Return Value

The gradient.

---

<a name="11d9372e-d95c-4d34-932a-3ffb4badd70f"></a>
##Public [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) Gradient

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Gets or sets the gradient.
###Return Value

The gradient.

---

<a name="51377f0c-bc80-46e8-ad79-01925cc28c2e"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoGradient>` Gradients

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Gets or sets the gradients.
###Return Value

The gradients.

---

<a name="4e55ef72-2e3b-41e2-a68e-b0871023be4c"></a>
##Public [KimonoCore.KimonoGradientType](#c8669bb8-85ff-41f6-ab12-12c36ca8e95b) GradientType

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the type of the gradient.
###Return Value

The type of the gradient.

---

<a name="1a078778-a453-49e8-8e03-69f669748aeb"></a>
##Public Static Read Only `SkiaSharp.SKColor` Grape

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Grape` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="8c15e780-95ab-44f6-a7a6-f6eb3a82f7e5"></a>
##Public Static Read Only `SkiaSharp.SKColor` Gray

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Gray` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="262659dd-2571-454a-b45d-3cf9b8cd1052"></a>
##Public Static Read Only `SkiaSharp.SKColor` Green

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Green` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="c4f56d00-e409-4471-b626-fcd49ea7da29"></a>
##Public [KimonoCore.KimonoShapeGroupType](#cb6efc63-2b26-4cf8-82ea-9f0ed99cc157) GroupType

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets the type of the group.
###Return Value

The type of the group as a `KimonoShapeGroupType`.

---

<a name="239e6e7e-30f1-4249-8cd4-5be514edce43"></a>
##Public [KimonoCore.KimonoHandleType](#70c2ef11-f148-4072-b31b-fc357aaca407) HandleType

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the type of the handle.
###Return Value

The type of the handle as a `KimonoHandleType`.

---

<a name="915c77d9-eb48-4e8d-b423-57f1aee39544"></a>
##Public `System.Boolean` HasEndHead

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Gets or sets a value indicating whether this [KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535) has end head.
###Return Value

`true` if has end head; otherwise, `false`.

---

<a name="0316fbc9-d91f-4a75-a26c-9659b54ef9bb"></a>
##Public `System.Boolean` HasFill

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) has fill.
###Return Value

`true` if has fill; otherwise, `false`.

---

<a name="ce851df2-df99-496a-9b5d-5e13c03a3ef4"></a>
##Public `System.Boolean` HasFillBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) has fill blur.
###Return Value

`true` if has fill blur; otherwise, `false`.

---

<a name="d2c9c146-a23f-4b14-8d1b-7b7b2d4015a9"></a>
##Public `System.Boolean` HasFillJitter

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether the fill jitter is used.
###Return Value

`true` if has fill jitter; otherwise, `false`.

---

<a name="efe1b6bf-e1ad-4a4b-ba0e-1b1075472f7d"></a>
##Public `System.Boolean` HasFillShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) has fill shadow.
###Return Value

`true` if has fill shadow; otherwise, `false`.

---

<a name="7b7a9e3a-e4c4-40dd-9883-318f9bf593f1"></a>
##Public `System.Boolean` HasFrame

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) has a frame.
###Return Value

`true` if has frame; otherwise, `false`.

---

<a name="edeb13b3-b825-427e-b403-470a1ee93307"></a>
##Public `System.Boolean` HasFrameBlur

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) has frame blur.
###Return Value

`true` if has frame blur; otherwise, `false`.

---

<a name="9e6c604f-f16f-450d-b38c-2bc57d496628"></a>
##Public `System.Boolean` HasFrameDash

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether the frame has a dash.
###Return Value

`true` if the frame has a dash; otherwise, `false`.

---

<a name="139f43f5-c334-4eed-b09d-2677c5586740"></a>
##Public `System.Boolean` HasFrameJitter

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether the frame jitter is used.
###Return Value

`true` if has frame jitter; otherwise, `false`.

---

<a name="1e45b00e-63d8-4b34-9eb6-1fbb057148df"></a>
##Public `System.Boolean` HasFrameShadow

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) has frame shadow.
###Return Value

`true` if has frame shadow; otherwise, `false`.

---

<a name="20b2c4ea-89ba-445a-9ac8-d8de36d11e64"></a>
##Public `System.Boolean` HasStartHead

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Gets or sets a value indicating whether this [KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535) has start head.
###Return Value

`true` if has start head; otherwise, `false`.

---

<a name="701c90cb-c19c-47f9-84d5-76c29f8c0d40"></a>
##Public `System.Single` HeadInnerRatio

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Gets or sets the head inner ratio.
###Return Value

The head inner ratio.

---

<a name="b4f5ed6c-2df5-494b-b22b-e89625911764"></a>
##Public `System.Single` HeadOuterRatio

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Gets or sets the head outer ratio.
###Return Value

The head outer ratio.

---

<a name="4f766524-01e2-4542-bcd2-fd0d21ef59cf"></a>
##Public `System.Single` Height

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the height.
###Return Value

The height of the shape's bounding box.

---

<a name="7f3b3d4c-439c-4557-af92-ea87f14b02f5"></a>
##Public `System.Single` Height

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the height.
###Return Value

The height.

---

<a name="3b56783c-b182-4b90-b26b-bbf341753c8b"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) HitHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the hit handle.
###Return Value

The hit handle.

---

<a name="05971f26-8ead-49d7-995f-dc641f8ae395"></a>
##Public `SkiaSharp.SKPoint` HitOffset

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the hit offset.
###Return Value

The hit offset.

---

<a name="db71a5e9-6e0d-4258-91b8-e692f2a393d8"></a>
##Public `SkiaSharp.SKPoint` HitOffset

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the hit offset.
###Return Value

The hit offset.

---

<a name="df80b8fe-25ff-4fc9-a852-1715637418de"></a>
##Public Static Read Only `SkiaSharp.SKColor` Honeydew

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Honeydew` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="00274501-463e-4e8e-b439-45cf57d4edf3"></a>
##Public `System.Single` HorizontalBlurAmount

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Gets or sets the horizontal blur amount.
###Return Value

The horizontal blur amount.

---

<a name="a2e8e573-afc3-4198-a343-11bd3742eda1"></a>
##Public `System.Single` HorizontalBlurAmount

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets or sets the horizontal blur amount.
###Return Value

The horizontal blur amount.

---

<a name="24d8c7bd-b59f-4597-a041-fae20e60ffcc"></a>
##Public Read Only `System.Single` HorizontalCenter

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets the horizontal center.
###Return Value

The horizontal center.

---

<a name="c0970600-c61b-472e-ad83-57323ff5825c"></a>
##Public `System.Single` HorizontalOffset

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets or sets the horizontal offset.
###Return Value

The horizontal offset.

---

<a name="ac5bad60-3e48-4553-a417-165f28a46246"></a>
##Public `System.Single` HueAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the hue adjustment.
###Return Value

The hue adjustment.

---

<a name="00648d93-330c-45d8-80df-b1763ded0fe2"></a>
##Public Static Read Only `SkiaSharp.SKColor` Ice

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Ice` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="6004b0ee-5439-4121-98a9-68bcb57dc673"></a>
##Public `System.Int32` Index

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the index.
###Return Value

The index.

---

<a name="196d0f9a-aa75-4188-b30e-bf85d71071e0"></a>
##Public Static Read Only `SkiaSharp.SKColor` Iron

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Iron` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="8929f45d-c5e3-43fc-800a-551d48aa3665"></a>
##Public `System.Boolean` IsBooleanConstruct

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets a value indicating whether this [KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) is a boolean construct.
###Return Value

`true` if is boolean construct; otherwise, `false`.

---

<a name="11016306-d842-45b1-8953-fc2db710d7e7"></a>
##Public Virtual Read Only `System.Boolean` IsEditable

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Gets a value indicating whether this [KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) is editable.
###Return Value

`true` if is editable; otherwise, `false`.
###Remarks

An "Editable Shape" is one that is composed of a set of data points (such as `KimonoVector` or `KimonoBezier`) or a group of objects (such as `KimonoShapeGroup`).

---

<a name="3c897ff7-f0bb-4af1-8cb9-4a2aa576d429"></a>
##Public Virtual Read Only `System.Boolean` IsEditable

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets a value indicating whether this [KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) is editable.
###Return Value

`true` if is editable; otherwise, `false`.

---

<a name="019cc36d-d8a1-41d7-8c94-1176f7e9c099"></a>
##Public Virtual Read Only `System.Boolean` IsEditable

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Gets a value indicating whether this [KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850) is editable.
###Return Value

`true` if is editable; otherwise, `false`.

---

<a name="7625ac96-3928-48eb-bdaa-98873317bd82"></a>
##Public `System.Boolean` IsLinearText

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) is linear text.
###Return Value

`true` if is linear text; otherwise, `false`.

---

<a name="7f64f885-007b-492c-9768-c5b164b206a1"></a>
##Public `System.Boolean` IsLinearText

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets a value indicating whether this [KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf) is linear text.
###Return Value

`true` if is linear text; otherwise, `false`.

---

<a name="b9981b47-d6ca-4a79-b62d-9123e94ef389"></a>
##Public `System.Boolean` IsMaskedGroup

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets a value indicating whether this [KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) is masked group.
###Return Value

`true` if is masked group; otherwise, `false`.

---

<a name="428e1104-c1bd-473e-9883-3a4f1630cbec"></a>
##Public `System.Boolean` IsStreamlined

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Gets or sets a value indicating whether this [KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535) is streamlined.
###Return Value

`true` if is streamlined; otherwise, `false`.
###Remarks

A Streamlined Arrow, is drawn as a single line.

---

<a name="b0ff990f-a955-4849-a7c2-a55675f2db86"></a>
##Public `System.Boolean` IsVerticalText

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets a value indicating whether this [KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf) is vertical text.
###Return Value

`true` if is vertical text; otherwise, `false`.

---

<a name="50d8fbd8-8a8a-45ed-9d9f-996ead3fb453"></a>
##Public `System.Boolean` IsVerticalText

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) is vertical text.
###Return Value

`true` if is vertical text; otherwise, `false`.

---

<a name="e5b277e7-7afe-4496-b80b-027d7ffa8f1c"></a>
##Public Static Read Only `SkiaSharp.SKColor` Lavender

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Lavender` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="0ec35931-538b-4930-9287-f7ca0489254c"></a>
##Public `System.Int32` LayerDepth

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping on the design surface.
###Return Value

The layer depth.

---

<a name="76e3ac0a-226a-44bc-a3b8-b3d96703aa17"></a>
##Public Static Read Only `SkiaSharp.SKColor` Lead

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Lead` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="ebf31efb-467a-47e5-8ba3-258ae2f904e7"></a>
##Public `System.Single` Left

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the left.
###Return Value

The left coord location.

---

<a name="4282e356-ee57-45ef-9a26-b679121a35c3"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) LeftHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the left handle.
###Return Value

The left handle.

---

<a name="355b877e-f1e0-4ab4-a0f6-394e77faae0b"></a>
##Public Static Read Only `SkiaSharp.SKColor` Lemon

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Lemon` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="e5d0a321-d82a-4935-b0c4-b1a6da407a9f"></a>
##Public Static Read Only `SkiaSharp.SKColor` Licorice

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Licorice` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="577962b7-7829-48ae-b390-89ed6be3500c"></a>
##Public Static Read Only `SkiaSharp.SKColor` LightGray

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `LightGray` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="ac5626e4-3cc9-48b6-aaad-c8e8ae6dee20"></a>
##Public Static Read Only `SkiaSharp.SKColor` Lime

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Lime` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="953c0dd0-d766-462a-b05f-4f51cf4d5a83"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) LinkedColor

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets or sets the color of the linked.
###Return Value

The color of the linked.

---

<a name="4f766397-6fee-4ed2-91bb-b42bef2dd3d4"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) LinkedColor

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the color that this handle represents in a gradient. If the `LinkedColor` property is `null`, the `Color` property will  be used instead.
###Return Value

The color of the linked.

---

<a name="72ccb2ef-6775-40f7-ad3b-e96b81f6a6a5"></a>
##Public Static Read Only `SkiaSharp.SKColor` Magenta

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Magenta` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="330c91b4-e237-41ff-82de-195844ade69c"></a>
##Public Static Read Only `SkiaSharp.SKColor` Magnesium

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Magnesium` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="73629165-a85e-402a-89eb-19b61ddf2e5b"></a>
##Public Static Read Only `SkiaSharp.SKColor` Maraschino

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Maraschino` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="94dfb6a1-888a-4e34-a37f-46e89b793356"></a>
##Public Static Read Only `SkiaSharp.SKColor` Maroon

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Maroon` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="bd146f41-9553-40e3-803e-93a36c9db6c4"></a>
##Public [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) Mask

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets the `KimonoShape` that is acting as a mask for this group.
###Return Value

The mask as a `KimonoShape`.

---

<a name="bba35d42-292c-4d60-9124-a60f65fc756a"></a>
##Public `System.Int32` MaximumUndoPoints

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Gets or sets the maximum undo points.
###Return Value

The maximum undo points.

---

<a name="331c56dc-d835-4e3c-933f-7297e9bb3a61"></a>
##Public Static Read Only `SkiaSharp.SKColor` Mercury

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Mercury` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="b8268eb1-4244-42ad-b0dd-1af693425f70"></a>
##Public Static Read Only `SkiaSharp.SKColor` Midnight

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Midnight` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="921deb1f-be32-4bff-b3e8-8f3ee49785f5"></a>
##Public Static Read Only `SkiaSharp.SKColor` Mocha

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Mocha` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="d0bd6f18-babb-46d3-8670-3fe26078e259"></a>
##Public Static Read Only `SkiaSharp.SKColor` Moss

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Moss` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="824332e8-3663-45f6-9bc7-5c8e30b8331b"></a>
##Public `System.String` Name

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Gets or sets the name.
###Return Value

The name.

---

<a name="4f3964d4-77da-4833-b36d-c359364cd4da"></a>
##Public `System.String` Name

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the name.
###Return Value

The name.

---

<a name="c8afeb82-0e4c-4648-b5e6-0f1c6361fb76"></a>
##Public `System.String` Name

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the name.
###Return Value

The name.

---

<a name="91131a05-002e-4539-bcf8-dede9113b817"></a>
##Public `System.String` Name

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the name.
###Return Value

The name.

---

<a name="308c5d6b-4a91-41a5-a4a2-5a22a9ee0b2f"></a>
##Public `System.String` Name

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the name.
###Return Value

The name.

---

<a name="7ae1a474-dd79-49f2-8f45-79b5651d27ca"></a>
##Public Static Read Only `SkiaSharp.SKColor` Nickle

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Nickle` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="53c198c8-8c2f-48c2-a12d-1a52ca006d47"></a>
##Public `System.Int32` NumberOfPoints

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Gets or sets the number of points.
###Return Value

The number of points.

---

<a name="d93a996a-88c1-4490-bdd7-7ec2d82fbaf2"></a>
##Public `System.Int32` NumberOfSides

###Member of Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Gets or sets the number of sides.
###Return Value

The number of sides.

---

<a name="c2af8986-4233-4a57-a731-eda74317ca0c"></a>
##Public Static Read Only `SkiaSharp.SKColor` Ocean

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Ocean` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="3aed5bfb-4392-45fe-8e3b-e3dc7d42b6a6"></a>
##Public Static Read Only `SkiaSharp.SKColor` Orange

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Orange` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="b6cdd16d-a440-43d4-bb40-97ad319d5e32"></a>
##Public Static Read Only `SkiaSharp.SKColor` Orchid

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Orchid` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="6e11f6ff-72b9-46c4-bfc6-1e56864de0a2"></a>
##Public `System.Object` Parent

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets the parent `KimonoSketch` or `KimonoShapeGroup` that this `KimonoShapeGroup` belongs to.
###Return Value

The parent `KimonoSketch` or `KimonoShapeGroup`.

---

<a name="d1d91032-026a-4dd4-a731-ad864c619d87"></a>
##Public Read Only [KimonoCore.KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) ParentSketch

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets the parent sketch by scanning backwards through the chain of parent objects until a `KimonoSketch` is reached.
###Return Value

The parent `KimonoSketch`.

---

<a name="bf4c0b05-fb95-4b5f-a83e-c07aefbfd122"></a>
##Public Read Only `System.String` Path

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets the full path from this group back to the parent `KimonoSketch`.
###Return Value

The path representing the nesting level of this group.

---

<a name="533fb82c-3d3a-4956-aeb9-16a307fec987"></a>
##Public Static Read Only `SkiaSharp.SKColor` Pink

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Pink` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="daf9b7dd-9ef2-43ed-a35d-90aa42d40146"></a>
##Public Static Read Only `SkiaSharp.SKColor` Plum

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Plum` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="56c6d1f9-346d-48ad-8850-0d8e72688de6"></a>
##Public `System.Collections.Generic.List<SkiaSharp.SKPoint>` Points

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Gets or sets the points that define the shape.
###Return Value

The points.

---

<a name="7bcef765-da78-472d-a118-32b199628b23"></a>
##Public [KimonoCore.KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0) Portfolio

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets or sets the portfolio currently being worked on.
###Return Value

The `KimonoPortfolio`.

---

<a name="1847c555-d7d2-44cf-b07d-0c240c57c414"></a>
##Public `System.Single` PreviewHeight

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the height of the preview.
###Return Value

The height of the preview.

---

<a name="6e60d24c-d131-49b4-b615-950069aca001"></a>
##Public `System.Single` PreviewWidth

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the width of the preview.
###Return Value

The width of the preview.

---

<a name="a7058f0c-2f55-48cd-86bf-9791fd2b7189"></a>
##Public Static Read Only `SkiaSharp.SKColor` Purple

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Purple` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="c9ec180a-8d4c-4817-a38a-37b4ddc9934b"></a>
##Public `System.Single` Radius

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the radius used by radial and conical gradients.
###Return Value

The radius.

---

<a name="c7797d30-0c73-44d2-b538-d4a07c23ce12"></a>
##Public Read Only `SkiaSharp.SKRect` Rect

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets the rect.
###Return Value

The rect.

---

<a name="ae6ec7c2-e041-4900-8bc8-7f2c855f73ed"></a>
##Public Static Read Only `SkiaSharp.SKColor` Red

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Red` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="e1e3a13d-b1e1-456e-9a1e-711535d88fdb"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoPortfolio>` RedoStack

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Gets or sets the redo stack.
###Return Value

The redo stack.

---

<a name="68e16773-012f-4d19-9d88-534ac51c41cd"></a>
##Public Read Only `SkiaSharp.SKColor` RepresentedColor

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets the color that this handle represents.
###Return Value

The color as a `SKColor`.

---

<a name="2cc8d718-799c-4a16-bfd5-71820bbbffec"></a>
##Public `System.Single` Right

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the right.
###Return Value

The right coord location.

---

<a name="3e841c0b-fc16-476c-ba34-b405dc13ccb7"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) RightHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the right handle.
###Return Value

The right handle.

---

<a name="87e50b21-ff2d-41d5-bda6-0d86504dd6c9"></a>
##Public `System.Int32` RotationDegrees

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the rotation degrees.
###Return Value

The rotation degrees.

---

<a name="b5f7425e-fb63-4a28-afe2-cecb4a815d8f"></a>
##Public Static Read Only `SkiaSharp.SKColor` Salmon

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Salmon` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="46c46cb7-b417-4c99-87b4-e5459f02e4d3"></a>
##Public `System.Single` SaturationAdjustment

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the saturation adjustment.
###Return Value

The saturation adjustment.

---

<a name="22bd1b05-1400-4f87-b528-ef02eb9020d8"></a>
##Public Static Read Only `SkiaSharp.SKColor` SeaFoam

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `SeaFoam` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="28276812-4d1e-4195-84c5-13698bd52e55"></a>
##Public Read Only `SkiaSharp.SKColor` SelectedColor

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets the color of the selected handle.
###Return Value

The color of the selected handle or black if no handle is selected.

---

<a name="5fe459cd-e350-4efa-b44f-d8760dd2d3b0"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) SelectedHandle

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the selected handle.
###Return Value

The selected handle.

---

<a name="35195391-30f4-40c6-b1bf-3140107b045a"></a>
##Public [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) SelectedShape

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets or sets the selected shape.
###Return Value

The selected `KimonoShape`.

---

<a name="019550b0-c8d6-41d7-9f09-f61308af385d"></a>
##Public [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) SelectedShape

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="94077057-8c9e-4828-a74f-f8b745cf79f9"></a>
##Public [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) SelectedShape

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="33e4eca6-6178-4295-884f-6e4bda9ed6bc"></a>
##Public Read Only `System.Boolean` SelectedShapeAtBottom

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets a value indicating whether the selected shape is at the bottom.
###Return Value

`true` if selected shape at bottom; otherwise, `false`.

---

<a name="998e77a0-ef6a-434d-97c0-50884921677b"></a>
##Public Read Only `System.Boolean` SelectedShapeAtBottom

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets a value indicating whether the selected shape is at the bottom.
###Return Value

`true` if selected shape at bottom; otherwise, `false`.

---

<a name="b81ba2dc-7f90-4a2f-9dae-1cd3ae133df9"></a>
##Public Read Only `System.Boolean` SelectedShapeAtTop

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets a value indicating whether the selected shape is at the top.
###Return Value

`true` if selected shape at top; otherwise, `false`.

---

<a name="aabb8869-6430-4366-b5cb-4f2b9752fd64"></a>
##Public Read Only `System.Boolean` SelectedShapeAtTop

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets a value indicating whether the selected shape is at the top.
###Return Value

`true` if selected shape at top; otherwise, `false`.

---

<a name="42f86b9c-2bb1-4af8-a42a-87e1c305f8af"></a>
##Public [KimonoCore.KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) SelectedSketch

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Gets or sets the selected sketch.
###Return Value

The selected sketch.

---

<a name="141aecb3-b1ef-43a2-83b2-f9a685c1b833"></a>
##Public [KimonoCore.KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) SelectedSketch

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets or sets the selected sketch.
###Return Value

The selected `KimonoSketch`.

---

<a name="312c5aa2-6f7b-4fab-a2f1-3afbd03ce86a"></a>
##Public Read Only `SkiaSharp.SKShader` Shader

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets the Skia Shader that represents this gradient.
###Return Value

The `SKShader` for this gradient.

---

<a name="594cb038-89d3-41e8-ac52-35c9f0a64804"></a>
##Public Read Only `SkiaSharp.SKColor` ShadowColor

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets the color of the shadow.
###Return Value

The color of the shadow as a `SKColor`.
###Remarks

Returns either the custom color attached to this shadow or a linked color if it is being used.

---

<a name="eadc19d9-8270-4671-ae0d-fc2db41857e5"></a>
##Public Read Only `SkiaSharp.SKImageFilter` ShadowFilter

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets the shadoe filter represented by this shadow effect.
###Return Value

The `SKImageFilter` for the blur filter.

---

<a name="c160657b-e8ca-4947-bd50-35f46bdd525b"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoShape>` Shapes

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the shapes.
###Return Value

The shapes.

---

<a name="e50e8dea-d6f3-499c-b7b0-6d15ddc7320d"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoShape>` Shapes

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets the shapes.
###Return Value

The shapes.

---

<a name="afafe5d3-1464-4bc7-a049-023396554a83"></a>
##Public Static Read Only `SkiaSharp.SKColor` Silver

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Silver` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="477b6f3c-92f0-476b-b89b-ce19a51dda88"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoSketch>` Sketches

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Gets or sets the sketches.
###Return Value

The sketches.

---

<a name="5ab1ce34-ee33-4bd0-839f-215562e7aff8"></a>
##Public `System.Int32` SkipPoints

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Gets or sets the skip points.
###Return Value

The skip points.

---

<a name="7f48b851-8e92-4b19-b361-f7c321885f2f"></a>
##Public Static Read Only `SkiaSharp.SKColor` Sky

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Sky` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="3c7bbebe-6aa0-406b-a623-10742966147a"></a>
##Public Static Read Only `SkiaSharp.SKColor` Snow

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Snow` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="39a3d103-4823-4c4b-8e05-f80d98412723"></a>
##Public Static Read Only `SkiaSharp.SKColor` Spindrift

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Spindrift` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="8b297857-5c46-4db1-9bc0-ac8f278877af"></a>
##Public Static Read Only `SkiaSharp.SKColor` Spring

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Spring` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="9c5aa616-ee64-42fd-b9ab-b6d20517db77"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) StartPoint

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the start point.
###Return Value

The start point.

---

<a name="04afcf7c-a25b-4d52-946f-7928fb28bed8"></a>
##Public [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) State

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets the current edit state of the `KimonoShape`.
###Return Value

The state as a `KimonoShapeState`.

---

<a name="35d2ad7d-bf77-487b-85c6-afe5b42471c1"></a>
##Public [KimonoCore.KimonoShapeState](#628fb735-c63a-41df-98d5-2353b7bb4b3d) State

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets the edit state of the `KimonoHandle`.
###Return Value

The state as a `KimonoShapeState`.

---

<a name="a704c479-e5f5-4fd7-b78a-a06daa94e3f6"></a>
##Public Static Read Only `SkiaSharp.SKColor` Steel

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Steel` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="988fb347-c593-4add-9d33-b7190caccb37"></a>
##Public Static Read Only `SkiaSharp.SKColor` Strawberry

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Strawberry` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="49e11ae3-12c7-4302-a78c-278c27927921"></a>
##Public `System.Boolean` StrikeThruText

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets a value indicating whether this [KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf) strike thru text.
###Return Value

`true` if strike thru text; otherwise, `false`.

---

<a name="74d12e0b-f9c0-4f31-86c1-5aeaa9f02fb4"></a>
##Public `System.Boolean` StrikeThruText

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) strike thru text.
###Return Value

`true` if strike thru text; otherwise, `false`.

---

<a name="3e3fa4fb-b794-4ecd-9776-07e65b9ae357"></a>
##Public Virtual [KimonoCore.KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) Style

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Gets or sets the style.
###Return Value

The `KimonoStyle` that will be used to draw this shape.

---

<a name="3d4b02ed-32cb-49ff-ae9f-e4a8b66fd9bd"></a>
##Public Virtual [KimonoCore.KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) Style

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets the style of this group.
###Return Value

The style as a `KimonoStyle`.

---

<a name="7b07422c-b878-425f-974f-b7ad32a86d43"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoStyle>` Styles

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Gets or sets the styles.
###Return Value

The styles.

---

<a name="a7e21b13-87e8-4ebb-9691-ffcf14218752"></a>
##Public [KimonoCore.KimonoStyleType](#123b85c2-002f-4b58-8208-8b0fda7d825f) StyleType

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the type of the style.
###Return Value

The type of the style.

---

<a name="ae8f36cf-4388-40ff-aa5c-5de58b021b4b"></a>
##Public Static Read Only `SkiaSharp.SKColor` Tangerine

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Tangerine` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="2d797727-aea7-4a61-a326-8ae0176a3a60"></a>
##Public Static Read Only `SkiaSharp.SKColor` Teal

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Teal` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="c17932c4-7221-44f1-8061-3d174bee5c65"></a>
##Public `System.String` Text

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the text.
###Return Value

The text.

---

<a name="5bcb6d2d-45b7-4232-b96b-4dce7d9284c6"></a>
##Public `SkiaSharp.SKTextAlign` TextAlign

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the text align.
###Return Value

The text align.

---

<a name="a4c01df1-287c-46aa-9030-382ff4303448"></a>
##Public `SkiaSharp.SKTextAlign` TextAlign

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the text align.
###Return Value

The text align.

---

<a name="8a9f2fe2-dde8-4fde-910a-ba9981acdb90"></a>
##Public `SkiaSharp.SKTextEncoding` TextEncoding

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the text encoding.
###Return Value

The text encoding.

---

<a name="81a5da59-8f2d-42f2-9140-f184346ad6b2"></a>
##Public `SkiaSharp.SKTextEncoding` TextEncoding

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the text encoding.
###Return Value

The text encoding.

---

<a name="5ec3fb0e-0c21-423c-b504-71d664e3d554"></a>
##Public `System.Single` TextScaleX

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the text scale x.
###Return Value

The text scale x.

---

<a name="bc6d6490-64fd-49b9-935f-6bfba315737b"></a>
##Public `System.Single` TextScaleX

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the text scale x.
###Return Value

The text scale x.

---

<a name="f972c61f-58b9-4414-af3d-5fe490c9f880"></a>
##Public `System.Single` TextSize

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the size of the text.
###Return Value

The size of the text.

---

<a name="435c2737-288b-4133-8e20-0a060ae4a6c9"></a>
##Public `System.Single` TextSize

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the size of the text.
###Return Value

The size of the text.

---

<a name="9eb82d70-3c13-4dea-b8c0-3813e7779d58"></a>
##Public `System.Single` TextSkewX

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the text skew x.
###Return Value

The text skew x.

---

<a name="a76c2e7d-0bce-4525-a7c5-16be82a2bd34"></a>
##Public `System.Single` TextSkewX

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the text skew x.
###Return Value

The text skew x.

---

<a name="5861d01f-8673-423b-bec7-c190e661ced7"></a>
##Public `SkiaSharp.SKShaderTileMode` TileMode

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the tile mode.
###Return Value

The tile mode.

---

<a name="43e7b82c-c034-4a02-ae24-95ad8741da44"></a>
##Public Static Read Only `SkiaSharp.SKColor` Tin

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Tin` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="5b0ee87b-77e5-4275-81f6-d2aa72853170"></a>
##Public [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Tool

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Gets or sets the tool.
###Return Value

The current `KimonoTool`.

---

<a name="282cfdf5-e4ba-4770-806d-7563fb32caaf"></a>
##Public [KimonoCore.KimonoTool](#cb899de9-c57c-45d2-8438-cb8855487811) Tool

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the tool.
###Return Value

The tool.

---

<a name="ed742916-2fbd-42af-a218-20fdeb316f4d"></a>
##Public `System.Single` Top

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the top.
###Return Value

The top coord location.

---

<a name="16de6f21-40cf-436c-a35e-5d614c75afb3"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) TopHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the top handle.
###Return Value

The top handle.

---

<a name="857ea0a3-d4e2-4cac-88c7-77e6d959cb33"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) TopLeftHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the top left handle.
###Return Value

The top left handle.

---

<a name="ddb9ac26-db0a-4b14-b8b4-6d92bd6da22e"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) TopRightHandle

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the top right handle.
###Return Value

The top right handle.

---

<a name="a9b9a0b1-f516-4101-944b-aef58b38b2e4"></a>
##Public Static Read Only `SkiaSharp.SKColor` Tungsten

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Tungsten` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="804b5554-431a-4d1d-b28f-0fed787e99b3"></a>
##Public Static Read Only `SkiaSharp.SKColor` Turquoise

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Turquoise` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="90334331-55cf-4fd0-a502-7b86e4ce69b1"></a>
##Public `SkiaSharp.SKTypeface` Typeface

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the typeface.
###Return Value

The typeface.

---

<a name="496e1d14-6f1f-4f8c-af7b-d381827cc406"></a>
##Public `SkiaSharp.SKTypeface` Typeface

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the typeface.
###Return Value

The typeface.

---

<a name="d740c753-3942-4490-b0d5-7fa52fb7631b"></a>
##Public `SkiaSharp.SKTypefaceStyle` TypefaceStyle

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets the typeface style.
###Return Value

The typeface style.

---

<a name="4706f55d-c293-43e6-8f3f-987ed0368f88"></a>
##Public `SkiaSharp.SKTypefaceStyle` TypefaceStyle

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the typeface style.
###Return Value

The typeface style.

---

<a name="8d139fcc-5840-4f29-96b7-5847fa6b6448"></a>
##Public `System.Boolean` UnderlineText

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets a value indicating whether this [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) underline text.
###Return Value

`true` if underline text; otherwise, `false`.

---

<a name="a1b8bfed-fd77-412c-accc-ec786b7727b2"></a>
##Public `System.Boolean` UnderlineText

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Gets or sets a value indicating whether this [KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf) underline text.
###Return Value

`true` if underline text; otherwise, `false`.

---

<a name="7e626cc7-a1cb-47a8-b270-7d327573999a"></a>
##Public `System.Collections.Generic.List<KimonoCore.KimonoPortfolio>` UndoStack

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Gets or sets the undo stack.
###Return Value

The undo stack.

---

<a name="8080e962-f997-4dd1-828b-d196c781a23d"></a>
##Public `System.String` UniqueID

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the unique identifier.
###Return Value

The unique identifier.

---

<a name="8c3e86a6-27e7-41dc-8c37-7e41c68572e8"></a>
##Public `System.String` UniqueID

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the unique identifier.
###Return Value

The unique identifier.

---

<a name="3cd14ce6-ad42-45f8-87bf-47d9c7072e5c"></a>
##Public `System.String` UniqueID

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Gets or sets the unique identifier.
###Return Value

The unique identifier.

---

<a name="4838ec8b-32b6-4f38-891c-ff72552db575"></a>
##Public `System.String` UniqueID

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Gets or sets the unique identifier.
###Return Value

The unique identifier.

---

<a name="0722acfd-3ace-427f-827d-8476240a4e49"></a>
##Public `System.String` UniqueID

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the unique identifier.
###Return Value

The unique identifier.

---

<a name="7db1c2e9-8d4f-477c-b894-e43eb61d3a7e"></a>
##Public `System.String` UniqueID

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Gets or sets the unique identifier.
###Return Value

The unique identifier.

---

<a name="7cf66664-02a8-45cd-ab27-f569064afdd5"></a>
##Public `System.String` UniqueID

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Gets or sets the unique identifier.
###Return Value

The unique identifier.

---

<a name="8b44dd95-7f2f-4bc7-b676-ddcfb5a72e24"></a>
##Public `System.Single` VerticalBlurAmount

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets or sets the vertical blur amount.
###Return Value

The vertical blur amount.

---

<a name="5bea92c7-556d-4ae6-acec-818a9d649392"></a>
##Public `System.Single` VerticalBlurAmount

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Gets or sets the vertical blur amount.
###Return Value

The vertical blur amount.

---

<a name="7ddac4b1-e198-4b16-a74e-b3d2691b7c3a"></a>
##Public Read Only `System.Single` VerticalCenter

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets the vertical center.
###Return Value

The vertical center.

---

<a name="81d708bc-2aeb-48c7-8d53-cd2d7fcb3c0a"></a>
##Public `System.Single` VerticalOffset

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Gets or sets the vertical offset.
###Return Value

The vertical offset.

---

<a name="5dd56e99-84be-4f10-b608-4e9c1c113304"></a>
##Public Virtual `System.Boolean` Visible

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Gets or sets a value indicating whether this [KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) is visible.
###Return Value

`true` if visible; otherwise, `false`.

---

<a name="677da7b2-1645-41b1-a0bd-cc57017f2bce"></a>
##Public Virtual `System.Boolean` Visible

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Gets or sets a value indicating whether this [KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) is visible.
###Return Value

`true` if visible; otherwise, `false`.

---

<a name="c2cf1792-75e0-4259-912a-908b322ffc4a"></a>
##Public Static Read Only `SkiaSharp.SKColor` White

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `White` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="4e34f26f-7edf-4a36-86d7-6a1e3cd8ab7b"></a>
##Public `System.Single` Width

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Gets or sets the width.
###Return Value

The width.

---

<a name="77534c49-02e9-436d-a041-bd0b21246cbe"></a>
##Public `System.Single` Width

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Gets or sets the width.
###Return Value

The width of the shape's bounding box.

---

<a name="a78fc769-e53d-4eda-abb9-a5aebccf4cdc"></a>
##Public `System.Single` X

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the x value.
###Return Value

The x coord of the handle's top-left location.

---

<a name="36cd876c-505e-4b34-a602-209501c81790"></a>
##Public `System.Single` Y

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Gets or sets the y value.
###Return Value

The y coord of the handle's top-left location.

---

<a name="0da3eab8-6def-4bd1-ae47-d0fe1a060770"></a>
##Public Static Read Only `SkiaSharp.SKColor` Yellow

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

The public static read only `Yellow` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.
<a name="Methods"></a>
#Methods


---

<a name="0f352456-f80d-44f5-a605-a144f13ce3d0"></a>
##Public Virtual `System.Boolean` AcceptsFirstResponder ()

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Acceptses the first responder.
###Returns

`true`, if first responder was accepted, `false` otherwise.

---

<a name="824c01d7-8483-4534-8cb3-045e9a9024fc"></a>
##Public Virtual `System.Boolean` AcceptsFirstResponder ()

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Acceptses the first responder.
###Returns

`true`, if first responder was accepted, `false` otherwise.

---

<a name="1eb123b5-eeee-4363-b422-241669bbe7cf"></a>
##Public Virtual `System.Boolean` AcceptsFirstResponder ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Acceptses the first responder.
###Returns

`true`, if first responder was accepted, `false` otherwise.

---

<a name="fe5dae5d-2ed7-4cf5-8b59-fd5b40774137"></a>
##Public Void AddControlPoint ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Adds a new control point to the gradients collection and makes it the selected control point.

---

<a name="89a8716a-3d5c-40f1-bc90-09fab1576cfd"></a>
##Void AddHandles (KimonoCore.KimonoShapeState)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Adds the control handles to the bounds
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="008b7c17-8c45-4748-8075-bb02ef34531b"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>The <code>state</code> parameter of the AddHandles method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="c32168ca-39c3-4c74-9f80-16b21f48841e"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) AddNewColor ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Adds a new `KimonoColor` to this portfolio.
###Returns

The new `KimonoColor`.

---

<a name="7bd29f74-10ba-47ac-b9d7-691e669d47e8"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) AddNewColor (SkiaSharp.SKColor)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Adds a new `KimonoColor` to this portfolio based off of a given `SKColor`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="5d9ed056-0abb-434c-93aa-3274886574e4"></a>
<b>SkiaSharp.SKColor baseColor</b></p>

<p>Base color.</p>
</td></tr></table></p>

###Returns

The new `KimonoColor`.

---

<a name="84209fbc-0bde-426c-8cd2-b2fcf9c7c5b5"></a>
##Public [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) AddNewGradient ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Adds the new gradient.
###Returns

The new gradient.

---

<a name="dbc58116-b638-4c7c-84bf-ca4384e3810e"></a>
##Public Void AddNewSketch ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Adds the a new `KimonoSketch` to this portfolio.

---

<a name="044c1edc-8059-47e8-bf2d-90d4a5f2fdbe"></a>
##Public Void AddNewStyle ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Adds the a new `KimonoStyle` to the portfolio.

---

<a name="66a5c10d-0076-4b61-ac8a-6fe7eb5a7670"></a>
##Public Void AddPoint (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Adds the given point to the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3b80daf5-f84f-491d-ae2a-089a9d15c70a"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>


---

<a name="0f073db5-7f3b-4228-a16e-29b1dc9474e5"></a>
##Public Void AddPoint (System.Single, System.Single)

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Adds a point to the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="05989ade-eb99-4daa-a803-c062c7214947"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="9a872a8c-d5e9-4508-a381-7590b659d4f2"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>


---

<a name="d3bf44e0-faab-4fd4-85f4-b009a9f5f50f"></a>
##Public Void AddShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Adds the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="6b0b8cb3-5cd0-4bf2-8aec-f4620672fa32"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>


---

<a name="87a5f838-e2c2-4c34-b5f3-20a7bb17ea94"></a>
##Public Void AddShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Adds the given `KimonoShape` to the group if it isn't already a part of the group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="80f07877-c9f7-4645-bc4c-891691207b17"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>


---

<a name="533bd3a2-1b34-4f0b-b620-6aa1e0994c79"></a>
##Public Void AlignAllBottom ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Aligns all shapes in the group at the bottom.

---

<a name="9dbe0e24-5ca5-456a-868e-2e3360166603"></a>
##Public Void AlignAllCenter ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Centers all shapes in the group.

---

<a name="4c33c3da-1d5b-4bb2-a2ba-2476e959fc2b"></a>
##Public Void AlignAllCenterHorizontal ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Center horizontal all shapes in the group.

---

<a name="39311a21-168a-4c8c-a75a-9d6577b769d8"></a>
##Public Void AlignAllCenterVertical ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Center vertical all shapes in the group.

---

<a name="cde7a972-1c73-4bb9-8261-422d4d72491c"></a>
##Public Void AlignAllLeft ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Aligns all shapes in the group to the left.

---

<a name="9a4c8b70-4bf3-42f5-8549-84b90ac36e12"></a>
##Public Void AlignAllRight ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Aligns all shapes in the group to the right.

---

<a name="cd36883a-6a36-46fe-bd2e-2259c68153e3"></a>
##Public Void AlignAllTop ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Aligns all shapes in the group at the top.

---

<a name="24d8a393-2c40-4b11-8902-d0852aed30c3"></a>
##Public Void ApplyFillEffects ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Applies the fill effects based on the style settings.

---

<a name="e76159f9-fbb8-4457-a834-af21875f9f09"></a>
##Public Void ApplyFrameEffects ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Applies the frame effects based on the style settings.

---

<a name="1242fa00-c3a6-445e-85cb-23f8eeac94dd"></a>
##Private Void ApplyMoveAndScale ()

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Applies the move and scale amount to the data point that make up the shape.

---

<a name="d507e5ca-213e-4795-9356-73a1b9a7279f"></a>
##Private Void ApplyMoveAndScale ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Applies the move and scale adjustments to all `KimonoShapes` inside this group.

---

<a name="c8455954-74d8-4b28-a033-244a91bfa399"></a>
##Private Void ApplySizeChange ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Applies the size change.

---

<a name="38be0ece-fa23-4bef-92e2-ab9207eb4d90"></a>
##Public Void BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Handles the user clicking a control point in the gradient design bar.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a361e398-56c2-4ada-b1da-3724c85c460c"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="c87968f0-ba20-400f-8dbd-26b64c420220"></a>
<b>System.Int32 clicks</b></p>

<p>The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="6c0ba8af-b738-4475-bf8d-a0891e9ed1ac"></a>
<b>System.Boolean multiSelect</b></p>

<p>If set to <code>true</code> multi select.</p>
</td></tr></table></p>


---

<a name="92c6a7bd-1a85-40f9-b832-66681f0f65e3"></a>
##Public Void BarToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Handles the user draging a control point in the gradient design bar. 
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="8f328d46-c443-4cb0-8dee-d959cdb7360a"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new location.</p>
</td></tr></table></p>


---

<a name="e047c4ed-15e8-4490-9e0a-83f4bc1e42af"></a>
##Public Void BarToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Handles the user releasing a control point in the gradient design bar.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3810670e-2c37-4ae6-b99d-7875c763dcb9"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>


---

<a name="05ec92a2-d108-460b-907d-db4a35a1ba2c"></a>
##Private Void BaseColorChanged ()

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Handles the base color being changed.

---

<a name="ac677dfd-46a9-44f4-93d7-c84edb6f1320"></a>
##Public Virtual Void BoundsChanged ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Update the bouds of this group when they have changed from either a move or a drag operation.

---

<a name="fa07a6a5-91f3-4f88-bb8e-fb60aec17e61"></a>
##Public Virtual Void BoundsChanged ()

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Updates the location of the edit handles when the bounds has been relocated or resized.

---

<a name="344e271d-fa3b-454d-b58d-08d62abe63ef"></a>
##Public Virtual Void BoundsChanged ()

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Handles the bounds of the shape being changed.

---

<a name="29839d55-0481-4a8b-abcf-3fea372ae62b"></a>
##Private `System.Double` CalculateConcaveRadius (System.Int32, System.Int32)

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Calculates the concave radius.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' ><p><a name="ded56f41-575a-4eb7-bd1c-d10e02a43423"></a>
<b>System.Int32 numPoints</b></p>

<p>Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' class='def'><p><a name="25f27650-f011-4e2e-8707-861043cd8507"></a>
<b>System.Int32 skip</b></p>

<p>Skip.</p>
</td></tr></table></p>

###Returns

The concave radius.
###Remarks

This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.

---

<a name="a2901840-7380-40fd-a41a-dcf38a0eae73"></a>
##Public Virtual Void ChangeBounds (System.Single, System.Single, System.Single, System.Single)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Changes the bounds to match the given values.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="780f619b-84c1-4c03-8d88-4416f18a4f5c"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="ac2a0fc7-f9bf-466d-b52a-28d04ec8186f"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="3f878540-cc4d-4125-a29f-3ddf1a2c69c3"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="9f4ca395-148b-488f-b240-3cefa7e78bf7"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="88459f85-0f11-4fde-8e33-5af3084a6112"></a>
##Public Static `System.Boolean` CharIsNumber (System.Char)

###Member of Type

[Kimono](#046b6991-7999-46f9-88a0-e5abdf7d8361)

###Summary

Test to see if the given character is a number character.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="c06a6584-d5ba-4518-809d-cfdc1f0e8773"></a>
<b>System.Char c</b></p>

<p>C.</p>
</td></tr></table></p>

###Returns

`true`, if is number was chared, `false` otherwise.

---

<a name="9cddbc30-08dc-48f7-91ee-ae2aabb09c94"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Clone this instance.
###Returns

The clone `KimonoShapeStar`.

---

<a name="62511d1a-ab16-460b-a8fd-7df0e7aaadfd"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd)

###Summary

Clone this instance.
###Returns

The clone `KimonoOval`.

---

<a name="f4aa7452-bf4e-442c-aa79-645588301138"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b)

###Summary

Clone this instance.
###Returns

The clone `KimonoShapeTriangle`.

---

<a name="c3d7fd22-37bb-4ffd-a191-a21c78cba680"></a>
##Public [KimonoCore.KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0) Clone ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Clone this instance.
###Returns

A deep clone of this `KimonoPortfolio`.

---

<a name="6706bff2-d136-4973-8b53-bef835f762c4"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Clone this instance.
###Returns

The clone.

---

<a name="8e665e4c-71a6-4982-857d-c1dacdab11ab"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516)

###Summary

Clone this instance.
###Returns

The clone of the `KimonoLine`.

---

<a name="811ba04c-5c8b-4caf-9a57-c64e8aef2b18"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Clone this instance.
###Returns

The clone `KimonoShapeText`.

---

<a name="7d9df035-73a7-48ba-ace7-687c83489e0e"></a>
##Public [KimonoCore.KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) Clone ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Clone this instance.
###Returns

A deep clone of this `KimonoSketch`.

---

<a name="f209ebe0-66e1-4f88-b734-66fa5934f769"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) Clone ()

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Clone this instance.
###Returns

The clone.

---

<a name="66790971-3083-412f-9a14-5b790a67dc9d"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Clone this instance.
###Returns

A deep clone of this `KimonoShapeGroup`.

---

<a name="03af743e-3624-4c26-8766-e47540b95ee3"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Clone this instance.
###Returns

The clone of the `KimonoArrow`.

---

<a name="8167a45f-e54d-4d09-91fa-4cda5bd921bf"></a>
##Public [KimonoCore.KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce) Clone ()

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Clone this instance.
###Returns

The clone.

---

<a name="c5fec200-8f9e-4014-92f7-e242eb17e8de"></a>
##Public [KimonoCore.KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565) Clone ()

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Clone this instance.
###Returns

The clone.

---

<a name="063a46d6-739c-4901-845e-cb9f6d12abbd"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Clone this instance.
###Returns

The clone `KimonoPloygon`.

---

<a name="696afe93-6dfd-44f9-9a47-24a3aa88ddb3"></a>
##Public [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) Clone ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Clone this instance.
###Returns

The clone.

---

<a name="3114f3a0-85a5-4a74-9240-91b0925f265e"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) Clone ()

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Clone this instance.
###Returns

The clone.

---

<a name="e467502b-3662-46f2-bef5-dd3b7d55f604"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Clone this instance.
###Returns

The clone `KimonoShapeRoundRect`.

---

<a name="d80d33b5-c99a-4e3f-993d-5a8b5b421099"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Clone this instance.
###Returns

The clone `KimonoShapeVector`.

---

<a name="a046e75d-4b86-4863-8566-ab5c10ac30b4"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Clone this instance.
###Returns

The clone of this shape as a base `KimonoBounds`.

---

<a name="5e7b5ba7-d3ac-4b42-a09e-b4e7d24899ef"></a>
##Public Virtual [KimonoCore.KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) Clone ()

###Member of Type

[KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384)

###Summary

Clone this instance.
###Returns

The clone.

---

<a name="fe03c2f0-7cf7-400b-b9fc-23b0e7d93d23"></a>
##Public [KimonoCore.KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) Clone (System.Boolean)

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Clones the `KimonoStyle`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deepClone</td><td style='width:75%' ><p><a name="e03b577d-d950-4cac-afe5-a12f51ab2014"></a>
<b>System.Boolean deepClone</b></p>

<p>If set to <code>true</code>, a deep clone of the style is made.</p>
</td></tr></table></p>

###Returns

The a clone of the `KimonoStyle`.

---

<a name="4ba0f7ca-0cd5-424c-a094-fc943d6b6aaa"></a>
##[KimonoCore.KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) CloneAttachedStyle ()

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Clones the attached style.
###Returns

A duplicate `KimonoStyle`.

---

<a name="60e348a3-83b0-4289-858c-f384a6aba6c3"></a>
##Public Static `SkiaSharp.SKColor` CloneColor (SkiaSharp.SKColor)

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Clones the color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="f6a3c41a-425a-45f5-997d-b00381044b6d"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>

###Returns

The color.

---

<a name="9977fc9a-b628-43df-9a21-66ca00f8bf60"></a>
##Public Static `SkiaSharp.SKPaint` ClonePaint (SkiaSharp.SKPaint)

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Clones the given `SKPaint` object.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' ><p><a name="db81ef9d-5bf0-46d8-939f-73c4f685e94a"></a>
<b>SkiaSharp.SKPaint paint</b></p>

<p>The <code>SKPaint</code> object to clone.</p>
</td></tr></table></p>

###Returns

The new `SKPaint` instance.

---

<a name="fec15414-9b53-473b-83e6-c57d9e30639e"></a>
##Public Static `SkiaSharp.SKPoint` CloneSKPoint (SkiaSharp.SKPoint)

###Member of Type

[Kimono](#046b6991-7999-46f9-88a0-e5abdf7d8361)

###Summary

Clones the given `SKPoint`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e8f05562-e648-42ff-ab92-525ffb22ca03"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to clone.</p>
</td></tr></table></p>

###Returns

A clone of the given point.

---

<a name="68df1608-c1fc-4755-8db5-23106912cc3f"></a>
##Public Virtual Void ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Conforms the gradient to shape by fitting it to the bounds of the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="e0560179-d818-46c7-b9c6-bb284414c141"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to conform.</p>
</td></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' class='def'><p><a name="6cb49735-8989-4446-8b2d-07ba57bcf31d"></a>
<b>SkiaSharp.SKPaint paint</b></p>

<p>The <code>SKPaint</code> that the gradient is being attached to.</p>
</td></tr></table></p>


---

<a name="3761ed6d-5618-4433-9ecf-0b27a778a48b"></a>
##Public `SkiaSharp.SKShader` ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Generates a shader that conforms to a given start and end point.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="c28ba6dc-88e1-4c12-987f-66dceb2ea846"></a>
<b>SkiaSharp.SKPoint startPoint</b></p>

<p>Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="eb7de4d9-948f-491c-a248-fe193e7ad0b7"></a>
<b>SkiaSharp.SKPoint endPoint</b></p>

<p>End point.</p>
</td></tr></table></p>

###Returns

The `SKShader` for the gradient bound to a given shape's dimentions.

---

<a name="c54b2241-4df5-4fb6-9f92-8a5e9595cc36"></a>
##Public Void ConvertSelectedShapeToStyle ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Takes the custom `KimonoStyle` of the currently selected `KimonoShape`, converts it to a named, shared style and adds it to the portfolio's collection of styles.

---

<a name="727103f5-5d4b-4f4b-88fa-c6220d6c5892"></a>
##Private `SkiaSharp.SKPoint` ConvertToCanvasPoint (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Converts a raw macOS mouse event point into the coordinates of the currently selected sketch's Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="20f2e8e9-9022-4e5d-a64a-820d66243261"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The raw mouse <code>NSEvent</code>.</p>
</td></tr></table></p>

###Returns

An `SKPoint` adjusted to the sketch's coordinate system.

---

<a name="6bf9d26d-887b-4df6-95a5-69d39b6a3a65"></a>
##Private `SkiaSharp.SKPoint` ConvertToCanvasPoint (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Converts a raw macOS mouse event point into the coordinates of the currently selected bar's Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="db78b416-fe79-46d9-a4ff-27d7fd976bb4"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The raw mouse <code>NSEvent</code>.</p>
</td></tr></table></p>

###Returns

An `SKPoint` adjusted to the bar's coordinate system.

---

<a name="e65e1209-a190-4ab6-9c6b-90b220aeaac9"></a>
##Private `SkiaSharp.SKPoint` ConvertToCanvasPoint (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Converts a raw macOS mouse event point into the coordinates of the currently selected bar's Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="4ecc59be-4f8a-4aca-9046-680b3b8ec018"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The raw mouse <code>NSEvent</code>.</p>
</td></tr></table></p>

###Returns

An `SKPoint` adjusted to the bar's coordinate system.

---

<a name="52292738-ddf0-4d63-8f6b-309c3cd2e5b5"></a>
##Public Void DeleteColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Deletes the given `KimonoColor` from the portfolio.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="97adb6ad-4e9d-4fee-a002-9d7e1daad6d8"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>


---

<a name="bd8ec18b-9e99-41e6-ba38-a928b5823fb6"></a>
##Public Void DeleteColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Deletes the given `KimonoColor` from this group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="b8dac360-4391-4c0f-8da2-a3399c2bd25f"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>


---

<a name="56f86159-38f2-462d-a5b8-85673d43313f"></a>
##Public Void DeleteGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Deletes the given gradient from the group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="3476774f-bc25-4eb9-8924-749162684c50"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>


---

<a name="a1e6ebde-c469-416d-bfb3-54f788a8bd21"></a>
##Public Void DeleteGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Deletes the given gradient from the portfolio.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="20f6d0b3-3d04-46e8-a8a9-053a9b0cd2d2"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>


---

<a name="12b56973-811e-4b06-8495-b7b22b893004"></a>
##Public Void DeleteSelectedControlPoint ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Deletes the selected control point.

---

<a name="3187a1bf-c4e1-49a6-ae2d-d45ba5b6d337"></a>
##Public Void DeleteSelectedShape ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Deletes the selected shape.

---

<a name="792aa1f6-27af-4f1c-b375-d4835ed4ba39"></a>
##Public Void DeleteSelectedShape ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Deletes the selected shape.

---

<a name="2bc0ae67-e907-4753-8ec3-f21e9b3832ba"></a>
##Public Void DeleteSelectedShape ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Deletes the selected shape.

---

<a name="f6a7aef5-89bc-4a73-803a-51ad422cc5a6"></a>
##Public Void DeleteSelectedSketch ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Deletes the selected sketch.

---

<a name="98700e00-5931-4c23-8af0-59e86503f7a0"></a>
##Public Void DeleteShapes ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Deletes the shapes in this selection group.

---

<a name="bb9718fe-d635-4b80-87b7-34753e26826e"></a>
##Public Void DeleteShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Deletes the shapes in this selection group from the parent group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="e86c3679-23de-4d5b-ac6a-60904c4b305e"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>


---

<a name="ffe5af3c-70c8-4140-93df-edc5477463f5"></a>
##Public Void DeleteShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Deletes the shapes in this selection group from the parent sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="11fdca80-48b7-428c-885c-09b56b295bc0"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>


---

<a name="fd6d57fb-4129-4158-b705-00716c78cb22"></a>
##Public Void DeleteStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Deletes the given `KimonoStyle` from the portfolio's collection of styles.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="d3ec87bb-f892-4211-8136-e96994fafe36"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>


---

<a name="aca8d3f9-c94d-44c3-ae04-7151ae55414f"></a>
##Public Void DeselectAll ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Deselects all shapes in the sketch.

---

<a name="e9fe54fb-9244-4dc5-b05d-e5c49c7db403"></a>
##Public Void DeselectAll ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Deselects all shapes in this group.

---

<a name="fca392f8-5573-4791-a509-6f1be8211722"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Drags the bounds of the shape to a new location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="7fba9acf-7994-4a98-9d69-14773ae2dc83"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>


---

<a name="75f1193c-1940-471d-8c6a-cf773966dad3"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Drags the bounds of this group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ff04b3bd-4d67-4b9d-89f1-31edda56d78e"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new location as a <code>SKPoint</code>.</p>
</td></tr></table></p>


---

<a name="d49ec2da-a23c-4b51-bd5a-f3875ed92278"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Drags the bounds of the arrow to a new location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="eb1050e0-38c8-47aa-993d-83619c485cfa"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> specifying the new location of the bounds.</p>
</td></tr></table></p>


---

<a name="2b919d47-a06e-4342-b67f-b1b2120521a5"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Drags the bounds.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="cbc00829-3ebf-4a4c-a0f7-e7e085b3b4e7"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>


---

<a name="d2b546ee-53fd-42e1-b507-1af9533d1c73"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Drags the bounds of the text block.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="46af5dfd-3a57-416e-9d2e-f649e49dbfd6"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> with the new location of the bounds.</p>
</td></tr></table></p>


---

<a name="d946cec8-e2a5-48f3-92e7-5c1ce71b87ee"></a>
##Public Void DragHandle (SkiaSharp.SKPoint)

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Drags the handle.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="222bdd9f-c582-4855-b778-10ff6476734a"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>


---

<a name="4f2b6b03-2ddb-4d81-ad99-4260e75ad83a"></a>
##Public `SkiaSharp.SKData` Draw ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

The public `Draw ()` member of the `KimonoSketch` class returns a `SkiaSharp.SKData` value.

---

<a name="555dc59d-464f-4ca4-8af7-4f02b5e22f5c"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Draws the star into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="35da97eb-b643-43c1-ac72-c65582934f59"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="b230cfcd-a868-4759-8702-61c913a4d3d6"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Draws the text block into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="43f626c9-7e56-40b7-877d-c79f28aa05cc"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>

###Remarks

TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.

---

<a name="c6e29673-364f-435d-82fb-c4e45f7a6a41"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Draw all the `KimonoShapes` that are part of this group into the given Skia canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="46556136-b42d-4f29-8745-e5bf70607a32"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="e4e6039f-e5d0-465c-80b3-ad5d4f9606a5"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Draws the arrow into the specified Skia canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="863773e2-c763-4369-adb9-70d1b5fa4c4b"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="88fba7f1-9a38-4557-9912-186bd4c4f217"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Draws the round rectangle into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="bf038452-eac1-4210-ad99-dfbdba3f167e"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="f897b401-2e1b-406f-b5b5-6518b29c0817"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384)

###Summary

Draws the rectangle into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="34c3c4f2-8c42-4586-82eb-68f37097fe15"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="f3f87d97-08d0-436b-ac7b-2d89aae07dc7"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd)

###Summary

Draw the oval into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="e149fdfa-c82b-4f72-a36a-b76e7297000f"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="49a675cb-5cb1-4123-9ae8-38c60c7e43e6"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Draws the bounding box and its edit handles into the given canvas
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="be6b8309-9f75-4a43-8cc1-6867773bd066"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>Canvas.</p>
</td></tr></table></p>


---

<a name="e99e7864-d141-4945-97de-0bb297ca57bc"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516)

###Summary

Draws the line into the given Skia canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="5be03887-8ef1-4bb1-9b3a-2523889bbe7a"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="31bb06d5-4efb-4fab-b896-4875367cf095"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Draws the polygon into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="9260d29c-ee96-49e6-b09d-f02188b8a889"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="c2fc3ffa-7a04-487f-a647-ab21b3fc49c6"></a>
##Public Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Draws the hanled into the given Skia canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="99068474-bb9c-405d-8a2a-76f14426d873"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw the hanled into.</p>
</td></tr></table></p>

###Returns

The draw.

---

<a name="f3117b6d-1b10-449e-aee2-0230dfa35bf3"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b)

###Summary

Draws the triangle into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="40030c98-c218-4ab6-8126-e9712bbb011b"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="464e90bd-46ce-48d7-9bb9-65a7d685b0c4"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Draws the shape into the given Skia Canvas.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="b11a47b7-9a65-41ca-a773-c816222fcdf7"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>


---

<a name="2ce6ddd2-5bad-4641-95be-fcaf228272fe"></a>
##Public `SkiaSharp.SKData` DrawBar ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Draws the bar.
###Returns

The bar.

---

<a name="67e988a7-00cf-4d11-8d15-7320462a58cf"></a>
##Public `SkiaSharp.SKData` DrawPreview ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Draws the preview.
###Returns

The preview.

---

<a name="b8e6aa99-4a69-4564-9028-d28b4e892e59"></a>
##Public Void DuplicateColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Duplicates the given `KimonoColor` and adds it to the portfolio's collection of colors.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="83e0dded-75bd-44f6-bc84-a7a83be52809"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>


---

<a name="7cc70dd1-9087-4fec-8f2e-aec307d80c4f"></a>
##Public Void DuplicateGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

The public `DuplicateGradient (KimonoCore.KimonoGradient)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="1bd897ee-7c20-4158-8465-d568fa50b308"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>gradient</code> parameter of the DuplicateGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="b7b819d1-3e86-4f9c-b1fd-136b1d9303d1"></a>
##Public Void DuplicateSelectedControlPoint ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Duplicates the selected control point.

---

<a name="aae64c00-8141-43e7-9d1b-2b09d9b6acea"></a>
##Public Void DuplicateSelectedShape ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Duplicates the selected shape.

---

<a name="7ec4460c-91c4-4d86-ab51-54fde61d2424"></a>
##Public Void DuplicateSelectedShape ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Duplicates the selected shape.

---

<a name="ab27018c-843c-4bea-a6cb-4e0c58556304"></a>
##Public Void DuplicateSelectedShape ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Duplicates the selected shape.

---

<a name="0098d5c6-4f31-45fd-8e77-8168c3d04501"></a>
##Public Void DuplicateSelectedSketch ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Duplicates the selected sketch.

---

<a name="9faa4b33-0a8e-4b4d-8698-0be3ad11a44a"></a>
##Public Void DuplicateShapes ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Duplicates the shapes in a selection group.

---

<a name="3acc7256-6da9-42e5-a95a-d1641cb81871"></a>
##Public Void DuplicateShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Duplicates the shapes in this selection group into the parent group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="fa07e4f1-64a7-463a-97ec-daa50a454ce3"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>


---

<a name="ffbdb738-26ba-49cb-80ab-2f0900d750ab"></a>
##Public Void DuplicateShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Duplicates the shapes in this selection group into the parent sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="2cc6f77f-9241-495f-b0f8-c08eaebca015"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>


---

<a name="c2914c27-039e-43f5-8454-8b7c265c253b"></a>
##Public Void DuplicateStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Duplicates the given `KimonoStyle` adding it to the portfolio's collection of styles.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="3241d689-50f5-404a-a34c-44347e205bb4"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>


---

<a name="91a1aaea-856f-4d13-94d8-84e902f969a9"></a>
##Public Virtual Void EndEditing ()

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Ends the editing mode.

---

<a name="2eaf0d04-a6c0-4517-9682-b95995e64c82"></a>
##Public Virtual Void EndEditing ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Ends editing this group.

---

<a name="64c7d5c1-2f83-4e0c-93ea-d76994ce847a"></a>
##Public [KimonoCore.KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) FindColor (System.String)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Finds the given `KimonoColor` by its unique ID.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="9e61456b-5b92-49de-9d34-d8148f08a9a6"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

###Returns

The `KimonoColor` if found, else `null`.

---

<a name="a14c461b-92eb-4030-a40d-57f36a8b5ab9"></a>
##Public [KimonoCore.KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) FindGradient (System.String)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Finds the gradient by its unique ID.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="52e98f55-e243-47be-86a4-09cd6427c7a3"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

###Returns

The `KimonoGradient` if found, else `null`.

---

<a name="16e676a8-75b7-456c-80e2-2e69a3d68e78"></a>
##Public [KimonoCore.KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) FindHandle (System.String)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Finds the handle matching the given unique ID.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="81d5ff0c-db5b-4dd7-9f08-5061468bac89"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

###Returns

The matching `KimonoHandle` or `null` if not found.

---

<a name="3d985a13-c5f3-41ea-bb55-b0fc1679f8e3"></a>
##Private Void FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean@, System.Boolean@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@)

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Finds the intersection.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>p1</td><td style='width:75%' ><p><a name="7b3d9dd7-eecf-41ac-b10e-cfedf097dd27"></a>
<b>SkiaSharp.SKPoint p1</b></p>

<p>P1.</p>
</td></tr><tr><td style='width:25%' class='term'>p2</td><td style='width:75%' class='def'><p><a name="ef1ef5b0-209b-4e99-ada8-03ab41eeade3"></a>
<b>SkiaSharp.SKPoint p2</b></p>

<p>P2.</p>
</td></tr><tr><td style='width:25%' class='term'>p3</td><td style='width:75%' ><p><a name="c79789b4-3118-4310-bf8f-4e447e626bda"></a>
<b>SkiaSharp.SKPoint p3</b></p>

<p>P3.</p>
</td></tr><tr><td style='width:25%' class='term'>p4</td><td style='width:75%' class='def'><p><a name="aec036f4-b406-49db-8623-46061eace1b0"></a>
<b>SkiaSharp.SKPoint p4</b></p>

<p>P4.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref lines_intersect</td><td style='width:75%' ><p><a name="d20edb69-91da-49e1-b71e-bc85ceb6da50"></a>
<b>System.Boolean Out Ref lines_intersect</b></p>

<p>If set to <code>true</code> lines intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref segments_intersect</td><td style='width:75%' class='def'><p><a name="017972a1-41f9-43f4-be51-6b1edc51e9f7"></a>
<b>System.Boolean Out Ref segments_intersect</b></p>

<p>If set to <code>true</code> segments intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref intersection</td><td style='width:75%' ><p><a name="57d85c05-f09d-4739-94c2-88cf03e40626"></a>
<b>SkiaSharp.SKPoint Out Ref intersection</b></p>

<p>Intersection.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref close_p1</td><td style='width:75%' class='def'><p><a name="940528e6-3991-453e-81b4-1dfdf88b076a"></a>
<b>SkiaSharp.SKPoint Out Ref close_p1</b></p>

<p>Close p1.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref close_p2</td><td style='width:75%' ><p><a name="99295d94-6b7f-4527-81c1-f2c77896590e"></a>
<b>SkiaSharp.SKPoint Out Ref close_p2</b></p>

<p>Close p2.</p>
</td></tr></table></p>

###Remarks

This code adapted from http://csharphelper.com/blog/2014/08/determine-where-two-lines-intersect-in-c/ by Rod Stephens.

---

<a name="56578c01-f978-4e70-b39c-9325b6d6c5f9"></a>
##Public [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) FindShape (System.String)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Finds the shape specified by its unique ID.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="55f38329-f143-4602-920f-61be01187b8c"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

###Returns

If found, the `KimonoShape` will be returned, else `null`.

---

<a name="25557052-61c2-458c-a626-6d391f8f0d4e"></a>
##Public [KimonoCore.KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) FindShape (System.String)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Finds a given shape by its Unique ID.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="84f9c9ef-ddca-425b-9eb3-439e1408e7b8"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

###Returns

The `KimonoShape` if found, else `null`.

---

<a name="47747538-416c-4e31-bb34-a4d289e41663"></a>
##Public [KimonoCore.KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) FindSketch (System.String)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Finds the given `KimonoSketch` by its Unique ID.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="c7aba4a4-ee1a-41d1-a338-e5f0ec4b40d2"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

###Returns

The `KimonoSketch` if found, else `null`.

---

<a name="6a7eff20-be05-4cb6-9c72-06dd8bced676"></a>
##Public [KimonoCore.KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) FindStyle (System.String)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Finds the given `KimonoStyle` by its Unique ID.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="8e6b1339-1062-4ceb-b689-5563ce735ee6"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

###Returns

The `KimonoStyle` if found, else `null`.

---

<a name="a7d8f1ac-c9e3-4c9c-89fd-e1c29ddab14d"></a>
##Public Void GroupShapes ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Groups the shapes.

---

<a name="39b24f68-34fa-4270-933b-bb4fc9ef7d95"></a>
##Public Void GroupShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Groups the shapes in the parent group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="c1f496d0-a3cb-4321-bf73-4b20b7232e5a"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>


---

<a name="aba82e44-474c-4e60-9055-82111f9faa7c"></a>
##Public Void GroupShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Groups the shapes in the parent sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="1340021b-9663-4674-8ef3-ef816eae87d6"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>


---

<a name="53af411c-1620-4038-9daf-f36544df12f5"></a>
##Public Void GroupUngroupSelectedShapes ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Groups or ungroups the currently selected group of shapes based on the current selection type.

---

<a name="3b1ce2be-515c-4ae2-9d95-87e46ed15d8c"></a>
##Public Virtual Void GrowBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Grows the bounds of the arrow.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="45eb55d6-820b-422b-a027-4f7b50844175"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> containing the bounds adjustment.</p>
</td></tr></table></p>


---

<a name="2ffe204d-e7fa-4eaf-a75a-d3a01e5695a5"></a>
##Public Virtual Void GrowBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Grows the bounds of the text block.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="13e55836-8b35-4d66-ac89-91b4a61d486d"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to adjust the bounds by.</p>
</td></tr></table></p>

###Remarks

TODO: Changing the bounds of a text box should optionally scale the size of the text within.

---

<a name="a4f0b727-2043-40a6-b9e8-850cda128bbc"></a>
##Public Virtual Void GrowBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Adjusts the size of the bounds.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d0c85727-3ab7-4b79-a7ed-b362e7ec1a01"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new size as a <code>SKPoint</code>.</p>
</td></tr></table></p>


---

<a name="6faceadd-a027-4c40-878a-fcd260161180"></a>
##Private Void HandleFillBlurOrShadowChange ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Handles the fill blur change.

---

<a name="14328d15-e792-41f7-bb02-d144efce443f"></a>
##Private Void HandleFillColorChange ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Handles the fill color change.

---

<a name="6bedc32b-0fd3-4407-a98d-e03b397abea4"></a>
##Private Void HandleFillGradientChange ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Handles the fill gradient change.

---

<a name="17010e68-c63c-4a7d-a83a-2dc53fcc1268"></a>
##Private Void HandleFrameBlurOrShadowChange ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Handles the frame blur change.

---

<a name="89a52c1f-6a29-453f-b867-47eb5f90f433"></a>
##Private Void HandleFrameColorChange ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Handles the frame color change.

---

<a name="bcd706e2-9e86-48a3-a2f3-73d2cc7210c3"></a>
##Private Void HandleFrameGradientChange ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Handles the frame gradient change.

---

<a name="99f84ed7-4a65-49ba-9e05-67e28b60aab6"></a>
##Public Void HandleGradientModified ()

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Handles the gradient being modified.

---

<a name="5990744e-dcaa-421e-88ed-f5341d9ef889"></a>
##Public Void HandleGradientModified ()

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Handles the gradient being modified.

---

<a name="dcb2a2f4-38de-47b1-ac95-9e105f42517f"></a>
##Private Void HandleLinkedColorChanged ()

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Handles the linked color changed.

---

<a name="89232dbe-0b34-4fb3-900a-fa9a0e20ab10"></a>
##Private Void HandleSketchChanging (KimonoCore.KimonoSketch)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Handles the currently selected sketch changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="a3caf5eb-c98a-4154-8f15-1573a3b811de"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The new <code>KimonoSketch</code> being selected.</p>
</td></tr></table></p>


---

<a name="6413b188-542c-4973-b31c-59f4a1015fed"></a>
##Public Static `System.String` IncrementName (System.String)

###Member of Type

[Kimono](#046b6991-7999-46f9-88a0-e5abdf7d8361)

###Summary

Increments the name by appending a number to the end or incrementing an existing number count.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="5a775189-a524-4e6d-aedf-6b618405c73b"></a>
<b>System.String name</b></p>

<p>Name.</p>
</td></tr></table></p>

###Returns

The name.

---

<a name="ec80e9c7-a92e-4d27-8b62-f09b7d264fe2"></a>
##Void Initialize ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Initialize this instance.

---

<a name="cbd34e86-7381-42aa-b8a5-47c0284938f2"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Initialize this instance.

---

<a name="6662db47-314e-4473-97ca-c8d90a49e52c"></a>
##Void Initialize ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Initialize this instance.

---

<a name="85494a45-71d7-4b32-85bb-1c667e523fb6"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b)

###Summary

Initialize this instance.

---

<a name="9ec7042c-9f82-4e19-b608-431aaefa94fc"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Initialize this instance.

---

<a name="77697730-bd99-4cd5-97c1-76c39b6c26c3"></a>
##Void Initialize ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Initialize this instance.

---

<a name="1d8631d9-4ba3-49fa-8d03-f32e3afcd171"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Initialize this instance.

---

<a name="4c8a3eda-45eb-4d20-baf7-3def104e57d0"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516)

###Summary

Initialize this instance.

---

<a name="ad60d043-2d92-4333-a476-6ebc38d3a0f1"></a>
##Void Initialize ()

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Initialize this instance.

---

<a name="edde0a22-4c8c-4ad3-866d-773b48581b8a"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd)

###Summary

Initialize this instance.

---

<a name="bd4c85f1-f5fc-402e-bede-2a1642a1fade"></a>
##Public Void Initialize ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Initialize this instance.

---

<a name="4b6ab5bf-3314-43ce-bff5-2d77ead48270"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384)

###Summary

Initialize this instance.

---

<a name="03c3b7c7-f15f-43fe-a7f6-6c6bceefeb38"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Initialize this instance.

---

<a name="edae8d40-ee54-4148-9baf-bf9445b38299"></a>
##Private Void Initialize ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Initialize this instance.

---

<a name="aabc6b94-f281-428a-94b7-bef864f05824"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Initialize this instance.

---

<a name="96fd7c72-e3da-424e-9396-fae86fbab80e"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Initialize this instance.

---

<a name="4fa181da-28e3-4fa2-8fe1-265d45bb1437"></a>
##Private Void Initialize (System.Object)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Initialize the specified parent.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="3c6a5e5f-a71f-40a1-9a39-e65906065ead"></a>
<b>System.Object parent</b></p>

<p>Parent.</p>
</td></tr></table></p>

###Returns

The initialize.

---

<a name="a7466906-8bc4-4519-a046-ce33784c2840"></a>
##Public Void KimonoBlur ()

###Constructor for Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Initializes a new instance of the [KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce) class.

---

<a name="af208db0-838b-4135-ab9d-4e06afe5dc06"></a>
##Public Void KimonoBlur (System.Single, System.Single)

###Constructor for Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Initializes a new instance of the [KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' ><p><a name="597f14f0-b279-4316-93e7-bffe9c0a05e2"></a>
<b>System.Single horizontalBlurAmount</b></p>

<p>Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="871916c2-eca7-422f-a5aa-45c07dd08383"></a>
<b>System.Single verticalBlurAmount</b></p>

<p>Vertical blur amount.</p>
</td></tr></table></p>


---

<a name="8e7bb0e1-4a78-458c-8cd0-ea16a58a0def"></a>
##Public Void KimonoBounds ()

###Constructor for Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Initializes a new instance of the [KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) class.

---

<a name="dac0bb2b-cc96-4f4d-924f-500622e97972"></a>
##Public Void KimonoBounds (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Initializes a new instance of the [KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="346f61b8-8c3c-42b6-8a2c-d46e3af594a1"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="04198f77-31ff-4327-aa54-8a26ef23f86d"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="8d2c56b9-71e8-4916-abda-3e14f7b707b7"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="02236817-c7c5-48a9-a6ec-42b8291b424c"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="7b7db6bb-a21f-4940-9b9d-4cb203bd3e81"></a>
##Public Void KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Initializes a new instance of the [KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="600bb152-83c4-43a2-b6c9-8632bb0c5e6c"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="89b578b9-90fc-4b86-b107-8751abedd9e6"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ea42dbed-3566-4462-9ac8-7fceac6cc655"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="64431c72-a961-4c36-8467-1d0f4a0a2c42"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="46400541-19e5-451d-828e-683084877d2a"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="a742a000-845f-4934-83af-918869efccec"></a>
##Public Void KimonoColor ()

###Constructor for Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Initializes a new instance of the [KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) class.

---

<a name="98c2b614-1f16-4cf5-9427-2ff7a4ab4516"></a>
##Public Void KimonoColor (KimonoCore.KimonoColor)

###Constructor for Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Initializes a new instance of the [KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="f83624f5-4bf8-4930-a59c-22f7c1c97ef7"></a>
<b>KimonoCore.KimonoColor baseColor</b></p>

<p>Base color.</p>
</td></tr></table></p>


---

<a name="704e80de-5d21-4146-bb77-de8b26bfc563"></a>
##Public Void KimonoColor (SkiaSharp.SKColor)

###Constructor for Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Initializes a new instance of the [KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="40a8e904-f46b-4ec0-a581-231274921135"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>


---

<a name="030459db-0bfc-4ba2-afc3-378c476c0f0a"></a>
##Public Void KimonoDesignSurface ()

###Constructor for Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Initializes a new instance of the [KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f) class.

---

<a name="06ee8aa4-f43c-4c15-ac44-b0adcd8c0c9a"></a>
##Public Void KimonoDesignSurface (CoreGraphics.CGRect)

###Constructor for Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Initializes a new instance of the [KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="08adffe6-b506-475e-b196-8774b7715b1f"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>


---

<a name="ff10cb5d-6d1f-4f62-b4f7-f9fc89f3bea7"></a>
##Public Void KimonoDesignSurface (Foundation.NSCoder)

###Constructor for Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Initializes a new instance of the [KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="32233030-2b55-4174-99a3-9027dd4a1563"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>


---

<a name="6e71edeb-76ac-40c7-95d2-1cb81d1c32b7"></a>
##Public Void KimonoDesignSurface (System.IntPtr)

###Constructor for Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Initializes a new instance of the [KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="6d7c7f5e-015b-4160-9681-944ff87f5c9a"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="86edabf5-be0f-431e-ab92-87fe2c966be0"></a>
##Public Void KimonoGradient ()

###Constructor for Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Initializes a new instance of the [KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) class.

---

<a name="176c22e3-f979-4715-9084-1ff195d33e26"></a>
##Public Void KimonoGradient (System.Single, System.Single)

###Constructor for Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Initializes a new instance of the [KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="ea2255fb-1226-4226-bf5c-c629903f88e6"></a>
<b>System.Single barWidth</b></p>

<p>Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="32920467-4cf2-4578-aa21-4637cbc06f43"></a>
<b>System.Single barHeight</b></p>

<p>Bar height.</p>
</td></tr></table></p>


---

<a name="a5a30340-4fed-4202-90e2-d1eb4c0fe940"></a>
##Public Void KimonoGradient (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Initializes a new instance of the [KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="c8c45031-f73d-4e03-a830-fe13c79bab2a"></a>
<b>System.Single barWidth</b></p>

<p>Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="3a5eeba6-0511-4cc0-9411-9cd18b9fa8cf"></a>
<b>System.Single barHeight</b></p>

<p>Bar height.</p>
</td></tr><tr><td style='width:25%' class='term'>previewWidth</td><td style='width:75%' ><p><a name="c08517f6-3ea1-416f-a819-6744cc2fd596"></a>
<b>System.Single previewWidth</b></p>

<p>Preview width.</p>
</td></tr><tr><td style='width:25%' class='term'>previewHeight</td><td style='width:75%' class='def'><p><a name="53d45242-5bbe-4204-a5f8-5f3c01fb4792"></a>
<b>System.Single previewHeight</b></p>

<p>Preview height.</p>
</td></tr></table></p>


---

<a name="8a50f479-8fac-4103-b2f3-f24d7310c25a"></a>
##Public Void KimonoGradientDesignBar ()

###Constructor for Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.

---

<a name="1647a9f1-9664-4ddd-b089-b604c90608b6"></a>
##Public Void KimonoGradientDesignBar (CoreGraphics.CGRect)

###Constructor for Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="cb3a7d25-6ba7-4840-b40c-282d938011b3"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>


---

<a name="29781c74-00c0-4879-82c2-a2b2ed0e7d16"></a>
##Public Void KimonoGradientDesignBar (Foundation.NSCoder)

###Constructor for Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="ceae8f52-6ad9-4404-b7b0-f2a86bc7b640"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>


---

<a name="a608def7-4e88-4630-9e74-1a519831a916"></a>
##Public Void KimonoGradientDesignBar (System.IntPtr)

###Constructor for Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="3ea65aa3-4ef2-4190-907f-b8e38ef8129c"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="4899a667-c111-4676-85f9-4c44c2c37165"></a>
##Public Void KimonoGradientDesignPreview ()

###Constructor for Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.

---

<a name="4ed5c459-cd28-4956-993b-38f6ace92392"></a>
##Public Void KimonoGradientDesignPreview (CoreGraphics.CGRect)

###Constructor for Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="04ba834b-2a40-484a-9f3d-10181cd517b6"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>


---

<a name="5589cd1d-2e18-4b1c-ac52-19c8cd123bb4"></a>
##Public Void KimonoGradientDesignPreview (Foundation.NSCoder)

###Constructor for Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="04b89e5e-9856-4290-9785-5692075dbcdc"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>


---

<a name="5cf4c5ac-794f-41ac-abfc-54f6e2abe0ca"></a>
##Public Void KimonoGradientDesignPreview (System.IntPtr)

###Constructor for Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Initializes a new instance of the [KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="78714ee3-5603-4c15-9ce7-f69ecf2ef34b"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="78da86a5-6f40-47e9-adba-f42e3d1d790d"></a>
##Private Static Void KimonoHandle ()

###Constructor for Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

The private static `KimonoHandle ()` constructor for the `KimonoHandle` class.

---

<a name="9f83fd58-c4fa-42e0-8ad2-85f592401109"></a>
##Public Void KimonoHandle (System.Single, System.Single)

###Constructor for Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Initializes a new instance of the [KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="4a72afcd-8a64-43ce-82cb-91f9c27ba1bf"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="37ef1e0e-b9f8-4893-9d34-6af46132f3cf"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>


---

<a name="69d167a4-4d46-4b90-b528-21de635162d7"></a>
##Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)

###Constructor for Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Initializes a new instance of the [KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="6325874a-a7b9-43b8-ad21-3dc46e07c0cd"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="b8873d33-ca5b-4de6-aeb9-a2e515b1bc80"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="299de7be-b13e-473c-a315-683bd89e0d9a"></a>
<b>KimonoCore.KimonoHandleConstraint constraint</b></p>

<p>Constraint.</p>
</td></tr></table></p>


---

<a name="af4d32a6-c75a-44b9-8e30-2f5150b5d189"></a>
##Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Initializes a new instance of the [KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="0332ef43-bc30-44ee-a7a9-0dc7d7186be9"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="9e9be782-2bf4-4e47-a0fe-31ccb4e227db"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="695f3547-6ad6-4847-9ca7-7d45930056cf"></a>
<b>KimonoCore.KimonoHandleConstraint constraint</b></p>

<p>Constraint.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="c7044c94-b6df-4569-8a84-cf36ca479688"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="30b55d08-620f-452a-887f-121079b1a9af"></a>
##Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Initializes a new instance of the [KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="a19e97c0-76ea-4dd7-8d9a-638f7445cdfd"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="bf6feb5a-eef3-4da7-b0b8-3309adbb1e7b"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="771010ef-5755-4184-b102-3cee3f7663ff"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="8685aa0e-5576-4d83-b91a-9124a3d3f90c"></a>
##Public Void KimonoPortfolio (System.Boolean)

###Constructor for Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Initializes a new instance of the [KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>initialize</td><td style='width:75%' ><p><a name="011804be-0d56-426c-9016-e219d53e1545"></a>
<b>System.Boolean initialize</b></p>

<p>If <code>true</code>, the new instance will be initialized with the default values.</p>
</td></tr></table></p>

###Remarks

`initialize` is set to `false` when a clone is being made of given `KimonoPortfolio`.

---

<a name="01491009-13b5-4536-a4aa-8fbffbb171b1"></a>
##Public Void KimonoShadow ()

###Constructor for Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Initializes a new instance of the [KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565) class.

---

<a name="7a284970-72ef-4beb-983f-1e56e25811b1"></a>
##Public Void KimonoShadow (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Initializes a new instance of the [KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalOffset</td><td style='width:75%' ><p><a name="6b356a84-8de3-4625-abbc-d78e572009e2"></a>
<b>System.Single horizontalOffset</b></p>

<p>Horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' class='def'><p><a name="a65ee4c8-95b9-4919-9618-dc2bb229f344"></a>
<b>System.Single horizontalBlurAmount</b></p>

<p>Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalOffset</td><td style='width:75%' ><p><a name="3859336d-371a-468e-b1f7-e929c8f32c38"></a>
<b>System.Single verticalOffset</b></p>

<p>Vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="4954909f-5c3c-4775-80c5-fb5bfc719ccb"></a>
<b>System.Single verticalBlurAmount</b></p>

<p>Vertical blur amount.</p>
</td></tr></table></p>


---

<a name="75b27eaf-c3b0-45d0-b26d-70c61d229aeb"></a>
##Public Void KimonoShape ()

###Constructor for Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Initializes a new instance of the [KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) class.

---

<a name="9f94f6b0-3b7d-4e4c-88d3-5f12ce4c7ff3"></a>
##Public Void KimonoShape (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Initializes a new instance of the [KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="35c57504-4371-40f9-ae63-4c78124529fe"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="1b762c76-121e-419b-9b8f-dd125470aeee"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="240ef754-5419-4c9c-9eae-341f1d72db1f"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="206b4180-0863-4c0e-983f-158374c3e17e"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="6c77c295-9729-41d7-bbe9-aaa58770895a"></a>
##Public Void KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Initializes a new instance of the [KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f5a0a879-abb5-4a73-8ce3-0817aa65c309"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="27b889b9-d385-47db-8584-2980174db29a"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="229e234e-d4f6-4a1e-837e-eb4db8eb6f8b"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f099d705-c261-4804-8c5c-e19411eb6877"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="9994fea7-4dbe-41da-900f-dfb88d4e874d"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="c8a754db-a507-4756-bcb4-95b509d7f55c"></a>
##Public Void KimonoShapeArrow ()

###Constructor for Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Initializes a new instance of the [KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535) class.

---

<a name="35b152e2-a414-4da5-8bee-c04afaa4a0f8"></a>
##Public Void KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Initializes a new instance of the [KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="39c895e0-6a03-464e-a907-2d791bf85130"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="619143c6-d564-4ef7-9b4b-d3a775e2a2fd"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="35d877d5-6f06-40f0-a0e7-8cc339dabc3a"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="1393c3f4-75de-4379-a6e6-3f0f2ac18d04"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="5d6e04cc-25c7-4c9e-a065-f393c149001a"></a>
##Public Void KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Initializes a new instance of the [KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="ac790bc9-8ed7-4874-9385-90866289e6b0"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="ac47e8a5-d80c-425b-b9ad-079a07850cca"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="da6f073f-2dac-447c-bb4a-5d0f28a0324e"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="81fe3f28-3046-41d5-b588-bc14e7edc571"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="7842379e-a7f7-4cb2-9de3-42a561bd075d"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="ff09ff18-f1ad-4898-9c21-12116c7a515e"></a>
##Public Void KimonoShapeGroup (System.Object)

###Constructor for Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Initializes a new instance of the [KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="e64c3875-2ed0-4c6b-8a3d-79158c1c0223"></a>
<b>System.Object parent</b></p>

<p>The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>


---

<a name="721f5dc9-c255-479e-9737-e6411c28f394"></a>
##Public Void KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Initializes a new instance of the [KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="efe6f2b2-62d9-4ffb-9ac2-2dafb4024667"></a>
<b>System.Object parent</b></p>

<p>Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="2b1427c2-6fb4-4c0d-b685-6d9332aeb294"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="496ddd21-5933-437f-96bf-6a04f114f74f"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="d5ca9466-61a8-43a8-974a-663fc1f63d12"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="9d4c95c2-46d9-4eea-ada7-4aa89523c870"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="ec6a8f65-0a10-46d6-8a57-e129eb7a452e"></a>
##Public Void KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Initializes a new instance of the [KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="9ec61f81-9da1-4071-ad4a-69e88e87656c"></a>
<b>System.Object parent</b></p>

<p>Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="45e52d62-8d2a-44c5-b376-eb2b2ae7c3d7"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="66195c08-ad4d-4d20-a2eb-847736ae62b1"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="78f686b4-0841-439e-bfd3-c0e582223a45"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="434b5314-9966-4ea3-b6cd-9bcd523b36f0"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="9edf05d6-cde2-441d-aa40-d433d10ea0e8"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="51dc0bb7-e718-47b7-8bd0-bdf9759cba51"></a>
##Public Void KimonoShapeLine ()

###Constructor for Type

[KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516)

###Summary

Initializes a new instance of the [KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516) class.

---

<a name="76a38bce-e52a-41ff-a8bf-110f527fbf67"></a>
##Public Void KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516)

###Summary

Initializes a new instance of the [KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="81cc4e10-8b97-41d1-b359-a0d9904925a1"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="3898a3ca-ffe5-4ab2-adcb-007568a37792"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="b66b6647-a6d9-43da-aae0-423aa4f41a61"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="4aa3ae16-f917-429f-8395-06ca9445c403"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="da47403e-fbf4-4f3a-adab-320500605534"></a>
##Public Void KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516)

###Summary

Initializes a new instance of the [KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6061ab3e-7448-4779-95a2-20ad73bdfd7c"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c94354af-9652-4068-b379-ccb07e361ea4"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="86307794-cac1-45b4-a002-5f8d36f47df0"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="81b738e0-b05c-4388-ad30-76ab42e58fbb"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="32db442d-b907-4986-a6e6-c56dcb3c2372"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="43ffd78b-7efe-40a3-a50a-398872c66b17"></a>
##Public Void KimonoShapeOval ()

###Constructor for Type

[KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd)

###Summary

Initializes a new instance of the [KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd) class.

---

<a name="070aec9e-bd6b-4497-9d45-0f655dcf47cd"></a>
##Public Void KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd)

###Summary

Initializes a new instance of the [KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="b8e556d5-1758-4222-af96-fd7fbc5b09fc"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="8cbf0d88-b6fe-4f56-a52c-b1f001a37289"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="e1e2002b-be39-4651-8288-1ead696b171e"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="7282ba40-19b3-4976-a886-58cc72546280"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="3bd92b5d-8a98-4502-891b-c652085cde27"></a>
##Public Void KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd)

###Summary

Initializes a new instance of the [KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="a8d79685-ebed-4b63-8a6c-eec98940076a"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="3bc3fd56-8da1-4a94-81ef-64ce1e99b506"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="84965950-7e84-43e9-976d-b6ed35654081"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="8620d992-a058-4702-bb75-a980d2106934"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="6310b0e9-1f76-4066-a0a4-507b0cdb8b2f"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="8867556b-cfde-4fbe-8b1e-0ff94d310030"></a>
##Public Void KimonoShapePolygon ()

###Constructor for Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Initializes a new instance of the [KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752) class.

---

<a name="83b6a1f0-e297-4b5d-8580-f0040ce0a91e"></a>
##Public Void KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Initializes a new instance of the [KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="ef799ab9-857e-42e9-974f-4a6697c36213"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="9004275d-3676-4a22-a4cc-a98468f23375"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2bb99001-8c65-470c-bb3b-5f7c9ff8a33b"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="ec0525fd-6275-48f4-bc4e-40c4c991886d"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="3b759519-548f-40f5-96e1-081b295f872b"></a>
##Public Void KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Initializes a new instance of the [KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="ecb4e8f4-75db-4627-aaca-146572bad358"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="b9818716-55dd-4da3-99e2-864d6d2f32fa"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="682ee31d-ac2b-4d1a-b5d9-028274c47f10"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="7f0ff775-7e50-448b-884d-58e8dd1fe00b"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="e80d82aa-8e73-402f-ba70-adf1e2980926"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="362494fd-04fc-4788-a6e2-576bac793043"></a>
##Public Void KimonoShapeRect ()

###Constructor for Type

[KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384)

###Summary

Initializes a new instance of the [KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384) class.

---

<a name="eb7bf51d-75ec-4ed3-b963-bc753b3789cd"></a>
##Public Void KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384)

###Summary

Initializes a new instance of the [KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="ecbcb0cd-437b-4fe2-80da-3af8048d0af8"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6412c96d-440f-471b-a928-8d8636d20a50"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="29c4fb3d-ac2f-48a3-9341-54fce2707e1b"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="04c2c799-b97b-4f51-be95-ea1aa2d21f7a"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="a106c3d2-3c7f-433e-bb5d-896959502e73"></a>
##Public Void KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384)

###Summary

Initializes a new instance of the [KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f8e8477b-b6ce-4dca-a330-1bfd38c87b25"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f23c5332-2c52-447d-a6b5-85ebe23d615e"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="3e6639d2-a948-4863-90b0-934c2152d32b"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="5be0eda0-5b1f-47fa-ab75-f93d053d2646"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="fdfa4afe-4831-4adf-88b8-7243b1fd8933"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="d30edcc7-27a6-48ce-bce7-5f9f36d9e812"></a>
##Public Void KimonoShapeRoundRect ()

###Constructor for Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Initializes a new instance of the [KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a) class.

---

<a name="1a3433f9-92aa-4e15-a77b-7525edb9bcf4"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Initializes a new instance of the [KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="080e26b5-b3b2-47ae-887d-afa4c276ad29"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="073ba1fc-70ce-41bd-ab01-ed8537c5788a"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="1c46efe4-d4bb-452a-9bf5-8e49b5a6446d"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="20e1aa22-f617-42a4-a518-a0faea1fa89f"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="dbdaa685-fe48-46bd-a78e-27f8392338f0"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Initializes a new instance of the [KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="0e01d9a9-385e-41a4-8542-cbb6f373d073"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="0bb377f4-c6d1-4011-ac74-8fa7109d06de"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="c813d957-933f-4e58-9ae1-4cea3320cdc0"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="c539b0a2-3d60-4d84-ba1e-8f18ffda96e5"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="c280669b-421d-4f23-bebc-7f7d8c826c82"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="eda27429-5d80-49b5-bfe4-d0faf293d7ab"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Initializes a new instance of the [KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="de87af5d-a130-47ba-a453-c5ee881a52c6"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e891c7fb-cb6f-4ee5-8158-335b49d10dfe"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="a2dc5253-8598-4ec1-ba7d-de5529119f1e"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="3b1622f9-bee4-46f2-9a0a-40f040a2a531"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="884f2068-beae-49a9-9373-3d4156a3df88"></a>
<b>System.Single cornerRadius</b></p>

<p>Corner radius.</p>
</td></tr></table></p>


---

<a name="1a9c6c8c-3a93-4d7b-bb5d-78f4c8dcdc6e"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Initializes a new instance of the [KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="02d62312-63fc-4ead-9239-658b2a9c2a50"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="19553c1d-dce4-49fd-91fb-81dd96ddd1b0"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="dcd40a30-a432-4c94-9bb2-5a502a9a1b0f"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="66a75c55-9508-483b-af8e-0cdc21e3db13"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="e67c0e26-d1e7-426c-bb26-f974ce75a511"></a>
<b>System.Single cornerRadius</b></p>

<p>Corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="792798e1-4574-46a2-8c30-915a90e63713"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="272ee9b5-5c46-4e41-96d3-f7fe3992483d"></a>
##Public Void KimonoShapeStar ()

###Constructor for Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Initializes a new instance of the [KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76) class.

---

<a name="e820937e-f849-4302-91da-3b98c71e5bd9"></a>
##Public Void KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Initializes a new instance of the [KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="29e75219-cf16-4eb7-a9ec-224d901ff8f6"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f669262f-7de5-43e0-8704-8be33a349c75"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="40766fc4-716a-445d-9d6e-15d0878dd124"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="318bbdfb-004f-4110-8df0-b5b3a21474d7"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="f48efed9-41d9-45b3-9100-c253be70b454"></a>
##Public Void KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Initializes a new instance of the [KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="5e70705d-3031-4044-830d-f2480868fde7"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="2bdd6113-3ad7-4e8c-82f7-a266c4374123"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2eda8e86-bc22-4a03-a54d-871e4bdccc80"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e14ac7fc-5ffc-4af7-a2a9-a5f34cd456da"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="76416c14-cc07-4188-a5e0-ec02d55230bb"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="9db4ba06-7aea-434c-9218-d5c71df0009f"></a>
##Public Void KimonoShapeText ()

###Constructor for Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Initializes a new instance of the [KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf) class.

---

<a name="8466faf5-34f4-46d2-b5cc-c43c50786bfd"></a>
##Public Void KimonoShapeText (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Initializes a new instance of the [KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="344f66b0-8359-4776-945d-55b9a6c70494"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="be3d310e-da55-45bf-9b4d-461c1cf6c680"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="55ea6e9c-884f-4f52-9c0e-27b14e789301"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f3cf1e8a-8401-4975-b43e-9ea8aa0f71d6"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="3fd9571f-fc3d-4327-ba63-ec3eba870520"></a>
##Public Void KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Initializes a new instance of the [KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8ca22093-3730-44ee-a14f-7675e11ebb2f"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="93509830-e8fa-4380-8e2c-d1159e912987"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="86f5d983-9a90-4b9d-b445-cf80022ad880"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="6aafffed-7257-4a4f-a3dc-4bc0c1d11450"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="fab7e95f-c936-4d74-8f5f-a89c106bcca6"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="571d8440-321e-4581-af18-c0827c78104c"></a>
##Public Void KimonoShapeTriangle ()

###Constructor for Type

[KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b)

###Summary

Initializes a new instance of the [KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b) class.

---

<a name="fb03f043-0094-459d-9303-629301a5514a"></a>
##Public Void KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b)

###Summary

Initializes a new instance of the [KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="1c0939e1-ba61-478e-a022-094d9b345de7"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6f6f393a-5d56-497a-bc79-96dfe41a409f"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="04960630-97e6-475d-b317-a3e9755e757a"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="bd23d6a1-380e-4944-921c-f83999358670"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="d10518a4-ed89-4b4a-a39a-5a403cf4f59d"></a>
##Public Void KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b)

###Summary

Initializes a new instance of the [KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6510b69c-fb39-4d58-ae28-6430f65b172b"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="006f1546-257f-409b-b867-8534b0a29e3a"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="64540011-d381-4814-876f-699da762c9d4"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="24996c41-9239-4a89-b11b-885f1a05011b"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="2d2a1cf1-a854-42a2-a0e9-4115680e8306"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="245d843c-45e5-4144-9206-9416beda6c8a"></a>
##Public Void KimonoShapeVector ()

###Constructor for Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Initializes a new instance of the [KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850) class.

---

<a name="2487c6e7-663a-48c8-8e11-6778e56aac0d"></a>
##Public Void KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Initializes a new instance of the [KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6d4e881f-ee34-45f5-9567-af198f77e41c"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="4d83f4e2-270a-40f0-a4f1-692bb0fc57ef"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="5a45ca0c-7f46-4a10-aa6c-cfa85a69c156"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="68c6da67-cef1-4d5e-b226-a52fd44299f6"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>


---

<a name="4f0e2914-452a-41ad-a518-e9614eac720a"></a>
##Public Void KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Initializes a new instance of the [KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6216105a-2da1-4ac4-9553-c96dcf22ffd4"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="7f6c074e-4015-44f5-b9dd-a0df0dcacf87"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="8a208800-3ee8-417f-83d4-9f36959bd74c"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="41b97c2e-4973-41a2-9858-031a350924bb"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="991fe2f6-7e84-416e-8e20-0d5e40c59cc1"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>


---

<a name="e77a3856-dbf9-4672-bfc4-a26cf89de41f"></a>
##Public Void KimonoSketch ()

###Constructor for Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Initializes a new instance of the [KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) class.

---

<a name="69b5245b-3c9a-4f3d-97e7-92a1e8e5a4e3"></a>
##Public Void KimonoSketch (System.String, System.Single, System.Single)

###Constructor for Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Initializes a new instance of the [KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="66afc958-8a31-4bd8-a34a-d1b2f2a25794"></a>
<b>System.String name</b></p>

<p>Name.</p>
</td></tr><tr><td style='width:25%' class='term'>width</td><td style='width:75%' class='def'><p><a name="56072fc5-2f2e-4ffc-a8c4-e8586ec91bae"></a>
<b>System.Single width</b></p>

<p>Width.</p>
</td></tr><tr><td style='width:25%' class='term'>height</td><td style='width:75%' ><p><a name="25298f7c-6dfa-4912-b161-4dc2bb174a88"></a>
<b>System.Single height</b></p>

<p>Height.</p>
</td></tr></table></p>


---

<a name="622f894e-2300-4197-bba7-9f4aa2283086"></a>
##Public Void KimonoStyle ()

###Constructor for Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Initializes a new instance of the [KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf) class.

---

<a name="75dc4ab0-226e-4aff-877d-0d35cc18e026"></a>
##Public Void KimonoUndoHandler ()

###Constructor for Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Initializes a new instance of the [KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4) class.

---

<a name="b51209c8-e73d-4fae-8a31-b45117fcf9ed"></a>
##Private `System.Collections.Generic.List<System.Single>` MakeDashInterval ()

###Member of Type

[KimonoStyle](#c441c4bb-a1b4-455f-aaca-18aa873ff2cf)

###Summary

Makes the dash interval from the dash pattern.
###Returns

The dash interval.

---

<a name="6147ca8b-f83a-4124-8802-28bf4e2282a7"></a>
##Private `SkiaSharp.SKPoint[]` MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)

###Member of Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Makes the star points.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="4163ffd9-76fb-4ada-b77f-3de703d3ac8f"></a>
<b>System.Double startTheta</b></p>

<p>Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="267218fd-fe75-47c8-b7a8-f86b8a08e215"></a>
<b>System.Int32 numPoints</b></p>

<p>Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="d441b1fa-2c7b-4d49-992d-3f578db9e0c7"></a>
<b>Deleted In API Version 01.00.00</b></p>

<p>Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="d537eb92-657d-4dfc-90e2-91acec8f6d34"></a>
<b>SkiaSharp.SKRect rect</b></p>

<p>Rect.</p>
</td></tr></table></p>

###Returns

The star points.
###Remarks

This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.

---

<a name="d57410d3-c70d-4729-879d-5a512c016a21"></a>
##Private `SkiaSharp.SKPoint[]` MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Makes the star points.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="5bba6022-ee48-43ce-88c1-65f2a30168f4"></a>
<b>System.Double startTheta</b></p>

<p>Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="9cc644a6-237c-49f2-baf3-d6ea9512708d"></a>
<b>System.Int32 numPoints</b></p>

<p>Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="25711c2c-b67b-4fd7-91d9-38117f021873"></a>
<b>System.Int32 skip</b></p>

<p>Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="783fec04-cb01-4cae-a226-ba3264e19b71"></a>
<b>SkiaSharp.SKRect rect</b></p>

<p>Rect.</p>
</td></tr><tr><td style='width:25%' class='term'>depth</td><td style='width:75%' ><p><a name="a8c9927f-5960-427b-9054-e35738a95348"></a>
<b>System.Single depth</b></p>

<p>The <code>depth</code> parameter of the MakeStarPoints method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>

###Returns

The star points.
###Remarks

This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.

---

<a name="0f4e1a58-e510-4328-9372-78070125cf0d"></a>
##Private Void MixColor ()

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Mixes the color based on the base values and any adjustment that have been applied.

---

<a name="321a8fb7-4b86-4793-8082-94ccf4d091f6"></a>
##Public Virtual Void MouseDown (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Handles the user clicking the mouse
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="3ed0265d-78a2-48f4-a332-9d3fae5c7ff4"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse down.</p>
</td></tr></table></p>


---

<a name="eee09301-ad33-46d3-9f4a-418f91f6a822"></a>
##Public Virtual Void MouseDown (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Handles the user clicking the mouse
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="5f95ebe5-85ae-4db1-8b10-fb0e7b64de49"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse down.</p>
</td></tr></table></p>


---

<a name="abdc500e-e94b-4662-9e90-3a2bdb8952e1"></a>
##Public Virtual Void MouseDown (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Handles the user clicking the mouse
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="789ba7f1-498e-4bad-9ab0-648a2a7d543e"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse down.</p>
</td></tr></table></p>


---

<a name="39156aeb-61ff-41c5-947d-b3ce03d835a7"></a>
##Public Virtual Void MouseDragged (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Handles the user dragging the mouse.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="315b81af-21a9-4163-a677-8559f5451cb2"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse drag.</p>
</td></tr></table></p>


---

<a name="a19cba97-b16a-408d-9fa7-e3d1eea4fd41"></a>
##Public Virtual Void MouseDragged (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Handles the user dragging the mouse.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="2e6b6861-8748-40f3-8375-15b80ee48ebd"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse drag.</p>
</td></tr></table></p>


---

<a name="e2dd1d2d-fed9-4fab-a37f-5f985f1ddb99"></a>
##Public Virtual Void MouseDragged (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Handles the user dragging the mouse.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="8206cd48-4335-4300-967e-52b86736ee87"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse drag.</p>
</td></tr></table></p>


---

<a name="52546b43-ca67-408d-a3bb-29a9dc4517ad"></a>
##Public Virtual Void MouseMoved (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Handles the user moving the mouse.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="30d1bd5d-c7e5-4935-8812-0ea0a041e731"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse move.</p>
</td></tr></table></p>


---

<a name="2e74e6bc-0f7c-4acf-aa84-197427bc27c8"></a>
##Public Virtual Void MouseMoved (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Handles the user moving the mouse.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="ca4e2f78-8b25-4f13-97d3-76e11786fa1a"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse move.</p>
</td></tr></table></p>


---

<a name="e5521dc9-02da-4ccf-ab2d-02b9ed0c7ec5"></a>
##Public Virtual Void MouseMoved (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Handles the user moving the mouse.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="8d139b63-e8e5-447d-a887-71b0e0e582c4"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse move.</p>
</td></tr></table></p>


---

<a name="626e6c8c-c1c9-4fd5-b945-487721bfda91"></a>
##Public Virtual Void MouseUp (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Handles the user releasing a mouse button.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="ea4d1bc1-f148-4371-8127-9bbf065653b8"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse up.</p>
</td></tr></table></p>


---

<a name="62aa29f1-efde-409a-a57e-30e5fb6a67db"></a>
##Public Virtual Void MouseUp (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Handles the user releasing a mouse button.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="8ddb3333-0fd0-42e7-b781-ca097faff6d8"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse up.</p>
</td></tr></table></p>


---

<a name="848d424c-0b25-4b83-98d4-b84aed0f7f30"></a>
##Public Virtual Void MouseUp (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Handles the user releasing a mouse button.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="c0678646-fe07-4d50-b9af-59f0cc28a52e"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse up.</p>
</td></tr></table></p>


---

<a name="111b6f2b-084a-4169-8655-d19216cbb8a5"></a>
##Public Virtual Void MoveBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Moves the bounds to the given point.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="5b9c1d3d-bca0-4dd9-a8e1-a15cc5b931e4"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new top, left location as a <code>SKPoint</code>.</p>
</td></tr></table></p>


---

<a name="c149f55b-7788-4af6-8200-f230c83d7053"></a>
##Public Void MoveLastPoint (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Moves the last point added to the new position.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="51476946-3f2c-4995-9570-96cccf5faebd"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>


---

<a name="2e67413e-ea98-485c-8d91-0bca71968f68"></a>
##Public Void MoveSelectedShapeBackwards ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Moves the selected shape backwards.

---

<a name="4fa648db-e2ff-4798-b953-7149538301cb"></a>
##Public Void MoveSelectedShapeBackwards ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Moves the selected shape backwards.

---

<a name="d7f1c2a1-e865-4f27-9f7e-fcbd0cbf0747"></a>
##Public Void MoveSelectedShapeForwards ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Moves the selected shape forwards.

---

<a name="d84b626c-965a-4294-b2f6-d3417aaaa768"></a>
##Public Void MoveSelectedShapeForwards ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Moves the selected shape forwards.

---

<a name="162ed250-dce5-491a-ac82-841e1c2d8a8c"></a>
##Public Void MoveSelectedShapeToBottom ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Moves the selected shape to bottom.

---

<a name="bc010cc3-e1ae-4ace-b6ce-6f39df119ab5"></a>
##Public Void MoveSelectedShapeToBottom ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Moves the selected shape to bottom.

---

<a name="d2e0ae0d-4c21-49ab-ba2d-2bb1058a9247"></a>
##Public Void MoveSelectedShapeToTop ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Moves the selected shape to top.

---

<a name="61367b3c-83d9-4f8d-99b2-0ddcc87703a1"></a>
##Public Void MoveSelectedShapeToTop ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Moves the selected shape to top.

---

<a name="94ecbd32-b618-4e86-beed-34e2f9f61c53"></a>
##Public Void MoveTo (System.Single, System.Single)

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Moves the handle to the given coordinates.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="6a254260-e356-425f-9d94-81cf18195706"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="d9e5a3ac-6796-462a-b0e9-d093df746f6c"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>


---

<a name="95dfdbbe-df39-4cb8-a891-b65698e1154d"></a>
##Public Void PlaceUnderConstruction (System.Boolean)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Places the bounds under construction.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>needsHandles</td><td style='width:75%' ><p><a name="1489b8f5-59be-4689-a23f-7d5b093c63c6"></a>
<b>System.Boolean needsHandles</b></p>

<p>If set to <code>true</code> needs handles.</p>
</td></tr></table></p>


---

<a name="b7c204cb-f7ca-44f6-8b27-68eb9b255359"></a>
##Public `System.Boolean` PointInBound (SkiaSharp.SKPoint)

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Test to see if the given point is inside of the current bounds
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="8344698a-42d0-4f14-b136-672e329cecb0"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>

###Returns

`true`, if in bounds, `false` otherwise.

---

<a name="41dfa140-a26d-4417-8070-774cea380a39"></a>
##Public Virtual `System.Boolean` PointInBound (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Test to see if the given point is inside the bounds of this group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9682c2b9-d0cc-4346-81c7-4f739e4284d4"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to test for.</p>
</td></tr></table></p>

###Returns

`true`, if the point was in bounds, `false` otherwise.

---

<a name="a0214361-2a90-4cc4-bc84-779105caed23"></a>
##Public Virtual `System.Boolean` PointInBound (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Tests to see if the given point is inside the bounds of the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="29190c8d-824b-431e-ae6a-2f109eb30e8e"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

###Returns

`true`, if in bound was pointed, `false` otherwise.

---

<a name="908692e6-318f-4628-9f3c-4153f3ab917c"></a>
##Public Virtual `System.Boolean` PointInBound (SkiaSharp.SKPoint)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Test to see if the given point is inside of the current bounds
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ce790539-f773-464c-9034-e90409849cd3"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>

###Returns

`true`, if in bounds, `false` otherwise.

---

<a name="ff4c2324-f4e8-444f-b84f-481b3b2e6f8f"></a>
##Public [KimonoCore.KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0) PopRedoPoint (KimonoCore.KimonoPortfolio)

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Pops the redo point off the stack.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="5fc63dae-4e4f-4318-9806-d96e151b9a7a"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

###Returns

The previous state of the `KimonoPortfolio`.

---

<a name="bd9d4508-7d9b-4cd2-b6d1-3ffa9f880e07"></a>
##Public [KimonoCore.KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0) PopUndoPoint (KimonoCore.KimonoPortfolio)

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Pops the undo point off the stack.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="36ee82e2-af90-4add-9a3d-14263c58df18"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

###Returns

The prior state of the `KimonoPortfolio`.

---

<a name="938369db-4f4b-46f2-aab4-e9e40ceeb6c8"></a>
##Public Void PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Handles the user clicking a control point in the gradient preview.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="277dc960-75a1-4b5e-aea6-2f6eb11061cb"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="a923e8df-08dc-4f33-bb88-8504365ee1e9"></a>
<b>System.Int32 clicks</b></p>

<p>The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="c5cbcc25-f062-48ee-b136-f0a0aa506e1c"></a>
<b>System.Boolean multiSelect</b></p>

<p>If set to <code>true</code> multi select.</p>
</td></tr></table></p>


---

<a name="3542c564-4471-4041-bdbf-18ec53a24664"></a>
##Public Void PreviewToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Handles the user draging a control point in the gradient preview. 
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="35b6aff3-8146-467f-b7ff-56bd64b4d5ff"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new location.</p>
</td></tr></table></p>


---

<a name="6967bed2-cc92-4902-8a7a-70c37123ac99"></a>
##Public Void PreviewToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Handles the user releasing a control point in the gradient preview.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="99d57cdb-9945-475e-b867-e9e6ff97abb5"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>


---

<a name="35b7f7c0-e823-4a89-b454-e2909b0616b1"></a>
##Public Void PushUndoPoint (KimonoCore.KimonoPortfolio)

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Pushes the undo point onto the stack.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="14991e81-d1e2-4f4d-9bfd-4c9d37038b27"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>


---

<a name="2249794f-9407-4289-a5cc-149f596105e0"></a>
##Void RaiseBlurModified ()

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Raises the blur modified event.

---

<a name="284ad5e6-e263-4ab4-ae68-95172a823e29"></a>
##Void RaiseColorChanged ()

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Raises the color changed event.

---

<a name="2e7e2ac5-0682-4a50-8543-5c7c434805fa"></a>
##Void RaiseColorsModified (KimonoCore.KimonoColor)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the colors modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="2f61cb50-b0d8-46d8-be20-f5f5dcc0fb59"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>


---

<a name="8dac4f41-1777-48bc-b2a3-25f65af9dd98"></a>
##Void RaiseColorsModified (KimonoCore.KimonoColor)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the colors modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="ef9d356e-7eca-4496-be43-58e706dfb645"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>


---

<a name="053bc160-15a8-48c3-8b22-efa7d0aebfa4"></a>
##Void RaiseGradientModified ()

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Raises the gradient modified event.

---

<a name="eb04dc7f-3c80-4f88-8534-34e67fdb1268"></a>
##Void RaiseGradientModified ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Raises the gradient modified event.

---

<a name="a5a0df3d-1348-47fd-a8ee-b8efe779d0bc"></a>
##Void RaiseGradientsModified (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the gradients modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="413824e1-5fc1-42fd-a490-dfdf3509d61a"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>


---

<a name="8ab90732-02f6-4f4b-a098-934a373fef1e"></a>
##Void RaiseGradientsModified (KimonoCore.KimonoGradient)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the gradients modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="252dbdd9-cb8b-4b33-abdc-798058eabd72"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>


---

<a name="cc3d318c-65d9-40ff-af2f-81b939ea750f"></a>
##Void RaiseHandleSelected (KimonoCore.KimonoHandle)

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Raises the handle selected event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="860f62f5-22c5-43cb-949e-2e1ebe4f4324"></a>
<b>KimonoCore.KimonoHandle handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="95b8307b-736d-4716-8a45-92d895497730"></a>
##Void RaiseHandleSelected (KimonoCore.KimonoHandle)

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Raises the handle selected event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="578ce48f-9a90-412f-af30-3257551ab9dd"></a>
<b>KimonoCore.KimonoHandle handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="582988a3-91a5-494b-8274-c6ce1a1716db"></a>
##Void RaiseHandleSelected (KimonoCore.KimonoHandle)

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Raises the handle selected event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="be743bee-52c9-47b7-80f2-cbbba5994d28"></a>
<b>KimonoCore.KimonoHandle handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="805aaeaf-ccf4-4506-b6e5-c98a349edb53"></a>
##Void RaiseImageBufferNeedsRefresh ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Raises the image buffer needs refresh event.

---

<a name="a421db20-36bb-4293-a157-e9f27a99bf05"></a>
##Void RaiseMoved (SkiaSharp.SKPoint)

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Raises the moved event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="4c436d6e-7063-4e7a-a7cf-d34418d056c2"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>


---

<a name="a018b084-2c40-4ddd-876c-3f94a555322a"></a>
##Void RaiseReloadUI ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the reload user interface event.

---

<a name="f0d27747-35ab-4820-a96d-621244273ef3"></a>
##Void RaiseRequestNewUndoPoint ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the request new undo point event.

---

<a name="f118e99a-7767-4244-b6d4-4271c3a0e9d2"></a>
##Void RaiseRequestNewUndoPoint ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Raises the request new undo point event.

---

<a name="ec6a6466-b9b1-40ea-a3da-4587c14d978d"></a>
##Void RaiseSelectedShapeChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the selected shape changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="2f1a0fe7-1ac8-4926-8c83-7b9bc3378661"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>The new <code>KimonoShape</code> that was selected.</p>
</td></tr></table></p>


---

<a name="119ca242-04cd-4263-b145-c11edb20200d"></a>
##Void RaiseSelectedShapeModified ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Raises the selected shape modified event.

---

<a name="eb45e31c-8a93-42d1-89be-d6b70d212abb"></a>
##Void RaiseSelectedShapeModified ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the selected shape modified event.

---

<a name="d0938b09-4b96-438b-b985-2d63e18e7a76"></a>
##Void RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the selected sketch did change event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="842255f4-c3a7-428e-9b4a-9bd827061f51"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> that did change.</p>
</td></tr></table></p>


---

<a name="7fd107a3-15f0-4ca3-a478-fb19db06b565"></a>
##Void RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the selected sketch will change event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="12784a1e-ab35-46f4-9dd6-3185611c8567"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> that will change.</p>
</td></tr></table></p>


---

<a name="0fa28ea7-b26f-48c1-bfae-c223d6f4527c"></a>
##Void RaiseSelectionChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Raises the selection changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="00b57898-02f3-48c3-a38b-47e42b003a49"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>Selected.</p>
</td></tr></table></p>


---

<a name="702e07f6-e5b3-4c8a-9847-a1685bf03e17"></a>
##Void RaiseSelectionChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the selection changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="a8bb4cab-8f00-491e-9aec-2f32d3c75e65"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>The new <code>KimonoShape</code> selected.</p>
</td></tr></table></p>


---

<a name="15af7e34-1e34-4455-8c0a-1055bb924bbf"></a>
##Void RaiseShadowModified ()

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Raises the shadow modified event.

---

<a name="c0741924-a677-4feb-bfa3-32dbe7f8f054"></a>
##Void RaiseSketchesModified ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the sketches modified event.

---

<a name="4816e90c-db04-47f8-bef1-38d0151e3443"></a>
##Void RaiseSketchesModified ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the sketches modified event.

---

<a name="4e71d83b-23bb-47ae-965a-36965c240c50"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the sketch modified event.

---

<a name="31addf06-c564-46c4-83e3-df82d3e662b3"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Raises the sketch modified event.

---

<a name="b2f04fe7-1238-4e27-b6b6-010cc1aa6bfb"></a>
##Void RaiseSketchSizeChanged ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Raises the sketch size changed event.

---

<a name="9c1e5c4d-9989-4811-b1cc-623ac416916f"></a>
##Void RaiseSketchSizeChanged ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the sketch size changed event.

---

<a name="a48ebba8-f27f-4d50-9064-4d5e1847b7cd"></a>
##Void RaiseStylesModified (KimonoCore.KimonoStyle)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the styles modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="091af394-ea28-4dd7-9f9e-697e3a673609"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>


---

<a name="da3b8cfe-b594-4f96-b4ee-21e36b4162f5"></a>
##Void RaiseStylesModified (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Raises the styles modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="625bbfd7-b90e-4776-a86b-4762f6bb5746"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>


---

<a name="f7571b28-6acf-4eec-b86d-74d90396901c"></a>
##Void RaiseToolChanged (KimonoCore.KimonoTool)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the tool changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="6b37c582-f675-4935-a1a5-a7bf513c9327"></a>
<b>KimonoCore.KimonoTool tool</b></p>

<p>The new <code>KimonoTool</code> selected.</p>
</td></tr></table></p>


---

<a name="76dc0b14-79c0-44eb-949b-b1940c765f05"></a>
##Void RaiseToolChanged (KimonoCore.KimonoTool)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Raises the tool changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="03927138-f748-4517-9390-7db60139285d"></a>
<b>KimonoCore.KimonoTool tool</b></p>

<p>The new <code>KimonoTool</code> that has been selected.</p>
</td></tr></table></p>


---

<a name="5db34ede-6d39-41e8-9078-2106b0f207a6"></a>
##Void RaiseUndoStateChanged ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Raises the undo state changed event.

---

<a name="05a485fa-32c7-4ed4-a2f0-71a0d4a35c45"></a>
##Void RaiseUndoStateChanged ()

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Raises the undo state changed event.

---

<a name="d2756574-fd9a-4258-8b23-a586859834ec"></a>
##Public Void RecalculateGroupBounds ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Recalculates the group bounds to encompass every `KimonoShape` inside this group.

---

<a name="9378c715-cb15-42c2-9d50-467a68b10dfa"></a>
##Public Void RecalculateLayerDepths ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Recalculates the layer depths.
###Remarks

Layer depths are used to maintain the front to back order of the `KimonoShapes` that for the sketch.

---

<a name="bebc0de4-f909-4860-b2db-6e5d2c92fa42"></a>
##Public Void RecalculateLayerDepths ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Recalculates the layer depths.
###Remarks

Layer depths are used to maintain the front to back order of the `KimonoShapes` that for the sketch.

---

<a name="780b4f80-0980-49f9-b69b-71940000ec98"></a>
##Public Void RecalculateVectorBounds ()

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Recalculates the vector bounds to encompas all of the data points that define the shape.

---

<a name="b5145c4c-e9b2-4ac6-b673-98ab0c3378ff"></a>
##Public Void Redo (Foundation.NSObject)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Redoes the last change.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5ecbe09b-ce39-49e3-ad8c-51ff24493ba3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="baaf9a9b-fe57-47e9-bf8b-fb9b27a2b66f"></a>
##Public Void RedoChange ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Redoes the last change.

---

<a name="3466be51-b652-4f37-9646-68aa7617730a"></a>
##Public Void RefreshView ()

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Refreshs the view by redrawing the gradient design bar.

---

<a name="367f9497-ecf8-4cf9-85b2-60482d020e46"></a>
##Public Void RefreshView ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Refreshs the Design Surface's view by redrawing the currently selected `KimonoSketch`.

---

<a name="1aff2631-1223-42ad-9272-20f5490d2ecc"></a>
##Public Void RefreshView ()

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Refreshs the view by redrawing the gradient design bar.

---

<a name="91955ef4-d030-4139-9ca1-3e083a1b3b30"></a>
##Void RelinkColors ()

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Relinks the colors after a clone operation.

---

<a name="80fda76d-f2b8-4851-a034-2f0a8f4d4b21"></a>
##Void RelinkGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Relinks the gradient after a clone operation.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="e5c13e5d-afca-45e7-a260-f4ee171c765f"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to relink.</p>
</td></tr></table></p>


---

<a name="735421e6-15a4-456c-a746-84773194cf79"></a>
##Void RelinkShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Relinks the given `KimonoShape` after a clone operation.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="6dbee1a3-8f9f-4d3c-ad60-645244c20edb"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>


---

<a name="dbbecdc6-032e-47bc-bffd-ece0c509929b"></a>
##Void RelinkShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Relinks the given shape after a clone operation.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="a747d779-eff4-482b-b01f-744f41dee47f"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>


---

<a name="25048fcf-276b-44d9-ae33-c75d60402c1b"></a>
##Void RelinkShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Relinks the shape after a clone operation.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="71b9163f-defd-4e4a-aba4-d75fec685513"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>


---

<a name="f466d50d-208a-4784-a006-ce665cb8d6f8"></a>
##Void RelinkSketch (KimonoCore.KimonoSketch)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Relinks the given `KimonoSketch` after a clone operation.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="790ff70c-f4f0-49e7-b105-5cbb771f58b6"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> to relink.</p>
</td></tr></table></p>


---

<a name="c36665f0-73de-47df-8780-ba60545cbb9f"></a>
##Void RelinkStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Relinks the given `KimonoStyle` after a clone operation.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="6507f032-cf8b-4d04-8687-84149fa310ae"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to relink.</p>
</td></tr></table></p>


---

<a name="c1aae215-bc94-4775-bbbb-d1cbf2464f05"></a>
##Void RemoveHandles ()

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Removes the control handles from the bounds.

---

<a name="988ef738-80be-4655-8f41-bfdccc5eb231"></a>
##Public Void RemovePoint (System.Int32)

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Removes the given point.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="1a288d2b-228a-483d-ad88-e4c976b37a9a"></a>
<b>System.Int32 n</b></p>

<p>The index of the point ot remove.</p>
</td></tr></table></p>


---

<a name="65534f18-0956-4e0d-8082-8d034cbb7c1e"></a>
##Public Void RemoveShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Removes the given `KimonoShape` from the group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="c54a5839-f6a2-49a8-92ae-461791d50150"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>


---

<a name="24c33c3c-36ef-4912-9147-a174d6b901e6"></a>
##Public Void ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Replaces the last undo point with the one being passed in.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="3362eb14-27cc-4ca5-949a-611a3a7ff3cf"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>


---

<a name="d37055c9-93a5-44cd-9b11-d87eee032243"></a>
##Public Void ReplaceUndoPoint ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Replaces the last undo point.

---

<a name="5c0ce1f2-5ed8-4cf6-8ee6-baf130ae1bd4"></a>
##Public Void ReturnToSketch ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Returns to base parent `KimonoSketch` for this group.

---

<a name="6a52a98f-94f7-4736-b393-4d04a5c5707d"></a>
##Void SavePreviousBounds ()

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Saves the previous bounds.

---

<a name="42cf8f62-b989-4b70-8170-f2dce3a078c5"></a>
##Private Void SavePreviousSize ()

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Saves the previous size of the sketch.

---

<a name="5d53b768-d46a-4197-a3f2-7c1bccb17359"></a>
##Public Void SaveUndoPoint ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Saves a new undo point.

---

<a name="fdfc2a71-3bd1-46ce-a7b3-d9295a2dacfd"></a>
##Public Void Select ()

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Puts the `KimonoShape` into the edit mode and creates the edit handles as required.

---

<a name="1e3dca59-6793-4429-85ed-b349e20c1333"></a>
##Public Void SelectShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Selects the given shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="37f723bd-4cd9-47f7-8e60-6a124ee0d783"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to select.</p>
</td></tr></table></p>


---

<a name="088ee476-9519-4fc7-ae07-c6a8552993ce"></a>
##Public Void SelectShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Selects the given `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="da00a93b-a846-4fbd-a726-1819f9076a13"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>


---

<a name="4e64e8fe-9611-4ba5-b611-1126d99beee8"></a>
##Public `System.Boolean` ShapeInGroup (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Test to see if the given `KimonoShape` is a part of this group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="b3ea5e58-4b11-4c5a-90ad-b87609276c69"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to test for.</p>
</td></tr></table></p>

###Returns

`true`, if in shape is in the group, `false` otherwise.

---

<a name="76ebd85b-4bee-48c0-bd35-11c8bb73172a"></a>
##Private `SkiaSharp.SKColor[]` SortedColors ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Returns a list of sorted colors by their "X" location inside the gradient.
###Returns

The sorted colors arrays.

---

<a name="455367ef-a628-4bdd-b8eb-0479489020bb"></a>
##Private `System.Single[]` SortedWeights ()

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Returns a list a color weights by their "X" location in the gradient.
###Returns

The sorted weights.

---

<a name="bc0fdfe3-a004-454a-8be7-a597e96b1471"></a>
##Public Virtual Void StartEditing ()

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Places the shape into the editing mode where the user can adjust the individual data points that define the shape.

---

<a name="cb38d4ea-8314-44e7-bb0d-9d2310e8300d"></a>
##Public Virtual Void StartEditing ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Starts editing this group.

---

<a name="ab0ae3ee-1f0e-4623-991c-1702ac8bf8f4"></a>
##Public Virtual Void StartEditing ()

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Places the shape in the editing mode.

---

<a name="73d48c96-d7fb-41fd-ad9f-9dbeded2296f"></a>
##Public Void StartGrouping ()

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Starts the bounds grouping.

---

<a name="979c02a6-1655-48f4-b78c-7a28290763c1"></a>
##Public Void ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Handles the user placing the current `KimonoTool` down on the group's Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="fd489836-ed0d-4f4d-80cd-e0c9da7ced42"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="0a631155-3651-46e7-8a37-fa7e545227e2"></a>
<b>System.Int32 clicks</b></p>

<p>The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="0225e6c3-47be-47f7-bc42-01f31e52811f"></a>
<b>System.Boolean multiSelect</b></p>

<p>If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>


---

<a name="6158396f-f6a5-426d-bfc9-a136bbfda960"></a>
##Public Void ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Handles the user placing the current `KimonoTool` down on the sketch's Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="7571980a-a9f8-46cd-a96a-4fcd39a942ac"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="589d19ec-f17f-409b-a797-22b9c5484b7c"></a>
<b>System.Int32 clicks</b></p>

<p>The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="9acff2df-bce1-44c3-be2b-49ceea887b0f"></a>
<b>System.Boolean multiSelect</b></p>

<p>If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>


---

<a name="695765c3-7cd3-43d2-a8f3-13a0068aa18f"></a>
##Public Void ToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

The public `ToolDrag (SkiaSharp.SKPoint)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="bc6126ff-3e88-4627-8a98-1715d41a8d4f"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>point</code> parameter of the ToolDrag method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="55e09c92-9be7-4e9f-912f-1853f54793a6"></a>
##Public Void ToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Handle the user dragging the selected `KimonoTool` on the sketch's Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d3f1b2b4-946c-4d93-ac31-c274429fde16"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> representing the new tool position on the Design Surface.</p>
</td></tr></table></p>


---

<a name="2286c8fe-5ce2-4ec7-9cbd-c282577efd9d"></a>
##Public Void ToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Handles the user lifting the current `KimonoTool` off of the sketch's Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="c2d414ac-92a8-4dcd-9a7a-a76a4aa6d12f"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> where the user lifted up the tool.</p>
</td></tr></table></p>


---

<a name="27c43834-3700-4bca-bf7e-f10bf7bebcb0"></a>
##Public Void ToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

The public `ToolUp (SkiaSharp.SKPoint)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="23bd55cf-b05e-4aab-913c-ea8e42dd060d"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>point</code> parameter of the ToolUp method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="62d9879c-e27a-4afe-89c0-8badbe0fc119"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="680186bf-3718-462c-bffd-0506c3083015"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="4a5ab9c7-9d6d-4eee-9b3b-fd209ba39a47"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeRect](#85d708a0-1446-4e21-9ba3-961994114384)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="999827cd-4058-45e4-97b3-76f4ef4b95a3"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapePolygon](#503226d4-73b7-4ece-8096-a9cc509a2752)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="3afd1d7f-3967-4006-a425-c988a85ec2b7"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeTriangle](#5df8659c-9e94-4a72-8cbf-d6e33a87da2b)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="36662fb8-e588-4ff6-983b-2ff8fdcdbd61"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeArrow](#ae7d9bfe-d26d-4656-b90e-3c234e3fb535)

###Summary

Converts the arrow to a path.
###Returns

The the arrow as a `SKPath`.

---

<a name="109851b6-23bd-4df4-a20b-e6f178e015fc"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Converts the group of shapes to a path.
###Returns

The group of shapes as a `SKPath`.

---

<a name="5a9c4ac0-4e82-4923-a9fd-66d688ecaf7d"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeRoundRect](#429ac09f-fc9f-44ab-a634-e41870b8350a)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="30fe722b-4af6-4005-a0af-cc0002b5505c"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeLine](#7849552a-49ed-4035-a1df-0fa7bfe40516)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="c6007cd4-7d1a-4d47-8b88-8ecf26d9b076"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="4823dbd6-8568-4466-9b40-ff270f8f0856"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeText](#d36ff3bb-39d5-48cb-93d9-6cd1d36f9aaf)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="fc114963-aa32-48e0-8872-9653d1b0f727"></a>
##Public Virtual `SkiaSharp.SKPath` ToPath ()

###Member of Type

[KimonoShapeOval](#5ae119e2-ae85-45bc-9f1d-26cf8a5e19fd)

###Summary

Converts the current shape to a path.
###Returns

The shape as a `SKPath`.

---

<a name="6f23f0f7-0615-4356-bd47-e286c312190b"></a>
##Public Virtual [KimonoCore.KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850) ToVector ()

###Member of Type

[KimonoShapeStar](#dea1abbc-1d3b-4c51-9ef9-257afde86f76)

###Summary

Converts the star into a vector.
###Returns

The `KimonoShapeVector` version of the star.

---

<a name="323ce27d-5a1a-41d1-91fa-fb41386bb459"></a>
##Public Virtual [KimonoCore.KimonoShapeVector](#fb84c492-9888-473d-932e-a6bb3e440850) ToVector ()

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Converts the current shape to a vector.
###Returns

The shape as a `KimonoVector`.

---

<a name="b89f7a43-bed8-4982-a12b-ee76147478af"></a>
##Public Virtual Void UncoupleDeletedStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoShape](#4e0e6705-6811-444f-99e3-3670c315a4b5)

###Summary

Uncouples the deleted style from the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deletedStyle</td><td style='width:75%' ><p><a name="faf8740f-1507-438c-99fb-8951459b8406"></a>
<b>KimonoCore.KimonoStyle deletedStyle</b></p>

<p>The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>


---

<a name="cd8e9aba-81d7-41b2-8138-d9d02aff5e54"></a>
##Public Void Undo (Foundation.NSObject)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Udoes the last change.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="83b0fab2-e971-46f8-82f5-2305f1e43dd5"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="c20936fd-4570-47d8-a75c-d2fa6e2d9a04"></a>
##Public Void UndoChange ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Undoes the last change.

---

<a name="80205958-ba80-4035-86d8-3aeeab3bb2ff"></a>
##Public Void UngroupShapes ()

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Ungroups the shapes in this group.

---

<a name="1e15a5c9-6d49-4abe-bacb-ca55444ca889"></a>
##Public Void UngroupShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Ungroups the shapes in the parent group.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="754f8239-583d-43e9-84b2-6f1db424bfd4"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>


---

<a name="fa334db9-e5da-4a42-9e08-fd4a4b68358a"></a>
##Public Void UngroupShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#4396bdd6-990a-4ec6-9417-494b96ad9978)

###Summary

Ungroups the shapes in the parent sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="5a506c08-a401-4225-b864-74da683b5aa2"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>


---

<a name="54d12fdb-3ab8-41ee-bb4c-518561f4bb2c"></a>
##Public Void Unselect ()

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Unselects the `KimonoShape` as the current edit target and removes any edit handles.

---

<a name="f2aa59cb-3368-49c5-8afc-21fadaa72880"></a>
##Private Void UnwirePortfolioEvents ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Unwires the portfolio events from this Design Surface.

---

<a name="b539a0a3-d40b-4050-9d90-718ca0bc99b7"></a>
##Private Void UnwireSketchEvents (KimonoCore.KimonoSketch)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Unwires the sketch events from this Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="5bbcbad4-aa68-4cb7-bf91-aab7813c15be"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> to remove events from.</p>
</td></tr></table></p>


---

<a name="47672832-44cd-421c-8616-b23b691af103"></a>
##`System.Boolean` ValueBetween (System.Single, System.Single, System.Single)

###Member of Type

[KimonoBounds](#639c6397-7290-4595-a07f-28187ab889ac)

###Summary

Checks to see if the given value is between the two given points.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="1b23b497-00ff-4da0-82a7-4bdef818c629"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>a</td><td style='width:75%' class='def'><p><a name="e161a3c2-9c83-42d9-9c7b-b51500c4405d"></a>
<b>System.Single a</b></p>

<p>The alpha component.</p>
</td></tr><tr><td style='width:25%' class='term'>b</td><td style='width:75%' ><p><a name="cf248ac7-6bc9-4716-a202-b324c46de031"></a>
<b>System.Single b</b></p>

<p>The blue component.</p>
</td></tr></table></p>

###Returns

The `Boolean`.

---

<a name="95e7ae76-a456-4e74-9950-3ad463534baf"></a>
##Private Void WireupPortfolioEvents ()

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Wireups the portfolio events to this Design Surface.

---

<a name="5b898744-6182-47ba-80dd-39fc7b83639d"></a>
##Private Void WireUpSketchEvents (KimonoCore.KimonoSketch)

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Wires up sketch events to this Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="7f201889-f8f2-479a-9456-8af1a8939e33"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoStech</code> to wire events for.</p>
</td></tr></table></p>

<a name="Events"></a>
#Events


---

<a name="4f08637d-4bbc-4fca-bbd1-9ec1e4cc23dd"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) BlurModified

###Member of Type

[KimonoBlur](#fae21e79-93eb-42b6-b762-561f41464dce)

###Summary

Occurs when the blur is modified.

---

<a name="9197a98a-f3f7-468a-9fdb-2d6814d653ef"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ColorChanged

###Member of Type

[KimonoColor](#41122ae8-4826-48b0-8e4a-ee3184785b85)

###Summary

Occurs when color changed.

---

<a name="0a1a982d-8789-4000-9b9a-8e118c2504fd"></a>
##[KimonoCore.Kimono.ColorEventDelegate](#25985d5b-a2ce-424e-be45-441f59aa7c43) ColorsModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when colors collection is modified.

---

<a name="e37968b1-adfc-410d-bf49-46508369282f"></a>
##[KimonoCore.Kimono.ColorEventDelegate](#25985d5b-a2ce-424e-be45-441f59aa7c43) ColorsModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when colors collection is modified.

---

<a name="7c6ed5c3-3667-4149-b746-5d46a43e20d9"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) GradientModified

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Occurs when the gradient is modified.

---

<a name="2a20f97f-45f9-4d9e-971f-4aad99e9dc9f"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) GradientModified

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Occurs when the gradient is modified.

---

<a name="0e42ff13-7b6e-4499-ab7a-83d24e82f8bb"></a>
##[KimonoCore.Kimono.GradientEventDelegate](#6c8be89d-0395-4113-848e-8d6c6db2db41) GradientsModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when gradients collection is modified.

---

<a name="c6b766e6-e4d4-431a-831f-e814201fed73"></a>
##[KimonoCore.Kimono.GradientEventDelegate](#6c8be89d-0395-4113-848e-8d6c6db2db41) GradientsModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when gradients collection is modified.

---

<a name="872a9106-1fbb-4870-91f2-88ddd18c76df"></a>
##[KimonoCore.Kimono.HandleEventDelegate](#5436152c-1852-4971-8005-73d9893d5536) HandleSelected

###Member of Type

[KimonoGradientDesignBar](#280365ed-8698-43da-8044-88ca04124c8f)

###Summary

Occurs when a handle is selected.

---

<a name="addc346e-1564-40ec-a52c-9254dd268c6b"></a>
##[KimonoCore.Kimono.HandleEventDelegate](#5436152c-1852-4971-8005-73d9893d5536) HandleSelected

###Member of Type

[KimonoGradient](#b165c88b-a830-4f7a-849f-eeecab4d05cb)

###Summary

Occurs when a handle is selected.

---

<a name="15e2ddcf-834e-4631-a0d5-cdc1dc68ffaf"></a>
##[KimonoCore.Kimono.HandleEventDelegate](#5436152c-1852-4971-8005-73d9893d5536) HandleSelected

###Member of Type

[KimonoGradientDesignPreview](#add08d63-303c-40cb-84f2-e7c69c7c114f)

###Summary

Occurs when a handle is selected.

---

<a name="a7d0b8b7-1b8d-4087-9d51-220a4b86d74d"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ImageBufferNeedsRefresh

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Occurs when image buffer needs refresh.

---

<a name="0d100c12-157d-4d71-a49f-fc852e68fc13"></a>
##[KimonoCore.Kimono.SkiaPointEventDelegate](#bfbe96be-6e35-47b9-a948-05247f47ad11) Moved

###Member of Type

[KimonoHandle](#d3a2ffd3-76f2-4474-98da-a70eef7c09d8)

###Summary

Occurs when moved.

---

<a name="945cda63-4b44-44a6-9062-7126d18a7eff"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ReloadUI

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when the user interface needs to be fully reloaded.

---

<a name="20c91322-0579-4cb8-bf40-d1e98bcf84b7"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) RequestNewUndoPoint

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when a new undo point is requested.

---

<a name="13304b3a-7b6a-4c92-bfeb-0aa7216634b1"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) RequestNewUndoPoint

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Occurs when a new undo point is requested.

---

<a name="e123802c-a03d-4df2-bbcc-44bb5bd2737a"></a>
##[KimonoCore.Kimono.ShapeEventDelegate](#d433a563-8929-4467-a4a2-cec7dd75d576) SelectedShapeChanged

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when selected shape changed.

---

<a name="f203ebcb-64a8-46fd-9bf7-30e271c4db9c"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SelectedShapeModified

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Occurs when selected shape is modified.

---

<a name="e147e22a-8c1c-4c5f-853b-020b17d4df95"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SelectedShapeModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when the selected shape is modified.

---

<a name="c09ac749-25db-49eb-b6ec-8a4193df5e16"></a>
##[KimonoCore.Kimono.SketchEventDelegate](#a7beb193-d36a-4580-843e-5cf6a6983896) SelectedSketchDidChange

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when selected sketch did change.

---

<a name="7d35c9a3-67c0-4f0b-88fb-da546eb5cd73"></a>
##[KimonoCore.Kimono.SketchEventDelegate](#a7beb193-d36a-4580-843e-5cf6a6983896) SelectedSketchWillChange

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when selected sketch will change.

---

<a name="ccbef80f-c2f2-42cc-af42-95cdc14fdfaa"></a>
##[KimonoCore.Kimono.ShapeEventDelegate](#d433a563-8929-4467-a4a2-cec7dd75d576) SelectionChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when selection changed.

---

<a name="f02037b8-a122-4d12-9c90-4f856a13dfdd"></a>
##[KimonoCore.Kimono.ShapeEventDelegate](#d433a563-8929-4467-a4a2-cec7dd75d576) SelectionChanged

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Occurs when selection changed.

---

<a name="292efbbe-8921-468d-b1d8-e88d0a66806c"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) ShadowModified

###Member of Type

[KimonoShadow](#68d5259e-c294-48fc-bed4-4590fa128565)

###Summary

Occurs when the shadow is modified.

---

<a name="2af98e1e-fec0-40c2-8cab-7ae7d82d0c4d"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchesModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when sketches collection is modified.

---

<a name="e2a2ea53-8a83-4cb6-8b75-766a396cbe91"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchesModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when sketches collection is modified.

---

<a name="7940b021-0660-4307-8eba-0fa0b6fa708e"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when a sketch is modified.

---

<a name="25cee5d5-fcd6-45c2-b90a-3b60261ba9b0"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchModified

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Occurs when sketch modified.

---

<a name="939730ae-1c7d-48c2-833a-277d4f5f2f31"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchSizeChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when sketch size changed.

---

<a name="70c9add0-f113-4356-aef2-b5570b386311"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) SketchSizeChanged

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Occurs when sketch size changed.

---

<a name="892c64c3-fce5-4e2a-8d2d-1b3a61ba8b6f"></a>
##[KimonoCore.Kimono.StyleEventDelegate](#2aaf4313-c5a8-46c4-ba3e-028f99e9950e) StylesModified

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when styles collection is modified.

---

<a name="ac1ffa01-ac9a-4fb7-9a61-79c32dd2e51f"></a>
##[KimonoCore.Kimono.StyleEventDelegate](#2aaf4313-c5a8-46c4-ba3e-028f99e9950e) StylesModified

###Member of Type

[KimonoPortfolio](#195f0884-2949-40da-ab6c-5df36b4f88a0)

###Summary

Occurs when styles collection is modified.

---

<a name="6a392ed6-6439-4b3c-bd25-2728f5ac3f8f"></a>
##[KimonoCore.Kimono.ToolEventDelegate](#4a5cb542-03c0-4c45-b57f-4528c185e19f) ToolChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when tool changed.

---

<a name="44454a9c-ecde-43e1-8c34-84aea2837d92"></a>
##[KimonoCore.Kimono.ToolEventDelegate](#4a5cb542-03c0-4c45-b57f-4528c185e19f) ToolChanged

###Member of Type

[KimonoSketch](#aec876fe-5a0c-43d7-830e-67738d4a5435)

###Summary

Occurs when tool changed.

---

<a name="5dfa405a-a3ef-43c2-905f-d0f526ae4759"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) UndoStateChanged

###Member of Type

[KimonoUndoHandler](#e7da2536-e17c-44b8-8f70-5065503d7de4)

###Summary

Occurs when undo state changed.

---

<a name="352a7d11-44db-46ef-b568-6c693ebafb13"></a>
##[KimonoCore.Kimono.PortfolioEventDelegate](#d3116afc-96a9-44b4-b4c7-2e30d9a194ef) UndoStateChanged

###Member of Type

[KimonoDesignSurface](#e7e0780e-ee1f-4f5e-b65e-65dc1523314f)

###Summary

Occurs when undo state changed.
