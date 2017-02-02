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

<a name="3b0537c6-0071-43fb-8f0b-5afb98aba72d"></a>
##KimonoCore

###Summary

Defines the core routines that are shared across the Kimono library that uses SkiaSharp to provide cross-platform graphics to a C# application.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b263b717-d01a-421a-acb3-efeccd38daa3'>Kimono</a></td><td style='width:75%' ><p>The public <code>Kimono</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines no fields, no properties, 3 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccd38be3-b55d-4a79-a6f7-d8aacd36968a'>KimonoBlur</a></td><td style='width:75%' class='def'><p>The public <code>KimonoBlur</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 3 fields, 3 properties, 11 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68f44f8c-f23b-468d-97ed-54e91abacbc6'>KimonoBounds</a></td><td style='width:75%' ><p>The public <code>KimonoBounds</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 16 fields, 22 properties, 72 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98619b0e-09fb-4b9b-9b74-891b3e79542f'>KimonoColor</a></td><td style='width:75%' class='def'><p>The public <code>KimonoColor</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 17 fields, 72 properties, 94 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a45a2698-077c-49c7-b694-b83ad29ea05f'>KimonoGradient</a></td><td style='width:75%' ><p>The public <code>KimonoGradient</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 18 fields, 15 properties, 56 methods and 2 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15ec7baa-7b4c-41fe-ade4-0707f190962a'>KimonoGradientType</a></td><td style='width:75%' class='def'><p>The public <code>KimonoGradientType</code> enum inherits from the <code>System.Enum</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 5 fields, no properties, no methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b606af25-7c99-452e-a1c8-52c98d06a1ac'>KimonoHandle</a></td><td style='width:75%' ><p>The public <code>KimonoHandle</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 13 fields, 12 properties, 35 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6434577-1829-4c70-9960-8f7e394bad29'>KimonoHandleConstraint</a></td><td style='width:75%' class='def'><p>The public <code>KimonoHandleConstraint</code> enum inherits from the <code>System.Enum</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 5 fields, no properties, no methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26c349b5-1f2e-4106-9168-f9f405f0e58c'>KimonoHandleType</a></td><td style='width:75%' ><p>The public <code>KimonoHandleType</code> enum inherits from the <code>System.Enum</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 4 fields, no properties, no methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#667d7181-027e-4675-907d-34febce25be5'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p>The public <code>KimonoPortfolio</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 15 fields, 6 properties, 62 methods and 8 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5'>KimonoShape</a></td><td style='width:75%' ><p>The public <code>KimonoShape</code> class inherits from the <code>KimonoCore.KimonoBounds</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 5 fields, 6 properties, 22 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dd7ed00-7125-446f-a83a-4a1b7594819c'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeArrow</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 5 fields, 5 properties, 18 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0e87798-7ac4-4bc0-b144-091e7a48bd33'>KimonoShapeGroup</a></td><td style='width:75%' ><p>The public <code>KimonoShapeGroup</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 9 fields, 13 properties, 71 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d6f36d2-8266-4a30-b62d-bf0d805c00fe'>KimonoShapeGroupType</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeGroupType</code> enum inherits from the <code>System.Enum</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 4 fields, no properties, no methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8'>KimonoShapeLine</a></td><td style='width:75%' ><p>The public <code>KimonoShapeLine</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines no fields, no properties, 6 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68719e7d-0150-4764-ab5b-951410790c56'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeOval</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines no fields, no properties, 6 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0de3411-8576-4c57-8adc-c347de6f9e61'>KimonoShapePolygon</a></td><td style='width:75%' ><p>The public <code>KimonoShapePolygon</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines one field, one property, 9 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ca1fe46-06b3-4864-bc70-9399db18d5b6'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeRect</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines no fields, no properties, 6 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f030891f-b2f6-43bf-8b30-4bb33dcf09b2'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>The public <code>KimonoShapeRoundRect</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines one field, one property, 10 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64605364-e990-4030-80f9-303d6eea30c5'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeStar</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 3 fields, 3 properties, 16 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd9f0b12-aa56-4011-8727-9289436b1a36'>KimonoShapeState</a></td><td style='width:75%' ><p>The public <code>KimonoShapeState</code> enum inherits from the <code>System.Enum</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 7 fields, no properties, no methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e3efe51-2fa7-41ca-80dd-505cdc283a79'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeText</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines one field, 14 properties, 35 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91eab6b8-c802-4441-a4b1-e9de268c98fc'>KimonoShapeTriangle</a></td><td style='width:75%' ><p>The public <code>KimonoShapeTriangle</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines no fields, no properties, 6 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18c66d58-56cf-40e1-8c23-663e3459f52b'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeVector</code> class inherits from the <code>KimonoCore.KimonoShape</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 2 fields, 3 properties, 21 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#580760e3-f281-48e0-b51d-b44cb97551f5'>KimonoSketch</a></td><td style='width:75%' ><p>The public <code>KimonoSketch</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 20 fields, 16 properties, 69 methods and 7 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38ee5869-ef06-48de-b11a-0b101b8c9f56'>KimonoStyle</a></td><td style='width:75%' class='def'><p>The public <code>KimonoStyle</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 23 fields, 36 properties, 84 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e715544c-1bd6-4f0f-812a-151d4fc8b509'>KimonoStyleType</a></td><td style='width:75%' ><p>The public <code>KimonoStyleType</code> enum inherits from the <code>System.Enum</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 6 fields, no properties, no methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0286b37c-e03e-4d80-824c-fc8c54818ea4'>KimonoTool</a></td><td style='width:75%' class='def'><p>The public <code>KimonoTool</code> enum inherits from the <code>System.Enum</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 13 fields, no properties, no methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fc62732-b04e-4e18-b8d6-222f8063115e'>KimonoUndoHandler</a></td><td style='width:75%' ><p>The public <code>KimonoUndoHandler</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 4 fields, 5 properties, 16 methods and one event.</p>
</td></tr></table></p>


---

<a name="b2f2f877-3487-4d6b-8fe6-1c424ba513da"></a>
##KimonoCore.Mac

###Summary

A Xamarin.Mac specific implementation of the KimonoCore library that provides access to cross-platform graphics built in the Kimono Designer.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1217c28d-4d87-4a20-ad9d-33dd6a58139e'>KimonoDesignSurface</a></td><td style='width:75%' ><p>The public <code>KimonoDesignSurface</code> class inherits from the <code>AppKit.NSImageView</code> class and is defined in the <code>KimonoCore.Mac</code> namespace. It defines 13 fields, 8 properties, 70 methods and 11 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p>The public <code>KimonoGradientDesignBar</code> class inherits from the <code>AppKit.NSImageView</code> class and is defined in the <code>KimonoCore.Mac</code> namespace. It defines 2 fields, one property, 17 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e632d6b2-a18d-4d7d-8538-9d6bdea9a878'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p>The public <code>KimonoGradientDesignPreview</code> class inherits from the <code>AppKit.NSImageView</code> class and is defined in the <code>KimonoCore.Mac</code> namespace. It defines 3 fields, one property, 20 methods and 2 events.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="b263b717-d01a-421a-acb3-efeccd38daa3"></a>
##Public Static Class Kimono

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `Kimono` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines no fields, no properties, 3 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#31d1fb36-e5e6-4945-9899-ed44537463ae'>CharIsNumber</a></td><td style='width:75%' ><p>The public static <code>CharIsNumber (System.Char)</code> member of the <code>Kimono</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbdf73d0-f4c6-4adc-b103-c0f9d5ec170d'>CloneSKPoint</a></td><td style='width:75%' class='def'><p>The public static <code>CloneSKPoint (SkiaSharp.SKPoint)</code> member of the <code>Kimono</code> class returns a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dd185f7-98bd-48cc-a817-b0260631d592'>IncrementName</a></td><td style='width:75%' ><p>The public static <code>IncrementName (System.String)</code> member of the <code>Kimono</code> class returns a <code>System.String</code> value.</p>
</td></tr></table></p>


---

<a name="ccd38be3-b55d-4a79-a6f7-d8aacd36968a"></a>
##Public Class KimonoBlur

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoBlur` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 3 fields, 3 properties, 11 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#57a2309f-601c-49db-8960-f99295cbe267'>_horizontalBlurAmount</a></td><td style='width:75%' ><p>The private <code>_horizontalBlurAmount</code> field of the <code>KimonoBlur</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2343726-95d5-4ce7-b002-cc1460e254b7'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p>The private <code>_verticalBlurAmount</code> field of the <code>KimonoBlur</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34937ba4-df42-4c1b-991c-214710ebea55'>BlurModified</a></td><td style='width:75%' ><p>The private <code>BlurModified</code> field of the <code>KimonoBlur</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9b8b0628-ab05-4a3f-b801-9faa1835ea12'>BlurFilter</a></td><td style='width:75%' ><p>The public read only <code>BlurFilter</code> property of the <code>KimonoBlur</code> class has a <code>SkiaSharp.SKImageFilter</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d820cf2d-d566-400f-9ce2-b33ba0da72dc'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p>The public <code>HorizontalBlurAmount</code> property of the <code>KimonoBlur</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4df6221c-ffb2-46ab-b3c9-1d47f203ed31'>VerticalBlurAmount</a></td><td style='width:75%' ><p>The public <code>VerticalBlurAmount</code> property of the <code>KimonoBlur</code> class has a <code>System.Single</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#465f282f-ec15-45d6-8179-35f6985aee23'>Clone</a></td><td style='width:75%' ><p>The public <code>Clone ()</code> member of the <code>KimonoBlur</code> class returns a <code>KimonoCore.KimonoBlur</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6200092a-52c8-4091-a475-7aed83829b2d'>KimonoBlur</a></td><td style='width:75%' class='def'><p>The public <code>KimonoBlur ()</code> constructor for the <code>KimonoBlur</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffbae91f-276a-4a85-98e2-3908f5bbf6e5'>KimonoBlur</a></td><td style='width:75%' ><p>The public <code>KimonoBlur (System.Single, System.Single)</code> constructor for the <code>KimonoBlur</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d085a12-a7be-4d66-8c0f-9d1824fef9b0'>RaiseBlurModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseBlurModified ()</code> member of the <code>KimonoBlur</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c56995fc-15d5-495e-9b4a-b9023042c1b5'>BlurModified</a></td><td style='width:75%' ><p>The <code>BlurModified</code> event of the <code>KimonoBlur</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="68f44f8c-f23b-468d-97ed-54e91abacbc6"></a>
##Public Class KimonoBounds

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoBounds` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 16 fields, 22 properties, 72 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e8173c76-01e2-404c-8962-46f7ec279d52'>PreviousCenter</a></td><td style='width:75%' ><p>The  <code>PreviousCenter</code> field of the <code>KimonoBounds</code> class holds a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce938466-03c8-48e8-9662-959015ba764c'>PreviousRect</a></td><td style='width:75%' class='def'><p>The  <code>PreviousRect</code> field of the <code>KimonoBounds</code> class holds a <code>SkiaSharp.SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e29b2226-17c0-4353-a0d1-60f7e9f64daf'>Rect</a></td><td style='width:75%' ><p>The  <code>Rect</code> field of the <code>KimonoBounds</code> class holds a <code>SkiaSharp.SKRect</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9af5751d-448d-45cd-b99b-06e3a80c7c39'>Bottom</a></td><td style='width:75%' ><p>The public <code>Bottom</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edd27757-4cc0-4180-98ac-ceab43f76c7f'>BottomHandle</a></td><td style='width:75%' class='def'><p>The public <code>BottomHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a63c39c-bbfa-4247-be5a-1833d777048c'>BottomLeftHandle</a></td><td style='width:75%' ><p>The public <code>BottomLeftHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3f6f9f1-bc9f-4628-884c-84cd37bc085e'>BottomRightHandle</a></td><td style='width:75%' class='def'><p>The public <code>BottomRightHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41caa07f-b47b-4489-a815-8f1ae373c4fa'>Center</a></td><td style='width:75%' ><p>The public read only <code>Center</code> property of the <code>KimonoBounds</code> class has a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de51e2be-9b6c-4519-a92a-c214a5bb594b'>Height</a></td><td style='width:75%' class='def'><p>The public <code>Height</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4eb3c765-3293-4a9c-a378-7ea64f1dc5ca'>HitHandle</a></td><td style='width:75%' ><p>The public <code>HitHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23345182-7e3f-4f8c-9c0b-e4218436058c'>HitOffset</a></td><td style='width:75%' class='def'><p>The public <code>HitOffset</code> property of the <code>KimonoBounds</code> class has a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cef81fdb-e8e9-4a8e-96d9-cba267a7d85b'>HorizontalCenter</a></td><td style='width:75%' ><p>The public read only <code>HorizontalCenter</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0e06ad3-7664-4721-a6ae-6e6ea8bd1950'>Left</a></td><td style='width:75%' class='def'><p>The public <code>Left</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b65c98f-c301-45b9-ab8b-510af994a4a3'>LeftHandle</a></td><td style='width:75%' ><p>The public <code>LeftHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28b63feb-c443-4a2c-a836-c4dd07e53f61'>Right</a></td><td style='width:75%' class='def'><p>The public <code>Right</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e369b4de-2ea4-4ed7-a477-a1a72cbf5c4d'>RightHandle</a></td><td style='width:75%' ><p>The public <code>RightHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec496c24-9e48-4a1d-ae15-87d2c579cb2d'>RotationDegrees</a></td><td style='width:75%' class='def'><p>The public <code>RotationDegrees</code> property of the <code>KimonoBounds</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f8cf0aa-d2cc-4e2b-9d11-31168c42f1eb'>State</a></td><td style='width:75%' ><p>The public <code>State</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoShapeState</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#adb04526-c6b2-4247-bccb-7d6d8589f4e5'>Top</a></td><td style='width:75%' class='def'><p>The public <code>Top</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d072d3a-d3ab-4a30-aa03-fc3a90e4eae0'>TopHandle</a></td><td style='width:75%' ><p>The public <code>TopHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f0abbcc-f631-4a89-bbac-5ba0694eca67'>TopLeftHandle</a></td><td style='width:75%' class='def'><p>The public <code>TopLeftHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd455fac-085e-47a3-8c0f-73470d937cb6'>TopRightHandle</a></td><td style='width:75%' ><p>The public <code>TopRightHandle</code> property of the <code>KimonoBounds</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c3c71ab-68a2-479b-b660-3c2ce6d84a8e'>UniqueID</a></td><td style='width:75%' class='def'><p>The public <code>UniqueID</code> property of the <code>KimonoBounds</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab9209f5-02a9-4f44-a41a-b8f31aa8aa9b'>VerticalCenter</a></td><td style='width:75%' ><p>The public read only <code>VerticalCenter</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10169bb1-0547-4c74-8aed-c730dab18ed8'>Width</a></td><td style='width:75%' class='def'><p>The public <code>Width</code> property of the <code>KimonoBounds</code> class has a <code>System.Single</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8591562b-f4a6-48eb-9db3-d6cf7662fbb6'>AddHandles</a></td><td style='width:75%' ><p>The  <code>AddHandles (KimonoCore.KimonoShapeState)</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b174ed1b-940b-4c36-9bc0-1fff2f4681c7'>BoundsChanged</a></td><td style='width:75%' class='def'><p>The public virtual <code>BoundsChanged ()</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a403c82d-4173-4366-aa71-7cb998e497bd'>ChangeBounds</a></td><td style='width:75%' ><p>The public virtual <code>ChangeBounds (System.Single, System.Single, System.Single, System.Single)</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02d6507c-ed0d-4bff-a0be-d91a3c64c49d'>Clone</a></td><td style='width:75%' class='def'><p>The public virtual <code>Clone ()</code> member of the <code>KimonoBounds</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2b91583-bd5d-4957-8e96-85964089bb29'>DragBounds</a></td><td style='width:75%' ><p>The public virtual <code>DragBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4dbee081-caa6-4f2b-a51b-eeabfba77f08'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8c8300f-a2ae-43a4-a0fa-fba6f70cd614'>GrowBounds</a></td><td style='width:75%' ><p>The public virtual <code>GrowBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e34eea8e-4759-455c-b133-8422a51113f4'>KimonoBounds</a></td><td style='width:75%' class='def'><p>The public <code>KimonoBounds ()</code> constructor for the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#569fa607-211f-4f34-9343-64156c821504'>KimonoBounds</a></td><td style='width:75%' ><p>The public <code>KimonoBounds (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7c96676-62f5-418f-9e74-6e6763736595'>KimonoBounds</a></td><td style='width:75%' class='def'><p>The public <code>KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7df68ad1-894d-41db-a570-dde520f6ee44'>MoveBounds</a></td><td style='width:75%' ><p>The public virtual <code>MoveBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff735239-3f9c-4448-9920-ac7fb1f4e8a8'>PlaceUnderConstruction</a></td><td style='width:75%' class='def'><p>The public <code>PlaceUnderConstruction (System.Boolean)</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c54f5bb-ca25-45a3-935d-ec4cbf46ebba'>PointInBound</a></td><td style='width:75%' ><p>The public virtual <code>PointInBound (SkiaSharp.SKPoint)</code> member of the <code>KimonoBounds</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c5f7dc5-6d6c-45b1-b947-03e47e43a0eb'>RemoveHandles</a></td><td style='width:75%' class='def'><p>The  <code>RemoveHandles ()</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75d01804-d85e-44b3-ae97-8d1ebe2dbb45'>SavePreviousBounds</a></td><td style='width:75%' ><p>The  <code>SavePreviousBounds ()</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc1d94a6-5db1-467c-8010-fc0f1a1de879'>Select</a></td><td style='width:75%' class='def'><p>The public <code>Select ()</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#061af8bc-1690-4c47-b988-a2040e72cba9'>StartGrouping</a></td><td style='width:75%' ><p>The public <code>StartGrouping ()</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78f746a0-6359-43b9-bfa6-ef0fb45299af'>Unselect</a></td><td style='width:75%' class='def'><p>The public <code>Unselect ()</code> member of the <code>KimonoBounds</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#463a8a92-95b5-45a6-9338-5ed07747276f'>ValueBetween</a></td><td style='width:75%' ><p>The  <code>ValueBetween (System.Single, System.Single, System.Single)</code> member of the <code>KimonoBounds</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr></table></p>


---

<a name="98619b0e-09fb-4b9b-9b74-891b3e79542f"></a>
##Public Class KimonoColor

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoColor` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 17 fields, 72 properties, 94 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a298839f-638d-4e20-ac9f-b8bdba9cb7b2'>_adjustAlpha</a></td><td style='width:75%' ><p>The  <code>_adjustAlpha</code> field of the <code>KimonoColor</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cbaa9e7-dc3f-43f2-86b5-4b22c0200648'>_adjustBrightness</a></td><td style='width:75%' class='def'><p>The  <code>_adjustBrightness</code> field of the <code>KimonoColor</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79f3cac9-dda5-4f7c-bde4-e5444122f24b'>_adjustHue</a></td><td style='width:75%' ><p>The  <code>_adjustHue</code> field of the <code>KimonoColor</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d7fcef1-2242-4bfb-a177-b65dab219668'>_adjustSaturation</a></td><td style='width:75%' class='def'><p>The  <code>_adjustSaturation</code> field of the <code>KimonoColor</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce649049-6c27-4aaa-8a93-aba46b7bef37'>_alphaAdjustment</a></td><td style='width:75%' ><p>The  <code>_alphaAdjustment</code> field of the <code>KimonoColor</code> class holds a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2af6ffab-56d8-47a1-93f2-bac74d60fe3e'>_baseColor</a></td><td style='width:75%' class='def'><p>The  <code>_baseColor</code> field of the <code>KimonoColor</code> class holds a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfbb431e-9448-4b4a-8fbb-c260ae4c7c70'>_brightnessAdjustment</a></td><td style='width:75%' ><p>The  <code>_brightnessAdjustment</code> field of the <code>KimonoColor</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4aaa657-bf79-487b-9d39-11c1c3f7f849'>_color</a></td><td style='width:75%' class='def'><p>The  <code>_color</code> field of the <code>KimonoColor</code> class holds a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2128901-f261-49e8-964b-21ab7b7db2d6'>_hueAdjustment</a></td><td style='width:75%' ><p>The  <code>_hueAdjustment</code> field of the <code>KimonoColor</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7c71a51-5aa2-466d-8178-617b0a4a2980'>_saturationAdjustment</a></td><td style='width:75%' class='def'><p>The  <code>_saturationAdjustment</code> field of the <code>KimonoColor</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0ec0a6b-7bea-45c1-a03b-8fc64bde8526'>Alpha</a></td><td style='width:75%' ><p>The  <code>Alpha</code> field of the <code>KimonoColor</code> class holds a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf098d41-e7f8-4ecd-bf79-e6629c26198e'>Brightness</a></td><td style='width:75%' class='def'><p>The  <code>Brightness</code> field of the <code>KimonoColor</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6d3572e-b274-4ca8-bdfc-966fa496fa52'>ColorChanged</a></td><td style='width:75%' ><p>The private <code>ColorChanged</code> field of the <code>KimonoColor</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3a7a00b-8c28-441d-8dfb-f762ff0fe8bc'>Hue</a></td><td style='width:75%' class='def'><p>The  <code>Hue</code> field of the <code>KimonoColor</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35d97f35-fa7c-479e-aa18-b8dd50d75361'>Saturation</a></td><td style='width:75%' ><p>The  <code>Saturation</code> field of the <code>KimonoColor</code> class holds a <code>System.Single</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b632a17c-9f49-489e-9ca3-ead2e1930605'>AdjustsAlpha</a></td><td style='width:75%' ><p>The public <code>AdjustsAlpha</code> property of the <code>KimonoColor</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ab943b2-5667-4e9c-8ceb-40cce27eab22'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p>The public <code>AdjustsBrightness</code> property of the <code>KimonoColor</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc12f926-0c85-4e0d-a558-659028350a7e'>AdjustsHue</a></td><td style='width:75%' ><p>The public <code>AdjustsHue</code> property of the <code>KimonoColor</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fa82769-ab26-420a-a93c-a202d668a3dd'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p>The public <code>AdjustsSaturation</code> property of the <code>KimonoColor</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c19ba9f7-e455-47ea-894e-91df298061e0'>AlphaAdjustment</a></td><td style='width:75%' ><p>The public <code>AlphaAdjustment</code> property of the <code>KimonoColor</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#521eea28-a889-462d-bfb0-a05c4dfc4c52'>Aluminum</a></td><td style='width:75%' class='def'><p>The public static read only <code>Aluminum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3737dee-19fb-4b1e-bb6c-9f50ba5368ed'>Aqua</a></td><td style='width:75%' ><p>The public static read only <code>Aqua</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c92846f4-014e-428e-8661-cd24043bb11f'>Asparagus</a></td><td style='width:75%' class='def'><p>The public static read only <code>Asparagus</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b11b15fb-9416-4369-9f72-511598db675d'>Banana</a></td><td style='width:75%' ><p>The public static read only <code>Banana</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45b0a72c-8832-47fb-884b-0e3ff898a740'>BaseColor</a></td><td style='width:75%' class='def'><p>The public <code>BaseColor</code> property of the <code>KimonoColor</code> class has a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#606f8a76-9799-4379-afa6-814cc03a9d35'>Black</a></td><td style='width:75%' ><p>The public static read only <code>Black</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c05f16f6-72cb-457b-985d-87e4095d3d5a'>Blue</a></td><td style='width:75%' class='def'><p>The public static read only <code>Blue</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1900ad82-a309-41e1-b555-c9d7c22733cc'>Blueberry</a></td><td style='width:75%' ><p>The public static read only <code>Blueberry</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5962817-46c5-48a0-8486-6be2a2406b70'>BrightnessAdjustment</a></td><td style='width:75%' class='def'><p>The public <code>BrightnessAdjustment</code> property of the <code>KimonoColor</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22754ec5-97e6-4087-895a-b77c87f5016f'>Bubblegum</a></td><td style='width:75%' ><p>The public static read only <code>Bubblegum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04db5822-4c14-4d9f-a55b-bc51831a5b0f'>Cantalope</a></td><td style='width:75%' class='def'><p>The public static read only <code>Cantalope</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e97f17d-abe4-4516-a7a4-02c983d70f4f'>Carnation</a></td><td style='width:75%' ><p>The public static read only <code>Carnation</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bf1dfe4-1610-4a48-80b4-8a23c08bd2d2'>Cayenne</a></td><td style='width:75%' class='def'><p>The public static read only <code>Cayenne</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7d71223-0851-4b86-b674-522c6bd7b559'>Clover</a></td><td style='width:75%' ><p>The public static read only <code>Clover</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8bcb470-3dec-4823-9862-e6e9a13d0efb'>Color</a></td><td style='width:75%' class='def'><p>The public <code>Color</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab5760b5-c5da-47ec-8168-1b3962d646ca'>DarkGray</a></td><td style='width:75%' ><p>The public static read only <code>DarkGray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f159479a-96b5-46ce-9b3c-c908007c39aa'>Eggplant</a></td><td style='width:75%' class='def'><p>The public static read only <code>Eggplant</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6f43f58-85ef-4115-83fa-5fd5991697c6'>Fern</a></td><td style='width:75%' ><p>The public static read only <code>Fern</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c746ecea-b4a3-4609-8e73-90302e132254'>Flora</a></td><td style='width:75%' class='def'><p>The public static read only <code>Flora</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e53624bb-65f9-4ee7-b489-b5eb95c445d5'>Grape</a></td><td style='width:75%' ><p>The public static read only <code>Grape</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8941506-e1a3-490b-8c9d-d96bb4821729'>Gray</a></td><td style='width:75%' class='def'><p>The public static read only <code>Gray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe18f423-dea9-4f8b-ad28-0abdafb9ed58'>Green</a></td><td style='width:75%' ><p>The public static read only <code>Green</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70537db3-ebe3-424a-80cb-6ba6802d5fcd'>Honeydew</a></td><td style='width:75%' class='def'><p>The public static read only <code>Honeydew</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a804fbe-c066-48f7-a6ea-7c72f120e71b'>HueAdjustment</a></td><td style='width:75%' ><p>The public <code>HueAdjustment</code> property of the <code>KimonoColor</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50dc6fa6-1149-468f-9b1f-1b95e9b404e3'>Ice</a></td><td style='width:75%' class='def'><p>The public static read only <code>Ice</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a248ab75-063e-494b-8dc9-1cc80fc4c1e2'>Iron</a></td><td style='width:75%' ><p>The public static read only <code>Iron</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4bd9f7e-167f-4330-bf98-d1599aa246e8'>Lavender</a></td><td style='width:75%' class='def'><p>The public static read only <code>Lavender</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#793c798a-22f6-47f9-b8f4-297d42983661'>Lead</a></td><td style='width:75%' ><p>The public static read only <code>Lead</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f32ea9d-569b-41c8-b679-a1295d2479ae'>Lemon</a></td><td style='width:75%' class='def'><p>The public static read only <code>Lemon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc0ed75f-5bb3-4f25-8a05-e845082141cf'>Licorice</a></td><td style='width:75%' ><p>The public static read only <code>Licorice</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f5873e6-b9ad-4a43-8fe6-3d1d77467aa9'>LightGray</a></td><td style='width:75%' class='def'><p>The public static read only <code>LightGray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5526a574-dd0f-4957-90c4-cd6237b89430'>Lime</a></td><td style='width:75%' ><p>The public static read only <code>Lime</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f77743e-30a2-4535-8fad-7bab5753d4af'>Magenta</a></td><td style='width:75%' class='def'><p>The public static read only <code>Magenta</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d28590e8-5084-49ff-829f-48226908e2c4'>Magnesium</a></td><td style='width:75%' ><p>The public static read only <code>Magnesium</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#608c6d3f-d11a-45f4-9f64-223baecad03f'>Maraschino</a></td><td style='width:75%' class='def'><p>The public static read only <code>Maraschino</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d32ab6f3-f683-4696-8e57-394f6af9c49d'>Maroon</a></td><td style='width:75%' ><p>The public static read only <code>Maroon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#267a4ef3-ab74-4869-ad89-5a854d1573dc'>Mercury</a></td><td style='width:75%' class='def'><p>The public static read only <code>Mercury</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e194694c-0560-4e7e-a57d-05bf39ee9570'>Midnight</a></td><td style='width:75%' ><p>The public static read only <code>Midnight</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d081972-f7a0-4e13-8eea-6f0996a10b83'>Mocha</a></td><td style='width:75%' class='def'><p>The public static read only <code>Mocha</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff895d6e-e81c-4252-bae3-00d520d47df1'>Moss</a></td><td style='width:75%' ><p>The public static read only <code>Moss</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2223d63-c523-44fe-8dbf-990d4f671cc8'>Name</a></td><td style='width:75%' class='def'><p>The public <code>Name</code> property of the <code>KimonoColor</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#785235bd-8e2a-4652-8feb-e30998670d77'>Nickle</a></td><td style='width:75%' ><p>The public static read only <code>Nickle</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3747703-7f9d-45ee-bbc9-cc63c533a155'>Ocean</a></td><td style='width:75%' class='def'><p>The public static read only <code>Ocean</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5fdd2ad-a667-4e37-bf48-4d07389f89a8'>Orange</a></td><td style='width:75%' ><p>The public static read only <code>Orange</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7db2e55d-0194-4937-9c93-c995b3602ca6'>Orchid</a></td><td style='width:75%' class='def'><p>The public static read only <code>Orchid</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#185cca5a-3f16-4d1e-9f99-592a06bd3305'>Pink</a></td><td style='width:75%' ><p>The public static read only <code>Pink</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f5c506a-3fae-4d2f-82cb-47d55c17f5d7'>Plum</a></td><td style='width:75%' class='def'><p>The public static read only <code>Plum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c00f1ecc-0d84-4d8b-b86e-457f7e3307c9'>Purple</a></td><td style='width:75%' ><p>The public static read only <code>Purple</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76e7c4fd-9423-4fe5-b5e9-65ed84320926'>Red</a></td><td style='width:75%' class='def'><p>The public static read only <code>Red</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0b46995-7e7c-472e-a716-969f7bec6728'>Salmon</a></td><td style='width:75%' ><p>The public static read only <code>Salmon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bc3cf52-e5a8-4d7e-ace3-7ebafdf3bf1c'>SaturationAdjustment</a></td><td style='width:75%' class='def'><p>The public <code>SaturationAdjustment</code> property of the <code>KimonoColor</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ce8789f-7aee-4917-abcc-ef6c979d66d7'>SeaFoam</a></td><td style='width:75%' ><p>The public static read only <code>SeaFoam</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27091374-d862-4f27-b943-2a2a019564fb'>Silver</a></td><td style='width:75%' class='def'><p>The public static read only <code>Silver</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52417cbe-354c-412b-ac7e-c8aaa515de8c'>Sky</a></td><td style='width:75%' ><p>The public static read only <code>Sky</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2def0693-dfc1-4ced-a26d-2790dbbc64b6'>Snow</a></td><td style='width:75%' class='def'><p>The public static read only <code>Snow</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd9c4159-725a-4a7e-9ab2-4d92c8f60b40'>Spindrift</a></td><td style='width:75%' ><p>The public static read only <code>Spindrift</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#590a254e-323b-4d01-8f36-44643c086046'>Spring</a></td><td style='width:75%' class='def'><p>The public static read only <code>Spring</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93dc5bcf-d854-4467-9973-a1e0a408c20f'>Steel</a></td><td style='width:75%' ><p>The public static read only <code>Steel</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa00e185-a2ec-43a1-a40c-f4d7dac65cec'>Strawberry</a></td><td style='width:75%' class='def'><p>The public static read only <code>Strawberry</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54a32cbd-bd10-4cbb-becf-f6d240ab6bfc'>Tangerine</a></td><td style='width:75%' ><p>The public static read only <code>Tangerine</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e9500d1-f22f-4210-b02d-1ba39938ffaf'>Teal</a></td><td style='width:75%' class='def'><p>The public static read only <code>Teal</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b9df7fa-42c2-4ee1-a885-d8fee098c534'>Tin</a></td><td style='width:75%' ><p>The public static read only <code>Tin</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa4514d7-6fdf-4c4a-8975-29a839ee5be5'>Tungsten</a></td><td style='width:75%' class='def'><p>The public static read only <code>Tungsten</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97ed5962-fb74-4a23-8bf9-dd5e5bea0dd1'>Turquoise</a></td><td style='width:75%' ><p>The public static read only <code>Turquoise</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e812a29-4e81-4e3d-9f9f-dddd97105031'>UniqueID</a></td><td style='width:75%' class='def'><p>The public <code>UniqueID</code> property of the <code>KimonoColor</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d8ad8eb-7b4d-4a03-93ca-cc06b291c097'>White</a></td><td style='width:75%' ><p>The public static read only <code>White</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1662d905-28ff-4310-ab9e-5892cbc0adc6'>Yellow</a></td><td style='width:75%' class='def'><p>The public static read only <code>Yellow</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#52e32a77-3d51-4ee0-a998-885ea79853ed'>BaseColorChanged</a></td><td style='width:75%' ><p>The private <code>BaseColorChanged ()</code> member of the <code>KimonoColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#771233ef-6381-42ec-9f8e-9beba83cfc58'>Clone</a></td><td style='width:75%' class='def'><p>The public <code>Clone ()</code> member of the <code>KimonoColor</code> class returns a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3a3ab60-c96d-42ae-bde6-9920f3ce9c57'>CloneColor</a></td><td style='width:75%' ><p>The public static <code>CloneColor (SkiaSharp.SKColor)</code> member of the <code>KimonoColor</code> class returns a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3afb6312-8855-41a3-be5e-33c6f96a0823'>KimonoColor</a></td><td style='width:75%' class='def'><p>The public <code>KimonoColor ()</code> constructor for the <code>KimonoColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3396a90d-76df-4a6d-b2fb-d26709d8a56d'>KimonoColor</a></td><td style='width:75%' ><p>The public <code>KimonoColor (KimonoCore.KimonoColor)</code> constructor for the <code>KimonoColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5c41070-c604-433d-ae2a-7b78ce459336'>KimonoColor</a></td><td style='width:75%' class='def'><p>The public <code>KimonoColor (SkiaSharp.SKColor)</code> constructor for the <code>KimonoColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ef7a30a-6b8a-4af4-90e5-66dd13a4b633'>MixColor</a></td><td style='width:75%' ><p>The private <code>MixColor ()</code> member of the <code>KimonoColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0292df71-9c6e-4763-8f39-7302dfadf2af'>RaiseColorChanged</a></td><td style='width:75%' class='def'><p>The  <code>RaiseColorChanged ()</code> member of the <code>KimonoColor</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3b7c9534-f0ab-4f2c-a6e6-cba3410c2eb5'>ColorChanged</a></td><td style='width:75%' ><p>The <code>ColorChanged</code> event of the <code>KimonoColor</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="1217c28d-4d87-4a20-ad9d-33dd6a58139e"></a>
##Public Class KimonoDesignSurface

###Namespace

[KimonoCore.Mac](#b2f2f877-3487-4d6b-8fe6-1c424ba513da)

###Inherits From

`AppKit.NSImageView`

###Summary

The public `KimonoDesignSurface` class inherits from the `AppKit.NSImageView` class and is defined in the `KimonoCore.Mac` namespace. It defines 13 fields, 8 properties, 70 methods and 11 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#923a2207-a856-4f65-88eb-3679cb29c5f6'>_portfolio</a></td><td style='width:75%' ><p>The private <code>_portfolio</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98d02cf7-b06a-4428-982b-5b7083a5b978'>ColorsModified</a></td><td style='width:75%' class='def'><p>The private <code>ColorsModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f181e95-6790-4907-a1f3-9f46056a6420'>GradientsModified</a></td><td style='width:75%' ><p>The private <code>GradientsModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c92873a-0436-4ee1-889f-cc9d4288ce44'>ReloadUI</a></td><td style='width:75%' class='def'><p>The private <code>ReloadUI</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65bfc7a2-1291-44ae-91c5-78dac3d7eb9e'>SelectedShapeModified</a></td><td style='width:75%' ><p>The private <code>SelectedShapeModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10592ad9-b676-46e9-be7f-c8debcb4ef33'>SelectionChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectionChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9eef7b7-dc0e-466e-b4db-216edbd07ef2'>SketchesModified</a></td><td style='width:75%' ><p>The private <code>SketchesModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d2ed73a-6284-41c2-9e12-66c902f54610'>SketchModified</a></td><td style='width:75%' class='def'><p>The private <code>SketchModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f639d25c-30c6-44f0-9aef-9a75d2ddb6e2'>SketchSizeChanged</a></td><td style='width:75%' ><p>The private <code>SketchSizeChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25dd7d2f-a48b-4b14-9f58-44956f791279'>StylesModified</a></td><td style='width:75%' class='def'><p>The private <code>StylesModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc8342f8-fd3e-49b8-bb3f-059565dc971f'>ToolChanged</a></td><td style='width:75%' ><p>The private <code>ToolChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3b7c4d3-99b4-48d2-bd31-29504c98bc34'>UndoHandler</a></td><td style='width:75%' class='def'><p>The private <code>UndoHandler</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.KimonoUndoHandler</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b280ea4-ca22-40cc-b16e-99e0d590a75e'>UndoStateChanged</a></td><td style='width:75%' ><p>The private <code>UndoStateChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#050fce01-ed0a-47aa-9185-13af5c63a93a'>CanRedo</a></td><td style='width:75%' ><p>The public read only <code>CanRedo</code> property of the <code>KimonoDesignSurface</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0203570-0233-4625-a56b-7df1d00c0fe4'>CanUndo</a></td><td style='width:75%' class='def'><p>The public read only <code>CanUndo</code> property of the <code>KimonoDesignSurface</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03739644-1452-4811-9464-d92edcf3ef5a'>DeeplySelectedGroup</a></td><td style='width:75%' ><p>The public read only <code>DeeplySelectedGroup</code> property of the <code>KimonoDesignSurface</code> class has a <code>KimonoCore.KimonoShapeGroup</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f2e5dea-f24d-4984-9806-63c3b6839ba2'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p>The public read only <code>DeeplySelectedShape</code> property of the <code>KimonoDesignSurface</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f7f1c54-8ad8-4713-a055-349d16e78662'>Portfolio</a></td><td style='width:75%' ><p>The public <code>Portfolio</code> property of the <code>KimonoDesignSurface</code> class has a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76c1c2e4-b043-4769-bdcb-3d93b30216f5'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoDesignSurface</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff13957b-70d0-4f57-be85-00b1d3916be4'>SelectedSketch</a></td><td style='width:75%' ><p>The public <code>SelectedSketch</code> property of the <code>KimonoDesignSurface</code> class has a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b14195b-15dd-4fee-938a-21566feea7a9'>Tool</a></td><td style='width:75%' class='def'><p>The public <code>Tool</code> property of the <code>KimonoDesignSurface</code> class has a <code>KimonoCore.KimonoTool</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a7b2f1c6-d222-49b6-bac3-f171df5084d7'>AcceptsFirstResponder</a></td><td style='width:75%' ><p>The public virtual <code>AcceptsFirstResponder ()</code> member of the <code>KimonoDesignSurface</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#401e0f0c-7c96-4f2c-b92d-280cef5bb904'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p>The private <code>ConvertToCanvasPoint (AppKit.NSEvent)</code> member of the <code>KimonoDesignSurface</code> class returns a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80120611-3fb0-483a-a6f3-a05dbcc1b7d2'>DeleteSelectedShape</a></td><td style='width:75%' ><p>The public <code>DeleteSelectedShape ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ca66fd2-c95a-495b-ad90-10b753fa04ed'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateSelectedShape ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d789c673-8fd6-44c3-b495-6853ecb51aad'>HandleSketchChanging</a></td><td style='width:75%' ><p>The private <code>HandleSketchChanging (KimonoCore.KimonoSketch)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cd20312-a562-44c6-9697-31b5424a3be8'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81298765-94ef-4732-a6ec-b0d16a6d5fec'>KimonoDesignSurface</a></td><td style='width:75%' ><p>The public <code>KimonoDesignSurface ()</code> constructor for the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93536513-054e-473f-8956-a1de9dce3cff'>KimonoDesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>KimonoDesignSurface (CoreGraphics.CGRect)</code> constructor for the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5e84f1b-528d-48c4-8556-89dae78fa307'>KimonoDesignSurface</a></td><td style='width:75%' ><p>The public <code>KimonoDesignSurface (Foundation.NSCoder)</code> constructor for the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e4285a3-092d-4b12-83ea-6c49c6ec2960'>KimonoDesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>KimonoDesignSurface (System.IntPtr)</code> constructor for the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#199033ab-e2a7-4fde-83e7-6495f3f53d80'>MouseDown</a></td><td style='width:75%' ><p>The public virtual <code>MouseDown (AppKit.NSEvent)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e7e1c46-daf0-4825-bdb4-944d5b2e8904'>MouseDragged</a></td><td style='width:75%' class='def'><p>The public virtual <code>MouseDragged (AppKit.NSEvent)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f44d77b-08f2-413e-be47-8c68392ba787'>MouseMoved</a></td><td style='width:75%' ><p>The public virtual <code>MouseMoved (AppKit.NSEvent)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f76151c9-cc29-4d24-bff4-472d19971fac'>MouseUp</a></td><td style='width:75%' class='def'><p>The public virtual <code>MouseUp (AppKit.NSEvent)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2479006-2f31-45cc-a21f-b18298f760b7'>RaiseColorsModified</a></td><td style='width:75%' ><p>The  <code>RaiseColorsModified (KimonoCore.KimonoColor)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1970325-a2fb-45f0-aaea-ee9c39e17a17'>RaiseGradientsModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseGradientsModified (KimonoCore.KimonoGradient)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82faffbf-e823-48ec-bdd7-692ec795ab4e'>RaiseReloadUI</a></td><td style='width:75%' ><p>The  <code>RaiseReloadUI ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35ce422b-79ca-4d0e-99c1-f6254075953c'>RaiseSelectedShapeModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSelectedShapeModified ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fc9442c-4e40-406a-b0d7-11148e3302f8'>RaiseSelectionChanged</a></td><td style='width:75%' ><p>The  <code>RaiseSelectionChanged (KimonoCore.KimonoShape)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39cb7ef7-cc40-41f1-a6ce-79256cd0c103'>RaiseSketchesModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSketchesModified ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3688e03d-e046-4d34-b363-2e6958904d48'>RaiseSketchModified</a></td><td style='width:75%' ><p>The  <code>RaiseSketchModified ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8df1742-4b25-47a1-9fc1-903f45ff2def'>RaiseSketchSizeChanged</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSketchSizeChanged ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64a463e0-a219-4394-8b7c-7136b367f216'>RaiseStylesModified</a></td><td style='width:75%' ><p>The  <code>RaiseStylesModified (KimonoCore.KimonoStyle)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23bc85ea-5fa0-49fe-a8b6-e6ee07a39788'>RaiseToolChanged</a></td><td style='width:75%' class='def'><p>The  <code>RaiseToolChanged (KimonoCore.KimonoTool)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab957055-bcd7-4d7e-86dc-cd82c8234292'>RaiseUndoStateChanged</a></td><td style='width:75%' ><p>The  <code>RaiseUndoStateChanged ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b864e33f-2815-469c-bbc6-eb452f939c74'>Redo</a></td><td style='width:75%' class='def'><p>The public <code>Redo (Foundation.NSObject)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f66db2d5-cb03-4bab-9a1f-4218c0f81e9c'>RedoChange</a></td><td style='width:75%' ><p>The public <code>RedoChange ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c818db69-fd40-43be-80eb-82ac83f50468'>RefreshView</a></td><td style='width:75%' class='def'><p>The public <code>RefreshView ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#515c9370-98d7-4198-ac7c-3c5749f039b4'>ReplaceUndoPoint</a></td><td style='width:75%' ><p>The public <code>ReplaceUndoPoint ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d613328-317a-408d-ad07-7e147fb77b7b'>SaveUndoPoint</a></td><td style='width:75%' class='def'><p>The public <code>SaveUndoPoint ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b205225c-4e2e-4220-90ab-97c4e206dbd9'>Undo</a></td><td style='width:75%' ><p>The public <code>Undo (Foundation.NSObject)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e45d3bd-0458-4241-9a65-25abda538d73'>UndoChange</a></td><td style='width:75%' class='def'><p>The public <code>UndoChange ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f3d6d54-3817-47d3-a1a5-61b8307b94b0'>UnwirePortfolioEvents</a></td><td style='width:75%' ><p>The private <code>UnwirePortfolioEvents ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48171e1e-24be-4893-8f0a-f610bc622781'>UnwireSketchEvents</a></td><td style='width:75%' class='def'><p>The private <code>UnwireSketchEvents (KimonoCore.KimonoSketch)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1481dfc-1aad-4fba-8860-4f9964d8f9f7'>WireupPortfolioEvents</a></td><td style='width:75%' ><p>The private <code>WireupPortfolioEvents ()</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6393e1b6-4c63-47ea-8307-9501897c48ab'>WireUpSketchEvents</a></td><td style='width:75%' class='def'><p>The private <code>WireUpSketchEvents (KimonoCore.KimonoSketch)</code> member of the <code>KimonoDesignSurface</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bae454ce-6279-40d1-bc35-d9d1f1bbe2d4'>ColorsModified</a></td><td style='width:75%' ><p>The <code>ColorsModified</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89f05dcd-d447-4beb-8232-ab5fd7aabe19'>GradientsModified</a></td><td style='width:75%' class='def'><p>The <code>GradientsModified</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbdbbacd-2b57-4b4d-82e3-49b62df601bf'>ReloadUI</a></td><td style='width:75%' ><p>The <code>ReloadUI</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3463e17c-a843-4cfb-9f2e-e60da856255b'>SelectedShapeModified</a></td><td style='width:75%' class='def'><p>The <code>SelectedShapeModified</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0e083f2-06b8-4258-b180-93590fff649a'>SelectionChanged</a></td><td style='width:75%' ><p>The <code>SelectionChanged</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a80ee3d-3ac2-4777-9996-6b351afdd6fb'>SketchesModified</a></td><td style='width:75%' class='def'><p>The <code>SketchesModified</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#735bd482-aade-4963-9db7-b9eebba8a83b'>SketchModified</a></td><td style='width:75%' ><p>The <code>SketchModified</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#232e72f9-1f5d-4039-9c2f-b13afa3e6a12'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p>The <code>SketchSizeChanged</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39a23caa-8f67-4844-b3d5-532a2ffbe058'>StylesModified</a></td><td style='width:75%' ><p>The <code>StylesModified</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#327755c5-3733-4bb7-a3db-d523a9b1290b'>ToolChanged</a></td><td style='width:75%' class='def'><p>The <code>ToolChanged</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17385b8b-07af-4cc2-8500-9da2d316887c'>UndoStateChanged</a></td><td style='width:75%' ><p>The <code>UndoStateChanged</code> event of the <code>KimonoDesignSurface</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="a45a2698-077c-49c7-b694-b83ad29ea05f"></a>
##Public Class KimonoGradient

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoGradient` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 18 fields, 15 properties, 56 methods and 2 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a4e14d0c-f2ac-4ff8-aec0-cd454cfb8456'>_endPoint</a></td><td style='width:75%' ><p>The private <code>_endPoint</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d6a4824-15ff-42d3-a30f-b6e6e6dcae1c'>_gradientType</a></td><td style='width:75%' class='def'><p>The private <code>_gradientType</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.KimonoGradientType</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad3f8321-d99f-46f7-92fc-a2edd1fe0e52'>_radius</a></td><td style='width:75%' ><p>The private <code>_radius</code> field of the <code>KimonoGradient</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f18f94b9-2c96-45f7-904f-780a5665fea0'>_selectedHandle</a></td><td style='width:75%' class='def'><p>The private <code>_selectedHandle</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2acf643-cb07-4f31-bd29-e1f17676c97d'>_startPoint</a></td><td style='width:75%' ><p>The private <code>_startPoint</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09de4ac4-43bb-4bdb-917a-696444130e31'>_tileMode</a></td><td style='width:75%' class='def'><p>The private <code>_tileMode</code> field of the <code>KimonoGradient</code> class holds a <code>SkiaSharp.SKShaderTileMode</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9753f7d3-4796-4d9f-a500-9f9674dbd19f'>GradientModified</a></td><td style='width:75%' ><p>The private <code>GradientModified</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8657850b-1fc0-40c2-8606-f1ed30d60056'>HandleSelected</a></td><td style='width:75%' class='def'><p>The private <code>HandleSelected</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62b88ed4-b988-4fad-8b4e-7b5b258be718'>PerformingDrag</a></td><td style='width:75%' ><p>The private <code>PerformingDrag</code> field of the <code>KimonoGradient</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8f6ae76d-5e32-4270-b661-985022e33272'>BarHeight</a></td><td style='width:75%' ><p>The public <code>BarHeight</code> property of the <code>KimonoGradient</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4970339d-8dca-4910-9020-8915130909fa'>BarWidth</a></td><td style='width:75%' class='def'><p>The public <code>BarWidth</code> property of the <code>KimonoGradient</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87161652-6a12-4bcb-a5e3-9b998412ad3b'>ControlPoints</a></td><td style='width:75%' ><p>The public <code>ControlPoints</code> property of the <code>KimonoGradient</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoHandle&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09a339b3-1a67-46be-9fef-7a1164ba1e92'>EndPoint</a></td><td style='width:75%' class='def'><p>The public <code>EndPoint</code> property of the <code>KimonoGradient</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43b475b2-ee09-4f7c-b01c-cc82a7f63c74'>GradientType</a></td><td style='width:75%' ><p>The public <code>GradientType</code> property of the <code>KimonoGradient</code> class has a <code>KimonoCore.KimonoGradientType</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3664d6fe-b173-47f0-af45-d962aea6b409'>Name</a></td><td style='width:75%' class='def'><p>The public <code>Name</code> property of the <code>KimonoGradient</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c47d62e-559c-4d6d-9977-ae93ede756e0'>PreviewHeight</a></td><td style='width:75%' ><p>The public <code>PreviewHeight</code> property of the <code>KimonoGradient</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2f7cca2-346b-4375-a705-3e3b82b19813'>PreviewWidth</a></td><td style='width:75%' class='def'><p>The public <code>PreviewWidth</code> property of the <code>KimonoGradient</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a28abe8-016d-409c-82cb-172813407050'>Radius</a></td><td style='width:75%' ><p>The public <code>Radius</code> property of the <code>KimonoGradient</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fb4df4a-84cb-4d58-a9ec-553a0b131d7c'>SelectedColor</a></td><td style='width:75%' class='def'><p>The public read only <code>SelectedColor</code> property of the <code>KimonoGradient</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f46a3b46-3f4b-49c0-adf7-488c1ecf6a08'>SelectedHandle</a></td><td style='width:75%' ><p>The public <code>SelectedHandle</code> property of the <code>KimonoGradient</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd7322b7-3a67-47d3-92ff-62dae9cd7999'>Shader</a></td><td style='width:75%' class='def'><p>The public read only <code>Shader</code> property of the <code>KimonoGradient</code> class has a <code>SkiaSharp.SKShader</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d523c6d-ac26-4569-9bc0-98e40ff937fd'>StartPoint</a></td><td style='width:75%' ><p>The public <code>StartPoint</code> property of the <code>KimonoGradient</code> class has a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#933a04bf-5946-4379-874c-8c29c8608339'>TileMode</a></td><td style='width:75%' class='def'><p>The public <code>TileMode</code> property of the <code>KimonoGradient</code> class has a <code>SkiaSharp.SKShaderTileMode</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72e6f743-339e-4812-a01a-22e34e9681af'>UniqueID</a></td><td style='width:75%' ><p>The public <code>UniqueID</code> property of the <code>KimonoGradient</code> class has a <code>System.String</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#943db9d0-4a58-4c56-90ef-731f58e101ed'>AddControlPoint</a></td><td style='width:75%' ><p>The public <code>AddControlPoint ()</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0781f9c-24f3-461e-833b-2a1702b74ae4'>BarToolDown</a></td><td style='width:75%' class='def'><p>The public <code>BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb638b99-00cb-4b43-ba52-eff7a2403d8c'>BarToolDrag</a></td><td style='width:75%' ><p>The public <code>BarToolDrag (SkiaSharp.SKPoint)</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27d859c0-4618-46f6-8cbb-60a9a45d42a8'>BarToolUp</a></td><td style='width:75%' class='def'><p>The public <code>BarToolUp (SkiaSharp.SKPoint)</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b49f1c0c-4ab2-46b3-8b7f-5a6fecb49158'>Clone</a></td><td style='width:75%' ><p>The public <code>Clone ()</code> member of the <code>KimonoGradient</code> class returns a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b8a9a5e-49a5-4c47-8a43-a8f70d90c868'>ConformingShader</a></td><td style='width:75%' class='def'><p>The public <code>ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</code> member of the <code>KimonoGradient</code> class returns a <code>SkiaSharp.SKShader</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3032884-3a90-4a04-a207-d066cda50122'>DeleteSelectedControlPoint</a></td><td style='width:75%' ><p>The public <code>DeleteSelectedControlPoint ()</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#089c971e-1dbf-447f-8e76-5d6bc7dfca15'>DrawBar</a></td><td style='width:75%' class='def'><p>The public <code>DrawBar ()</code> member of the <code>KimonoGradient</code> class returns a <code>SkiaSharp.SKData</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#633fc5dd-0034-4470-ad58-18743927e76f'>DrawPreview</a></td><td style='width:75%' ><p>The public <code>DrawPreview ()</code> member of the <code>KimonoGradient</code> class returns a <code>SkiaSharp.SKData</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#637b49b2-33bb-4807-b959-816c44c2a905'>DuplicateSelectedControlPoint</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateSelectedControlPoint ()</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0d9da53-f39a-4942-a1cc-3572cfba27de'>FindHandle</a></td><td style='width:75%' ><p>The public <code>FindHandle (System.String)</code> member of the <code>KimonoGradient</code> class returns a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#483414bd-ef0b-4659-80cc-2d33fa91a28f'>Initialize</a></td><td style='width:75%' class='def'><p>The  <code>Initialize ()</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0e6aeb7-d0d5-47f5-9bc7-e3ade5ba0d78'>KimonoGradient</a></td><td style='width:75%' ><p>The public <code>KimonoGradient ()</code> constructor for the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36e7f37e-cba4-40aa-a8af-e259ff7d18e6'>KimonoGradient</a></td><td style='width:75%' class='def'><p>The public <code>KimonoGradient (System.Single, System.Single)</code> constructor for the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05ba3d16-1162-443c-83cc-61d4277bfc98'>KimonoGradient</a></td><td style='width:75%' ><p>The public <code>KimonoGradient (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efe189b8-4203-421c-9f40-1839c3256a67'>PreviewToolDown</a></td><td style='width:75%' class='def'><p>The public <code>PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f80f2b58-512e-419d-b78e-a324c00da3ca'>PreviewToolDrag</a></td><td style='width:75%' ><p>The public <code>PreviewToolDrag (SkiaSharp.SKPoint)</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcc47e13-178f-4503-a09a-6db7976d7804'>PreviewToolUp</a></td><td style='width:75%' class='def'><p>The public <code>PreviewToolUp (SkiaSharp.SKPoint)</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01f7a992-3338-4912-b079-faf9bf75fe1e'>RaiseGradientModified</a></td><td style='width:75%' ><p>The  <code>RaiseGradientModified ()</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#472cd9a2-a496-430d-92cd-efcb38bc17ff'>RaiseHandleSelected</a></td><td style='width:75%' class='def'><p>The  <code>RaiseHandleSelected (KimonoCore.KimonoHandle)</code> member of the <code>KimonoGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56ef69b5-1214-48fe-bcea-e46ce5e66b9b'>SortedColors</a></td><td style='width:75%' ><p>The private <code>SortedColors ()</code> member of the <code>KimonoGradient</code> class returns a <code>SkiaSharp.SKColor[]</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b0a7d78-a02f-4923-b7f5-861687b001dd'>SortedWeights</a></td><td style='width:75%' class='def'><p>The private <code>SortedWeights ()</code> member of the <code>KimonoGradient</code> class returns a <code>System.Single[]</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#42e10075-fdd4-4724-aa0e-6e7ac6cf5612'>GradientModified</a></td><td style='width:75%' ><p>The <code>GradientModified</code> event of the <code>KimonoGradient</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#611a6489-bf42-4af2-8c03-442351120efc'>HandleSelected</a></td><td style='width:75%' class='def'><p>The <code>HandleSelected</code> event of the <code>KimonoGradient</code> class returns a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="a2dc3fda-4f70-47a2-9ed4-fc5ac8129753"></a>
##Public Class KimonoGradientDesignBar

###Namespace

[KimonoCore.Mac](#b2f2f877-3487-4d6b-8fe6-1c424ba513da)

###Inherits From

`AppKit.NSImageView`

###Summary

The public `KimonoGradientDesignBar` class inherits from the `AppKit.NSImageView` class and is defined in the `KimonoCore.Mac` namespace. It defines 2 fields, one property, 17 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2571e052-77ce-47cc-942a-005d3a3d3a54'>_gradient</a></td><td style='width:75%' ><p>The private <code>_gradient</code> field of the <code>KimonoGradientDesignBar</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01feab92-d0db-4ee3-8613-731398fd032c'>HandleSelected</a></td><td style='width:75%' class='def'><p>The private <code>HandleSelected</code> field of the <code>KimonoGradientDesignBar</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#88fd0355-c6dd-480c-9beb-c4d6575cbcc8'>Gradient</a></td><td style='width:75%' ><p>The public <code>Gradient</code> property of the <code>KimonoGradientDesignBar</code> class has a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6518fe59-8d0d-4e44-a7d3-c522a608cead'>AcceptsFirstResponder</a></td><td style='width:75%' ><p>The public virtual <code>AcceptsFirstResponder ()</code> member of the <code>KimonoGradientDesignBar</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1a3a565-8664-4aef-8ce1-1a157e891152'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p>The private <code>ConvertToCanvasPoint (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignBar</code> class returns a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b5c526b-677d-42e4-a84e-e39df3b58064'>HandleGradientModified</a></td><td style='width:75%' ><p>The public <code>HandleGradientModified ()</code> member of the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d442d207-b744-456e-9a1f-ab7d54917b3e'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p>The public <code>KimonoGradientDesignBar ()</code> constructor for the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#548c2b68-36aa-49ae-8d90-86929965dec0'>KimonoGradientDesignBar</a></td><td style='width:75%' ><p>The public <code>KimonoGradientDesignBar (CoreGraphics.CGRect)</code> constructor for the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcac7d01-7ca4-4121-bd22-4119b1ddf9f3'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p>The public <code>KimonoGradientDesignBar (Foundation.NSCoder)</code> constructor for the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05b53324-6936-4fdb-b581-46e77a60fc10'>KimonoGradientDesignBar</a></td><td style='width:75%' ><p>The public <code>KimonoGradientDesignBar (System.IntPtr)</code> constructor for the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2db51269-d075-48a4-b92f-f48b6d1d098d'>MouseDown</a></td><td style='width:75%' class='def'><p>The public virtual <code>MouseDown (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#246223e4-bfdd-4049-9f7d-da07b80c1e0b'>MouseDragged</a></td><td style='width:75%' ><p>The public virtual <code>MouseDragged (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4540c58f-ec37-4b8a-9106-e6a302bea1de'>MouseMoved</a></td><td style='width:75%' class='def'><p>The public virtual <code>MouseMoved (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffd6a7d5-aefe-4825-a6c7-f940d1d1cff6'>MouseUp</a></td><td style='width:75%' ><p>The public virtual <code>MouseUp (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9274902-d018-450a-a270-051c344f0a64'>RaiseHandleSelected</a></td><td style='width:75%' class='def'><p>The  <code>RaiseHandleSelected (KimonoCore.KimonoHandle)</code> member of the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea168e56-709d-40ce-9391-50d744f403c7'>RefreshView</a></td><td style='width:75%' ><p>The public <code>RefreshView ()</code> member of the <code>KimonoGradientDesignBar</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7a5c1d8f-feb1-498d-802b-65fbeabb0c67'>HandleSelected</a></td><td style='width:75%' ><p>The <code>HandleSelected</code> event of the <code>KimonoGradientDesignBar</code> class returns a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="e632d6b2-a18d-4d7d-8538-9d6bdea9a878"></a>
##Public Class KimonoGradientDesignPreview

###Namespace

[KimonoCore.Mac](#b2f2f877-3487-4d6b-8fe6-1c424ba513da)

###Inherits From

`AppKit.NSImageView`

###Summary

The public `KimonoGradientDesignPreview` class inherits from the `AppKit.NSImageView` class and is defined in the `KimonoCore.Mac` namespace. It defines 3 fields, one property, 20 methods and 2 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6a177893-3c87-4000-9654-1e1b54bd868e'>_gradient</a></td><td style='width:75%' ><p>The private <code>_gradient</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0d0e723-ff6b-401f-8ce7-5c329654f414'>GradientModified</a></td><td style='width:75%' class='def'><p>The private <code>GradientModified</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13a828f0-570f-4a20-b52c-b1b4b5e80145'>HandleSelected</a></td><td style='width:75%' ><p>The private <code>HandleSelected</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ad9edaee-877e-49bc-aaaf-21ecaf353e41'>Gradient</a></td><td style='width:75%' ><p>The public <code>Gradient</code> property of the <code>KimonoGradientDesignPreview</code> class has a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0bcabf43-0d9a-4ab8-b4bf-e7f9afc69000'>AcceptsFirstResponder</a></td><td style='width:75%' ><p>The public virtual <code>AcceptsFirstResponder ()</code> member of the <code>KimonoGradientDesignPreview</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e758aae9-57df-41a0-9318-d82a806e2ac6'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p>The private <code>ConvertToCanvasPoint (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignPreview</code> class returns a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc80c022-60fc-4511-a806-c538bec9a451'>HandleGradientModified</a></td><td style='width:75%' ><p>The public <code>HandleGradientModified ()</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e50b55a-9d07-45dc-8287-8dd2c01cf37b'>KimonoGradientDesignPreview</a></td><td style='width:75%' class='def'><p>The public <code>KimonoGradientDesignPreview ()</code> constructor for the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2c5d31a-ccf0-4366-adbc-0317cb815ae3'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p>The public <code>KimonoGradientDesignPreview (CoreGraphics.CGRect)</code> constructor for the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2434ae7-0c7d-4fc3-a137-a2e0a763f85c'>KimonoGradientDesignPreview</a></td><td style='width:75%' class='def'><p>The public <code>KimonoGradientDesignPreview (Foundation.NSCoder)</code> constructor for the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#423b2565-4567-4891-b5c6-2a42fb2f90d9'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p>The public <code>KimonoGradientDesignPreview (System.IntPtr)</code> constructor for the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#780995bd-1421-43db-8acc-d114c6e73734'>MouseDown</a></td><td style='width:75%' class='def'><p>The public virtual <code>MouseDown (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#580d086e-5990-48de-af2c-a146fb9c7eaf'>MouseDragged</a></td><td style='width:75%' ><p>The public virtual <code>MouseDragged (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a7ce575-84cb-4038-ae06-6742a20d29d5'>MouseMoved</a></td><td style='width:75%' class='def'><p>The public virtual <code>MouseMoved (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f0fa740-d1be-4610-9c73-1490f434e687'>MouseUp</a></td><td style='width:75%' ><p>The public virtual <code>MouseUp (AppKit.NSEvent)</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89c063b0-9ca6-4522-9d96-03d423d5fca2'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseGradientModified ()</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d125a7b5-5248-4092-9f82-dcc025c9f225'>RaiseHandleSelected</a></td><td style='width:75%' ><p>The  <code>RaiseHandleSelected (KimonoCore.KimonoHandle)</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#411009d9-ef4f-4096-bdb0-0e2564a73289'>RefreshView</a></td><td style='width:75%' class='def'><p>The public <code>RefreshView ()</code> member of the <code>KimonoGradientDesignPreview</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d0b3c108-01ea-4e84-9232-bb7ad6a62f59'>GradientModified</a></td><td style='width:75%' ><p>The <code>GradientModified</code> event of the <code>KimonoGradientDesignPreview</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9832e90a-1bb3-407c-9518-cc5cd2815f1c'>HandleSelected</a></td><td style='width:75%' class='def'><p>The <code>HandleSelected</code> event of the <code>KimonoGradientDesignPreview</code> class returns a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="15ec7baa-7b4c-41fe-ade4-0707f190962a"></a>
##Public Enum KimonoGradientType

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Enum`

###Summary

The public `KimonoGradientType` enum inherits from the `System.Enum` class and is defined in the `KimonoCore` namespace. It defines 5 fields, no properties, no methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8f42b5d8-e3a1-4202-a92e-a061a6db3b75'>ConicalGradient</a></td><td style='width:75%' ><p>The public static constant <code>ConicalGradient</code> field of the <code>KimonoGradientType</code> enum holds a <code>KimonoCore.KimonoGradientType</code> value of <code>3</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6340dd7-f730-4c1d-9c6c-b3375c036b55'>LinearGradient</a></td><td style='width:75%' class='def'><p>The public static constant <code>LinearGradient</code> field of the <code>KimonoGradientType</code> enum holds a <code>KimonoCore.KimonoGradientType</code> value of <code>0</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#172f39a8-c40f-43b6-b8dc-c41842f5ffd0'>RadialGradient</a></td><td style='width:75%' ><p>The public static constant <code>RadialGradient</code> field of the <code>KimonoGradientType</code> enum holds a <code>KimonoCore.KimonoGradientType</code> value of <code>1</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf6b1ff3-1027-4348-8f78-e0ea4d954892'>SweepGradient</a></td><td style='width:75%' class='def'><p>The public static constant <code>SweepGradient</code> field of the <code>KimonoGradientType</code> enum holds a <code>KimonoCore.KimonoGradientType</code> value of <code>2</code>.</p>
</td></tr></table></p>


---

<a name="b606af25-7c99-452e-a1c8-52c98d06a1ac"></a>
##Public Class KimonoHandle

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoHandle` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 13 fields, 12 properties, 35 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#654f3d1a-e886-42e0-b452-b1d17801d7d9'>DrawOffset</a></td><td style='width:75%' ><p>The public static <code>DrawOffset</code> field of the <code>KimonoHandle</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63109c74-dc83-4a2b-9dcf-c3a59cf1094c'>DrawWidth</a></td><td style='width:75%' class='def'><p>The public static <code>DrawWidth</code> field of the <code>KimonoHandle</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#624fd4f2-b23e-4c78-a095-49e082f3f321'>Moved</a></td><td style='width:75%' ><p>The private <code>Moved</code> field of the <code>KimonoHandle</code> class holds a <code>KimonoCore.Kimono.SkiaPointEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#93627e90-c69f-4664-b1ba-9afebe305510'>Color</a></td><td style='width:75%' ><p>The public <code>Color</code> property of the <code>KimonoHandle</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f935282c-9903-42d1-a784-bb7197c847d2'>Constraint</a></td><td style='width:75%' class='def'><p>The public <code>Constraint</code> property of the <code>KimonoHandle</code> class has a <code>KimonoCore.KimonoHandleConstraint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a215d694-6e82-40f8-91ce-f976478d67e0'>HandleType</a></td><td style='width:75%' ><p>The public <code>HandleType</code> property of the <code>KimonoHandle</code> class has a <code>KimonoCore.KimonoHandleType</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67d948cd-e9d3-4e9a-9062-32c524dac597'>HitOffset</a></td><td style='width:75%' class='def'><p>The public <code>HitOffset</code> property of the <code>KimonoHandle</code> class has a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae47a554-2a62-44d5-b932-ff3ff759060c'>Index</a></td><td style='width:75%' ><p>The public <code>Index</code> property of the <code>KimonoHandle</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72bdffad-6a78-4e4c-b106-77419f0b12b8'>LinkedColor</a></td><td style='width:75%' class='def'><p>The public <code>LinkedColor</code> property of the <code>KimonoHandle</code> class has a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6309e81d-b3b3-4ff5-9419-4c9544e48b29'>Rect</a></td><td style='width:75%' ><p>The public read only <code>Rect</code> property of the <code>KimonoHandle</code> class has a <code>SkiaSharp.SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91a99171-d36f-4b7a-b1db-1b5c52c48dfa'>RepresentedColor</a></td><td style='width:75%' class='def'><p>The public read only <code>RepresentedColor</code> property of the <code>KimonoHandle</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c121ef4-2da4-4c16-9e17-71c70d79641d'>State</a></td><td style='width:75%' ><p>The public <code>State</code> property of the <code>KimonoHandle</code> class has a <code>KimonoCore.KimonoShapeState</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f4015f5-96db-4a5c-af1b-e6641c800f09'>UniqueID</a></td><td style='width:75%' class='def'><p>The public <code>UniqueID</code> property of the <code>KimonoHandle</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#509d9ccd-591e-4419-a933-45c193088bee'>X</a></td><td style='width:75%' ><p>The public <code>X</code> property of the <code>KimonoHandle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#faa3c969-4d6c-4cc0-9ddc-9215dbe79bfe'>Y</a></td><td style='width:75%' class='def'><p>The public <code>Y</code> property of the <code>KimonoHandle</code> class has a <code>System.Single</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fb473989-d62a-4dcc-9c1c-3cd309d07ddc'>Clone</a></td><td style='width:75%' ><p>The public <code>Clone ()</code> member of the <code>KimonoHandle</code> class returns a <code>KimonoCore.KimonoHandle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a66efc7e-19a1-4967-be21-3a983a43d24a'>DragHandle</a></td><td style='width:75%' class='def'><p>The public <code>DragHandle (SkiaSharp.SKPoint)</code> member of the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f2a0839-8f2a-4e4c-8c0c-ebda8cb2e052'>Draw</a></td><td style='width:75%' ><p>The public <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8310974-1103-47cc-93ea-322589842907'>KimonoHandle</a></td><td style='width:75%' class='def'><p>The private static <code>KimonoHandle ()</code> constructor for the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56013472-ab38-4319-af4c-744b69ec3a47'>KimonoHandle</a></td><td style='width:75%' ><p>The public <code>KimonoHandle (System.Single, System.Single)</code> constructor for the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c13f6dd-7d7b-4642-943b-797e85a8bde5'>KimonoHandle</a></td><td style='width:75%' class='def'><p>The public <code>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)</code> constructor for the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7fb39df-1590-4dc2-be24-94381d04c813'>KimonoHandle</a></td><td style='width:75%' ><p>The public <code>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdce73d6-4b5e-4803-ad34-88e042a370f5'>KimonoHandle</a></td><td style='width:75%' class='def'><p>The public <code>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#527435f9-da1d-41f8-93e1-238158dcd67c'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.Single, System.Single)</code> member of the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c57e4b6-44cc-4507-b65a-e9f41afd4118'>PointInBound</a></td><td style='width:75%' class='def'><p>The public <code>PointInBound (SkiaSharp.SKPoint)</code> member of the <code>KimonoHandle</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6533653-6c54-415e-b145-f9b74dd35d7e'>RaiseMoved</a></td><td style='width:75%' ><p>The  <code>RaiseMoved (SkiaSharp.SKPoint)</code> member of the <code>KimonoHandle</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#95592c4b-5ffd-4a18-8f8b-14394aeb7902'>Moved</a></td><td style='width:75%' ><p>The <code>Moved</code> event of the <code>KimonoHandle</code> class returns a <code>KimonoCore.Kimono.SkiaPointEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="b6434577-1829-4c70-9960-8f7e394bad29"></a>
##Public Enum KimonoHandleConstraint

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Enum`

###Summary

The public `KimonoHandleConstraint` enum inherits from the `System.Enum` class and is defined in the `KimonoCore` namespace. It defines 5 fields, no properties, no methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8287a340-d27c-457f-a8d1-714668b6c437'>Horizontal</a></td><td style='width:75%' ><p>The public static constant <code>Horizontal</code> field of the <code>KimonoHandleConstraint</code> enum holds a <code>KimonoCore.KimonoHandleConstraint</code> value of <code>1</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cd144d1-729a-4eb2-8784-54bcdddb7c8e'>Locked</a></td><td style='width:75%' class='def'><p>The public static constant <code>Locked</code> field of the <code>KimonoHandleConstraint</code> enum holds a <code>KimonoCore.KimonoHandleConstraint</code> value of <code>3</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5180a2b-bcae-4018-a391-121403f29644'>None</a></td><td style='width:75%' ><p>The public static constant <code>None</code> field of the <code>KimonoHandleConstraint</code> enum holds a <code>KimonoCore.KimonoHandleConstraint</code> value of <code>0</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd32faff-8be4-4731-b61a-23392d75eb3d'>Vertical</a></td><td style='width:75%' class='def'><p>The public static constant <code>Vertical</code> field of the <code>KimonoHandleConstraint</code> enum holds a <code>KimonoCore.KimonoHandleConstraint</code> value of <code>2</code>.</p>
</td></tr></table></p>


---

<a name="26c349b5-1f2e-4106-9168-f9f405f0e58c"></a>
##Public Enum KimonoHandleType

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Enum`

###Summary

The public `KimonoHandleType` enum inherits from the `System.Enum` class and is defined in the `KimonoCore` namespace. It defines 4 fields, no properties, no methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2b562856-7289-4811-8f1b-285fbc363f9c'>ControlPoint</a></td><td style='width:75%' ><p>The public static constant <code>ControlPoint</code> field of the <code>KimonoHandleType</code> enum holds a <code>KimonoCore.KimonoHandleType</code> value of <code>0</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e23fa37-e0a3-4bef-b71d-17d1c9bfd19d'>GradientColor</a></td><td style='width:75%' class='def'><p>The public static constant <code>GradientColor</code> field of the <code>KimonoHandleType</code> enum holds a <code>KimonoCore.KimonoHandleType</code> value of <code>1</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1a50503-377c-42ad-bb23-9033f1d26ecf'>GradientPosition</a></td><td style='width:75%' ><p>The public static constant <code>GradientPosition</code> field of the <code>KimonoHandleType</code> enum holds a <code>KimonoCore.KimonoHandleType</code> value of <code>2</code>.</p>
</td></tr></table></p>


---

<a name="667d7181-027e-4675-907d-34febce25be5"></a>
##Public Class KimonoPortfolio

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoPortfolio` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 15 fields, 6 properties, 62 methods and 8 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#afd6447f-8fad-4e66-b399-afa3fcd7f0c7'>_selectedSketch</a></td><td style='width:75%' ><p>The  <code>_selectedSketch</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf852537-59e1-401c-bc4b-478bb58b818a'>ColorsModified</a></td><td style='width:75%' class='def'><p>The private <code>ColorsModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ce0049e-f521-46ef-9c27-3efd1fd4a72d'>GradientsModified</a></td><td style='width:75%' ><p>The private <code>GradientsModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14f307c7-dfac-46e0-85a4-f7d439c1d529'>NewSketchNumber</a></td><td style='width:75%' class='def'><p>The  <code>NewSketchNumber</code> field of the <code>KimonoPortfolio</code> class holds a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f5d837b-bff7-4480-8801-333e386ccb0e'>RequestNewUndoPoint</a></td><td style='width:75%' ><p>The private <code>RequestNewUndoPoint</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a3ea277-bb3d-49fb-a26e-63505aff4357'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectedShapeChanged</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcfae7c7-cc44-4ead-b1ad-dfc19e221c04'>SelectedSketchDidChange</a></td><td style='width:75%' ><p>The private <code>SelectedSketchDidChange</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13feccfd-51bb-483b-8f4f-51fb8c0384b7'>SelectedSketchWillChange</a></td><td style='width:75%' class='def'><p>The private <code>SelectedSketchWillChange</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4e91ec5-700d-4789-8195-29cec6707b0b'>SketchesModified</a></td><td style='width:75%' ><p>The private <code>SketchesModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef8a4e52-49a4-4e0a-8287-d74f1f0a16be'>StylesModified</a></td><td style='width:75%' class='def'><p>The private <code>StylesModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5b18dc9d-5d11-4941-9ac7-84765262f9a3'>Colors</a></td><td style='width:75%' ><p>The public <code>Colors</code> property of the <code>KimonoPortfolio</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoColor&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36a840d8-5adb-41ac-b159-3ddc9b051d05'>Gradients</a></td><td style='width:75%' class='def'><p>The public <code>Gradients</code> property of the <code>KimonoPortfolio</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoGradient&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81d09865-7f77-4c01-91a1-bf5aa0de3563'>SelectedSketch</a></td><td style='width:75%' ><p>The public <code>SelectedSketch</code> property of the <code>KimonoPortfolio</code> class has a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ead5bb9-277c-4513-94ae-127b2fc15985'>Sketches</a></td><td style='width:75%' class='def'><p>The public <code>Sketches</code> property of the <code>KimonoPortfolio</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoSketch&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e39202b7-3688-4d61-b998-57518f0e7a5c'>Styles</a></td><td style='width:75%' ><p>The public <code>Styles</code> property of the <code>KimonoPortfolio</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoStyle&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f76d175a-b792-4893-b465-f3f44a477399'>UniqueID</a></td><td style='width:75%' class='def'><p>The public <code>UniqueID</code> property of the <code>KimonoPortfolio</code> class has a <code>System.String</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3d245966-32a0-4396-9a39-29621d62699d'>AddNewColor</a></td><td style='width:75%' ><p>The public <code>AddNewColor ()</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc7d4e19-1362-42d5-9c9e-afc6656a8fd0'>AddNewColor</a></td><td style='width:75%' class='def'><p>The public <code>AddNewColor (SkiaSharp.SKColor)</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90ce502a-aaef-4d74-bc83-5fbf7100dd95'>AddNewGradient</a></td><td style='width:75%' ><p>The public <code>AddNewGradient ()</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77e3b05e-6188-4987-acdc-addef18ebec6'>AddNewSketch</a></td><td style='width:75%' class='def'><p>The public <code>AddNewSketch ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bc8fde5-e91f-4c2a-86e5-660695aa5376'>AddNewStyle</a></td><td style='width:75%' ><p>The public <code>AddNewStyle ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd335f5c-d273-46e2-a6e0-a6cedf1df998'>Clone</a></td><td style='width:75%' class='def'><p>The public <code>Clone ()</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c28315f4-3cb5-4a41-9eca-e792c72acb41'>ConvertSelectedShapeToStyle</a></td><td style='width:75%' ><p>The public <code>ConvertSelectedShapeToStyle ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cf5fe44-516c-405c-a586-a745fb13466c'>DeleteColor</a></td><td style='width:75%' class='def'><p>The public <code>DeleteColor (KimonoCore.KimonoColor)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#467de33b-e045-4269-be88-3adc92721d71'>DeleteGradient</a></td><td style='width:75%' ><p>The public <code>DeleteGradient (KimonoCore.KimonoGradient)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#666761f7-122c-4b5f-a6bf-c5d9ca18aa76'>DeleteSelectedSketch</a></td><td style='width:75%' class='def'><p>The public <code>DeleteSelectedSketch ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#144badd8-d793-4d23-ba21-362ede749244'>DeleteStyle</a></td><td style='width:75%' ><p>The public <code>DeleteStyle (KimonoCore.KimonoStyle)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1cfa8ca-9b66-468b-84cf-ff39008ebcc0'>DuplicateColor</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateColor (KimonoCore.KimonoColor)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0efa9c22-777b-46ca-afc6-84a2a3fd106a'>DuplicateGradient</a></td><td style='width:75%' ><p>The public <code>DuplicateGradient (KimonoCore.KimonoGradient)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6671ae0-40b1-40de-9059-e694dba22537'>DuplicateSelectedSketch</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateSelectedSketch ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef94e817-c0be-4545-9179-5d54b6c10914'>DuplicateStyle</a></td><td style='width:75%' ><p>The public <code>DuplicateStyle (KimonoCore.KimonoStyle)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2419d23-726a-4892-9c42-3d4582f35ef8'>FindColor</a></td><td style='width:75%' class='def'><p>The public <code>FindColor (System.String)</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7669aaad-f676-462b-a116-f39012cdde12'>FindGradient</a></td><td style='width:75%' ><p>The public <code>FindGradient (System.String)</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#950f4e51-fbc1-44f3-a13b-10fed100262f'>FindSketch</a></td><td style='width:75%' class='def'><p>The public <code>FindSketch (System.String)</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4e52df5-a711-4245-888a-59e0531d967b'>FindStyle</a></td><td style='width:75%' ><p>The public <code>FindStyle (System.String)</code> member of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b5b034a-b9c0-417d-a4d9-255883d20483'>Initialize</a></td><td style='width:75%' class='def'><p>The  <code>Initialize ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83eb816c-ae88-4297-ab99-b23ebb0a9fd8'>KimonoPortfolio</a></td><td style='width:75%' ><p>The public <code>KimonoPortfolio (System.Boolean)</code> constructor for the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c4882a4-54d9-4510-ae0e-98c8c669193f'>RaiseColorsModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseColorsModified (KimonoCore.KimonoColor)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef7f25b6-773a-4e4b-ae72-0323bb583eec'>RaiseGradientsModified</a></td><td style='width:75%' ><p>The  <code>RaiseGradientsModified (KimonoCore.KimonoGradient)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ec29807-08ac-4964-b86c-08057e743f8e'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>The  <code>RaiseRequestNewUndoPoint ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7ebe340-2e32-4108-9178-e12ed9d80a4d'>RaiseSelectedShapeChanged</a></td><td style='width:75%' ><p>The  <code>RaiseSelectedShapeChanged (KimonoCore.KimonoShape)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3452f671-1b77-4c88-8652-2a1ac454f95e'>RaiseSelectedSketchDidChange</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d18de91-736b-44e4-944a-9c5ee3360855'>RaiseSelectedSketchWillChange</a></td><td style='width:75%' ><p>The  <code>RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5847e6c9-0e55-47e0-9aa3-16fdb8aee566'>RaiseSketchesModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSketchesModified ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97780e9e-14b6-43c8-86c4-7a50442d4e96'>RaiseStylesModified</a></td><td style='width:75%' ><p>The  <code>RaiseStylesModified (KimonoCore.KimonoStyle)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df974b49-982f-4fc9-853e-decfdecc8042'>RelinkColors</a></td><td style='width:75%' class='def'><p>The  <code>RelinkColors ()</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d62be691-18d2-4f95-8e9d-cb280de5bcc1'>RelinkGradient</a></td><td style='width:75%' ><p>The  <code>RelinkGradient (KimonoCore.KimonoGradient)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95fd683b-a66e-4c25-8d00-bb51511ec42f'>RelinkShape</a></td><td style='width:75%' class='def'><p>The  <code>RelinkShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#064ea090-0461-4547-a1bb-1535d16043bf'>RelinkSketch</a></td><td style='width:75%' ><p>The  <code>RelinkSketch (KimonoCore.KimonoSketch)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9cd293e-bdce-477d-9fcd-a988bcd97515'>RelinkStyle</a></td><td style='width:75%' class='def'><p>The  <code>RelinkStyle (KimonoCore.KimonoStyle)</code> member of the <code>KimonoPortfolio</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#67945210-946a-4565-885f-f6def512d799'>ColorsModified</a></td><td style='width:75%' ><p>The <code>ColorsModified</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1468c79c-2b7d-42a9-9c13-e3baf9c2b8df'>GradientsModified</a></td><td style='width:75%' class='def'><p>The <code>GradientsModified</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5c52844-317f-4502-8867-03c717723ca3'>RequestNewUndoPoint</a></td><td style='width:75%' ><p>The <code>RequestNewUndoPoint</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79dd2777-5cd6-44e0-a2fb-e61134189429'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p>The <code>SelectedShapeChanged</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bceb599-6d62-492f-9948-f70132b2738e'>SelectedSketchDidChange</a></td><td style='width:75%' ><p>The <code>SelectedSketchDidChange</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2e32fff-8356-4212-9bf2-a89dea91d579'>SelectedSketchWillChange</a></td><td style='width:75%' class='def'><p>The <code>SelectedSketchWillChange</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cfb2e7d-b21d-416b-975d-18b90535948f'>SketchesModified</a></td><td style='width:75%' ><p>The <code>SketchesModified</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c878d64-164b-4982-b3c4-8721dbe5a629'>StylesModified</a></td><td style='width:75%' class='def'><p>The <code>StylesModified</code> event of the <code>KimonoPortfolio</code> class returns a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5"></a>
##Public Class KimonoShape

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `KimonoShape` class inherits from the `KimonoCore.KimonoBounds` class and is defined in the `KimonoCore` namespace. It defines 5 fields, 6 properties, 22 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2519edfc-a0ed-4d21-aba8-951c459be5a7'>_name</a></td><td style='width:75%' ><p>The private <code>_name</code> field of the <code>KimonoShape</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bb194df-bd4a-4b29-949f-ab503e695973'>_style</a></td><td style='width:75%' class='def'><p>The  <code>_style</code> field of the <code>KimonoShape</code> class holds a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb3acd53-df6d-4ac8-9e3e-e1fafed191ee'>_visible</a></td><td style='width:75%' ><p>The  <code>_visible</code> field of the <code>KimonoShape</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fa7d2a21-ba88-4430-bb93-d642a3ee6b85'>ControlPoints</a></td><td style='width:75%' ><p>The public <code>ControlPoints</code> property of the <code>KimonoShape</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoHandle&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa8ae91d-04cc-4ec4-80ae-f06eeeb26bfd'>IsEditable</a></td><td style='width:75%' class='def'><p>The public read only virtual <code>IsEditable</code> property of the <code>KimonoShape</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82eab041-9c49-4202-accd-6bfa928892a6'>LayerDepth</a></td><td style='width:75%' ><p>The public <code>LayerDepth</code> property of the <code>KimonoShape</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0628dfaa-fe57-4901-a857-09c802ba3602'>Name</a></td><td style='width:75%' class='def'><p>The public <code>Name</code> property of the <code>KimonoShape</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ff31721-df6c-4326-8b0d-9de5f0c57a62'>Style</a></td><td style='width:75%' ><p>The public virtual <code>Style</code> property of the <code>KimonoShape</code> class has a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05bef948-78d4-42dc-a0d4-91618de1c326'>Visible</a></td><td style='width:75%' class='def'><p>The public virtual <code>Visible</code> property of the <code>KimonoShape</code> class has a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#90662c55-92a7-48e9-88cb-6b1c6b2b01a1'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShape</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#faf657f6-3960-4002-8060-3a88b00993d5'>CloneAttachedStyle</a></td><td style='width:75%' class='def'><p>The  <code>CloneAttachedStyle ()</code> member of the <code>KimonoShape</code> class returns a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#672d1b8a-5d5f-4384-a0f3-aa03b062b62a'>ConformGradientToShape</a></td><td style='width:75%' ><p>The public virtual <code>ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)</code> member of the <code>KimonoShape</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f57541eb-4680-4c57-ac55-1c047dd35647'>EndEditing</a></td><td style='width:75%' class='def'><p>The public virtual <code>EndEditing ()</code> member of the <code>KimonoShape</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7189f07d-ee7a-4a2d-8db1-4203b0e30971'>Initialize</a></td><td style='width:75%' ><p>The  <code>Initialize ()</code> member of the <code>KimonoShape</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7986c1d-5099-4a21-8310-e0e987f6b1c8'>KimonoShape</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShape ()</code> constructor for the <code>KimonoShape</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3b89118-5039-4030-b678-dcb145215a3f'>KimonoShape</a></td><td style='width:75%' ><p>The public <code>KimonoShape (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShape</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2cd08f4-490b-4a0d-8da0-75d2ae9043fc'>KimonoShape</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShape</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbc68275-738c-4314-898f-faaa4368955e'>StartEditing</a></td><td style='width:75%' ><p>The public virtual <code>StartEditing ()</code> member of the <code>KimonoShape</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e11bf97-c48f-4e26-bd60-0a6503335e8c'>ToVector</a></td><td style='width:75%' class='def'><p>The public virtual <code>ToVector ()</code> member of the <code>KimonoShape</code> class returns a <code>KimonoCore.KimonoShapeVector</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae3e9cb4-1c60-4ee5-a9fe-847295e2218f'>UncoupleDeletedStyle</a></td><td style='width:75%' ><p>The public virtual <code>UncoupleDeletedStyle (KimonoCore.KimonoStyle)</code> member of the <code>KimonoShape</code> class.</p>
</td></tr></table></p>


---

<a name="2dd7ed00-7125-446f-a83a-4a1b7594819c"></a>
##Public Class KimonoShapeArrow

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeArrow` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines 5 fields, 5 properties, 18 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8ca632c8-6ff7-4cc7-beb0-85d542a6f09c'>HasEndHead</a></td><td style='width:75%' ><p>The public <code>HasEndHead</code> property of the <code>KimonoShapeArrow</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78b2628f-f8f8-48c3-82de-ba548edc6728'>HasStartHead</a></td><td style='width:75%' class='def'><p>The public <code>HasStartHead</code> property of the <code>KimonoShapeArrow</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9bb33fd-195b-4cd0-8a97-431314f38714'>HeadInnerRatio</a></td><td style='width:75%' ><p>The public <code>HeadInnerRatio</code> property of the <code>KimonoShapeArrow</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f15f170c-26b0-4a02-865b-927995c7b005'>HeadOuterRatio</a></td><td style='width:75%' class='def'><p>The public <code>HeadOuterRatio</code> property of the <code>KimonoShapeArrow</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2e1d678-442d-4086-984e-407867f682b1'>IsStreamlined</a></td><td style='width:75%' ><p>The public <code>IsStreamlined</code> property of the <code>KimonoShapeArrow</code> class has a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#aff31888-0f0e-481d-be81-8740cb9752af'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeArrow</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8166236-cf5b-469d-b926-fe3a54402d43'>DragBounds</a></td><td style='width:75%' class='def'><p>The public virtual <code>DragBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e53d2cf-1714-4a43-a260-fbbabff916e2'>Draw</a></td><td style='width:75%' ><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb01e0da-f22c-4b87-9113-6df3a13b1a87'>GrowBounds</a></td><td style='width:75%' class='def'><p>The public virtual <code>GrowBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8706535e-b00a-45ca-a5cb-c4ac7f432b4d'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52763ac7-ca21-46de-93a6-7e8f3b4246c6'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeArrow ()</code> constructor for the <code>KimonoShapeArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75e2e659-d220-4969-83ce-7a0c62e06ad7'>KimonoShapeArrow</a></td><td style='width:75%' ><p>The public <code>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4b5b3e1-848b-45f5-a07b-ec95697bf227'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeArrow</code> class.</p>
</td></tr></table></p>


---

<a name="d0e87798-7ac4-4bc0-b144-091e7a48bd33"></a>
##Public Class KimonoShapeGroup

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeGroup` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines 9 fields, 13 properties, 71 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#86d274da-e546-4d5e-930f-4fb8d94a9264'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoShapeGroup</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44bf14f3-6576-4a7b-851e-b153b4fc1d9c'>Dragging</a></td><td style='width:75%' class='def'><p>The private <code>Dragging</code> field of the <code>KimonoShapeGroup</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96f30a0b-4e4c-4085-a502-dbab895bbd6b'>IgnoreDrag</a></td><td style='width:75%' ><p>The private <code>IgnoreDrag</code> field of the <code>KimonoShapeGroup</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#583c5cee-ea7e-491e-86da-c6bb2476a40a'>PerformingDrag</a></td><td style='width:75%' class='def'><p>The private <code>PerformingDrag</code> field of the <code>KimonoShapeGroup</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26920769-cc5e-41e2-ab8b-ccc7afdd6538'>ShapeUnderConstruction</a></td><td style='width:75%' ><p>The private <code>ShapeUnderConstruction</code> field of the <code>KimonoShapeGroup</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a993f1ad-e717-4c52-98fa-4fd8a07f55f6'>ToolDownAt</a></td><td style='width:75%' class='def'><p>The private <code>ToolDownAt</code> field of the <code>KimonoShapeGroup</code> class holds a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#57afe74b-af2c-4eb6-b67d-f0a0cee39abd'>DeeplySelectedGroup</a></td><td style='width:75%' ><p>The public read only <code>DeeplySelectedGroup</code> property of the <code>KimonoShapeGroup</code> class has a <code>KimonoCore.KimonoShapeGroup</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01157665-9ad2-4887-98f2-b5858e3b85d1'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p>The public read only <code>DeeplySelectedShape</code> property of the <code>KimonoShapeGroup</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6814433b-b077-4a46-952e-8c0bcc9f10c5'>GroupType</a></td><td style='width:75%' ><p>The public <code>GroupType</code> property of the <code>KimonoShapeGroup</code> class has a <code>KimonoCore.KimonoShapeGroupType</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b15475ab-3af4-4ccd-a428-c2f1f3cc67a5'>IsEditable</a></td><td style='width:75%' class='def'><p>The public read only virtual <code>IsEditable</code> property of the <code>KimonoShapeGroup</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f562fc5b-0d53-4998-9bec-ce773b524a25'>Parent</a></td><td style='width:75%' ><p>The public <code>Parent</code> property of the <code>KimonoShapeGroup</code> class has a <code>System.Object</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1e046b4-7b71-4f93-9323-cf2cd9b0156d'>ParentSketch</a></td><td style='width:75%' class='def'><p>The public read only <code>ParentSketch</code> property of the <code>KimonoShapeGroup</code> class has a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05b958dc-dcda-4ebe-8d5a-d751349e5015'>Path</a></td><td style='width:75%' ><p>The public read only <code>Path</code> property of the <code>KimonoShapeGroup</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85e0ca2c-bcd5-441a-945d-ef896474667c'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoShapeGroup</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1746b332-e51a-4a87-958d-2dc9d2cf18af'>SelectedShapeAtBottom</a></td><td style='width:75%' ><p>The public read only <code>SelectedShapeAtBottom</code> property of the <code>KimonoShapeGroup</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4451a58d-ef4c-4f6a-9d21-19bf79ca3663'>SelectedShapeAtTop</a></td><td style='width:75%' class='def'><p>The public read only <code>SelectedShapeAtTop</code> property of the <code>KimonoShapeGroup</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86c9136c-abb2-4454-b3fb-c007b0fed060'>Shapes</a></td><td style='width:75%' ><p>The public <code>Shapes</code> property of the <code>KimonoShapeGroup</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoShape&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2931890a-0a3e-4af7-b2c5-1909ea208ab2'>Style</a></td><td style='width:75%' class='def'><p>The public virtual <code>Style</code> property of the <code>KimonoShapeGroup</code> class has a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26aaa78d-e098-4ed1-852f-0141bf4139d6'>Visible</a></td><td style='width:75%' ><p>The public virtual <code>Visible</code> property of the <code>KimonoShapeGroup</code> class has a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f2901133-dfb0-4d9a-b5d7-4def2ded6787'>AddShape</a></td><td style='width:75%' ><p>The public <code>AddShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c40bcde-a304-4db1-89d2-e2e90a95566b'>AlignAllBottom</a></td><td style='width:75%' class='def'><p>The public <code>AlignAllBottom ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbd44d13-b352-474f-a9df-36297a77cc6e'>AlignAllCenter</a></td><td style='width:75%' ><p>The public <code>AlignAllCenter ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e82e3202-ca41-4f7b-b60e-daa02560fac3'>AlignAllCenterHorizontal</a></td><td style='width:75%' class='def'><p>The public <code>AlignAllCenterHorizontal ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b6b0a3c-7503-4786-92a2-5f74be6142f6'>AlignAllCenterVertical</a></td><td style='width:75%' ><p>The public <code>AlignAllCenterVertical ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82972f7a-a13b-4885-b095-eddaec19c0e6'>AlignAllLeft</a></td><td style='width:75%' class='def'><p>The public <code>AlignAllLeft ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21ab55de-63cb-4d71-a99b-034a64702edb'>AlignAllRight</a></td><td style='width:75%' ><p>The public <code>AlignAllRight ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42a77b07-62b2-4ae3-a2bc-fe10454eadc6'>AlignAllTop</a></td><td style='width:75%' class='def'><p>The public <code>AlignAllTop ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85cb8f29-c770-4566-b36e-97856e09438d'>ApplyMoveAndScale</a></td><td style='width:75%' ><p>The private <code>ApplyMoveAndScale ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3cb8391-3892-4982-a72b-4e6e20b19c11'>BoundsChanged</a></td><td style='width:75%' class='def'><p>The public virtual <code>BoundsChanged ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#157683d4-e429-4543-8c56-9f10ec56b9fd'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeGroup</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee56d479-8258-4e72-b28d-e56ce40a2ab4'>DeleteColor</a></td><td style='width:75%' class='def'><p>The public <code>DeleteColor (KimonoCore.KimonoColor)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e57ff48a-f8ac-48a4-ba58-3792be6d60bf'>DeleteGradient</a></td><td style='width:75%' ><p>The public <code>DeleteGradient (KimonoCore.KimonoGradient)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2411e69-f713-4800-a808-a16ca92a0beb'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>DeleteSelectedShape ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1bd8a52-048f-4b36-9a60-74f5b1b0acfe'>DeleteShapes</a></td><td style='width:75%' ><p>The public <code>DeleteShapes ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36721b03-8290-4547-adc8-693507bcda84'>DeleteShapes</a></td><td style='width:75%' class='def'><p>The public <code>DeleteShapes (KimonoCore.KimonoShapeGroup)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98be0cdf-ebe0-4c71-a905-51518fa777e4'>DeleteShapes</a></td><td style='width:75%' ><p>The public <code>DeleteShapes (KimonoCore.KimonoSketch)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb3cab47-9b2c-484e-9fc6-115712a2cb9e'>DeselectAll</a></td><td style='width:75%' class='def'><p>The public <code>DeselectAll ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cc1cd12-79f5-4f42-911d-2d57208b54dc'>DragBounds</a></td><td style='width:75%' ><p>The public virtual <code>DragBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3690b898-1ca3-4650-b89c-e9e6c5e8c168'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd2faecf-bfa0-4799-9065-a00c061ab83c'>DuplicateSelectedShape</a></td><td style='width:75%' ><p>The public <code>DuplicateSelectedShape ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7b99718-bc79-40e7-9cb5-1c3e2846db7b'>DuplicateShapes</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateShapes ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e355321-468f-4fab-a171-be593efdd9cc'>DuplicateShapes</a></td><td style='width:75%' ><p>The public <code>DuplicateShapes (KimonoCore.KimonoShapeGroup)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9a6ffa1-d4dd-4a73-b569-0d542cb4e601'>DuplicateShapes</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateShapes (KimonoCore.KimonoSketch)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c791575-ca00-4cf4-9480-a9121745d3c8'>EndEditing</a></td><td style='width:75%' ><p>The public virtual <code>EndEditing ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37565a02-58b0-4c51-9c0b-9ad6c7f4661c'>FindShape</a></td><td style='width:75%' class='def'><p>The public <code>FindShape (System.String)</code> member of the <code>KimonoShapeGroup</code> class returns a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfc60c82-26e0-43c8-b3dd-487fa077696f'>GroupShapes</a></td><td style='width:75%' ><p>The public <code>GroupShapes ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#986cd184-e4ac-49f2-b599-10a65f653c60'>GroupShapes</a></td><td style='width:75%' class='def'><p>The public <code>GroupShapes (KimonoCore.KimonoShapeGroup)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#116d1ac0-1c14-4f70-9a07-ab282fdb4cba'>GroupShapes</a></td><td style='width:75%' ><p>The public <code>GroupShapes (KimonoCore.KimonoSketch)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35348465-41ad-4d59-b26b-0b7b3b1d5da6'>Initialize</a></td><td style='width:75%' class='def'><p>The private <code>Initialize (System.Object)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d99a258-2c65-4694-a521-94b8359ead92'>KimonoShapeGroup</a></td><td style='width:75%' ><p>The public <code>KimonoShapeGroup (System.Object)</code> constructor for the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c334c18a-1242-4f76-9f2a-73c2629a7dbb'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c12bbd6f-3e99-420e-aa91-4510b5a7805b'>KimonoShapeGroup</a></td><td style='width:75%' ><p>The public <code>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6f5400f-b70d-4229-9458-bc11e04bdda5'>MoveSelectedShapeBackwards</a></td><td style='width:75%' class='def'><p>The public <code>MoveSelectedShapeBackwards ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb2d38dc-f334-4580-b8e6-5f04a153bc78'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p>The public <code>MoveSelectedShapeForwards ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#174ab2b5-fc99-4a01-92b2-7a9359be7177'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p>The public <code>MoveSelectedShapeToBottom ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c8014a3-19ff-4d86-ab82-f4023fc10050'>MoveSelectedShapeToTop</a></td><td style='width:75%' ><p>The public <code>MoveSelectedShapeToTop ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ecbde43-70c7-4521-9bd4-ad50fdfcf1f9'>PointInBound</a></td><td style='width:75%' class='def'><p>The public virtual <code>PointInBound (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4cad308-d388-445d-99b2-c89720987e0a'>RecalculateGroupBounds</a></td><td style='width:75%' ><p>The public <code>RecalculateGroupBounds ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d9844f7-499d-4dca-9c33-5d1df16be38c'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p>The public <code>RecalculateLayerDepths ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92103ed7-3f05-48d0-b022-3d1cae01e203'>RelinkShape</a></td><td style='width:75%' ><p>The  <code>RelinkShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#884d6584-ed47-4e65-b301-63db26c4e221'>RemoveShape</a></td><td style='width:75%' class='def'><p>The public <code>RemoveShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b2fee38-347c-45f5-94b5-072de9d21181'>ReturnToSketch</a></td><td style='width:75%' ><p>The public <code>ReturnToSketch ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23198712-f52d-4fb3-a744-2affbc886a26'>SelectShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f510773a-0afc-4714-ada8-508cd6e19760'>ShapeInGroup</a></td><td style='width:75%' ><p>The public <code>ShapeInGroup (KimonoCore.KimonoShape)</code> member of the <code>KimonoShapeGroup</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#325d3b01-fc67-48fc-b12d-84be6e9d1431'>StartEditing</a></td><td style='width:75%' class='def'><p>The public virtual <code>StartEditing ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#955e96b4-1248-4357-81cf-082ee011dbe9'>ToolDown</a></td><td style='width:75%' ><p>The public <code>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ae7070d-6fda-4c57-a683-40a679d7e48b'>ToolDrag</a></td><td style='width:75%' class='def'><p>The public <code>ToolDrag (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9181f0c-5815-4be1-bc43-7aaba9ef9ae3'>ToolUp</a></td><td style='width:75%' ><p>The public <code>ToolUp (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de69f412-bf03-42e0-ba09-4577ab156040'>UngroupShapes</a></td><td style='width:75%' class='def'><p>The public <code>UngroupShapes ()</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1869b5fd-fbe3-421d-9d26-c7833e508274'>UngroupShapes</a></td><td style='width:75%' ><p>The public <code>UngroupShapes (KimonoCore.KimonoShapeGroup)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2b57d2f-7723-45c4-86cd-67a6fbbb9b37'>UngroupShapes</a></td><td style='width:75%' class='def'><p>The public <code>UngroupShapes (KimonoCore.KimonoSketch)</code> member of the <code>KimonoShapeGroup</code> class.</p>
</td></tr></table></p>


---

<a name="7d6f36d2-8266-4a30-b62d-bf0d805c00fe"></a>
##Public Enum KimonoShapeGroupType

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Enum`

###Summary

The public `KimonoShapeGroupType` enum inherits from the `System.Enum` class and is defined in the `KimonoCore` namespace. It defines 4 fields, no properties, no methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#77c523ed-b5a4-48ed-a0b1-d341119ce2e0'>Collection</a></td><td style='width:75%' ><p>The public static constant <code>Collection</code> field of the <code>KimonoShapeGroupType</code> enum holds a <code>KimonoCore.KimonoShapeGroupType</code> value of <code>2</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c71f603-dcea-4d4a-90d0-c1ecd5765edc'>DragSelect</a></td><td style='width:75%' class='def'><p>The public static constant <code>DragSelect</code> field of the <code>KimonoShapeGroupType</code> enum holds a <code>KimonoCore.KimonoShapeGroupType</code> value of <code>1</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20b97c21-ab5d-4285-88d2-bc424cbfcf8b'>Selection</a></td><td style='width:75%' ><p>The public static constant <code>Selection</code> field of the <code>KimonoShapeGroupType</code> enum holds a <code>KimonoCore.KimonoShapeGroupType</code> value of <code>0</code>.</p>
</td></tr></table></p>


---

<a name="6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8"></a>
##Public Class KimonoShapeLine

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeLine` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines no fields, no properties, 6 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7abf9511-1801-4285-b108-4c57f01f044f'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeLine</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38890551-07f3-43cb-a597-4d45cbe6fe9e'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeLine</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4188863-2260-4fad-80dc-460bd752faf2'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeLine</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e26907ff-1c33-417a-aa45-e547bc6403d1'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeLine ()</code> constructor for the <code>KimonoShapeLine</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4653966c-a947-4c54-8423-edcc55cc3f9b'>KimonoShapeLine</a></td><td style='width:75%' ><p>The public <code>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeLine</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#062e89e9-dfcb-45b2-b0d3-adec2c7b69b9'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeLine</code> class.</p>
</td></tr></table></p>


---

<a name="68719e7d-0150-4764-ab5b-951410790c56"></a>
##Public Class KimonoShapeOval

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeOval` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines no fields, no properties, 6 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b116817f-e68c-4245-9e29-d818ed566f00'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeOval</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce55fb8f-1f1a-4e21-9fc1-0db047265b81'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeOval</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#566b4e7c-c11a-45f6-850a-698b8a507c22'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeOval</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57f63ef4-c231-4b88-81d2-906079cd4d60'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeOval ()</code> constructor for the <code>KimonoShapeOval</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10da9e2b-0944-4b1c-9f7c-6ea78ac4293e'>KimonoShapeOval</a></td><td style='width:75%' ><p>The public <code>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeOval</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d7b6959-7486-4467-b99d-020492c6e87c'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeOval</code> class.</p>
</td></tr></table></p>


---

<a name="f0de3411-8576-4c57-8adc-c347de6f9e61"></a>
##Public Class KimonoShapePolygon

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapePolygon` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines one field, one property, 9 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0d45c481-0d01-4cf4-a503-8085b26965a8'>NumberOfSides</a></td><td style='width:75%' ><p>The public <code>NumberOfSides</code> property of the <code>KimonoShapePolygon</code> class has a <code>System.Int32</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#70d07f23-ded6-4cee-b301-b9a4ea484ff2'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapePolygon</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96a564b2-aa5f-451f-9a54-62fba23944a2'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapePolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97a755c9-537e-42cc-beab-ce6111adad0a'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapePolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7808282d-2577-400a-b1ff-ce42d2a02454'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapePolygon ()</code> constructor for the <code>KimonoShapePolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68093fa7-1a5f-407b-bd49-8dc6db1c863c'>KimonoShapePolygon</a></td><td style='width:75%' ><p>The public <code>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapePolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa11bb4e-737c-4bed-bf8e-213134153f7b'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapePolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bd28291-d6ee-46c3-b497-750ca81e3691'>MakeSidePoints</a></td><td style='width:75%' ><p>The private <code>MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)</code> member of the <code>KimonoShapePolygon</code> class returns a <code>SkiaSharp.SKPoint[]</code> value.</p>
</td></tr></table></p>


---

<a name="2ca1fe46-06b3-4864-bc70-9399db18d5b6"></a>
##Public Class KimonoShapeRect

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeRect` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines no fields, no properties, 6 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d6540023-22b0-496d-9ad0-f0bfbe1db1ac'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeRect</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#231884a6-4dff-43b9-aed4-a9428eca101e'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8dbb508c-ab9e-4553-9216-af01de39ae2c'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc455a1a-3bce-43e5-bd73-dd61b8ea22e4'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeRect ()</code> constructor for the <code>KimonoShapeRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c243331a-04c9-4ea3-818b-a13de793e00d'>KimonoShapeRect</a></td><td style='width:75%' ><p>The public <code>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd3081cd-d0bc-4da4-8ee5-bb181f8032d5'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeRect</code> class.</p>
</td></tr></table></p>


---

<a name="f030891f-b2f6-43bf-8b30-4bb33dcf09b2"></a>
##Public Class KimonoShapeRoundRect

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeRoundRect` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines one field, one property, 10 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3318a443-1cfa-4e2e-a0de-e64e683498f6'>CornerRadius</a></td><td style='width:75%' ><p>The public <code>CornerRadius</code> property of the <code>KimonoShapeRoundRect</code> class has a <code>System.Single</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f3cc08c5-b7e1-4dbf-8b7d-a52cfe57469a'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeRoundRect</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a16d564e-50eb-4998-bb4c-0502332573ad'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dd7ce7a-759f-4a7b-a28e-a298cac538f4'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1605b28-8d33-4b8f-8b36-b771d682b32d'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeRoundRect ()</code> constructor for the <code>KimonoShapeRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56057e42-b218-4a3d-8a30-4121b3a13a33'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>The public <code>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4246fb6e-5052-4773-88a2-e7d0a41f0525'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3eafea5d-7cc2-4064-a8f5-f4fd39741cfd'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>The public <code>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f475826c-1407-4203-9375-b98d57c52efd'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeRoundRect</code> class.</p>
</td></tr></table></p>


---

<a name="64605364-e990-4030-80f9-303d6eea30c5"></a>
##Public Class KimonoShapeStar

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeStar` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines 3 fields, 3 properties, 16 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9e29bede-bd6b-44cf-920b-23fec80c9335'>DepthOffset</a></td><td style='width:75%' ><p>The public <code>DepthOffset</code> property of the <code>KimonoShapeStar</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5acc1b7a-9989-4dd6-8325-5f46a2897ab3'>NumberOfPoints</a></td><td style='width:75%' class='def'><p>The public <code>NumberOfPoints</code> property of the <code>KimonoShapeStar</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ef62a0a-ca6f-49ec-937e-48bbc0c72e54'>SkipPoints</a></td><td style='width:75%' ><p>The public <code>SkipPoints</code> property of the <code>KimonoShapeStar</code> class has a <code>System.Int32</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1e8d2164-f532-4732-a798-515f96f17891'>CalculateConcaveRadius</a></td><td style='width:75%' ><p>The private <code>CalculateConcaveRadius (System.Int32, System.Int32)</code> member of the <code>KimonoShapeStar</code> class returns a <code>System.Double</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d941b671-693c-4d76-a4e1-73d643a97697'>Clone</a></td><td style='width:75%' class='def'><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeStar</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69cc7c2e-264b-4204-a48b-0e5fe09ad1c4'>Draw</a></td><td style='width:75%' ><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#234f7172-b34e-4465-902a-ca89b286cabf'>FindIntersection</a></td><td style='width:75%' class='def'><p>The private <code>FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean&amp;, System.Boolean&amp;, SkiaSharp.SKPoint&amp;, SkiaSharp.SKPoint&amp;, SkiaSharp.SKPoint&amp;)</code> member of the <code>KimonoShapeStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c4063d5-dda1-4f71-897f-636e7dfe97f0'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ddca0fc-9994-41c9-a78f-69a14550f281'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeStar ()</code> constructor for the <code>KimonoShapeStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#309859e5-d450-48be-95dc-2e28367f6968'>KimonoShapeStar</a></td><td style='width:75%' ><p>The public <code>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f063e7f1-44ba-46c9-b4f1-c36346758a4d'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc23bf27-289f-4599-b43a-ed8b07476fb4'>MakeStarPoints</a></td><td style='width:75%' ><p>The private <code>MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)</code> member of the <code>KimonoShapeStar</code> class returns a <code>SkiaSharp.SKPoint[]</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c12d0697-8d37-462e-ad4b-1c2a72502116'>ToVector</a></td><td style='width:75%' class='def'><p>The public virtual <code>ToVector ()</code> member of the <code>KimonoShapeStar</code> class returns a <code>KimonoCore.KimonoShapeVector</code> value.</p>
</td></tr></table></p>


---

<a name="dd9f0b12-aa56-4011-8727-9289436b1a36"></a>
##Public Enum KimonoShapeState

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Enum`

###Summary

The public `KimonoShapeState` enum inherits from the `System.Enum` class and is defined in the `KimonoCore` namespace. It defines 7 fields, no properties, no methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bab7b6e2-e79d-48a6-9c3a-92a79980ae78'>Constructing</a></td><td style='width:75%' ><p>The public static constant <code>Constructing</code> field of the <code>KimonoShapeState</code> enum holds a <code>KimonoCore.KimonoShapeState</code> value of <code>4</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b16df70-3fec-427b-9e85-f0d78c631f14'>Editing</a></td><td style='width:75%' class='def'><p>The public static constant <code>Editing</code> field of the <code>KimonoShapeState</code> enum holds a <code>KimonoCore.KimonoShapeState</code> value of <code>2</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57c0af2f-3445-4199-a1a2-a0d322bcb61a'>Finalizing</a></td><td style='width:75%' ><p>The public static constant <code>Finalizing</code> field of the <code>KimonoShapeState</code> enum holds a <code>KimonoCore.KimonoShapeState</code> value of <code>3</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#181d3145-b3e6-4fbb-896e-11f3f3f59e03'>Grouping</a></td><td style='width:75%' class='def'><p>The public static constant <code>Grouping</code> field of the <code>KimonoShapeState</code> enum holds a <code>KimonoCore.KimonoShapeState</code> value of <code>5</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf4b832b-cc3c-4b1b-a265-9d630566cd28'>Selected</a></td><td style='width:75%' ><p>The public static constant <code>Selected</code> field of the <code>KimonoShapeState</code> enum holds a <code>KimonoCore.KimonoShapeState</code> value of <code>1</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b3de089-2faa-40ae-9684-4f47acf527f8'>Unselected</a></td><td style='width:75%' class='def'><p>The public static constant <code>Unselected</code> field of the <code>KimonoShapeState</code> enum holds a <code>KimonoCore.KimonoShapeState</code> value of <code>0</code>.</p>
</td></tr></table></p>


---

<a name="1e3efe51-2fa7-41ca-80dd-505cdc283a79"></a>
##Public Class KimonoShapeText

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeText` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines one field, 14 properties, 35 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#71444a51-edb5-40c4-91f6-790285612e04'>FontFamilyName</a></td><td style='width:75%' ><p>The public <code>FontFamilyName</code> property of the <code>KimonoShapeText</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#776f4e39-49a3-4c58-8e76-78996d176796'>FontMetrics</a></td><td style='width:75%' class='def'><p>The public read only <code>FontMetrics</code> property of the <code>KimonoShapeText</code> class has a <code>SkiaSharp.SKFontMetrics</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec1fc79a-bae6-43df-8b2f-321dda7e61b0'>IsLinearText</a></td><td style='width:75%' ><p>The public <code>IsLinearText</code> property of the <code>KimonoShapeText</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90584ec8-3059-4feb-983e-37bb79e7ffbc'>IsVerticalText</a></td><td style='width:75%' class='def'><p>The public <code>IsVerticalText</code> property of the <code>KimonoShapeText</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2c6b4e7-e468-4c0b-92ea-e8672c186d5c'>StrikeThruText</a></td><td style='width:75%' ><p>The public <code>StrikeThruText</code> property of the <code>KimonoShapeText</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5573f11-e2dc-4065-b741-9563e01404c0'>Text</a></td><td style='width:75%' class='def'><p>The public <code>Text</code> property of the <code>KimonoShapeText</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed163b36-599c-4670-ad9f-4803a7f4ba83'>TextAlign</a></td><td style='width:75%' ><p>The public <code>TextAlign</code> property of the <code>KimonoShapeText</code> class has a <code>SkiaSharp.SKTextAlign</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd358a44-f2a1-44ce-9277-fc417a550c58'>TextEncoding</a></td><td style='width:75%' class='def'><p>The public <code>TextEncoding</code> property of the <code>KimonoShapeText</code> class has a <code>SkiaSharp.SKTextEncoding</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9cc1ec3-926c-455c-8794-737f7fb4ee4f'>TextScaleX</a></td><td style='width:75%' ><p>The public <code>TextScaleX</code> property of the <code>KimonoShapeText</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70a76901-3866-4aa5-8520-6f3b3158ca06'>TextSize</a></td><td style='width:75%' class='def'><p>The public <code>TextSize</code> property of the <code>KimonoShapeText</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38b6bc23-95bd-449e-ad43-6d97b4104f49'>TextSkewX</a></td><td style='width:75%' ><p>The public <code>TextSkewX</code> property of the <code>KimonoShapeText</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8bef667-836c-4a24-af21-3096fef18b61'>Typeface</a></td><td style='width:75%' class='def'><p>The public <code>Typeface</code> property of the <code>KimonoShapeText</code> class has a <code>SkiaSharp.SKTypeface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57888b17-1993-4be1-8aa6-6371b83df79c'>TypefaceStyle</a></td><td style='width:75%' ><p>The public <code>TypefaceStyle</code> property of the <code>KimonoShapeText</code> class has a <code>SkiaSharp.SKTypefaceStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4be9ba8f-f135-4521-bc09-c868a49b9267'>UnderlineText</a></td><td style='width:75%' class='def'><p>The public <code>UnderlineText</code> property of the <code>KimonoShapeText</code> class has a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e45720f2-ddf7-46fa-b9d2-1a041eff47e1'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeText</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbeec0ae-6784-48ce-8535-40958e4fcb2f'>DragBounds</a></td><td style='width:75%' class='def'><p>The public virtual <code>DragBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de26f07f-5e2b-4f2e-9d87-60bcab291df5'>Draw</a></td><td style='width:75%' ><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#612d47a6-658a-4284-bbd4-5b6b4c651966'>GrowBounds</a></td><td style='width:75%' class='def'><p>The public virtual <code>GrowBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afafb67e-6b98-449d-afeb-1ed25655c427'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff04544b-3997-4051-8345-f5ce22394923'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeText ()</code> constructor for the <code>KimonoShapeText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08c56fe9-135b-4fa4-8a06-22090ab1c5e4'>KimonoShapeText</a></td><td style='width:75%' ><p>The public <code>KimonoShapeText (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88814b44-6aeb-4501-9d38-2c9854b4677b'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeText</code> class.</p>
</td></tr></table></p>


---

<a name="91eab6b8-c802-4441-a4b1-e9de268c98fc"></a>
##Public Class KimonoShapeTriangle

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeTriangle` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines no fields, no properties, 6 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d3de9f11-52d4-4d59-b5f3-19534695c39b'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeTriangle</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9c6abe5-da5f-453d-a334-b7623cfae3ef'>Draw</a></td><td style='width:75%' class='def'><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeTriangle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8da60612-f212-4b48-8a9d-aa6562bdba09'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeTriangle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2668d634-6af9-435a-a85f-35b8d5a35cf7'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeTriangle ()</code> constructor for the <code>KimonoShapeTriangle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fc3f7de-9d8a-414e-85c4-cc0cdda7a154'>KimonoShapeTriangle</a></td><td style='width:75%' ><p>The public <code>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeTriangle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bb82ca8-7008-4dca-9400-a002ff9312f7'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeTriangle</code> class.</p>
</td></tr></table></p>


---

<a name="18c66d58-56cf-40e1-8c23-663e3459f52b"></a>
##Public Class KimonoShapeVector

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShapeVector` class inherits from the `KimonoCore.KimonoShape` class and is defined in the `KimonoCore` namespace. It defines 2 fields, 3 properties, 21 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#24862674-c287-430d-a6d9-783f1c7411e3'>Closed</a></td><td style='width:75%' ><p>The public <code>Closed</code> property of the <code>KimonoShapeVector</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc61728c-5241-4164-94da-e5687b7766cc'>IsEditable</a></td><td style='width:75%' class='def'><p>The public read only virtual <code>IsEditable</code> property of the <code>KimonoShapeVector</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81c019dc-e9c4-4289-87fc-4196967c1fce'>Points</a></td><td style='width:75%' ><p>The public <code>Points</code> property of the <code>KimonoShapeVector</code> class has a <code>System.Collections.Generic.List&lt;SkiaSharp.SKPoint&gt;</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#40df9d7e-908a-4a41-aa93-4fc53ae8f379'>AddPoint</a></td><td style='width:75%' ><p>The public <code>AddPoint (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e753e6e-6d8a-4e40-be99-8f6cae088f04'>AddPoint</a></td><td style='width:75%' class='def'><p>The public <code>AddPoint (System.Single, System.Single)</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6c61910-831d-4971-acbf-aaa2e1d14b61'>ApplyMoveAndScale</a></td><td style='width:75%' ><p>The private <code>ApplyMoveAndScale ()</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#224fcd20-fa79-40b0-ad43-33748109b1f9'>BoundsChanged</a></td><td style='width:75%' class='def'><p>The public virtual <code>BoundsChanged ()</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67724f55-0b2a-4340-9960-16e2744594b8'>Clone</a></td><td style='width:75%' ><p>The public virtual <code>Clone ()</code> member of the <code>KimonoShapeVector</code> class returns a <code>KimonoCore.KimonoBounds</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9a8b97d-9d4c-429d-9695-8c1b91876143'>DragBounds</a></td><td style='width:75%' class='def'><p>The public virtual <code>DragBounds (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58e1cbc7-317e-404a-ad09-e5d7fad9119a'>Draw</a></td><td style='width:75%' ><p>The public virtual <code>Draw (SkiaSharp.SKCanvas)</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b97ebced-a2c1-43e2-a3d0-09cf26647797'>Initialize</a></td><td style='width:75%' class='def'><p>The private <code>Initialize ()</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#400605ae-b7ee-49b2-bfbf-9ab33c8f850a'>KimonoShapeVector</a></td><td style='width:75%' ><p>The public <code>KimonoShapeVector ()</code> constructor for the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65812acf-941f-4a3b-b7d0-38efca5ae0e7'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p>The public <code>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)</code> constructor for the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81e3235c-21c2-45a8-9ab1-49e5c67a44a1'>KimonoShapeVector</a></td><td style='width:75%' ><p>The public <code>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</code> constructor for the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a605ccc9-3a7c-4ee1-bcea-752882c633be'>MoveLastPoint</a></td><td style='width:75%' class='def'><p>The public <code>MoveLastPoint (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#896ee42e-13e8-4c96-b4de-1298227e9d0f'>PointInBound</a></td><td style='width:75%' ><p>The public virtual <code>PointInBound (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeVector</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9ac85ab-d1e0-47ca-93b0-a3b4daceb41e'>RecalculateVectorBounds</a></td><td style='width:75%' class='def'><p>The public <code>RecalculateVectorBounds ()</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f499a732-fdd8-4d65-a1fb-d221bb1a1683'>RemovePoint</a></td><td style='width:75%' ><p>The public <code>RemovePoint (System.Int32)</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7220a9d5-83a3-497e-bd74-335030f65f9e'>StartEditing</a></td><td style='width:75%' class='def'><p>The public virtual <code>StartEditing ()</code> member of the <code>KimonoShapeVector</code> class.</p>
</td></tr></table></p>


---

<a name="580760e3-f281-48e0-b51d-b44cb97551f5"></a>
##Public Class KimonoSketch

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoSketch` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 20 fields, 16 properties, 69 methods and 7 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f21e2f52-b912-42aa-bd7d-9183092300f4'>_canvasColor</a></td><td style='width:75%' ><p>The private <code>_canvasColor</code> field of the <code>KimonoSketch</code> class holds a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75315261-ea7d-456f-bd89-9af598c8d9a1'>_selectedShape</a></td><td style='width:75%' class='def'><p>The private <code>_selectedShape</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edb9d73a-5b40-45a4-b058-b3fb99aba34a'>_tool</a></td><td style='width:75%' ><p>The private <code>_tool</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.KimonoTool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87faf000-3a65-425d-9075-1b8c4e71bf34'>IgnoreDrag</a></td><td style='width:75%' class='def'><p>The private <code>IgnoreDrag</code> field of the <code>KimonoSketch</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d5b3703-13e8-4c73-8552-25eff80d31d7'>ImageBufferNeedsRefresh</a></td><td style='width:75%' ><p>The private <code>ImageBufferNeedsRefresh</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a066319-91ce-46ff-a351-d01fdf23b7c2'>PerformingDrag</a></td><td style='width:75%' class='def'><p>The private <code>PerformingDrag</code> field of the <code>KimonoSketch</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cd67449-87a5-4863-806e-affc70755dd2'>PreviousSize</a></td><td style='width:75%' ><p>The private <code>PreviousSize</code> field of the <code>KimonoSketch</code> class holds a <code>SkiaSharp.SKSize</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e958cd9-13a4-42b3-93e5-dcd326c3064b'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>The private <code>RequestNewUndoPoint</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d49c95d0-bca5-4f3a-8100-cfe107d58515'>SelectedShapeModified</a></td><td style='width:75%' ><p>The private <code>SelectedShapeModified</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73f57700-3253-4791-bd29-db3e5d2bce39'>SelectionChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectionChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52518d0a-98e8-4c8b-82d6-35a7d3e76686'>ShapeUnderConstruction</a></td><td style='width:75%' ><p>The  <code>ShapeUnderConstruction</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcb52d14-8408-495b-9afe-3a33f8075a5d'>Size</a></td><td style='width:75%' class='def'><p>The private <code>Size</code> field of the <code>KimonoSketch</code> class holds a <code>SkiaSharp.SKSize</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd03ca63-1904-4c59-9014-3d179e334ee7'>SketchModified</a></td><td style='width:75%' ><p>The private <code>SketchModified</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#470a16e6-049d-4fa7-a5f4-46d64f94d01c'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p>The private <code>SketchSizeChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d70f8657-0ce1-4d8e-a043-d47b043226f7'>ToolChanged</a></td><td style='width:75%' ><p>The private <code>ToolChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#497b26ea-06c5-47e5-89cb-6a193054abdd'>ToolDownAt</a></td><td style='width:75%' class='def'><p>The private <code>ToolDownAt</code> field of the <code>KimonoSketch</code> class holds a <code>SkiaSharp.SKPoint</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5b469474-ece9-485e-add9-d0cb1fa24dd0'>CanAlignShapes</a></td><td style='width:75%' ><p>The public read only <code>CanAlignShapes</code> property of the <code>KimonoSketch</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19c1589a-2fd2-4175-8213-5468ad09b623'>CanGroupShapes</a></td><td style='width:75%' class='def'><p>The public read only <code>CanGroupShapes</code> property of the <code>KimonoSketch</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ebd48a7-3185-4387-be61-86c644f587d0'>CanUngroupShapes</a></td><td style='width:75%' ><p>The public read only <code>CanUngroupShapes</code> property of the <code>KimonoSketch</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b31f2a0e-09a0-439e-a5f1-178f85fffd8d'>CanvasColor</a></td><td style='width:75%' class='def'><p>The public <code>CanvasColor</code> property of the <code>KimonoSketch</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42da8f6d-321f-4b30-88c2-c40b0031f021'>DeeplySelectedGroup</a></td><td style='width:75%' ><p>The public read only <code>DeeplySelectedGroup</code> property of the <code>KimonoSketch</code> class has a <code>KimonoCore.KimonoShapeGroup</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b89b925-a944-4556-8fb3-77cfdc45f342'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p>The public read only <code>DeeplySelectedShape</code> property of the <code>KimonoSketch</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec27a0d2-9fd7-4315-9952-bd7aa4fa8c78'>DrawCanvas</a></td><td style='width:75%' ><p>The public <code>DrawCanvas</code> property of the <code>KimonoSketch</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#982a8b2c-5d96-4b3f-be84-a5bfea2babbb'>Height</a></td><td style='width:75%' class='def'><p>The public <code>Height</code> property of the <code>KimonoSketch</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a012b6d-249d-497c-81ff-a7113eea1d8e'>Name</a></td><td style='width:75%' ><p>The public <code>Name</code> property of the <code>KimonoSketch</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ee8a7c4-5a5f-4a53-a8e7-f154d2146921'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoSketch</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea0e3f86-b02d-4009-a6b0-f7579d3190a5'>SelectedShapeAtBottom</a></td><td style='width:75%' ><p>The public read only <code>SelectedShapeAtBottom</code> property of the <code>KimonoSketch</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffa05f04-3338-4093-aa05-1e0b40a989f1'>SelectedShapeAtTop</a></td><td style='width:75%' class='def'><p>The public read only <code>SelectedShapeAtTop</code> property of the <code>KimonoSketch</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7489aff7-094c-46f0-a6b9-480e14a75b29'>Shapes</a></td><td style='width:75%' ><p>The public <code>Shapes</code> property of the <code>KimonoSketch</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoShape&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8a0bd81-f04c-4de3-bd54-cb75e89ff537'>Tool</a></td><td style='width:75%' class='def'><p>The public <code>Tool</code> property of the <code>KimonoSketch</code> class has a <code>KimonoCore.KimonoTool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3969b6d0-561d-4971-8cfc-37d96aae51fd'>UniqueID</a></td><td style='width:75%' ><p>The public <code>UniqueID</code> property of the <code>KimonoSketch</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41727111-a9f9-42f1-9e8b-fe101363da02'>Width</a></td><td style='width:75%' class='def'><p>The public <code>Width</code> property of the <code>KimonoSketch</code> class has a <code>System.Single</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#caf498a5-0d2e-4800-b29f-d55d63c30713'>AddShape</a></td><td style='width:75%' ><p>The public <code>AddShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c259ccb-326f-4c9b-a2c8-314cb82485bd'>ApplySizeChange</a></td><td style='width:75%' class='def'><p>The private <code>ApplySizeChange ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3e372f2-63d1-4a59-953c-41c11f0ea89b'>Clone</a></td><td style='width:75%' ><p>The public <code>Clone ()</code> member of the <code>KimonoSketch</code> class returns a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25f76383-f9f4-4f57-b43b-e99ca81ff050'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>DeleteSelectedShape ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#282436f7-295d-45a1-a382-4ddbbda9d525'>DeselectAll</a></td><td style='width:75%' ><p>The public <code>DeselectAll ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d01bec2b-f0c6-46cc-8f16-a9a2c9b3325d'>Draw</a></td><td style='width:75%' class='def'><p>The public <code>Draw ()</code> member of the <code>KimonoSketch</code> class returns a <code>SkiaSharp.SKData</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db430062-2b8c-4c1c-ab35-e1eaf29ece37'>DuplicateSelectedShape</a></td><td style='width:75%' ><p>The public <code>DuplicateSelectedShape ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c13f7c3-ec84-444a-a253-166b2c028c92'>FindShape</a></td><td style='width:75%' class='def'><p>The public <code>FindShape (System.String)</code> member of the <code>KimonoSketch</code> class returns a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36e0791e-17cc-4003-b3a5-087530191da0'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p>The public <code>GroupUngroupSelectedShapes ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92450678-a678-4f38-af1e-5ef82f8e765b'>Initialize</a></td><td style='width:75%' class='def'><p>The  <code>Initialize ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d21712d-6457-43c7-afc3-08b573dd0983'>KimonoSketch</a></td><td style='width:75%' ><p>The public <code>KimonoSketch ()</code> constructor for the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c072c7f-e305-4b65-8d47-03a5766040ed'>KimonoSketch</a></td><td style='width:75%' class='def'><p>The public <code>KimonoSketch (System.String, System.Single, System.Single)</code> constructor for the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#032a59fe-7b83-4de6-a17a-76afd21633ef'>MoveSelectedShapeBackwards</a></td><td style='width:75%' ><p>The public <code>MoveSelectedShapeBackwards ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58529416-d513-415a-bc8a-08d944f85799'>MoveSelectedShapeForwards</a></td><td style='width:75%' class='def'><p>The public <code>MoveSelectedShapeForwards ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b511c13-3ebe-40d7-af0d-b0775b8748ab'>MoveSelectedShapeToBottom</a></td><td style='width:75%' ><p>The public <code>MoveSelectedShapeToBottom ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d3e11aa-8daa-48eb-ae43-9b345793f13c'>MoveSelectedShapeToTop</a></td><td style='width:75%' class='def'><p>The public <code>MoveSelectedShapeToTop ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c27e3f0f-9ee5-41e4-8e29-39592d67ed93'>RaiseImageBufferNeedsRefresh</a></td><td style='width:75%' ><p>The  <code>RaiseImageBufferNeedsRefresh ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42a20b76-dfce-4470-8955-1c23d0a4c306'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>The  <code>RaiseRequestNewUndoPoint ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9cb5de40-feee-47e6-8c61-2fa7184002f3'>RaiseSelectedShapeModified</a></td><td style='width:75%' ><p>The  <code>RaiseSelectedShapeModified ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ae02175-fdb7-4cbc-960e-f8145f46849c'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSelectionChanged (KimonoCore.KimonoShape)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f6eecc5-976f-4369-b50e-d404916f3d43'>RaiseSketchModified</a></td><td style='width:75%' ><p>The  <code>RaiseSketchModified ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c15934b-d3d6-45ba-ae40-e3f14f9e46b9'>RaiseSketchSizeChanged</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSketchSizeChanged ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1050a25-c319-4227-a3d3-e8385e64d43f'>RaiseToolChanged</a></td><td style='width:75%' ><p>The  <code>RaiseToolChanged (KimonoCore.KimonoTool)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#887aed35-070e-42c8-858b-4b80a7604446'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p>The public <code>RecalculateLayerDepths ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3054ff45-b7c7-49ee-b247-0ad6cc997940'>RelinkShape</a></td><td style='width:75%' ><p>The  <code>RelinkShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95bcdfd8-b3f3-4c6d-9454-0fde9742615a'>SavePreviousSize</a></td><td style='width:75%' class='def'><p>The private <code>SavePreviousSize ()</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71dbabd6-e4c7-4acf-9b23-357a2377e7d0'>SelectShape</a></td><td style='width:75%' ><p>The public <code>SelectShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30526f4e-2567-473a-b479-a7e79f66f6ac'>ToolDown</a></td><td style='width:75%' class='def'><p>The public <code>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6e6722c-c43b-4ba6-9add-f0b8458881b1'>ToolDrag</a></td><td style='width:75%' ><p>The public <code>ToolDrag (SkiaSharp.SKPoint)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#814c5130-d480-4f06-903a-15a4a17bc364'>ToolUp</a></td><td style='width:75%' class='def'><p>The public <code>ToolUp (SkiaSharp.SKPoint)</code> member of the <code>KimonoSketch</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#20f4b611-4e02-4a12-989d-1d8dfcec5737'>ImageBufferNeedsRefresh</a></td><td style='width:75%' ><p>The <code>ImageBufferNeedsRefresh</code> event of the <code>KimonoSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8f41f2b-5bb9-4bab-8647-a3577704442b'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p>The <code>RequestNewUndoPoint</code> event of the <code>KimonoSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c972696-5833-4c74-8e2d-be10773ca4e1'>SelectedShapeModified</a></td><td style='width:75%' ><p>The <code>SelectedShapeModified</code> event of the <code>KimonoSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#359d1882-c4f8-48d9-a86e-078b16fbd0b2'>SelectionChanged</a></td><td style='width:75%' class='def'><p>The <code>SelectionChanged</code> event of the <code>KimonoSketch</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0ce8321-1265-4d4f-8891-a3dc9381d697'>SketchModified</a></td><td style='width:75%' ><p>The <code>SketchModified</code> event of the <code>KimonoSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4113db4-4f36-4dc0-bc49-7f83e6c88c6e'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p>The <code>SketchSizeChanged</code> event of the <code>KimonoSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64a35305-c28b-4815-98eb-eba6704da47d'>ToolChanged</a></td><td style='width:75%' ><p>The <code>ToolChanged</code> event of the <code>KimonoSketch</code> class returns a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="38ee5869-ef06-48de-b11a-0b101b8c9f56"></a>
##Public Class KimonoStyle

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoStyle` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 23 fields, 36 properties, 84 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c68a76b2-b341-4b03-9d97-2fd698ae576c'>_fillBlur</a></td><td style='width:75%' ><p>The private <code>_fillBlur</code> field of the <code>KimonoStyle</code> class holds a <code>KimonoCore.KimonoBlur</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4df6839a-cb0b-486f-9aac-e32f35a5fff9'>_fillColor</a></td><td style='width:75%' class='def'><p>The private <code>_fillColor</code> field of the <code>KimonoStyle</code> class holds a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aeb4cfed-297d-4bc5-941e-7371b54ff8a2'>_fillGradient</a></td><td style='width:75%' ><p>The private <code>_fillGradient</code> field of the <code>KimonoStyle</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#712d5b44-3d22-4246-867c-749c313fc24f'>_fillJitterDeviation</a></td><td style='width:75%' class='def'><p>The private <code>_fillJitterDeviation</code> field of the <code>KimonoStyle</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8895404-b90b-40ee-ab45-55840d334259'>_fillJitterLength</a></td><td style='width:75%' ><p>The private <code>_fillJitterLength</code> field of the <code>KimonoStyle</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63521a26-f9f0-4038-8632-85b9763ada18'>_frameBlur</a></td><td style='width:75%' class='def'><p>The private <code>_frameBlur</code> field of the <code>KimonoStyle</code> class holds a <code>KimonoCore.KimonoBlur</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fc97519-4503-4341-a23b-5ed46faf7eef'>_frameColor</a></td><td style='width:75%' ><p>The private <code>_frameColor</code> field of the <code>KimonoStyle</code> class holds a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bfc7ef6-529e-4123-993c-dd4da731d519'>_frameGradient</a></td><td style='width:75%' class='def'><p>The private <code>_frameGradient</code> field of the <code>KimonoStyle</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbeba83f-d2c0-4a96-b3ff-4bc5a1b14da3'>_frameJitterDeviation</a></td><td style='width:75%' ><p>The private <code>_frameJitterDeviation</code> field of the <code>KimonoStyle</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a021f95a-2c18-4669-8081-dfc81c7a9b6f'>_frameJitterLength</a></td><td style='width:75%' class='def'><p>The private <code>_frameJitterLength</code> field of the <code>KimonoStyle</code> class holds a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bff85b4e-9e35-4a3d-9d75-302a341d9e23'>_hasFillBlur</a></td><td style='width:75%' ><p>The private <code>_hasFillBlur</code> field of the <code>KimonoStyle</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1e571b0-f777-4163-a729-003a25e4de7d'>_hasFillJitter</a></td><td style='width:75%' class='def'><p>The private <code>_hasFillJitter</code> field of the <code>KimonoStyle</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bc9418b-197a-4355-bb7b-05f1ddc5b38d'>_hasFrameBlur</a></td><td style='width:75%' ><p>The private <code>_hasFrameBlur</code> field of the <code>KimonoStyle</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72b7389e-021b-4619-b1fb-994343973a9b'>_hasFrameDash</a></td><td style='width:75%' class='def'><p>The private <code>_hasFrameDash</code> field of the <code>KimonoStyle</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1283d0d8-4f3b-44ca-b179-de47a22abc76'>_hasFrameJitter</a></td><td style='width:75%' ><p>The private <code>_hasFrameJitter</code> field of the <code>KimonoStyle</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#14b9940e-5f40-4e8b-b53d-987ac84e6a47'>DashPattern</a></td><td style='width:75%' ><p>The public <code>DashPattern</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean[]</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03c6ca3d-9fb1-4db2-878c-49f34e416423'>Fill</a></td><td style='width:75%' class='def'><p>The public <code>Fill</code> property of the <code>KimonoStyle</code> class has a <code>SkiaSharp.SKPaint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10d34969-130e-4dcf-aca6-084d20a75459'>FillBlur</a></td><td style='width:75%' ><p>The public <code>FillBlur</code> property of the <code>KimonoStyle</code> class has a <code>KimonoCore.KimonoBlur</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26236084-3e8c-402e-a5b4-a1a73bbaf8d5'>FillColor</a></td><td style='width:75%' class='def'><p>The public <code>FillColor</code> property of the <code>KimonoStyle</code> class has a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#790d6d86-66dd-462b-a2a4-5cf9f61d2230'>FillGradient</a></td><td style='width:75%' ><p>The public <code>FillGradient</code> property of the <code>KimonoStyle</code> class has a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1343904-d933-476e-a7f5-6cc32f200476'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p>The public <code>FillJitterDeviation</code> property of the <code>KimonoStyle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4395ba1-56f5-4246-9d2f-86078b2c90cb'>FillJitterLength</a></td><td style='width:75%' ><p>The public <code>FillJitterLength</code> property of the <code>KimonoStyle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#504e6167-c6ac-4474-862f-3d79d22ae5ad'>FontFamilyName</a></td><td style='width:75%' class='def'><p>The public <code>FontFamilyName</code> property of the <code>KimonoStyle</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2b6e298-537c-407a-aff0-f0f1cf85d2cd'>FontMetrics</a></td><td style='width:75%' ><p>The public read only <code>FontMetrics</code> property of the <code>KimonoStyle</code> class has a <code>SkiaSharp.SKFontMetrics</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abbc496b-a050-4aab-8bcd-7a51f8f88e5d'>Frame</a></td><td style='width:75%' class='def'><p>The public <code>Frame</code> property of the <code>KimonoStyle</code> class has a <code>SkiaSharp.SKPaint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc269460-c010-4e20-91a2-aab3ae1f6766'>FrameBlur</a></td><td style='width:75%' ><p>The public <code>FrameBlur</code> property of the <code>KimonoStyle</code> class has a <code>KimonoCore.KimonoBlur</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4b164b1-0670-4b7c-83a4-4050889ec3fe'>FrameColor</a></td><td style='width:75%' class='def'><p>The public <code>FrameColor</code> property of the <code>KimonoStyle</code> class has a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12628290-cb2e-438f-8f00-5a50c67305e1'>FrameGradient</a></td><td style='width:75%' ><p>The public <code>FrameGradient</code> property of the <code>KimonoStyle</code> class has a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0342689b-d4de-47ba-a00b-9e91d0d6d7ef'>FrameJitterDeviation</a></td><td style='width:75%' class='def'><p>The public <code>FrameJitterDeviation</code> property of the <code>KimonoStyle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18637966-0a1f-41f9-85d9-aff50ab6144f'>FrameJitterLength</a></td><td style='width:75%' ><p>The public <code>FrameJitterLength</code> property of the <code>KimonoStyle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2328366d-c783-4ebe-943a-01007d67a912'>HasFill</a></td><td style='width:75%' class='def'><p>The public <code>HasFill</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b3b793e-517f-4df2-bc85-0aa2ff523d25'>HasFillBlur</a></td><td style='width:75%' ><p>The public <code>HasFillBlur</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d8e2b52-7d44-4c9f-8e75-0042c3e28e42'>HasFillJitter</a></td><td style='width:75%' class='def'><p>The public <code>HasFillJitter</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fe89c21-2ab7-428d-acd6-e2dfdb51621a'>HasFrame</a></td><td style='width:75%' ><p>The public <code>HasFrame</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e481594-67a1-408e-b132-88eee781886c'>HasFrameBlur</a></td><td style='width:75%' class='def'><p>The public <code>HasFrameBlur</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#677a8884-201b-4bcd-a5d1-4dfbe1a79421'>HasFrameDash</a></td><td style='width:75%' ><p>The public <code>HasFrameDash</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#824b4987-25bd-43db-bd46-6477551010c1'>HasFrameJitter</a></td><td style='width:75%' class='def'><p>The public <code>HasFrameJitter</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68dc5bb8-d497-4b17-8870-f0ba7806714c'>IsLinearText</a></td><td style='width:75%' ><p>The public <code>IsLinearText</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc725ffb-5cb2-4ed9-97b6-02441bef6cb3'>IsVerticalText</a></td><td style='width:75%' class='def'><p>The public <code>IsVerticalText</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#957abe2d-724e-4d2d-ba80-c581bd4582b2'>Name</a></td><td style='width:75%' ><p>The public <code>Name</code> property of the <code>KimonoStyle</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ab19b42-53ed-40ab-8776-3a16b3651a1f'>StrikeThruText</a></td><td style='width:75%' class='def'><p>The public <code>StrikeThruText</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e7827de-54b6-43c1-b80b-f6f56224a32f'>StyleType</a></td><td style='width:75%' ><p>The public <code>StyleType</code> property of the <code>KimonoStyle</code> class has a <code>KimonoCore.KimonoStyleType</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8fc75e8-2682-4a1f-99d0-283fc3d5ba03'>TextAlign</a></td><td style='width:75%' class='def'><p>The public <code>TextAlign</code> property of the <code>KimonoStyle</code> class has a <code>SkiaSharp.SKTextAlign</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96fe54d9-760f-4e19-83bc-92f620cffcdf'>TextEncoding</a></td><td style='width:75%' ><p>The public <code>TextEncoding</code> property of the <code>KimonoStyle</code> class has a <code>SkiaSharp.SKTextEncoding</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a009395-2402-4622-adda-1cdcdbe534f4'>TextScaleX</a></td><td style='width:75%' class='def'><p>The public <code>TextScaleX</code> property of the <code>KimonoStyle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#521c4f46-de29-4d83-bb0c-0da32efa6793'>TextSize</a></td><td style='width:75%' ><p>The public <code>TextSize</code> property of the <code>KimonoStyle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91b2c5fc-16af-4648-a5ce-1b60c511d4bd'>TextSkewX</a></td><td style='width:75%' class='def'><p>The public <code>TextSkewX</code> property of the <code>KimonoStyle</code> class has a <code>System.Single</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d336694b-a044-4100-a36e-8f085c8a19c8'>Typeface</a></td><td style='width:75%' ><p>The public <code>Typeface</code> property of the <code>KimonoStyle</code> class has a <code>SkiaSharp.SKTypeface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b723dea9-bb6b-4921-b1c3-3228afd05abc'>TypefaceStyle</a></td><td style='width:75%' class='def'><p>The public <code>TypefaceStyle</code> property of the <code>KimonoStyle</code> class has a <code>SkiaSharp.SKTypefaceStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab1c4381-4add-45c4-b27e-d48c3e0211b0'>UnderlineText</a></td><td style='width:75%' ><p>The public <code>UnderlineText</code> property of the <code>KimonoStyle</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ff5623d-2fad-4108-b859-5d7beb23bb86'>UniqueID</a></td><td style='width:75%' class='def'><p>The public <code>UniqueID</code> property of the <code>KimonoStyle</code> class has a <code>System.String</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9c25babd-e868-44b9-a04e-9fe03de2c8b5'>ApplyFillEffects</a></td><td style='width:75%' ><p>The public <code>ApplyFillEffects ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5f5968d-4c99-4a30-af88-071a380d19cd'>ApplyFrameEffects</a></td><td style='width:75%' class='def'><p>The public <code>ApplyFrameEffects ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a510667b-7c40-4846-be61-7bb8f45363b8'>Clone</a></td><td style='width:75%' ><p>The public <code>Clone (System.Boolean)</code> member of the <code>KimonoStyle</code> class returns a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5f72428-cc8e-4b31-b964-f2cb4d63512c'>ClonePaint</a></td><td style='width:75%' class='def'><p>The public static <code>ClonePaint (SkiaSharp.SKPaint)</code> member of the <code>KimonoStyle</code> class returns a <code>SkiaSharp.SKPaint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0b551a9-5f37-4b29-8bb7-94a857a2434c'>HandleFillBlurChange</a></td><td style='width:75%' ><p>The private <code>HandleFillBlurChange ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba83fbba-2251-4fea-8028-07cbf188b002'>HandleFillColorChange</a></td><td style='width:75%' class='def'><p>The private <code>HandleFillColorChange ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b94e4284-9bbb-4248-bf3f-8defd3a62ff4'>HandleFillGradientChange</a></td><td style='width:75%' ><p>The private <code>HandleFillGradientChange ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df7f2cdb-00f3-497e-96bc-388ba37215ba'>HandleFrameBlurChange</a></td><td style='width:75%' class='def'><p>The private <code>HandleFrameBlurChange ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb0c559c-79d0-4f71-9d90-17dfb76c6de4'>HandleFrameColorChange</a></td><td style='width:75%' ><p>The private <code>HandleFrameColorChange ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3505825-eeb9-40f3-b191-7e3cf2bed1af'>HandleFrameGradientChange</a></td><td style='width:75%' class='def'><p>The private <code>HandleFrameGradientChange ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e7ef4c0-4994-48a3-a070-14e95a27f1f8'>Initialize</a></td><td style='width:75%' ><p>The private <code>Initialize ()</code> member of the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4687cfa8-e49e-4262-b921-fe9bdfea4a0e'>KimonoStyle</a></td><td style='width:75%' class='def'><p>The public <code>KimonoStyle ()</code> constructor for the <code>KimonoStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd8cac1f-43c6-4e67-863f-67dbeb7138a1'>MakeDashInterval</a></td><td style='width:75%' ><p>The private <code>MakeDashInterval ()</code> member of the <code>KimonoStyle</code> class returns a <code>System.Collections.Generic.List&lt;System.Single&gt;</code> value.</p>
</td></tr></table></p>


---

<a name="e715544c-1bd6-4f0f-812a-151d4fc8b509"></a>
##Public Enum KimonoStyleType

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Enum`

###Summary

The public `KimonoStyleType` enum inherits from the `System.Enum` class and is defined in the `KimonoCore` namespace. It defines 6 fields, no properties, no methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d2118d92-5d7e-4ca2-a9be-42451b41cd01'>Custom</a></td><td style='width:75%' ><p>The public static constant <code>Custom</code> field of the <code>KimonoStyleType</code> enum holds a <code>KimonoCore.KimonoStyleType</code> value of <code>1</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a200c4e6-5ba5-4a23-aa0c-02586b265da5'>CustomText</a></td><td style='width:75%' class='def'><p>The public static constant <code>CustomText</code> field of the <code>KimonoStyleType</code> enum holds a <code>KimonoCore.KimonoStyleType</code> value of <code>2</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ceaf5fbb-59db-405f-ac06-c6d6d98044c9'>Default</a></td><td style='width:75%' ><p>The public static constant <code>Default</code> field of the <code>KimonoStyleType</code> enum holds a <code>KimonoCore.KimonoStyleType</code> value of <code>0</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a18ba813-2f48-4d4c-87c1-0408272c8700'>Standard</a></td><td style='width:75%' class='def'><p>The public static constant <code>Standard</code> field of the <code>KimonoStyleType</code> enum holds a <code>KimonoCore.KimonoStyleType</code> value of <code>3</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c888f7c-8df8-44af-af60-8da6cc99ecd8'>Text</a></td><td style='width:75%' ><p>The public static constant <code>Text</code> field of the <code>KimonoStyleType</code> enum holds a <code>KimonoCore.KimonoStyleType</code> value of <code>4</code>.</p>
</td></tr></table></p>


---

<a name="0286b37c-e03e-4d80-824c-fc8c54818ea4"></a>
##Public Enum KimonoTool

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Enum`

###Summary

The public `KimonoTool` enum inherits from the `System.Enum` class and is defined in the `KimonoCore` namespace. It defines 13 fields, no properties, no methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#34d54dfd-41f3-47d2-bcbe-c79adade6f03'>Arrow</a></td><td style='width:75%' ><p>The public static constant <code>Arrow</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>2</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4d02a43-cb56-49f2-bbb4-da29fe8ee368'>Bezier</a></td><td style='width:75%' class='def'><p>The public static constant <code>Bezier</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>10</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28c4cb8a-1d50-4d55-ab5b-1a18e2abdb0f'>Cursor</a></td><td style='width:75%' ><p>The public static constant <code>Cursor</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>0</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ff66dee-7118-4dff-92c7-49bc468669c2'>Line</a></td><td style='width:75%' class='def'><p>The public static constant <code>Line</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>1</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef8ca1c8-4ab4-4e98-87ea-109ad9c82642'>Oval</a></td><td style='width:75%' ><p>The public static constant <code>Oval</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>4</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e3f9c7c-a5eb-4446-b776-bc90132aca2c'>Polygon</a></td><td style='width:75%' class='def'><p>The public static constant <code>Polygon</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>7</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e93517dc-679d-4a92-9e68-d6459fac5afe'>Rectangle</a></td><td style='width:75%' ><p>The public static constant <code>Rectangle</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>3</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4391794f-5f91-4066-84a6-8348d11106d1'>RoundRect</a></td><td style='width:75%' class='def'><p>The public static constant <code>RoundRect</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>5</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0399165-5b39-4d34-b214-26c916453953'>Star</a></td><td style='width:75%' ><p>The public static constant <code>Star</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>6</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a8a4331-9389-4d6a-af96-c1ad340cc86a'>Text</a></td><td style='width:75%' class='def'><p>The public static constant <code>Text</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>11</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59ed8405-7ddd-4892-a600-1b92dea238e3'>Triangle</a></td><td style='width:75%' ><p>The public static constant <code>Triangle</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>8</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1313b607-be72-4b0d-bd2e-a91dae107e26'>Vector</a></td><td style='width:75%' class='def'><p>The public static constant <code>Vector</code> field of the <code>KimonoTool</code> enum holds a <code>KimonoCore.KimonoTool</code> value of <code>9</code>.</p>
</td></tr></table></p>


---

<a name="1fc62732-b04e-4e18-b8d6-222f8063115e"></a>
##Public Class KimonoUndoHandler

###Namespace

[KimonoCore](#3b0537c6-0071-43fb-8f0b-5afb98aba72d)

###Inherits From

`System.Object`

###Summary

The public `KimonoUndoHandler` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 4 fields, 5 properties, 16 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#33033989-df71-4ad0-be1d-c69ea21707ef'>UndoStateChanged</a></td><td style='width:75%' ><p>The private <code>UndoStateChanged</code> field of the <code>KimonoUndoHandler</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1bea3d52-a7d4-4d71-8653-7e51f4cf8c64'>CanRedo</a></td><td style='width:75%' ><p>The public read only <code>CanRedo</code> property of the <code>KimonoUndoHandler</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9a140a6-2953-4e23-af4a-348030b7b903'>CanUndo</a></td><td style='width:75%' class='def'><p>The public read only <code>CanUndo</code> property of the <code>KimonoUndoHandler</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#691c9cfb-232e-45d8-b111-808b136b451a'>MaximumUndoPoints</a></td><td style='width:75%' ><p>The public <code>MaximumUndoPoints</code> property of the <code>KimonoUndoHandler</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4f7598e-6cfe-41c1-88f9-77a59275c3cf'>RedoStack</a></td><td style='width:75%' class='def'><p>The public <code>RedoStack</code> property of the <code>KimonoUndoHandler</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoPortfolio&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5749c20e-eff3-4b5d-a8c9-b21e9eb5f81a'>UndoStack</a></td><td style='width:75%' ><p>The public <code>UndoStack</code> property of the <code>KimonoUndoHandler</code> class has a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoPortfolio&gt;</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8c2e47dd-6f2f-42fc-bf81-becbe172fffa'>KimonoUndoHandler</a></td><td style='width:75%' ><p>The public <code>KimonoUndoHandler ()</code> constructor for the <code>KimonoUndoHandler</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffd8bc67-0465-4d07-9d4b-bf3562930a10'>PopRedoPoint</a></td><td style='width:75%' class='def'><p>The public <code>PopRedoPoint (KimonoCore.KimonoPortfolio)</code> member of the <code>KimonoUndoHandler</code> class returns a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6a1e84a-633b-4f20-80e0-d2aed4da74a0'>PopUndoPoint</a></td><td style='width:75%' ><p>The public <code>PopUndoPoint (KimonoCore.KimonoPortfolio)</code> member of the <code>KimonoUndoHandler</code> class returns a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13288ab6-d0be-4a0e-b7ef-c434790a2e68'>PushUndoPoint</a></td><td style='width:75%' class='def'><p>The public <code>PushUndoPoint (KimonoCore.KimonoPortfolio)</code> member of the <code>KimonoUndoHandler</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66ff73ee-5591-49be-8a35-e7e7c0b096b6'>RaiseUndoStateChanged</a></td><td style='width:75%' ><p>The  <code>RaiseUndoStateChanged ()</code> member of the <code>KimonoUndoHandler</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a1565a5-d68f-4ec4-89b4-885ed651a89d'>ReplaceLastUndoPoint</a></td><td style='width:75%' class='def'><p>The public <code>ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)</code> member of the <code>KimonoUndoHandler</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7afdab45-760f-47f1-87f3-5fcf23e24820'>UndoStateChanged</a></td><td style='width:75%' ><p>The <code>UndoStateChanged</code> event of the <code>KimonoUndoHandler</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<a name="Fields"></a>
#Fields


---

<a name="a298839f-638d-4e20-ac9f-b8bdba9cb7b2"></a>
##_adjustAlpha

###Value

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_adjustAlpha` field of the `KimonoColor` class holds a `System.Boolean` value.

---

<a name="1cbaa9e7-dc3f-43f2-86b5-4b22c0200648"></a>
##_adjustBrightness

###Value

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_adjustBrightness` field of the `KimonoColor` class holds a `System.Boolean` value.

---

<a name="79f3cac9-dda5-4f7c-bde4-e5444122f24b"></a>
##_adjustHue

###Value

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_adjustHue` field of the `KimonoColor` class holds a `System.Boolean` value.

---

<a name="0d7fcef1-2242-4bfb-a177-b65dab219668"></a>
##_adjustSaturation

###Value

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_adjustSaturation` field of the `KimonoColor` class holds a `System.Boolean` value.

---

<a name="ce649049-6c27-4aaa-8a93-aba46b7bef37"></a>
##_alphaAdjustment

###Value

`System.Int32`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_alphaAdjustment` field of the `KimonoColor` class holds a `System.Int32` value.

---

<a name="2af6ffab-56d8-47a1-93f2-bac74d60fe3e"></a>
##_baseColor

###Value

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_baseColor` field of the `KimonoColor` class holds a `KimonoCore.KimonoColor` value.

---

<a name="bfbb431e-9448-4b4a-8fbb-c260ae4c7c70"></a>
##_brightnessAdjustment

###Value

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_brightnessAdjustment` field of the `KimonoColor` class holds a `System.Single` value.

---

<a name="f21e2f52-b912-42aa-bd7d-9183092300f4"></a>
##Private _canvasColor

###Value

`SkiaSharp.SKColor`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `_canvasColor` field of the `KimonoSketch` class holds a `SkiaSharp.SKColor` value.

---

<a name="c4aaa657-bf79-487b-9d39-11c1c3f7f849"></a>
##_color

###Value

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_color` field of the `KimonoColor` class holds a `SkiaSharp.SKColor` value.

---

<a name="a4e14d0c-f2ac-4ff8-aec0-cd454cfb8456"></a>
##Private _endPoint

###Value

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `_endPoint` field of the `KimonoGradient` class holds a `KimonoCore.KimonoHandle` value.

---

<a name="c68a76b2-b341-4b03-9d97-2fd698ae576c"></a>
##Private _fillBlur

###Value

[KimonoCore.KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_fillBlur` field of the `KimonoStyle` class holds a `KimonoCore.KimonoBlur` value.

---

<a name="4df6839a-cb0b-486f-9aac-e32f35a5fff9"></a>
##Private _fillColor

###Value

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_fillColor` field of the `KimonoStyle` class holds a `KimonoCore.KimonoColor` value.

---

<a name="aeb4cfed-297d-4bc5-941e-7371b54ff8a2"></a>
##Private _fillGradient

###Value

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_fillGradient` field of the `KimonoStyle` class holds a `KimonoCore.KimonoGradient` value.

---

<a name="712d5b44-3d22-4246-867c-749c313fc24f"></a>
##Private _fillJitterDeviation

###Value

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_fillJitterDeviation` field of the `KimonoStyle` class holds a `System.Single` value.

---

<a name="c8895404-b90b-40ee-ab45-55840d334259"></a>
##Private _fillJitterLength

###Value

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_fillJitterLength` field of the `KimonoStyle` class holds a `System.Single` value.

---

<a name="63521a26-f9f0-4038-8632-85b9763ada18"></a>
##Private _frameBlur

###Value

[KimonoCore.KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_frameBlur` field of the `KimonoStyle` class holds a `KimonoCore.KimonoBlur` value.

---

<a name="4fc97519-4503-4341-a23b-5ed46faf7eef"></a>
##Private _frameColor

###Value

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_frameColor` field of the `KimonoStyle` class holds a `KimonoCore.KimonoColor` value.

---

<a name="3bfc7ef6-529e-4123-993c-dd4da731d519"></a>
##Private _frameGradient

###Value

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_frameGradient` field of the `KimonoStyle` class holds a `KimonoCore.KimonoGradient` value.

---

<a name="cbeba83f-d2c0-4a96-b3ff-4bc5a1b14da3"></a>
##Private _frameJitterDeviation

###Value

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_frameJitterDeviation` field of the `KimonoStyle` class holds a `System.Single` value.

---

<a name="a021f95a-2c18-4669-8081-dfc81c7a9b6f"></a>
##Private _frameJitterLength

###Value

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_frameJitterLength` field of the `KimonoStyle` class holds a `System.Single` value.

---

<a name="6a177893-3c87-4000-9654-1e1b54bd868e"></a>
##Private _gradient

###Value

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The private `_gradient` field of the `KimonoGradientDesignPreview` class holds a `KimonoCore.KimonoGradient` value.

---

<a name="2571e052-77ce-47cc-942a-005d3a3d3a54"></a>
##Private _gradient

###Value

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The private `_gradient` field of the `KimonoGradientDesignBar` class holds a `KimonoCore.KimonoGradient` value.

---

<a name="8d6a4824-15ff-42d3-a30f-b6e6e6dcae1c"></a>
##Private _gradientType

###Value

[KimonoCore.KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `_gradientType` field of the `KimonoGradient` class holds a `KimonoCore.KimonoGradientType` value.

---

<a name="bff85b4e-9e35-4a3d-9d75-302a341d9e23"></a>
##Private _hasFillBlur

###Value

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_hasFillBlur` field of the `KimonoStyle` class holds a `System.Boolean` value.

---

<a name="c1e571b0-f777-4163-a729-003a25e4de7d"></a>
##Private _hasFillJitter

###Value

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_hasFillJitter` field of the `KimonoStyle` class holds a `System.Boolean` value.

---

<a name="2bc9418b-197a-4355-bb7b-05f1ddc5b38d"></a>
##Private _hasFrameBlur

###Value

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_hasFrameBlur` field of the `KimonoStyle` class holds a `System.Boolean` value.

---

<a name="72b7389e-021b-4619-b1fb-994343973a9b"></a>
##Private _hasFrameDash

###Value

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_hasFrameDash` field of the `KimonoStyle` class holds a `System.Boolean` value.

---

<a name="1283d0d8-4f3b-44ca-b179-de47a22abc76"></a>
##Private _hasFrameJitter

###Value

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `_hasFrameJitter` field of the `KimonoStyle` class holds a `System.Boolean` value.

---

<a name="57a2309f-601c-49db-8960-f99295cbe267"></a>
##Private _horizontalBlurAmount

###Value

`System.Single`

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The private `_horizontalBlurAmount` field of the `KimonoBlur` class holds a `System.Single` value.

---

<a name="e2128901-f261-49e8-964b-21ab7b7db2d6"></a>
##_hueAdjustment

###Value

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_hueAdjustment` field of the `KimonoColor` class holds a `System.Single` value.

---

<a name="2519edfc-a0ed-4d21-aba8-951c459be5a7"></a>
##Private _name

###Value

`System.String`

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The private `_name` field of the `KimonoShape` class holds a `System.String` value.

---

<a name="923a2207-a856-4f65-88eb-3679cb29c5f6"></a>
##Private _portfolio

###Value

[KimonoCore.KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `_portfolio` field of the `KimonoDesignSurface` class holds a `KimonoCore.KimonoPortfolio` value.

---

<a name="ad3f8321-d99f-46f7-92fc-a2edd1fe0e52"></a>
##Private _radius

###Value

`System.Single`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `_radius` field of the `KimonoGradient` class holds a `System.Single` value.

---

<a name="a7c71a51-5aa2-466d-8178-617b0a4a2980"></a>
##_saturationAdjustment

###Value

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `_saturationAdjustment` field of the `KimonoColor` class holds a `System.Single` value.

---

<a name="f18f94b9-2c96-45f7-904f-780a5665fea0"></a>
##Private _selectedHandle

###Value

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `_selectedHandle` field of the `KimonoGradient` class holds a `KimonoCore.KimonoHandle` value.

---

<a name="86d274da-e546-4d5e-930f-4fb8d94a9264"></a>
##Private _selectedShape

###Value

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `_selectedShape` field of the `KimonoShapeGroup` class holds a `KimonoCore.KimonoShape` value.

---

<a name="75315261-ea7d-456f-bd89-9af598c8d9a1"></a>
##Private _selectedShape

###Value

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `_selectedShape` field of the `KimonoSketch` class holds a `KimonoCore.KimonoShape` value.

---

<a name="afd6447f-8fad-4e66-b399-afa3fcd7f0c7"></a>
##_selectedSketch

###Value

[KimonoCore.KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `_selectedSketch` field of the `KimonoPortfolio` class holds a `KimonoCore.KimonoSketch` value.

---

<a name="d2acf643-cb07-4f31-bd29-e1f17676c97d"></a>
##Private _startPoint

###Value

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `_startPoint` field of the `KimonoGradient` class holds a `KimonoCore.KimonoHandle` value.

---

<a name="6bb194df-bd4a-4b29-949f-ab503e695973"></a>
##_style

###Value

[KimonoCore.KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The  `_style` field of the `KimonoShape` class holds a `KimonoCore.KimonoStyle` value.

---

<a name="09de4ac4-43bb-4bdb-917a-696444130e31"></a>
##Private _tileMode

###Value

`SkiaSharp.SKShaderTileMode`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `_tileMode` field of the `KimonoGradient` class holds a `SkiaSharp.SKShaderTileMode` value.

---

<a name="edb9d73a-5b40-45a4-b058-b3fb99aba34a"></a>
##Private _tool

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `_tool` field of the `KimonoSketch` class holds a `KimonoCore.KimonoTool` value.

---

<a name="e2343726-95d5-4ce7-b002-cc1460e254b7"></a>
##Private _verticalBlurAmount

###Value

`System.Single`

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The private `_verticalBlurAmount` field of the `KimonoBlur` class holds a `System.Single` value.

---

<a name="cb3acd53-df6d-4ac8-9e3e-e1fafed191ee"></a>
##_visible

###Value

`System.Boolean`

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The  `_visible` field of the `KimonoShape` class holds a `System.Boolean` value.

---

<a name="a0ec0a6b-7bea-45c1-a03b-8fc64bde8526"></a>
##Alpha

###Value

`System.Int32`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `Alpha` field of the `KimonoColor` class holds a `System.Int32` value.

---

<a name="34d54dfd-41f3-47d2-bcbe-c79adade6f03"></a>
##Public Static Constant Arrow

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 2

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Arrow` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `2`.

---

<a name="e4d02a43-cb56-49f2-bbb4-da29fe8ee368"></a>
##Public Static Constant Bezier

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 10

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Bezier` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `10`.

---

<a name="34937ba4-df42-4c1b-991c-214710ebea55"></a>
##Private BlurModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The private `BlurModified` field of the `KimonoBlur` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="cf098d41-e7f8-4ecd-bf79-e6629c26198e"></a>
##Brightness

###Value

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `Brightness` field of the `KimonoColor` class holds a `System.Single` value.

---

<a name="77c523ed-b5a4-48ed-a0b1-d341119ce2e0"></a>
##Public Static Constant Collection

###Value

[KimonoCore.KimonoShapeGroupType](#7d6f36d2-8266-4a30-b62d-bf0d805c00fe) of 2

###Member of Type

[KimonoShapeGroupType](#7d6f36d2-8266-4a30-b62d-bf0d805c00fe)

###Summary

The public static constant `Collection` field of the `KimonoShapeGroupType` enum holds a `KimonoCore.KimonoShapeGroupType` value of `2`.

---

<a name="e6d3572e-b274-4ca8-bdfc-966fa496fa52"></a>
##Private ColorChanged

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The private `ColorChanged` field of the `KimonoColor` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="98d02cf7-b06a-4428-982b-5b7083a5b978"></a>
##Private ColorsModified

###Value

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `ColorsModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="bf852537-59e1-401c-bc4b-478bb58b818a"></a>
##Private ColorsModified

###Value

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `ColorsModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="8f42b5d8-e3a1-4202-a92e-a061a6db3b75"></a>
##Public Static Constant ConicalGradient

###Value

[KimonoCore.KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a) of 3

###Member of Type

[KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a)

###Summary

The public static constant `ConicalGradient` field of the `KimonoGradientType` enum holds a `KimonoCore.KimonoGradientType` value of `3`.

---

<a name="bab7b6e2-e79d-48a6-9c3a-92a79980ae78"></a>
##Public Static Constant Constructing

###Value

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36) of 4

###Member of Type

[KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Summary

The public static constant `Constructing` field of the `KimonoShapeState` enum holds a `KimonoCore.KimonoShapeState` value of `4`.

---

<a name="2b562856-7289-4811-8f1b-285fbc363f9c"></a>
##Public Static Constant ControlPoint

###Value

[KimonoCore.KimonoHandleType](#26c349b5-1f2e-4106-9168-f9f405f0e58c) of 0

###Member of Type

[KimonoHandleType](#26c349b5-1f2e-4106-9168-f9f405f0e58c)

###Summary

The public static constant `ControlPoint` field of the `KimonoHandleType` enum holds a `KimonoCore.KimonoHandleType` value of `0`.

---

<a name="28c4cb8a-1d50-4d55-ab5b-1a18e2abdb0f"></a>
##Public Static Constant Cursor

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 0

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Cursor` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `0`.

---

<a name="d2118d92-5d7e-4ca2-a9be-42451b41cd01"></a>
##Public Static Constant Custom

###Value

[KimonoCore.KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509) of 1

###Member of Type

[KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509)

###Summary

The public static constant `Custom` field of the `KimonoStyleType` enum holds a `KimonoCore.KimonoStyleType` value of `1`.

---

<a name="a200c4e6-5ba5-4a23-aa0c-02586b265da5"></a>
##Public Static Constant CustomText

###Value

[KimonoCore.KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509) of 2

###Member of Type

[KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509)

###Summary

The public static constant `CustomText` field of the `KimonoStyleType` enum holds a `KimonoCore.KimonoStyleType` value of `2`.

---

<a name="ceaf5fbb-59db-405f-ac06-c6d6d98044c9"></a>
##Public Static Constant Default

###Value

[KimonoCore.KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509) of 0

###Member of Type

[KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509)

###Summary

The public static constant `Default` field of the `KimonoStyleType` enum holds a `KimonoCore.KimonoStyleType` value of `0`.

---

<a name="44bf14f3-6576-4a7b-851e-b153b4fc1d9c"></a>
##Private Dragging

###Value

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `Dragging` field of the `KimonoShapeGroup` class holds a `System.Boolean` value.

---

<a name="6c71f603-dcea-4d4a-90d0-c1ecd5765edc"></a>
##Public Static Constant DragSelect

###Value

[KimonoCore.KimonoShapeGroupType](#7d6f36d2-8266-4a30-b62d-bf0d805c00fe) of 1

###Member of Type

[KimonoShapeGroupType](#7d6f36d2-8266-4a30-b62d-bf0d805c00fe)

###Summary

The public static constant `DragSelect` field of the `KimonoShapeGroupType` enum holds a `KimonoCore.KimonoShapeGroupType` value of `1`.

---

<a name="654f3d1a-e886-42e0-b452-b1d17801d7d9"></a>
##Public Static DrawOffset

###Value

`System.Single`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public static `DrawOffset` field of the `KimonoHandle` class holds a `System.Single` value.

---

<a name="63109c74-dc83-4a2b-9dcf-c3a59cf1094c"></a>
##Public Static DrawWidth

###Value

`System.Single`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public static `DrawWidth` field of the `KimonoHandle` class holds a `System.Single` value.

---

<a name="2b16df70-3fec-427b-9e85-f0d78c631f14"></a>
##Public Static Constant Editing

###Value

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36) of 2

###Member of Type

[KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Summary

The public static constant `Editing` field of the `KimonoShapeState` enum holds a `KimonoCore.KimonoShapeState` value of `2`.

---

<a name="57c0af2f-3445-4199-a1a2-a0d322bcb61a"></a>
##Public Static Constant Finalizing

###Value

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36) of 3

###Member of Type

[KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Summary

The public static constant `Finalizing` field of the `KimonoShapeState` enum holds a `KimonoCore.KimonoShapeState` value of `3`.

---

<a name="1e23fa37-e0a3-4bef-b71d-17d1c9bfd19d"></a>
##Public Static Constant GradientColor

###Value

[KimonoCore.KimonoHandleType](#26c349b5-1f2e-4106-9168-f9f405f0e58c) of 1

###Member of Type

[KimonoHandleType](#26c349b5-1f2e-4106-9168-f9f405f0e58c)

###Summary

The public static constant `GradientColor` field of the `KimonoHandleType` enum holds a `KimonoCore.KimonoHandleType` value of `1`.

---

<a name="a0d0e723-ff6b-401f-8ce7-5c329654f414"></a>
##Private GradientModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The private `GradientModified` field of the `KimonoGradientDesignPreview` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="9753f7d3-4796-4d9f-a500-9f9674dbd19f"></a>
##Private GradientModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `GradientModified` field of the `KimonoGradient` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="d1a50503-377c-42ad-bb23-9033f1d26ecf"></a>
##Public Static Constant GradientPosition

###Value

[KimonoCore.KimonoHandleType](#26c349b5-1f2e-4106-9168-f9f405f0e58c) of 2

###Member of Type

[KimonoHandleType](#26c349b5-1f2e-4106-9168-f9f405f0e58c)

###Summary

The public static constant `GradientPosition` field of the `KimonoHandleType` enum holds a `KimonoCore.KimonoHandleType` value of `2`.

---

<a name="1f181e95-6790-4907-a1f3-9f46056a6420"></a>
##Private GradientsModified

###Value

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `GradientsModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="8ce0049e-f521-46ef-9c27-3efd1fd4a72d"></a>
##Private GradientsModified

###Value

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `GradientsModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="181d3145-b3e6-4fbb-896e-11f3f3f59e03"></a>
##Public Static Constant Grouping

###Value

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36) of 5

###Member of Type

[KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Summary

The public static constant `Grouping` field of the `KimonoShapeState` enum holds a `KimonoCore.KimonoShapeState` value of `5`.

---

<a name="13a828f0-570f-4a20-b52c-b1b4b5e80145"></a>
##Private HandleSelected

###Value

`KimonoCore.Kimono.HandleEventDelegate`

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The private `HandleSelected` field of the `KimonoGradientDesignPreview` class holds a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="01feab92-d0db-4ee3-8613-731398fd032c"></a>
##Private HandleSelected

###Value

`KimonoCore.Kimono.HandleEventDelegate`

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The private `HandleSelected` field of the `KimonoGradientDesignBar` class holds a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="8657850b-1fc0-40c2-8606-f1ed30d60056"></a>
##Private HandleSelected

###Value

`KimonoCore.Kimono.HandleEventDelegate`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `HandleSelected` field of the `KimonoGradient` class holds a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="8287a340-d27c-457f-a8d1-714668b6c437"></a>
##Public Static Constant Horizontal

###Value

[KimonoCore.KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29) of 1

###Member of Type

[KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29)

###Summary

The public static constant `Horizontal` field of the `KimonoHandleConstraint` enum holds a `KimonoCore.KimonoHandleConstraint` value of `1`.

---

<a name="c3a7a00b-8c28-441d-8dfb-f762ff0fe8bc"></a>
##Hue

###Value

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `Hue` field of the `KimonoColor` class holds a `System.Single` value.

---

<a name="96f30a0b-4e4c-4085-a502-dbab895bbd6b"></a>
##Private IgnoreDrag

###Value

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `IgnoreDrag` field of the `KimonoShapeGroup` class holds a `System.Boolean` value.

---

<a name="87faf000-3a65-425d-9075-1b8c4e71bf34"></a>
##Private IgnoreDrag

###Value

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `IgnoreDrag` field of the `KimonoSketch` class holds a `System.Boolean` value.

---

<a name="1d5b3703-13e8-4c73-8552-25eff80d31d7"></a>
##Private ImageBufferNeedsRefresh

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `ImageBufferNeedsRefresh` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="8ff66dee-7118-4dff-92c7-49bc468669c2"></a>
##Public Static Constant Line

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 1

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Line` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `1`.

---

<a name="f6340dd7-f730-4c1d-9c6c-b3375c036b55"></a>
##Public Static Constant LinearGradient

###Value

[KimonoCore.KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a) of 0

###Member of Type

[KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a)

###Summary

The public static constant `LinearGradient` field of the `KimonoGradientType` enum holds a `KimonoCore.KimonoGradientType` value of `0`.

---

<a name="4cd144d1-729a-4eb2-8784-54bcdddb7c8e"></a>
##Public Static Constant Locked

###Value

[KimonoCore.KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29) of 3

###Member of Type

[KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29)

###Summary

The public static constant `Locked` field of the `KimonoHandleConstraint` enum holds a `KimonoCore.KimonoHandleConstraint` value of `3`.

---

<a name="624fd4f2-b23e-4c78-a095-49e082f3f321"></a>
##Private Moved

###Value

`KimonoCore.Kimono.SkiaPointEventDelegate`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The private `Moved` field of the `KimonoHandle` class holds a `KimonoCore.Kimono.SkiaPointEventDelegate` value.

---

<a name="14f307c7-dfac-46e0-85a4-f7d439c1d529"></a>
##NewSketchNumber

###Value

`System.Int32`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `NewSketchNumber` field of the `KimonoPortfolio` class holds a `System.Int32` value.

---

<a name="e5180a2b-bcae-4018-a391-121403f29644"></a>
##Public Static Constant None

###Value

[KimonoCore.KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29) of 0

###Member of Type

[KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29)

###Summary

The public static constant `None` field of the `KimonoHandleConstraint` enum holds a `KimonoCore.KimonoHandleConstraint` value of `0`.

---

<a name="ef8ca1c8-4ab4-4e98-87ea-109ad9c82642"></a>
##Public Static Constant Oval

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 4

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Oval` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `4`.

---

<a name="583c5cee-ea7e-491e-86da-c6bb2476a40a"></a>
##Private PerformingDrag

###Value

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `PerformingDrag` field of the `KimonoShapeGroup` class holds a `System.Boolean` value.

---

<a name="62b88ed4-b988-4fad-8b4e-7b5b258be718"></a>
##Private PerformingDrag

###Value

`System.Boolean`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `PerformingDrag` field of the `KimonoGradient` class holds a `System.Boolean` value.

---

<a name="8a066319-91ce-46ff-a351-d01fdf23b7c2"></a>
##Private PerformingDrag

###Value

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `PerformingDrag` field of the `KimonoSketch` class holds a `System.Boolean` value.

---

<a name="9e3f9c7c-a5eb-4446-b776-bc90132aca2c"></a>
##Public Static Constant Polygon

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 7

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Polygon` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `7`.

---

<a name="e8173c76-01e2-404c-8962-46f7ec279d52"></a>
##PreviousCenter

###Value

`SkiaSharp.SKPoint`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The  `PreviousCenter` field of the `KimonoBounds` class holds a `SkiaSharp.SKPoint` value.

---

<a name="ce938466-03c8-48e8-9662-959015ba764c"></a>
##PreviousRect

###Value

`SkiaSharp.SKRect`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The  `PreviousRect` field of the `KimonoBounds` class holds a `SkiaSharp.SKRect` value.

---

<a name="4cd67449-87a5-4863-806e-affc70755dd2"></a>
##Private PreviousSize

###Value

`SkiaSharp.SKSize`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `PreviousSize` field of the `KimonoSketch` class holds a `SkiaSharp.SKSize` value.

---

<a name="172f39a8-c40f-43b6-b8dc-c41842f5ffd0"></a>
##Public Static Constant RadialGradient

###Value

[KimonoCore.KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a) of 1

###Member of Type

[KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a)

###Summary

The public static constant `RadialGradient` field of the `KimonoGradientType` enum holds a `KimonoCore.KimonoGradientType` value of `1`.

---

<a name="e29b2226-17c0-4353-a0d1-60f7e9f64daf"></a>
##Rect

###Value

`SkiaSharp.SKRect`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The  `Rect` field of the `KimonoBounds` class holds a `SkiaSharp.SKRect` value.

---

<a name="e93517dc-679d-4a92-9e68-d6459fac5afe"></a>
##Public Static Constant Rectangle

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 3

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Rectangle` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `3`.

---

<a name="7c92873a-0436-4ee1-889f-cc9d4288ce44"></a>
##Private ReloadUI

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `ReloadUI` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="0f5d837b-bff7-4480-8801-333e386ccb0e"></a>
##Private RequestNewUndoPoint

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `RequestNewUndoPoint` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="6e958cd9-13a4-42b3-93e5-dcd326c3064b"></a>
##Private RequestNewUndoPoint

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `RequestNewUndoPoint` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="4391794f-5f91-4066-84a6-8348d11106d1"></a>
##Public Static Constant RoundRect

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 5

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `RoundRect` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `5`.

---

<a name="35d97f35-fa7c-479e-aa18-b8dd50d75361"></a>
##Saturation

###Value

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `Saturation` field of the `KimonoColor` class holds a `System.Single` value.

---

<a name="cf4b832b-cc3c-4b1b-a265-9d630566cd28"></a>
##Public Static Constant Selected

###Value

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36) of 1

###Member of Type

[KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Summary

The public static constant `Selected` field of the `KimonoShapeState` enum holds a `KimonoCore.KimonoShapeState` value of `1`.

---

<a name="3a3ea277-bb3d-49fb-a26e-63505aff4357"></a>
##Private SelectedShapeChanged

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `SelectedShapeChanged` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="65bfc7a2-1291-44ae-91c5-78dac3d7eb9e"></a>
##Private SelectedShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `SelectedShapeModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="d49c95d0-bca5-4f3a-8100-cfe107d58515"></a>
##Private SelectedShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `SelectedShapeModified` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="dcfae7c7-cc44-4ead-b1ad-dfc19e221c04"></a>
##Private SelectedSketchDidChange

###Value

`KimonoCore.Kimono.SketchEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `SelectedSketchDidChange` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="13feccfd-51bb-483b-8f4f-51fb8c0384b7"></a>
##Private SelectedSketchWillChange

###Value

`KimonoCore.Kimono.SketchEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `SelectedSketchWillChange` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="20b97c21-ab5d-4285-88d2-bc424cbfcf8b"></a>
##Public Static Constant Selection

###Value

[KimonoCore.KimonoShapeGroupType](#7d6f36d2-8266-4a30-b62d-bf0d805c00fe) of 0

###Member of Type

[KimonoShapeGroupType](#7d6f36d2-8266-4a30-b62d-bf0d805c00fe)

###Summary

The public static constant `Selection` field of the `KimonoShapeGroupType` enum holds a `KimonoCore.KimonoShapeGroupType` value of `0`.

---

<a name="10592ad9-b676-46e9-be7f-c8debcb4ef33"></a>
##Private SelectionChanged

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `SelectionChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="73f57700-3253-4791-bd29-db3e5d2bce39"></a>
##Private SelectionChanged

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `SelectionChanged` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="26920769-cc5e-41e2-ab8b-ccc7afdd6538"></a>
##Private ShapeUnderConstruction

###Value

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `ShapeUnderConstruction` field of the `KimonoShapeGroup` class holds a `KimonoCore.KimonoShape` value.

---

<a name="52518d0a-98e8-4c8b-82d6-35a7d3e76686"></a>
##ShapeUnderConstruction

###Value

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `ShapeUnderConstruction` field of the `KimonoSketch` class holds a `KimonoCore.KimonoShape` value.

---

<a name="dcb52d14-8408-495b-9afe-3a33f8075a5d"></a>
##Private Size

###Value

`SkiaSharp.SKSize`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `Size` field of the `KimonoSketch` class holds a `SkiaSharp.SKSize` value.

---

<a name="c9eef7b7-dc0e-466e-b4db-216edbd07ef2"></a>
##Private SketchesModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `SketchesModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="f4e91ec5-700d-4789-8195-29cec6707b0b"></a>
##Private SketchesModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `SketchesModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="8d2ed73a-6284-41c2-9e12-66c902f54610"></a>
##Private SketchModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `SketchModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="fd03ca63-1904-4c59-9014-3d179e334ee7"></a>
##Private SketchModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `SketchModified` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="f639d25c-30c6-44f0-9aef-9a75d2ddb6e2"></a>
##Private SketchSizeChanged

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `SketchSizeChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="470a16e6-049d-4fa7-a5f4-46d64f94d01c"></a>
##Private SketchSizeChanged

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `SketchSizeChanged` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="a18ba813-2f48-4d4c-87c1-0408272c8700"></a>
##Public Static Constant Standard

###Value

[KimonoCore.KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509) of 3

###Member of Type

[KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509)

###Summary

The public static constant `Standard` field of the `KimonoStyleType` enum holds a `KimonoCore.KimonoStyleType` value of `3`.

---

<a name="a0399165-5b39-4d34-b214-26c916453953"></a>
##Public Static Constant Star

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 6

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Star` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `6`.

---

<a name="25dd7d2f-a48b-4b14-9f58-44956f791279"></a>
##Private StylesModified

###Value

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `StylesModified` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="ef8a4e52-49a4-4e0a-8287-d74f1f0a16be"></a>
##Private StylesModified

###Value

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The private `StylesModified` field of the `KimonoPortfolio` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="bf6b1ff3-1027-4348-8f78-e0ea4d954892"></a>
##Public Static Constant SweepGradient

###Value

[KimonoCore.KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a) of 2

###Member of Type

[KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a)

###Summary

The public static constant `SweepGradient` field of the `KimonoGradientType` enum holds a `KimonoCore.KimonoGradientType` value of `2`.

---

<a name="2c888f7c-8df8-44af-af60-8da6cc99ecd8"></a>
##Public Static Constant Text

###Value

[KimonoCore.KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509) of 4

###Member of Type

[KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509)

###Summary

The public static constant `Text` field of the `KimonoStyleType` enum holds a `KimonoCore.KimonoStyleType` value of `4`.

---

<a name="5a8a4331-9389-4d6a-af96-c1ad340cc86a"></a>
##Public Static Constant Text

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 11

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Text` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `11`.

---

<a name="d70f8657-0ce1-4d8e-a043-d47b043226f7"></a>
##Private ToolChanged

###Value

`KimonoCore.Kimono.ToolEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `ToolChanged` field of the `KimonoSketch` class holds a `KimonoCore.Kimono.ToolEventDelegate` value.

---

<a name="cc8342f8-fd3e-49b8-bb3f-059565dc971f"></a>
##Private ToolChanged

###Value

`KimonoCore.Kimono.ToolEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `ToolChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.ToolEventDelegate` value.

---

<a name="497b26ea-06c5-47e5-89cb-6a193054abdd"></a>
##Private ToolDownAt

###Value

`SkiaSharp.SKPoint`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `ToolDownAt` field of the `KimonoSketch` class holds a `SkiaSharp.SKPoint` value.

---

<a name="a993f1ad-e717-4c52-98fa-4fd8a07f55f6"></a>
##Private ToolDownAt

###Value

`SkiaSharp.SKPoint`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `ToolDownAt` field of the `KimonoShapeGroup` class holds a `SkiaSharp.SKPoint` value.

---

<a name="59ed8405-7ddd-4892-a600-1b92dea238e3"></a>
##Public Static Constant Triangle

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 8

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Triangle` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `8`.

---

<a name="b3b7c4d3-99b4-48d2-bd31-29504c98bc34"></a>
##Private UndoHandler

###Value

[KimonoCore.KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `UndoHandler` field of the `KimonoDesignSurface` class holds a `KimonoCore.KimonoUndoHandler` value.

---

<a name="3b280ea4-ca22-40cc-b16e-99e0d590a75e"></a>
##Private UndoStateChanged

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `UndoStateChanged` field of the `KimonoDesignSurface` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="33033989-df71-4ad0-be1d-c69ea21707ef"></a>
##Private UndoStateChanged

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The private `UndoStateChanged` field of the `KimonoUndoHandler` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="5b3de089-2faa-40ae-9684-4f47acf527f8"></a>
##Public Static Constant Unselected

###Value

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36) of 0

###Member of Type

[KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Summary

The public static constant `Unselected` field of the `KimonoShapeState` enum holds a `KimonoCore.KimonoShapeState` value of `0`.

---

<a name="1313b607-be72-4b0d-bd2e-a91dae107e26"></a>
##Public Static Constant Vector

###Value

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4) of 9

###Member of Type

[KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Summary

The public static constant `Vector` field of the `KimonoTool` enum holds a `KimonoCore.KimonoTool` value of `9`.

---

<a name="dd32faff-8be4-4731-b61a-23392d75eb3d"></a>
##Public Static Constant Vertical

###Value

[KimonoCore.KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29) of 2

###Member of Type

[KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29)

###Summary

The public static constant `Vertical` field of the `KimonoHandleConstraint` enum holds a `KimonoCore.KimonoHandleConstraint` value of `2`.
<a name="Properties"></a>
#Properties


---

<a name="b632a17c-9f49-489e-9ca3-ead2e1930605"></a>
##Public AdjustsAlpha

###Return Type

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `AdjustsAlpha` property of the `KimonoColor` class has a `System.Boolean` value.

---

<a name="1ab943b2-5667-4e9c-8ceb-40cce27eab22"></a>
##Public AdjustsBrightness

###Return Type

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `AdjustsBrightness` property of the `KimonoColor` class has a `System.Boolean` value.

---

<a name="bc12f926-0c85-4e0d-a558-659028350a7e"></a>
##Public AdjustsHue

###Return Type

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `AdjustsHue` property of the `KimonoColor` class has a `System.Boolean` value.

---

<a name="3fa82769-ab26-420a-a93c-a202d668a3dd"></a>
##Public AdjustsSaturation

###Return Type

`System.Boolean`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `AdjustsSaturation` property of the `KimonoColor` class has a `System.Boolean` value.

---

<a name="c19ba9f7-e455-47ea-894e-91df298061e0"></a>
##Public AlphaAdjustment

###Return Type

`System.Int32`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `AlphaAdjustment` property of the `KimonoColor` class has a `System.Int32` value.

---

<a name="521eea28-a889-462d-bfb0-a05c4dfc4c52"></a>
##Public Static Read Only Aluminum

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Aluminum` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="f3737dee-19fb-4b1e-bb6c-9f50ba5368ed"></a>
##Public Static Read Only Aqua

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Aqua` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="c92846f4-014e-428e-8661-cd24043bb11f"></a>
##Public Static Read Only Asparagus

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Asparagus` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="b11b15fb-9416-4369-9f72-511598db675d"></a>
##Public Static Read Only Banana

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Banana` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="8f6ae76d-5e32-4270-b661-985022e33272"></a>
##Public BarHeight

###Return Type

`System.Single`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `BarHeight` property of the `KimonoGradient` class has a `System.Single` value.

---

<a name="4970339d-8dca-4910-9020-8915130909fa"></a>
##Public BarWidth

###Return Type

`System.Single`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `BarWidth` property of the `KimonoGradient` class has a `System.Single` value.

---

<a name="45b0a72c-8832-47fb-884b-0e3ff898a740"></a>
##Public BaseColor

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `BaseColor` property of the `KimonoColor` class has a `KimonoCore.KimonoColor` value.

---

<a name="606f8a76-9799-4379-afa6-814cc03a9d35"></a>
##Public Static Read Only Black

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Black` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="c05f16f6-72cb-457b-985d-87e4095d3d5a"></a>
##Public Static Read Only Blue

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Blue` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="1900ad82-a309-41e1-b555-c9d7c22733cc"></a>
##Public Static Read Only Blueberry

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Blueberry` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="9b8b0628-ab05-4a3f-b801-9faa1835ea12"></a>
##Public Read Only BlurFilter

###Return Type

`SkiaSharp.SKImageFilter`

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The public read only `BlurFilter` property of the `KimonoBlur` class has a `SkiaSharp.SKImageFilter` value.

---

<a name="9af5751d-448d-45cd-b99b-06e3a80c7c39"></a>
##Public Bottom

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Bottom` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="edd27757-4cc0-4180-98ac-ceab43f76c7f"></a>
##Public BottomHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `BottomHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="3a63c39c-bbfa-4247-be5a-1833d777048c"></a>
##Public BottomLeftHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `BottomLeftHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="c3f6f9f1-bc9f-4628-884c-84cd37bc085e"></a>
##Public BottomRightHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `BottomRightHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="c5962817-46c5-48a0-8486-6be2a2406b70"></a>
##Public BrightnessAdjustment

###Return Type

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `BrightnessAdjustment` property of the `KimonoColor` class has a `System.Single` value.

---

<a name="22754ec5-97e6-4087-895a-b77c87f5016f"></a>
##Public Static Read Only Bubblegum

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Bubblegum` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="5b469474-ece9-485e-add9-d0cb1fa24dd0"></a>
##Public Read Only CanAlignShapes

###Return Type

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public read only `CanAlignShapes` property of the `KimonoSketch` class has a `System.Boolean` value.

---

<a name="19c1589a-2fd2-4175-8213-5468ad09b623"></a>
##Public Read Only CanGroupShapes

###Return Type

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public read only `CanGroupShapes` property of the `KimonoSketch` class has a `System.Boolean` value.

---

<a name="1bea3d52-a7d4-4d71-8653-7e51f4cf8c64"></a>
##Public Read Only CanRedo

###Return Type

`System.Boolean`

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public read only `CanRedo` property of the `KimonoUndoHandler` class has a `System.Boolean` value.

---

<a name="050fce01-ed0a-47aa-9185-13af5c63a93a"></a>
##Public Read Only CanRedo

###Return Type

`System.Boolean`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public read only `CanRedo` property of the `KimonoDesignSurface` class has a `System.Boolean` value.

---

<a name="04db5822-4c14-4d9f-a55b-bc51831a5b0f"></a>
##Public Static Read Only Cantalope

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Cantalope` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="a9a140a6-2953-4e23-af4a-348030b7b903"></a>
##Public Read Only CanUndo

###Return Type

`System.Boolean`

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public read only `CanUndo` property of the `KimonoUndoHandler` class has a `System.Boolean` value.

---

<a name="f0203570-0233-4625-a56b-7df1d00c0fe4"></a>
##Public Read Only CanUndo

###Return Type

`System.Boolean`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public read only `CanUndo` property of the `KimonoDesignSurface` class has a `System.Boolean` value.

---

<a name="9ebd48a7-3185-4387-be61-86c644f587d0"></a>
##Public Read Only CanUngroupShapes

###Return Type

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public read only `CanUngroupShapes` property of the `KimonoSketch` class has a `System.Boolean` value.

---

<a name="b31f2a0e-09a0-439e-a5f1-178f85fffd8d"></a>
##Public CanvasColor

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `CanvasColor` property of the `KimonoSketch` class has a `SkiaSharp.SKColor` value.

---

<a name="0e97f17d-abe4-4516-a7a4-02c983d70f4f"></a>
##Public Static Read Only Carnation

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Carnation` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="9bf1dfe4-1610-4a48-80b4-8a23c08bd2d2"></a>
##Public Static Read Only Cayenne

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Cayenne` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="41caa07f-b47b-4489-a815-8f1ae373c4fa"></a>
##Public Read Only Center

###Return Type

`SkiaSharp.SKPoint`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public read only `Center` property of the `KimonoBounds` class has a `SkiaSharp.SKPoint` value.

---

<a name="24862674-c287-430d-a6d9-783f1c7411e3"></a>
##Public Closed

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `Closed` property of the `KimonoShapeVector` class has a `System.Boolean` value.

---

<a name="c7d71223-0851-4b86-b674-522c6bd7b559"></a>
##Public Static Read Only Clover

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Clover` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="d8bcb470-3dec-4823-9862-e6e9a13d0efb"></a>
##Public Color

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `Color` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="93627e90-c69f-4664-b1ba-9afebe305510"></a>
##Public Color

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `Color` property of the `KimonoHandle` class has a `SkiaSharp.SKColor` value.

---

<a name="5b18dc9d-5d11-4941-9ac7-84765262f9a3"></a>
##Public Colors

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoColor>`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `Colors` property of the `KimonoPortfolio` class has a `System.Collections.Generic.List<KimonoCore.KimonoColor>` value.

---

<a name="f935282c-9903-42d1-a784-bb7197c847d2"></a>
##Public Constraint

###Return Type

[KimonoCore.KimonoHandleConstraint](#b6434577-1829-4c70-9960-8f7e394bad29)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `Constraint` property of the `KimonoHandle` class has a `KimonoCore.KimonoHandleConstraint` value.

---

<a name="87161652-6a12-4bcb-a5e3-9b998412ad3b"></a>
##Public ControlPoints

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoHandle>`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `ControlPoints` property of the `KimonoGradient` class has a `System.Collections.Generic.List<KimonoCore.KimonoHandle>` value.

---

<a name="fa7d2a21-ba88-4430-bb93-d642a3ee6b85"></a>
##Public ControlPoints

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoHandle>`

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `ControlPoints` property of the `KimonoShape` class has a `System.Collections.Generic.List<KimonoCore.KimonoHandle>` value.

---

<a name="3318a443-1cfa-4e2e-a0de-e64e683498f6"></a>
##Public CornerRadius

###Return Type

`System.Single`

###Member of Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public `CornerRadius` property of the `KimonoShapeRoundRect` class has a `System.Single` value.

---

<a name="ab5760b5-c5da-47ec-8168-1b3962d646ca"></a>
##Public Static Read Only DarkGray

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `DarkGray` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="14b9940e-5f40-4e8b-b53d-987ac84e6a47"></a>
##Public DashPattern

###Return Type

`System.Boolean[]`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `DashPattern` property of the `KimonoStyle` class has a `System.Boolean[]` value.

---

<a name="03739644-1452-4811-9464-d92edcf3ef5a"></a>
##Public Read Only DeeplySelectedGroup

###Return Type

[KimonoCore.KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public read only `DeeplySelectedGroup` property of the `KimonoDesignSurface` class has a `KimonoCore.KimonoShapeGroup` value.

---

<a name="42da8f6d-321f-4b30-88c2-c40b0031f021"></a>
##Public Read Only DeeplySelectedGroup

###Return Type

[KimonoCore.KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public read only `DeeplySelectedGroup` property of the `KimonoSketch` class has a `KimonoCore.KimonoShapeGroup` value.

---

<a name="57afe74b-af2c-4eb6-b67d-f0a0cee39abd"></a>
##Public Read Only DeeplySelectedGroup

###Return Type

[KimonoCore.KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public read only `DeeplySelectedGroup` property of the `KimonoShapeGroup` class has a `KimonoCore.KimonoShapeGroup` value.

---

<a name="01157665-9ad2-4887-98f2-b5858e3b85d1"></a>
##Public Read Only DeeplySelectedShape

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public read only `DeeplySelectedShape` property of the `KimonoShapeGroup` class has a `KimonoCore.KimonoShape` value.

---

<a name="9b89b925-a944-4556-8fb3-77cfdc45f342"></a>
##Public Read Only DeeplySelectedShape

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public read only `DeeplySelectedShape` property of the `KimonoSketch` class has a `KimonoCore.KimonoShape` value.

---

<a name="9f2e5dea-f24d-4984-9806-63c3b6839ba2"></a>
##Public Read Only DeeplySelectedShape

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public read only `DeeplySelectedShape` property of the `KimonoDesignSurface` class has a `KimonoCore.KimonoShape` value.

---

<a name="9e29bede-bd6b-44cf-920b-23fec80c9335"></a>
##Public DepthOffset

###Return Type

`System.Int32`

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public `DepthOffset` property of the `KimonoShapeStar` class has a `System.Int32` value.

---

<a name="ec27a0d2-9fd7-4315-9952-bd7aa4fa8c78"></a>
##Public DrawCanvas

###Return Type

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `DrawCanvas` property of the `KimonoSketch` class has a `System.Boolean` value.

---

<a name="f159479a-96b5-46ce-9b3c-c908007c39aa"></a>
##Public Static Read Only Eggplant

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Eggplant` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="09a339b3-1a67-46be-9fef-7a1164ba1e92"></a>
##Public EndPoint

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `EndPoint` property of the `KimonoGradient` class has a `KimonoCore.KimonoHandle` value.

---

<a name="e6f43f58-85ef-4115-83fa-5fd5991697c6"></a>
##Public Static Read Only Fern

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Fern` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="03c6ca3d-9fb1-4db2-878c-49f34e416423"></a>
##Public Fill

###Return Type

`SkiaSharp.SKPaint`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `Fill` property of the `KimonoStyle` class has a `SkiaSharp.SKPaint` value.

---

<a name="10d34969-130e-4dcf-aca6-084d20a75459"></a>
##Public FillBlur

###Return Type

[KimonoCore.KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FillBlur` property of the `KimonoStyle` class has a `KimonoCore.KimonoBlur` value.

---

<a name="26236084-3e8c-402e-a5b4-a1a73bbaf8d5"></a>
##Public FillColor

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FillColor` property of the `KimonoStyle` class has a `KimonoCore.KimonoColor` value.

---

<a name="790d6d86-66dd-462b-a2a4-5cf9f61d2230"></a>
##Public FillGradient

###Return Type

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FillGradient` property of the `KimonoStyle` class has a `KimonoCore.KimonoGradient` value.

---

<a name="d1343904-d933-476e-a7f5-6cc32f200476"></a>
##Public FillJitterDeviation

###Return Type

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FillJitterDeviation` property of the `KimonoStyle` class has a `System.Single` value.

---

<a name="c4395ba1-56f5-4246-9d2f-86078b2c90cb"></a>
##Public FillJitterLength

###Return Type

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FillJitterLength` property of the `KimonoStyle` class has a `System.Single` value.

---

<a name="c746ecea-b4a3-4609-8e73-90302e132254"></a>
##Public Static Read Only Flora

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Flora` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="504e6167-c6ac-4474-862f-3d79d22ae5ad"></a>
##Public FontFamilyName

###Return Type

`System.String`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FontFamilyName` property of the `KimonoStyle` class has a `System.String` value.

---

<a name="71444a51-edb5-40c4-91f6-790285612e04"></a>
##Public FontFamilyName

###Return Type

`System.String`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `FontFamilyName` property of the `KimonoShapeText` class has a `System.String` value.

---

<a name="e2b6e298-537c-407a-aff0-f0f1cf85d2cd"></a>
##Public Read Only FontMetrics

###Return Type

`SkiaSharp.SKFontMetrics`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public read only `FontMetrics` property of the `KimonoStyle` class has a `SkiaSharp.SKFontMetrics` value.

---

<a name="776f4e39-49a3-4c58-8e76-78996d176796"></a>
##Public Read Only FontMetrics

###Return Type

`SkiaSharp.SKFontMetrics`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public read only `FontMetrics` property of the `KimonoShapeText` class has a `SkiaSharp.SKFontMetrics` value.

---

<a name="abbc496b-a050-4aab-8bcd-7a51f8f88e5d"></a>
##Public Frame

###Return Type

`SkiaSharp.SKPaint`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `Frame` property of the `KimonoStyle` class has a `SkiaSharp.SKPaint` value.

---

<a name="cc269460-c010-4e20-91a2-aab3ae1f6766"></a>
##Public FrameBlur

###Return Type

[KimonoCore.KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FrameBlur` property of the `KimonoStyle` class has a `KimonoCore.KimonoBlur` value.

---

<a name="a4b164b1-0670-4b7c-83a4-4050889ec3fe"></a>
##Public FrameColor

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FrameColor` property of the `KimonoStyle` class has a `KimonoCore.KimonoColor` value.

---

<a name="12628290-cb2e-438f-8f00-5a50c67305e1"></a>
##Public FrameGradient

###Return Type

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FrameGradient` property of the `KimonoStyle` class has a `KimonoCore.KimonoGradient` value.

---

<a name="0342689b-d4de-47ba-a00b-9e91d0d6d7ef"></a>
##Public FrameJitterDeviation

###Return Type

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FrameJitterDeviation` property of the `KimonoStyle` class has a `System.Single` value.

---

<a name="18637966-0a1f-41f9-85d9-aff50ab6144f"></a>
##Public FrameJitterLength

###Return Type

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `FrameJitterLength` property of the `KimonoStyle` class has a `System.Single` value.

---

<a name="88fd0355-c6dd-480c-9beb-c4d6575cbcc8"></a>
##Public Gradient

###Return Type

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public `Gradient` property of the `KimonoGradientDesignBar` class has a `KimonoCore.KimonoGradient` value.

---

<a name="ad9edaee-877e-49bc-aaaf-21ecaf353e41"></a>
##Public Gradient

###Return Type

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public `Gradient` property of the `KimonoGradientDesignPreview` class has a `KimonoCore.KimonoGradient` value.

---

<a name="36a840d8-5adb-41ac-b159-3ddc9b051d05"></a>
##Public Gradients

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoGradient>`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `Gradients` property of the `KimonoPortfolio` class has a `System.Collections.Generic.List<KimonoCore.KimonoGradient>` value.

---

<a name="43b475b2-ee09-4f7c-b01c-cc82a7f63c74"></a>
##Public GradientType

###Return Type

[KimonoCore.KimonoGradientType](#15ec7baa-7b4c-41fe-ade4-0707f190962a)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `GradientType` property of the `KimonoGradient` class has a `KimonoCore.KimonoGradientType` value.

---

<a name="e53624bb-65f9-4ee7-b489-b5eb95c445d5"></a>
##Public Static Read Only Grape

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Grape` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="f8941506-e1a3-490b-8c9d-d96bb4821729"></a>
##Public Static Read Only Gray

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Gray` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="fe18f423-dea9-4f8b-ad28-0abdafb9ed58"></a>
##Public Static Read Only Green

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Green` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="6814433b-b077-4a46-952e-8c0bcc9f10c5"></a>
##Public GroupType

###Return Type

[KimonoCore.KimonoShapeGroupType](#7d6f36d2-8266-4a30-b62d-bf0d805c00fe)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `GroupType` property of the `KimonoShapeGroup` class has a `KimonoCore.KimonoShapeGroupType` value.

---

<a name="a215d694-6e82-40f8-91ce-f976478d67e0"></a>
##Public HandleType

###Return Type

[KimonoCore.KimonoHandleType](#26c349b5-1f2e-4106-9168-f9f405f0e58c)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `HandleType` property of the `KimonoHandle` class has a `KimonoCore.KimonoHandleType` value.

---

<a name="8ca632c8-6ff7-4cc7-beb0-85d542a6f09c"></a>
##Public HasEndHead

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `HasEndHead` property of the `KimonoShapeArrow` class has a `System.Boolean` value.

---

<a name="2328366d-c783-4ebe-943a-01007d67a912"></a>
##Public HasFill

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `HasFill` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="6b3b793e-517f-4df2-bc85-0aa2ff523d25"></a>
##Public HasFillBlur

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `HasFillBlur` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="8d8e2b52-7d44-4c9f-8e75-0042c3e28e42"></a>
##Public HasFillJitter

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `HasFillJitter` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="9fe89c21-2ab7-428d-acd6-e2dfdb51621a"></a>
##Public HasFrame

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `HasFrame` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="0e481594-67a1-408e-b132-88eee781886c"></a>
##Public HasFrameBlur

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `HasFrameBlur` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="677a8884-201b-4bcd-a5d1-4dfbe1a79421"></a>
##Public HasFrameDash

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `HasFrameDash` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="824b4987-25bd-43db-bd46-6477551010c1"></a>
##Public HasFrameJitter

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `HasFrameJitter` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="78b2628f-f8f8-48c3-82de-ba548edc6728"></a>
##Public HasStartHead

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `HasStartHead` property of the `KimonoShapeArrow` class has a `System.Boolean` value.

---

<a name="a9bb33fd-195b-4cd0-8a97-431314f38714"></a>
##Public HeadInnerRatio

###Return Type

`System.Single`

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `HeadInnerRatio` property of the `KimonoShapeArrow` class has a `System.Single` value.

---

<a name="f15f170c-26b0-4a02-865b-927995c7b005"></a>
##Public HeadOuterRatio

###Return Type

`System.Single`

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `HeadOuterRatio` property of the `KimonoShapeArrow` class has a `System.Single` value.

---

<a name="de51e2be-9b6c-4519-a92a-c214a5bb594b"></a>
##Public Height

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Height` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="982a8b2c-5d96-4b3f-be84-a5bfea2babbb"></a>
##Public Height

###Return Type

`System.Single`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `Height` property of the `KimonoSketch` class has a `System.Single` value.

---

<a name="4eb3c765-3293-4a9c-a378-7ea64f1dc5ca"></a>
##Public HitHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `HitHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="23345182-7e3f-4f8c-9c0b-e4218436058c"></a>
##Public HitOffset

###Return Type

`SkiaSharp.SKPoint`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `HitOffset` property of the `KimonoBounds` class has a `SkiaSharp.SKPoint` value.

---

<a name="67d948cd-e9d3-4e9a-9062-32c524dac597"></a>
##Public HitOffset

###Return Type

`SkiaSharp.SKPoint`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `HitOffset` property of the `KimonoHandle` class has a `SkiaSharp.SKPoint` value.

---

<a name="70537db3-ebe3-424a-80cb-6ba6802d5fcd"></a>
##Public Static Read Only Honeydew

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Honeydew` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="d820cf2d-d566-400f-9ce2-b33ba0da72dc"></a>
##Public HorizontalBlurAmount

###Return Type

`System.Single`

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The public `HorizontalBlurAmount` property of the `KimonoBlur` class has a `System.Single` value.

---

<a name="cef81fdb-e8e9-4a8e-96d9-cba267a7d85b"></a>
##Public Read Only HorizontalCenter

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public read only `HorizontalCenter` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="5a804fbe-c066-48f7-a6ea-7c72f120e71b"></a>
##Public HueAdjustment

###Return Type

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `HueAdjustment` property of the `KimonoColor` class has a `System.Single` value.

---

<a name="50dc6fa6-1149-468f-9b1f-1b95e9b404e3"></a>
##Public Static Read Only Ice

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Ice` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="ae47a554-2a62-44d5-b932-ff3ff759060c"></a>
##Public Index

###Return Type

`System.Int32`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `Index` property of the `KimonoHandle` class has a `System.Int32` value.

---

<a name="a248ab75-063e-494b-8dc9-1cc80fc4c1e2"></a>
##Public Static Read Only Iron

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Iron` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="fa8ae91d-04cc-4ec4-80ae-f06eeeb26bfd"></a>
##Public Virtual Read Only IsEditable

###Return Type

`System.Boolean`

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public read only virtual `IsEditable` property of the `KimonoShape` class has a `System.Boolean` value.

---

<a name="b15475ab-3af4-4ccd-a428-c2f1f3cc67a5"></a>
##Public Virtual Read Only IsEditable

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public read only virtual `IsEditable` property of the `KimonoShapeGroup` class has a `System.Boolean` value.

---

<a name="bc61728c-5241-4164-94da-e5687b7766cc"></a>
##Public Virtual Read Only IsEditable

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public read only virtual `IsEditable` property of the `KimonoShapeVector` class has a `System.Boolean` value.

---

<a name="68dc5bb8-d497-4b17-8870-f0ba7806714c"></a>
##Public IsLinearText

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `IsLinearText` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="ec1fc79a-bae6-43df-8b2f-321dda7e61b0"></a>
##Public IsLinearText

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `IsLinearText` property of the `KimonoShapeText` class has a `System.Boolean` value.

---

<a name="e2e1d678-442d-4086-984e-407867f682b1"></a>
##Public IsStreamlined

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `IsStreamlined` property of the `KimonoShapeArrow` class has a `System.Boolean` value.

---

<a name="90584ec8-3059-4feb-983e-37bb79e7ffbc"></a>
##Public IsVerticalText

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `IsVerticalText` property of the `KimonoShapeText` class has a `System.Boolean` value.

---

<a name="bc725ffb-5cb2-4ed9-97b6-02441bef6cb3"></a>
##Public IsVerticalText

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `IsVerticalText` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="c4bd9f7e-167f-4330-bf98-d1599aa246e8"></a>
##Public Static Read Only Lavender

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Lavender` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="82eab041-9c49-4202-accd-6bfa928892a6"></a>
##Public LayerDepth

###Return Type

`System.Int32`

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `LayerDepth` property of the `KimonoShape` class has a `System.Int32` value.

---

<a name="793c798a-22f6-47f9-b8f4-297d42983661"></a>
##Public Static Read Only Lead

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Lead` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="f0e06ad3-7664-4721-a6ae-6e6ea8bd1950"></a>
##Public Left

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Left` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="2b65c98f-c301-45b9-ab8b-510af994a4a3"></a>
##Public LeftHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `LeftHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="7f32ea9d-569b-41c8-b679-a1295d2479ae"></a>
##Public Static Read Only Lemon

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Lemon` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="cc0ed75f-5bb3-4f25-8a05-e845082141cf"></a>
##Public Static Read Only Licorice

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Licorice` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="5f5873e6-b9ad-4a43-8fe6-3d1d77467aa9"></a>
##Public Static Read Only LightGray

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `LightGray` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="5526a574-dd0f-4957-90c4-cd6237b89430"></a>
##Public Static Read Only Lime

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Lime` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="72bdffad-6a78-4e4c-b106-77419f0b12b8"></a>
##Public LinkedColor

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `LinkedColor` property of the `KimonoHandle` class has a `KimonoCore.KimonoColor` value.

---

<a name="6f77743e-30a2-4535-8fad-7bab5753d4af"></a>
##Public Static Read Only Magenta

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Magenta` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="d28590e8-5084-49ff-829f-48226908e2c4"></a>
##Public Static Read Only Magnesium

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Magnesium` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="608c6d3f-d11a-45f4-9f64-223baecad03f"></a>
##Public Static Read Only Maraschino

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Maraschino` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="d32ab6f3-f683-4696-8e57-394f6af9c49d"></a>
##Public Static Read Only Maroon

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Maroon` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="691c9cfb-232e-45d8-b111-808b136b451a"></a>
##Public MaximumUndoPoints

###Return Type

`System.Int32`

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `MaximumUndoPoints` property of the `KimonoUndoHandler` class has a `System.Int32` value.

---

<a name="267a4ef3-ab74-4869-ad89-5a854d1573dc"></a>
##Public Static Read Only Mercury

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Mercury` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="e194694c-0560-4e7e-a57d-05bf39ee9570"></a>
##Public Static Read Only Midnight

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Midnight` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="4d081972-f7a0-4e13-8eea-6f0996a10b83"></a>
##Public Static Read Only Mocha

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Mocha` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="ff895d6e-e81c-4252-bae3-00d520d47df1"></a>
##Public Static Read Only Moss

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Moss` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="3664d6fe-b173-47f0-af45-d962aea6b409"></a>
##Public Name

###Return Type

`System.String`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `Name` property of the `KimonoGradient` class has a `System.String` value.

---

<a name="0628dfaa-fe57-4901-a857-09c802ba3602"></a>
##Public Name

###Return Type

`System.String`

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `Name` property of the `KimonoShape` class has a `System.String` value.

---

<a name="7a012b6d-249d-497c-81ff-a7113eea1d8e"></a>
##Public Name

###Return Type

`System.String`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `Name` property of the `KimonoSketch` class has a `System.String` value.

---

<a name="957abe2d-724e-4d2d-ba80-c581bd4582b2"></a>
##Public Name

###Return Type

`System.String`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `Name` property of the `KimonoStyle` class has a `System.String` value.

---

<a name="c2223d63-c523-44fe-8dbf-990d4f671cc8"></a>
##Public Name

###Return Type

`System.String`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `Name` property of the `KimonoColor` class has a `System.String` value.

---

<a name="785235bd-8e2a-4652-8feb-e30998670d77"></a>
##Public Static Read Only Nickle

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Nickle` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="5acc1b7a-9989-4dd6-8325-5f46a2897ab3"></a>
##Public NumberOfPoints

###Return Type

`System.Int32`

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public `NumberOfPoints` property of the `KimonoShapeStar` class has a `System.Int32` value.

---

<a name="0d45c481-0d01-4cf4-a503-8085b26965a8"></a>
##Public NumberOfSides

###Return Type

`System.Int32`

###Member of Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The public `NumberOfSides` property of the `KimonoShapePolygon` class has a `System.Int32` value.

---

<a name="d3747703-7f9d-45ee-bbc9-cc63c533a155"></a>
##Public Static Read Only Ocean

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Ocean` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="b5fdd2ad-a667-4e37-bf48-4d07389f89a8"></a>
##Public Static Read Only Orange

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Orange` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="7db2e55d-0194-4937-9c93-c995b3602ca6"></a>
##Public Static Read Only Orchid

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Orchid` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="f562fc5b-0d53-4998-9bec-ce773b524a25"></a>
##Public Parent

###Return Type

`System.Object`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `Parent` property of the `KimonoShapeGroup` class has a `System.Object` value.

---

<a name="f1e046b4-7b71-4f93-9323-cf2cd9b0156d"></a>
##Public Read Only ParentSketch

###Return Type

[KimonoCore.KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public read only `ParentSketch` property of the `KimonoShapeGroup` class has a `KimonoCore.KimonoSketch` value.

---

<a name="05b958dc-dcda-4ebe-8d5a-d751349e5015"></a>
##Public Read Only Path

###Return Type

`System.String`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public read only `Path` property of the `KimonoShapeGroup` class has a `System.String` value.

---

<a name="185cca5a-3f16-4d1e-9f99-592a06bd3305"></a>
##Public Static Read Only Pink

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Pink` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="4f5c506a-3fae-4d2f-82cb-47d55c17f5d7"></a>
##Public Static Read Only Plum

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Plum` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="81c019dc-e9c4-4289-87fc-4196967c1fce"></a>
##Public Points

###Return Type

`System.Collections.Generic.List<SkiaSharp.SKPoint>`

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `Points` property of the `KimonoShapeVector` class has a `System.Collections.Generic.List<SkiaSharp.SKPoint>` value.

---

<a name="6f7f1c54-8ad8-4713-a055-349d16e78662"></a>
##Public Portfolio

###Return Type

[KimonoCore.KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `Portfolio` property of the `KimonoDesignSurface` class has a `KimonoCore.KimonoPortfolio` value.

---

<a name="0c47d62e-559c-4d6d-9977-ae93ede756e0"></a>
##Public PreviewHeight

###Return Type

`System.Single`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `PreviewHeight` property of the `KimonoGradient` class has a `System.Single` value.

---

<a name="c2f7cca2-346b-4375-a705-3e3b82b19813"></a>
##Public PreviewWidth

###Return Type

`System.Single`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `PreviewWidth` property of the `KimonoGradient` class has a `System.Single` value.

---

<a name="c00f1ecc-0d84-4d8b-b86e-457f7e3307c9"></a>
##Public Static Read Only Purple

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Purple` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="1a28abe8-016d-409c-82cb-172813407050"></a>
##Public Radius

###Return Type

`System.Single`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `Radius` property of the `KimonoGradient` class has a `System.Single` value.

---

<a name="6309e81d-b3b3-4ff5-9419-4c9544e48b29"></a>
##Public Read Only Rect

###Return Type

`SkiaSharp.SKRect`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public read only `Rect` property of the `KimonoHandle` class has a `SkiaSharp.SKRect` value.

---

<a name="76e7c4fd-9423-4fe5-b5e9-65ed84320926"></a>
##Public Static Read Only Red

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Red` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="a4f7598e-6cfe-41c1-88f9-77a59275c3cf"></a>
##Public RedoStack

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoPortfolio>`

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `RedoStack` property of the `KimonoUndoHandler` class has a `System.Collections.Generic.List<KimonoCore.KimonoPortfolio>` value.

---

<a name="91a99171-d36f-4b7a-b1db-1b5c52c48dfa"></a>
##Public Read Only RepresentedColor

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public read only `RepresentedColor` property of the `KimonoHandle` class has a `SkiaSharp.SKColor` value.

---

<a name="28b63feb-c443-4a2c-a836-c4dd07e53f61"></a>
##Public Right

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Right` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="e369b4de-2ea4-4ed7-a477-a1a72cbf5c4d"></a>
##Public RightHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `RightHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="ec496c24-9e48-4a1d-ae15-87d2c579cb2d"></a>
##Public RotationDegrees

###Return Type

`System.Int32`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `RotationDegrees` property of the `KimonoBounds` class has a `System.Int32` value.

---

<a name="e0b46995-7e7c-472e-a716-969f7bec6728"></a>
##Public Static Read Only Salmon

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Salmon` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="8bc3cf52-e5a8-4d7e-ace3-7ebafdf3bf1c"></a>
##Public SaturationAdjustment

###Return Type

`System.Single`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `SaturationAdjustment` property of the `KimonoColor` class has a `System.Single` value.

---

<a name="2ce8789f-7aee-4917-abcc-ef6c979d66d7"></a>
##Public Static Read Only SeaFoam

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `SeaFoam` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="7fb4df4a-84cb-4d58-a9ec-553a0b131d7c"></a>
##Public Read Only SelectedColor

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public read only `SelectedColor` property of the `KimonoGradient` class has a `SkiaSharp.SKColor` value.

---

<a name="f46a3b46-3f4b-49c0-adf7-488c1ecf6a08"></a>
##Public SelectedHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `SelectedHandle` property of the `KimonoGradient` class has a `KimonoCore.KimonoHandle` value.

---

<a name="3ee8a7c4-5a5f-4a53-a8e7-f154d2146921"></a>
##Public SelectedShape

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `SelectedShape` property of the `KimonoSketch` class has a `KimonoCore.KimonoShape` value.

---

<a name="85e0ca2c-bcd5-441a-945d-ef896474667c"></a>
##Public SelectedShape

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `SelectedShape` property of the `KimonoShapeGroup` class has a `KimonoCore.KimonoShape` value.

---

<a name="76c1c2e4-b043-4769-bdcb-3d93b30216f5"></a>
##Public SelectedShape

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `SelectedShape` property of the `KimonoDesignSurface` class has a `KimonoCore.KimonoShape` value.

---

<a name="ea0e3f86-b02d-4009-a6b0-f7579d3190a5"></a>
##Public Read Only SelectedShapeAtBottom

###Return Type

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public read only `SelectedShapeAtBottom` property of the `KimonoSketch` class has a `System.Boolean` value.

---

<a name="1746b332-e51a-4a87-958d-2dc9d2cf18af"></a>
##Public Read Only SelectedShapeAtBottom

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public read only `SelectedShapeAtBottom` property of the `KimonoShapeGroup` class has a `System.Boolean` value.

---

<a name="4451a58d-ef4c-4f6a-9d21-19bf79ca3663"></a>
##Public Read Only SelectedShapeAtTop

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public read only `SelectedShapeAtTop` property of the `KimonoShapeGroup` class has a `System.Boolean` value.

---

<a name="ffa05f04-3338-4093-aa05-1e0b40a989f1"></a>
##Public Read Only SelectedShapeAtTop

###Return Type

`System.Boolean`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public read only `SelectedShapeAtTop` property of the `KimonoSketch` class has a `System.Boolean` value.

---

<a name="ff13957b-70d0-4f57-be85-00b1d3916be4"></a>
##Public SelectedSketch

###Return Type

[KimonoCore.KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `SelectedSketch` property of the `KimonoDesignSurface` class has a `KimonoCore.KimonoSketch` value.

---

<a name="81d09865-7f77-4c01-91a1-bf5aa0de3563"></a>
##Public SelectedSketch

###Return Type

[KimonoCore.KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `SelectedSketch` property of the `KimonoPortfolio` class has a `KimonoCore.KimonoSketch` value.

---

<a name="dd7322b7-3a67-47d3-92ff-62dae9cd7999"></a>
##Public Read Only Shader

###Return Type

`SkiaSharp.SKShader`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public read only `Shader` property of the `KimonoGradient` class has a `SkiaSharp.SKShader` value.

---

<a name="7489aff7-094c-46f0-a6b9-480e14a75b29"></a>
##Public Shapes

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoShape>`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `Shapes` property of the `KimonoSketch` class has a `System.Collections.Generic.List<KimonoCore.KimonoShape>` value.

---

<a name="86c9136c-abb2-4454-b3fb-c007b0fed060"></a>
##Public Shapes

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoShape>`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `Shapes` property of the `KimonoShapeGroup` class has a `System.Collections.Generic.List<KimonoCore.KimonoShape>` value.

---

<a name="27091374-d862-4f27-b943-2a2a019564fb"></a>
##Public Static Read Only Silver

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Silver` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="2ead5bb9-277c-4513-94ae-127b2fc15985"></a>
##Public Sketches

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoSketch>`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `Sketches` property of the `KimonoPortfolio` class has a `System.Collections.Generic.List<KimonoCore.KimonoSketch>` value.

---

<a name="3ef62a0a-ca6f-49ec-937e-48bbc0c72e54"></a>
##Public SkipPoints

###Return Type

`System.Int32`

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public `SkipPoints` property of the `KimonoShapeStar` class has a `System.Int32` value.

---

<a name="52417cbe-354c-412b-ac7e-c8aaa515de8c"></a>
##Public Static Read Only Sky

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Sky` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="2def0693-dfc1-4ced-a26d-2790dbbc64b6"></a>
##Public Static Read Only Snow

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Snow` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="bd9c4159-725a-4a7e-9ab2-4d92c8f60b40"></a>
##Public Static Read Only Spindrift

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Spindrift` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="590a254e-323b-4d01-8f36-44643c086046"></a>
##Public Static Read Only Spring

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Spring` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="1d523c6d-ac26-4569-9bc0-98e40ff937fd"></a>
##Public StartPoint

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `StartPoint` property of the `KimonoGradient` class has a `KimonoCore.KimonoHandle` value.

---

<a name="7f8cf0aa-d2cc-4e2b-9d11-31168c42f1eb"></a>
##Public State

###Return Type

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `State` property of the `KimonoBounds` class has a `KimonoCore.KimonoShapeState` value.

---

<a name="5c121ef4-2da4-4c16-9e17-71c70d79641d"></a>
##Public State

###Return Type

[KimonoCore.KimonoShapeState](#dd9f0b12-aa56-4011-8727-9289436b1a36)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `State` property of the `KimonoHandle` class has a `KimonoCore.KimonoShapeState` value.

---

<a name="93dc5bcf-d854-4467-9973-a1e0a408c20f"></a>
##Public Static Read Only Steel

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Steel` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="fa00e185-a2ec-43a1-a40c-f4d7dac65cec"></a>
##Public Static Read Only Strawberry

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Strawberry` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="f2c6b4e7-e468-4c0b-92ea-e8672c186d5c"></a>
##Public StrikeThruText

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `StrikeThruText` property of the `KimonoShapeText` class has a `System.Boolean` value.

---

<a name="2ab19b42-53ed-40ab-8776-3a16b3651a1f"></a>
##Public StrikeThruText

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `StrikeThruText` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="3ff31721-df6c-4326-8b0d-9de5f0c57a62"></a>
##Public Virtual Style

###Return Type

[KimonoCore.KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `Style` property of the `KimonoShape` class has a `KimonoCore.KimonoStyle` value.

---

<a name="2931890a-0a3e-4af7-b2c5-1909ea208ab2"></a>
##Public Virtual Style

###Return Type

[KimonoCore.KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `Style` property of the `KimonoShapeGroup` class has a `KimonoCore.KimonoStyle` value.

---

<a name="e39202b7-3688-4d61-b998-57518f0e7a5c"></a>
##Public Styles

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoStyle>`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `Styles` property of the `KimonoPortfolio` class has a `System.Collections.Generic.List<KimonoCore.KimonoStyle>` value.

---

<a name="0e7827de-54b6-43c1-b80b-f6f56224a32f"></a>
##Public StyleType

###Return Type

[KimonoCore.KimonoStyleType](#e715544c-1bd6-4f0f-812a-151d4fc8b509)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `StyleType` property of the `KimonoStyle` class has a `KimonoCore.KimonoStyleType` value.

---

<a name="54a32cbd-bd10-4cbb-becf-f6d240ab6bfc"></a>
##Public Static Read Only Tangerine

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Tangerine` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="2e9500d1-f22f-4210-b02d-1ba39938ffaf"></a>
##Public Static Read Only Teal

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Teal` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="c5573f11-e2dc-4065-b741-9563e01404c0"></a>
##Public Text

###Return Type

`System.String`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `Text` property of the `KimonoShapeText` class has a `System.String` value.

---

<a name="c8fc75e8-2682-4a1f-99d0-283fc3d5ba03"></a>
##Public TextAlign

###Return Type

`SkiaSharp.SKTextAlign`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `TextAlign` property of the `KimonoStyle` class has a `SkiaSharp.SKTextAlign` value.

---

<a name="ed163b36-599c-4670-ad9f-4803a7f4ba83"></a>
##Public TextAlign

###Return Type

`SkiaSharp.SKTextAlign`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `TextAlign` property of the `KimonoShapeText` class has a `SkiaSharp.SKTextAlign` value.

---

<a name="96fe54d9-760f-4e19-83bc-92f620cffcdf"></a>
##Public TextEncoding

###Return Type

`SkiaSharp.SKTextEncoding`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `TextEncoding` property of the `KimonoStyle` class has a `SkiaSharp.SKTextEncoding` value.

---

<a name="bd358a44-f2a1-44ce-9277-fc417a550c58"></a>
##Public TextEncoding

###Return Type

`SkiaSharp.SKTextEncoding`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `TextEncoding` property of the `KimonoShapeText` class has a `SkiaSharp.SKTextEncoding` value.

---

<a name="d9cc1ec3-926c-455c-8794-737f7fb4ee4f"></a>
##Public TextScaleX

###Return Type

`System.Single`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `TextScaleX` property of the `KimonoShapeText` class has a `System.Single` value.

---

<a name="8a009395-2402-4622-adda-1cdcdbe534f4"></a>
##Public TextScaleX

###Return Type

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `TextScaleX` property of the `KimonoStyle` class has a `System.Single` value.

---

<a name="521c4f46-de29-4d83-bb0c-0da32efa6793"></a>
##Public TextSize

###Return Type

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `TextSize` property of the `KimonoStyle` class has a `System.Single` value.

---

<a name="70a76901-3866-4aa5-8520-6f3b3158ca06"></a>
##Public TextSize

###Return Type

`System.Single`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `TextSize` property of the `KimonoShapeText` class has a `System.Single` value.

---

<a name="91b2c5fc-16af-4648-a5ce-1b60c511d4bd"></a>
##Public TextSkewX

###Return Type

`System.Single`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `TextSkewX` property of the `KimonoStyle` class has a `System.Single` value.

---

<a name="38b6bc23-95bd-449e-ad43-6d97b4104f49"></a>
##Public TextSkewX

###Return Type

`System.Single`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `TextSkewX` property of the `KimonoShapeText` class has a `System.Single` value.

---

<a name="933a04bf-5946-4379-874c-8c29c8608339"></a>
##Public TileMode

###Return Type

`SkiaSharp.SKShaderTileMode`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `TileMode` property of the `KimonoGradient` class has a `SkiaSharp.SKShaderTileMode` value.

---

<a name="4b9df7fa-42c2-4ee1-a885-d8fee098c534"></a>
##Public Static Read Only Tin

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Tin` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="2b14195b-15dd-4fee-938a-21566feea7a9"></a>
##Public Tool

###Return Type

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `Tool` property of the `KimonoDesignSurface` class has a `KimonoCore.KimonoTool` value.

---

<a name="a8a0bd81-f04c-4de3-bd54-cb75e89ff537"></a>
##Public Tool

###Return Type

[KimonoCore.KimonoTool](#0286b37c-e03e-4d80-824c-fc8c54818ea4)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `Tool` property of the `KimonoSketch` class has a `KimonoCore.KimonoTool` value.

---

<a name="adb04526-c6b2-4247-bccb-7d6d8589f4e5"></a>
##Public Top

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Top` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="6d072d3a-d3ab-4a30-aa03-fc3a90e4eae0"></a>
##Public TopHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `TopHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="5f0abbcc-f631-4a89-bbac-5ba0694eca67"></a>
##Public TopLeftHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `TopLeftHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="cd455fac-085e-47a3-8c0f-73470d937cb6"></a>
##Public TopRightHandle

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `TopRightHandle` property of the `KimonoBounds` class has a `KimonoCore.KimonoHandle` value.

---

<a name="fa4514d7-6fdf-4c4a-8975-29a839ee5be5"></a>
##Public Static Read Only Tungsten

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Tungsten` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="97ed5962-fb74-4a23-8bf9-dd5e5bea0dd1"></a>
##Public Static Read Only Turquoise

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Turquoise` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="d336694b-a044-4100-a36e-8f085c8a19c8"></a>
##Public Typeface

###Return Type

`SkiaSharp.SKTypeface`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `Typeface` property of the `KimonoStyle` class has a `SkiaSharp.SKTypeface` value.

---

<a name="e8bef667-836c-4a24-af21-3096fef18b61"></a>
##Public Typeface

###Return Type

`SkiaSharp.SKTypeface`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `Typeface` property of the `KimonoShapeText` class has a `SkiaSharp.SKTypeface` value.

---

<a name="57888b17-1993-4be1-8aa6-6371b83df79c"></a>
##Public TypefaceStyle

###Return Type

`SkiaSharp.SKTypefaceStyle`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `TypefaceStyle` property of the `KimonoShapeText` class has a `SkiaSharp.SKTypefaceStyle` value.

---

<a name="b723dea9-bb6b-4921-b1c3-3228afd05abc"></a>
##Public TypefaceStyle

###Return Type

`SkiaSharp.SKTypefaceStyle`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `TypefaceStyle` property of the `KimonoStyle` class has a `SkiaSharp.SKTypefaceStyle` value.

---

<a name="ab1c4381-4add-45c4-b27e-d48c3e0211b0"></a>
##Public UnderlineText

###Return Type

`System.Boolean`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `UnderlineText` property of the `KimonoStyle` class has a `System.Boolean` value.

---

<a name="4be9ba8f-f135-4521-bc09-c868a49b9267"></a>
##Public UnderlineText

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `UnderlineText` property of the `KimonoShapeText` class has a `System.Boolean` value.

---

<a name="5749c20e-eff3-4b5d-a8c9-b21e9eb5f81a"></a>
##Public UndoStack

###Return Type

`System.Collections.Generic.List<KimonoCore.KimonoPortfolio>`

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `UndoStack` property of the `KimonoUndoHandler` class has a `System.Collections.Generic.List<KimonoCore.KimonoPortfolio>` value.

---

<a name="f76d175a-b792-4893-b465-f3f44a477399"></a>
##Public UniqueID

###Return Type

`System.String`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `UniqueID` property of the `KimonoPortfolio` class has a `System.String` value.

---

<a name="7ff5623d-2fad-4108-b859-5d7beb23bb86"></a>
##Public UniqueID

###Return Type

`System.String`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `UniqueID` property of the `KimonoStyle` class has a `System.String` value.

---

<a name="3969b6d0-561d-4971-8cfc-37d96aae51fd"></a>
##Public UniqueID

###Return Type

`System.String`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `UniqueID` property of the `KimonoSketch` class has a `System.String` value.

---

<a name="0f4015f5-96db-4a5c-af1b-e6641c800f09"></a>
##Public UniqueID

###Return Type

`System.String`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `UniqueID` property of the `KimonoHandle` class has a `System.String` value.

---

<a name="3c3c71ab-68a2-479b-b660-3c2ce6d84a8e"></a>
##Public UniqueID

###Return Type

`System.String`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `UniqueID` property of the `KimonoBounds` class has a `System.String` value.

---

<a name="4e812a29-4e81-4e3d-9f9f-dddd97105031"></a>
##Public UniqueID

###Return Type

`System.String`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `UniqueID` property of the `KimonoColor` class has a `System.String` value.

---

<a name="72e6f743-339e-4812-a01a-22e34e9681af"></a>
##Public UniqueID

###Return Type

`System.String`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `UniqueID` property of the `KimonoGradient` class has a `System.String` value.

---

<a name="4df6221c-ffb2-46ab-b3c9-1d47f203ed31"></a>
##Public VerticalBlurAmount

###Return Type

`System.Single`

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The public `VerticalBlurAmount` property of the `KimonoBlur` class has a `System.Single` value.

---

<a name="ab9209f5-02a9-4f44-a41a-b8f31aa8aa9b"></a>
##Public Read Only VerticalCenter

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public read only `VerticalCenter` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="26aaa78d-e098-4ed1-852f-0141bf4139d6"></a>
##Public Virtual Visible

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `Visible` property of the `KimonoShapeGroup` class has a `System.Boolean` value.

---

<a name="05bef948-78d4-42dc-a0d4-91618de1c326"></a>
##Public Virtual Visible

###Return Type

`System.Boolean`

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `Visible` property of the `KimonoShape` class has a `System.Boolean` value.

---

<a name="5d8ad8eb-7b4d-4a03-93ca-cc06b291c097"></a>
##Public Static Read Only White

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `White` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.

---

<a name="41727111-a9f9-42f1-9e8b-fe101363da02"></a>
##Public Width

###Return Type

`System.Single`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `Width` property of the `KimonoSketch` class has a `System.Single` value.

---

<a name="10169bb1-0547-4c74-8aed-c730dab18ed8"></a>
##Public Width

###Return Type

`System.Single`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Width` property of the `KimonoBounds` class has a `System.Single` value.

---

<a name="509d9ccd-591e-4419-a933-45c193088bee"></a>
##Public X

###Return Type

`System.Single`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `X` property of the `KimonoHandle` class has a `System.Single` value.

---

<a name="faa3c969-4d6c-4cc0-9ddc-9215dbe79bfe"></a>
##Public Y

###Return Type

`System.Single`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `Y` property of the `KimonoHandle` class has a `System.Single` value.

---

<a name="1662d905-28ff-4310-ab9e-5892cbc0adc6"></a>
##Public Static Read Only Yellow

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static read only `Yellow` property of the `KimonoColor` class has a `SkiaSharp.SKColor` value.
<a name="Methods"></a>
#Methods


---

<a name="0bcabf43-0d9a-4ab8-b4bf-e7f9afc69000"></a>
##Public Virtual AcceptsFirstResponder ()

###Return Type

`System.Boolean`

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public virtual `AcceptsFirstResponder ()` member of the `KimonoGradientDesignPreview` class returns a `System.Boolean` value.

---

<a name="a7b2f1c6-d222-49b6-bac3-f171df5084d7"></a>
##Public Virtual AcceptsFirstResponder ()

###Return Type

`System.Boolean`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public virtual `AcceptsFirstResponder ()` member of the `KimonoDesignSurface` class returns a `System.Boolean` value.

---

<a name="6518fe59-8d0d-4e44-a7d3-c522a608cead"></a>
##Public Virtual AcceptsFirstResponder ()

###Return Type

`System.Boolean`

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public virtual `AcceptsFirstResponder ()` member of the `KimonoGradientDesignBar` class returns a `System.Boolean` value.

---

<a name="943db9d0-4a58-4c56-90ef-731f58e101ed"></a>
##Public Void AddControlPoint ()

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `AddControlPoint ()` member of the `KimonoGradient` class.

---

<a name="8591562b-f4a6-48eb-9db3-d6cf7662fbb6"></a>
##Void AddHandles (KimonoCore.KimonoShapeState)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The  `AddHandles (KimonoCore.KimonoShapeState)` member of the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the AddHandles method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="3d245966-32a0-4396-9a39-29621d62699d"></a>
##Public AddNewColor ()

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `AddNewColor ()` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoColor` value.

---

<a name="bc7d4e19-1362-42d5-9c9e-afc6656a8fd0"></a>
##Public AddNewColor (SkiaSharp.SKColor)

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `AddNewColor (SkiaSharp.SKColor)` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p>The <code>baseColor</code> parameter of the AddNewColor method takes a <code>SkiaSharp.SKColor</code> value. </p>
</td></tr></table></p>


---

<a name="90ce502a-aaef-4d74-bc83-5fbf7100dd95"></a>
##Public AddNewGradient ()

###Return Type

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `AddNewGradient ()` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoGradient` value.

---

<a name="77e3b05e-6188-4987-acdc-addef18ebec6"></a>
##Public Void AddNewSketch ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `AddNewSketch ()` member of the `KimonoPortfolio` class.

---

<a name="5bc8fde5-e91f-4c2a-86e5-660695aa5376"></a>
##Public Void AddNewStyle ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `AddNewStyle ()` member of the `KimonoPortfolio` class.

---

<a name="40df9d7e-908a-4a41-aa93-4fc53ae8f379"></a>
##Public Void AddPoint (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `AddPoint (SkiaSharp.SKPoint)` member of the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the AddPoint method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="3e753e6e-6d8a-4e40-be99-8f6cae088f04"></a>
##Public Void AddPoint (System.Single, System.Single)

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `AddPoint (System.Single, System.Single)` member of the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p>The <code>x</code> parameter of the AddPoint method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p>The <code>y</code> parameter of the AddPoint method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="caf498a5-0d2e-4800-b29f-d55d63c30713"></a>
##Public Void AddShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `AddShape (KimonoCore.KimonoShape)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the AddShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="f2901133-dfb0-4d9a-b5d7-4def2ded6787"></a>
##Public Void AddShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AddShape (KimonoCore.KimonoShape)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the AddShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="1c40bcde-a304-4db1-89d2-e2e90a95566b"></a>
##Public Void AlignAllBottom ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AlignAllBottom ()` member of the `KimonoShapeGroup` class.

---

<a name="fbd44d13-b352-474f-a9df-36297a77cc6e"></a>
##Public Void AlignAllCenter ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AlignAllCenter ()` member of the `KimonoShapeGroup` class.

---

<a name="e82e3202-ca41-4f7b-b60e-daa02560fac3"></a>
##Public Void AlignAllCenterHorizontal ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AlignAllCenterHorizontal ()` member of the `KimonoShapeGroup` class.

---

<a name="7b6b0a3c-7503-4786-92a2-5f74be6142f6"></a>
##Public Void AlignAllCenterVertical ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AlignAllCenterVertical ()` member of the `KimonoShapeGroup` class.

---

<a name="82972f7a-a13b-4885-b095-eddaec19c0e6"></a>
##Public Void AlignAllLeft ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AlignAllLeft ()` member of the `KimonoShapeGroup` class.

---

<a name="21ab55de-63cb-4d71-a99b-034a64702edb"></a>
##Public Void AlignAllRight ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AlignAllRight ()` member of the `KimonoShapeGroup` class.

---

<a name="42a77b07-62b2-4ae3-a2bc-fe10454eadc6"></a>
##Public Void AlignAllTop ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `AlignAllTop ()` member of the `KimonoShapeGroup` class.

---

<a name="9c25babd-e868-44b9-a04e-9fe03de2c8b5"></a>
##Public Void ApplyFillEffects ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `ApplyFillEffects ()` member of the `KimonoStyle` class.

---

<a name="c5f5968d-4c99-4a30-af88-071a380d19cd"></a>
##Public Void ApplyFrameEffects ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `ApplyFrameEffects ()` member of the `KimonoStyle` class.

---

<a name="85cb8f29-c770-4566-b36e-97856e09438d"></a>
##Private Void ApplyMoveAndScale ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `ApplyMoveAndScale ()` member of the `KimonoShapeGroup` class.

---

<a name="d6c61910-831d-4971-acbf-aaa2e1d14b61"></a>
##Private Void ApplyMoveAndScale ()

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The private `ApplyMoveAndScale ()` member of the `KimonoShapeVector` class.

---

<a name="6c259ccb-326f-4c9b-a2c8-314cb82485bd"></a>
##Private Void ApplySizeChange ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `ApplySizeChange ()` member of the `KimonoSketch` class.

---

<a name="c0781f9c-24f3-461e-833b-2a1702b74ae4"></a>
##Public Void BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)` member of the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the BarToolDown method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p>The <code>clicks</code> parameter of the BarToolDown method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p>The <code>multiSelect</code> parameter of the BarToolDown method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="fb638b99-00cb-4b43-ba52-eff7a2403d8c"></a>
##Public Void BarToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `BarToolDrag (SkiaSharp.SKPoint)` member of the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the BarToolDrag method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="27d859c0-4618-46f6-8cbb-60a9a45d42a8"></a>
##Public Void BarToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `BarToolUp (SkiaSharp.SKPoint)` member of the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the BarToolUp method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="52e32a77-3d51-4ee0-a998-885ea79853ed"></a>
##Private Void BaseColorChanged ()

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The private `BaseColorChanged ()` member of the `KimonoColor` class.

---

<a name="e3cb8391-3892-4982-a72b-4e6e20b19c11"></a>
##Public Virtual Void BoundsChanged ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `BoundsChanged ()` member of the `KimonoShapeGroup` class.

---

<a name="224fcd20-fa79-40b0-ad43-33748109b1f9"></a>
##Public Virtual Void BoundsChanged ()

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public virtual `BoundsChanged ()` member of the `KimonoShapeVector` class.

---

<a name="b174ed1b-940b-4c36-9bc0-1fff2f4681c7"></a>
##Public Virtual Void BoundsChanged ()

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `BoundsChanged ()` member of the `KimonoBounds` class.

---

<a name="1e8d2164-f532-4732-a798-515f96f17891"></a>
##Private CalculateConcaveRadius (System.Int32, System.Int32)

###Return Type

`System.Double`

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The private `CalculateConcaveRadius (System.Int32, System.Int32)` member of the `KimonoShapeStar` class returns a `System.Double` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' ><p>The <code>numPoints</code> parameter of the CalculateConcaveRadius method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' class='def'><p>The <code>skip</code> parameter of the CalculateConcaveRadius method takes a <code>System.Int32</code> value. </p>
</td></tr></table></p>


---

<a name="a403c82d-4173-4366-aa71-7cb998e497bd"></a>
##Public Virtual Void ChangeBounds (System.Single, System.Single, System.Single, System.Single)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `ChangeBounds (System.Single, System.Single, System.Single, System.Single)` member of the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the ChangeBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the ChangeBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the ChangeBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the ChangeBounds method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="31d1fb36-e5e6-4945-9899-ed44537463ae"></a>
##Public Static CharIsNumber (System.Char)

###Return Type

`System.Boolean`

###Member of Type

[Kimono](#b263b717-d01a-421a-acb3-efeccd38daa3)

###Summary

The public static `CharIsNumber (System.Char)` member of the `Kimono` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p>The <code>c</code> parameter of the CharIsNumber method takes a <code>System.Char</code> value. </p>
</td></tr></table></p>


---

<a name="d941b671-693c-4d76-a4e1-73d643a97697"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeStar` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="d3e372f2-63d1-4a59-953c-41c11f0ea89b"></a>
##Public Clone ()

###Return Type

[KimonoCore.KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `Clone ()` member of the `KimonoSketch` class returns a `KimonoCore.KimonoSketch` value.

---

<a name="b49f1c0c-4ab2-46b3-8b7f-5a6fecb49158"></a>
##Public Clone ()

###Return Type

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `Clone ()` member of the `KimonoGradient` class returns a `KimonoCore.KimonoGradient` value.

---

<a name="771233ef-6381-42ec-9f8e-9beba83cfc58"></a>
##Public Clone ()

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `Clone ()` member of the `KimonoColor` class returns a `KimonoCore.KimonoColor` value.

---

<a name="dd335f5c-d273-46e2-a6e0-a6cedf1df998"></a>
##Public Clone ()

###Return Type

[KimonoCore.KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `Clone ()` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoPortfolio` value.

---

<a name="7abf9511-1801-4285-b108-4c57f01f044f"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeLine](#6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeLine` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="70d07f23-ded6-4cee-b301-b9a4ea484ff2"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The public virtual `Clone ()` member of the `KimonoShapePolygon` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="157683d4-e429-4543-8c56-9f10ec56b9fd"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeGroup` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="465f282f-ec15-45d6-8179-35f6985aee23"></a>
##Public Clone ()

###Return Type

[KimonoCore.KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The public `Clone ()` member of the `KimonoBlur` class returns a `KimonoCore.KimonoBlur` value.

---

<a name="02d6507c-ed0d-4bff-a0be-d91a3c64c49d"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `Clone ()` member of the `KimonoBounds` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="b116817f-e68c-4245-9e29-d818ed566f00"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeOval](#68719e7d-0150-4764-ab5b-951410790c56)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeOval` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="d3de9f11-52d4-4d59-b5f3-19534695c39b"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeTriangle](#91eab6b8-c802-4441-a4b1-e9de268c98fc)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeTriangle` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="fb473989-d62a-4dcc-9c1c-3cd309d07ddc"></a>
##Public Clone ()

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `Clone ()` member of the `KimonoHandle` class returns a `KimonoCore.KimonoHandle` value.

---

<a name="90662c55-92a7-48e9-88cb-6b1c6b2b01a1"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `Clone ()` member of the `KimonoShape` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="e45720f2-ddf7-46fa-b9d2-1a041eff47e1"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeText` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="67724f55-0b2a-4340-9960-16e2744594b8"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeVector` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="d6540023-22b0-496d-9ad0-f0bfbe1db1ac"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeRect](#2ca1fe46-06b3-4864-bc70-9399db18d5b6)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeRect` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="f3cc08c5-b7e1-4dbf-8b7d-a52cfe57469a"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeRoundRect` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="aff31888-0f0e-481d-be81-8740cb9752af"></a>
##Public Virtual Clone ()

###Return Type

[KimonoCore.KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public virtual `Clone ()` member of the `KimonoShapeArrow` class returns a `KimonoCore.KimonoBounds` value.

---

<a name="a510667b-7c40-4846-be61-7bb8f45363b8"></a>
##Public Clone (System.Boolean)

###Return Type

[KimonoCore.KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `Clone (System.Boolean)` member of the `KimonoStyle` class returns a `KimonoCore.KimonoStyle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deepClone</td><td style='width:75%' ><p>The <code>deepClone</code> parameter of the Clone method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="faf657f6-3960-4002-8060-3a88b00993d5"></a>
##CloneAttachedStyle ()

###Return Type

[KimonoCore.KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The  `CloneAttachedStyle ()` member of the `KimonoShape` class returns a `KimonoCore.KimonoStyle` value.

---

<a name="d3a3ab60-c96d-42ae-bde6-9920f3ce9c57"></a>
##Public Static CloneColor (SkiaSharp.SKColor)

###Return Type

`SkiaSharp.SKColor`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public static `CloneColor (SkiaSharp.SKColor)` member of the `KimonoColor` class returns a `SkiaSharp.SKColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the CloneColor method takes a <code>SkiaSharp.SKColor</code> value. </p>
</td></tr></table></p>


---

<a name="e5f72428-cc8e-4b31-b964-f2cb4d63512c"></a>
##Public Static ClonePaint (SkiaSharp.SKPaint)

###Return Type

`SkiaSharp.SKPaint`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public static `ClonePaint (SkiaSharp.SKPaint)` member of the `KimonoStyle` class returns a `SkiaSharp.SKPaint` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' ><p>The <code>paint</code> parameter of the ClonePaint method takes a <code>SkiaSharp.SKPaint</code> value. </p>
</td></tr></table></p>


---

<a name="dbdf73d0-f4c6-4adc-b103-c0f9d5ec170d"></a>
##Public Static CloneSKPoint (SkiaSharp.SKPoint)

###Return Type

`SkiaSharp.SKPoint`

###Member of Type

[Kimono](#b263b717-d01a-421a-acb3-efeccd38daa3)

###Summary

The public static `CloneSKPoint (SkiaSharp.SKPoint)` member of the `Kimono` class returns a `SkiaSharp.SKPoint` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the CloneSKPoint method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="672d1b8a-5d5f-4384-a0f3-aa03b062b62a"></a>
##Public Virtual Void ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)` member of the `KimonoShape` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the ConformGradientToShape method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' class='def'><p>The <code>paint</code> parameter of the ConformGradientToShape method takes a <code>SkiaSharp.SKPaint</code> value. </p>
</td></tr></table></p>


---

<a name="3b8a9a5e-49a5-4c47-8a43-a8f70d90c868"></a>
##Public ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)

###Return Type

`SkiaSharp.SKShader`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)` member of the `KimonoGradient` class returns a `SkiaSharp.SKShader` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p>The <code>startPoint</code> parameter of the ConformingShader method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p>The <code>endPoint</code> parameter of the ConformingShader method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="c28315f4-3cb5-4a41-9eca-e792c72acb41"></a>
##Public Void ConvertSelectedShapeToStyle ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `ConvertSelectedShapeToStyle ()` member of the `KimonoPortfolio` class.

---

<a name="d1a3a565-8664-4aef-8ce1-1a157e891152"></a>
##Private ConvertToCanvasPoint (AppKit.NSEvent)

###Return Type

`SkiaSharp.SKPoint`

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The private `ConvertToCanvasPoint (AppKit.NSEvent)` member of the `KimonoGradientDesignBar` class returns a `SkiaSharp.SKPoint` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the ConvertToCanvasPoint method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="401e0f0c-7c96-4f2c-b92d-280cef5bb904"></a>
##Private ConvertToCanvasPoint (AppKit.NSEvent)

###Return Type

`SkiaSharp.SKPoint`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `ConvertToCanvasPoint (AppKit.NSEvent)` member of the `KimonoDesignSurface` class returns a `SkiaSharp.SKPoint` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the ConvertToCanvasPoint method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="e758aae9-57df-41a0-9318-d82a806e2ac6"></a>
##Private ConvertToCanvasPoint (AppKit.NSEvent)

###Return Type

`SkiaSharp.SKPoint`

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The private `ConvertToCanvasPoint (AppKit.NSEvent)` member of the `KimonoGradientDesignPreview` class returns a `SkiaSharp.SKPoint` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the ConvertToCanvasPoint method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="ee56d479-8258-4e72-b28d-e56ce40a2ab4"></a>
##Public Void DeleteColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DeleteColor (KimonoCore.KimonoColor)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the DeleteColor method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="6cf5fe44-516c-405c-a586-a745fb13466c"></a>
##Public Void DeleteColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DeleteColor (KimonoCore.KimonoColor)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the DeleteColor method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="467de33b-e045-4269-be88-3adc92721d71"></a>
##Public Void DeleteGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DeleteGradient (KimonoCore.KimonoGradient)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the DeleteGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="e57ff48a-f8ac-48a4-ba58-3792be6d60bf"></a>
##Public Void DeleteGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DeleteGradient (KimonoCore.KimonoGradient)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the DeleteGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="d3032884-3a90-4a04-a207-d066cda50122"></a>
##Public Void DeleteSelectedControlPoint ()

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `DeleteSelectedControlPoint ()` member of the `KimonoGradient` class.

---

<a name="e2411e69-f713-4800-a808-a16ca92a0beb"></a>
##Public Void DeleteSelectedShape ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DeleteSelectedShape ()` member of the `KimonoShapeGroup` class.

---

<a name="25f76383-f9f4-4f57-b43b-e99ca81ff050"></a>
##Public Void DeleteSelectedShape ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `DeleteSelectedShape ()` member of the `KimonoSketch` class.

---

<a name="80120611-3fb0-483a-a6f3-a05dbcc1b7d2"></a>
##Public Void DeleteSelectedShape ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `DeleteSelectedShape ()` member of the `KimonoDesignSurface` class.

---

<a name="666761f7-122c-4b5f-a6bf-c5d9ca18aa76"></a>
##Public Void DeleteSelectedSketch ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DeleteSelectedSketch ()` member of the `KimonoPortfolio` class.

---

<a name="d1bd8a52-048f-4b36-9a60-74f5b1b0acfe"></a>
##Public Void DeleteShapes ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DeleteShapes ()` member of the `KimonoShapeGroup` class.

---

<a name="36721b03-8290-4547-adc8-693507bcda84"></a>
##Public Void DeleteShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DeleteShapes (KimonoCore.KimonoShapeGroup)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p>The <code>group</code> parameter of the DeleteShapes method takes a <code>KimonoCore.KimonoShapeGroup</code> value. </p>
</td></tr></table></p>


---

<a name="98be0cdf-ebe0-4c71-a905-51518fa777e4"></a>
##Public Void DeleteShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DeleteShapes (KimonoCore.KimonoSketch)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the DeleteShapes method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="144badd8-d793-4d23-ba21-362ede749244"></a>
##Public Void DeleteStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DeleteStyle (KimonoCore.KimonoStyle)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the DeleteStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="cb3cab47-9b2c-484e-9fc6-115712a2cb9e"></a>
##Public Void DeselectAll ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DeselectAll ()` member of the `KimonoShapeGroup` class.

---

<a name="282436f7-295d-45a1-a382-4ddbbda9d525"></a>
##Public Void DeselectAll ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `DeselectAll ()` member of the `KimonoSketch` class.

---

<a name="2cc1cd12-79f5-4f42-911d-2d57208b54dc"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `DragBounds (SkiaSharp.SKPoint)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the DragBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="a8166236-cf5b-469d-b926-fe3a54402d43"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public virtual `DragBounds (SkiaSharp.SKPoint)` member of the `KimonoShapeArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the DragBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="f9a8b97d-9d4c-429d-9695-8c1b91876143"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public virtual `DragBounds (SkiaSharp.SKPoint)` member of the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the DragBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="a2b91583-bd5d-4957-8e96-85964089bb29"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `DragBounds (SkiaSharp.SKPoint)` member of the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the DragBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="cbeec0ae-6784-48ce-8535-40958e4fcb2f"></a>
##Public Virtual Void DragBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public virtual `DragBounds (SkiaSharp.SKPoint)` member of the `KimonoShapeText` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the DragBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="a66efc7e-19a1-4967-be21-3a983a43d24a"></a>
##Public Void DragHandle (SkiaSharp.SKPoint)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `DragHandle (SkiaSharp.SKPoint)` member of the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the DragHandle method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="d01bec2b-f0c6-46cc-8f16-a9a2c9b3325d"></a>
##Public Draw ()

###Return Type

`SkiaSharp.SKData`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `Draw ()` member of the `KimonoSketch` class returns a `SkiaSharp.SKData` value.

---

<a name="a16d564e-50eb-4998-bb4c-0502332573ad"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeRoundRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="de26f07f-5e2b-4f2e-9d87-60bcab291df5"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeText` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="231884a6-4dff-43b9-aed4-a9428eca101e"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeRect](#2ca1fe46-06b3-4864-bc70-9399db18d5b6)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="e9c6abe5-da5f-453d-a334-b7623cfae3ef"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeTriangle](#91eab6b8-c802-4441-a4b1-e9de268c98fc)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeTriangle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="96a564b2-aa5f-451f-9a54-62fba23944a2"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapePolygon` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="4e53d2cf-1714-4a43-a260-fbbabff916e2"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="3690b898-1ca3-4650-b89c-e9e6c5e8c168"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="4dbee081-caa6-4f2b-a51b-eeabfba77f08"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="69cc7c2e-264b-4204-a48b-0e5fe09ad1c4"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="ce55fb8f-1f1a-4e21-9fc1-0db047265b81"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeOval](#68719e7d-0150-4764-ab5b-951410790c56)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeOval` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="58e1cbc7-317e-404a-ad09-e5d7fad9119a"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="0f2a0839-8f2a-4e4c-8c0c-ebda8cb2e052"></a>
##Public Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `Draw (SkiaSharp.SKCanvas)` member of the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="38890551-07f3-43cb-a597-4d45cbe6fe9e"></a>
##Public Virtual Void Draw (SkiaSharp.SKCanvas)

###Member of Type

[KimonoShapeLine](#6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8)

###Summary

The public virtual `Draw (SkiaSharp.SKCanvas)` member of the `KimonoShapeLine` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p>The <code>canvas</code> parameter of the Draw method takes a <code>SkiaSharp.SKCanvas</code> value. </p>
</td></tr></table></p>


---

<a name="089c971e-1dbf-447f-8e76-5d6bc7dfca15"></a>
##Public DrawBar ()

###Return Type

`SkiaSharp.SKData`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `DrawBar ()` member of the `KimonoGradient` class returns a `SkiaSharp.SKData` value.

---

<a name="633fc5dd-0034-4470-ad58-18743927e76f"></a>
##Public DrawPreview ()

###Return Type

`SkiaSharp.SKData`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `DrawPreview ()` member of the `KimonoGradient` class returns a `SkiaSharp.SKData` value.

---

<a name="e1cfa8ca-9b66-468b-84cf-ff39008ebcc0"></a>
##Public Void DuplicateColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DuplicateColor (KimonoCore.KimonoColor)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the DuplicateColor method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="0efa9c22-777b-46ca-afc6-84a2a3fd106a"></a>
##Public Void DuplicateGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DuplicateGradient (KimonoCore.KimonoGradient)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the DuplicateGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="637b49b2-33bb-4807-b959-816c44c2a905"></a>
##Public Void DuplicateSelectedControlPoint ()

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `DuplicateSelectedControlPoint ()` member of the `KimonoGradient` class.

---

<a name="db430062-2b8c-4c1c-ab35-e1eaf29ece37"></a>
##Public Void DuplicateSelectedShape ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `DuplicateSelectedShape ()` member of the `KimonoSketch` class.

---

<a name="cd2faecf-bfa0-4799-9065-a00c061ab83c"></a>
##Public Void DuplicateSelectedShape ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DuplicateSelectedShape ()` member of the `KimonoShapeGroup` class.

---

<a name="0ca66fd2-c95a-495b-ad90-10b753fa04ed"></a>
##Public Void DuplicateSelectedShape ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `DuplicateSelectedShape ()` member of the `KimonoDesignSurface` class.

---

<a name="c6671ae0-40b1-40de-9059-e694dba22537"></a>
##Public Void DuplicateSelectedSketch ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DuplicateSelectedSketch ()` member of the `KimonoPortfolio` class.

---

<a name="c7b99718-bc79-40e7-9cb5-1c3e2846db7b"></a>
##Public Void DuplicateShapes ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DuplicateShapes ()` member of the `KimonoShapeGroup` class.

---

<a name="7e355321-468f-4fab-a171-be593efdd9cc"></a>
##Public Void DuplicateShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DuplicateShapes (KimonoCore.KimonoShapeGroup)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p>The <code>group</code> parameter of the DuplicateShapes method takes a <code>KimonoCore.KimonoShapeGroup</code> value. </p>
</td></tr></table></p>


---

<a name="a9a6ffa1-d4dd-4a73-b569-0d542cb4e601"></a>
##Public Void DuplicateShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `DuplicateShapes (KimonoCore.KimonoSketch)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the DuplicateShapes method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="ef94e817-c0be-4545-9179-5d54b6c10914"></a>
##Public Void DuplicateStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `DuplicateStyle (KimonoCore.KimonoStyle)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the DuplicateStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="f57541eb-4680-4c57-ac55-1c047dd35647"></a>
##Public Virtual Void EndEditing ()

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `EndEditing ()` member of the `KimonoShape` class.

---

<a name="6c791575-ca00-4cf4-9480-a9121745d3c8"></a>
##Public Virtual Void EndEditing ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `EndEditing ()` member of the `KimonoShapeGroup` class.

---

<a name="e2419d23-726a-4892-9c42-3d4582f35ef8"></a>
##Public FindColor (System.String)

###Return Type

[KimonoCore.KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `FindColor (System.String)` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p>The <code>uniqueID</code> parameter of the FindColor method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="7669aaad-f676-462b-a116-f39012cdde12"></a>
##Public FindGradient (System.String)

###Return Type

[KimonoCore.KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `FindGradient (System.String)` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoGradient` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p>The <code>uniqueID</code> parameter of the FindGradient method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="f0d9da53-f39a-4942-a1cc-3572cfba27de"></a>
##Public FindHandle (System.String)

###Return Type

[KimonoCore.KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `FindHandle (System.String)` member of the `KimonoGradient` class returns a `KimonoCore.KimonoHandle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p>The <code>uniqueID</code> parameter of the FindHandle method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="234f7172-b34e-4465-902a-ca89b286cabf"></a>
##Private Void FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean&, System.Boolean&, SkiaSharp.SKPoint&, SkiaSharp.SKPoint&, SkiaSharp.SKPoint&)

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The private `FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean&, System.Boolean&, SkiaSharp.SKPoint&, SkiaSharp.SKPoint&, SkiaSharp.SKPoint&)` member of the `KimonoShapeStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>p1</td><td style='width:75%' ><p>The <code>p1</code> parameter of the FindIntersection method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>p2</td><td style='width:75%' class='def'><p>The <code>p2</code> parameter of the FindIntersection method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>p3</td><td style='width:75%' ><p>The <code>p3</code> parameter of the FindIntersection method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>p4</td><td style='width:75%' class='def'><p>The <code>p4</code> parameter of the FindIntersection method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref lines_intersect</td><td style='width:75%' ><p>The <code>lines_intersect</code> parameter of the FindIntersection method takes a <code>System.Boolean&amp;</code> value. Since <code>lines_intersect</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>out</code> modifier.Since <code>lines_intersect</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>ref</code> modifier.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref segments_intersect</td><td style='width:75%' class='def'><p>The <code>segments_intersect</code> parameter of the FindIntersection method takes a <code>System.Boolean&amp;</code> value. Since <code>segments_intersect</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>out</code> modifier.Since <code>segments_intersect</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>ref</code> modifier.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref intersection</td><td style='width:75%' ><p>The <code>intersection</code> parameter of the FindIntersection method takes a <code>SkiaSharp.SKPoint&amp;</code> value. Since <code>intersection</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>out</code> modifier.Since <code>intersection</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>ref</code> modifier.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref close_p1</td><td style='width:75%' class='def'><p>The <code>close_p1</code> parameter of the FindIntersection method takes a <code>SkiaSharp.SKPoint&amp;</code> value. Since <code>close_p1</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>out</code> modifier.Since <code>close_p1</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>ref</code> modifier.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref close_p2</td><td style='width:75%' ><p>The <code>close_p2</code> parameter of the FindIntersection method takes a <code>SkiaSharp.SKPoint&amp;</code> value. Since <code>close_p2</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>out</code> modifier.Since <code>close_p2</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>ref</code> modifier.</p>
</td></tr></table></p>


---

<a name="0c13f7c3-ec84-444a-a253-166b2c028c92"></a>
##Public FindShape (System.String)

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `FindShape (System.String)` member of the `KimonoSketch` class returns a `KimonoCore.KimonoShape` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p>The <code>uniqueID</code> parameter of the FindShape method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="37565a02-58b0-4c51-9c0b-9ad6c7f4661c"></a>
##Public FindShape (System.String)

###Return Type

[KimonoCore.KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `FindShape (System.String)` member of the `KimonoShapeGroup` class returns a `KimonoCore.KimonoShape` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p>The <code>uniqueID</code> parameter of the FindShape method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="950f4e51-fbc1-44f3-a13b-10fed100262f"></a>
##Public FindSketch (System.String)

###Return Type

[KimonoCore.KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `FindSketch (System.String)` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoSketch` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p>The <code>uniqueID</code> parameter of the FindSketch method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="b4e52df5-a711-4245-888a-59e0531d967b"></a>
##Public FindStyle (System.String)

###Return Type

[KimonoCore.KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `FindStyle (System.String)` member of the `KimonoPortfolio` class returns a `KimonoCore.KimonoStyle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p>The <code>uniqueID</code> parameter of the FindStyle method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="dfc60c82-26e0-43c8-b3dd-487fa077696f"></a>
##Public Void GroupShapes ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `GroupShapes ()` member of the `KimonoShapeGroup` class.

---

<a name="986cd184-e4ac-49f2-b599-10a65f653c60"></a>
##Public Void GroupShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `GroupShapes (KimonoCore.KimonoShapeGroup)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p>The <code>group</code> parameter of the GroupShapes method takes a <code>KimonoCore.KimonoShapeGroup</code> value. </p>
</td></tr></table></p>


---

<a name="116d1ac0-1c14-4f70-9a07-ab282fdb4cba"></a>
##Public Void GroupShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `GroupShapes (KimonoCore.KimonoSketch)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the GroupShapes method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="36e0791e-17cc-4003-b3a5-087530191da0"></a>
##Public Void GroupUngroupSelectedShapes ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `GroupUngroupSelectedShapes ()` member of the `KimonoSketch` class.

---

<a name="612d47a6-658a-4284-bbd4-5b6b4c651966"></a>
##Public Virtual Void GrowBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public virtual `GrowBounds (SkiaSharp.SKPoint)` member of the `KimonoShapeText` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the GrowBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="eb01e0da-f22c-4b87-9113-6df3a13b1a87"></a>
##Public Virtual Void GrowBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public virtual `GrowBounds (SkiaSharp.SKPoint)` member of the `KimonoShapeArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the GrowBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="a8c8300f-a2ae-43a4-a0fa-fba6f70cd614"></a>
##Public Virtual Void GrowBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `GrowBounds (SkiaSharp.SKPoint)` member of the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the GrowBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="a0b551a9-5f37-4b29-8bb7-94a857a2434c"></a>
##Private Void HandleFillBlurChange ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `HandleFillBlurChange ()` member of the `KimonoStyle` class.

---

<a name="ba83fbba-2251-4fea-8028-07cbf188b002"></a>
##Private Void HandleFillColorChange ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `HandleFillColorChange ()` member of the `KimonoStyle` class.

---

<a name="b94e4284-9bbb-4248-bf3f-8defd3a62ff4"></a>
##Private Void HandleFillGradientChange ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `HandleFillGradientChange ()` member of the `KimonoStyle` class.

---

<a name="df7f2cdb-00f3-497e-96bc-388ba37215ba"></a>
##Private Void HandleFrameBlurChange ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `HandleFrameBlurChange ()` member of the `KimonoStyle` class.

---

<a name="bb0c559c-79d0-4f71-9d90-17dfb76c6de4"></a>
##Private Void HandleFrameColorChange ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `HandleFrameColorChange ()` member of the `KimonoStyle` class.

---

<a name="d3505825-eeb9-40f3-b191-7e3cf2bed1af"></a>
##Private Void HandleFrameGradientChange ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `HandleFrameGradientChange ()` member of the `KimonoStyle` class.

---

<a name="fc80c022-60fc-4511-a806-c538bec9a451"></a>
##Public Void HandleGradientModified ()

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public `HandleGradientModified ()` member of the `KimonoGradientDesignPreview` class.

---

<a name="6b5c526b-677d-42e4-a84e-e39df3b58064"></a>
##Public Void HandleGradientModified ()

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public `HandleGradientModified ()` member of the `KimonoGradientDesignBar` class.

---

<a name="d789c673-8fd6-44c3-b495-6853ecb51aad"></a>
##Private Void HandleSketchChanging (KimonoCore.KimonoSketch)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `HandleSketchChanging (KimonoCore.KimonoSketch)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the HandleSketchChanging method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="5dd185f7-98bd-48cc-a817-b0260631d592"></a>
##Public Static IncrementName (System.String)

###Return Type

`System.String`

###Member of Type

[Kimono](#b263b717-d01a-421a-acb3-efeccd38daa3)

###Summary

The public static `IncrementName (System.String)` member of the `Kimono` class returns a `System.String` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p>The <code>name</code> parameter of the IncrementName method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="afafb67e-6b98-449d-afeb-1ed25655c427"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The private `Initialize ()` member of the `KimonoShapeText` class.

---

<a name="8da60612-f212-4b48-8a9d-aa6562bdba09"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeTriangle](#91eab6b8-c802-4441-a4b1-e9de268c98fc)

###Summary

The private `Initialize ()` member of the `KimonoShapeTriangle` class.

---

<a name="92450678-a678-4f38-af1e-5ef82f8e765b"></a>
##Void Initialize ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `Initialize ()` member of the `KimonoSketch` class.

---

<a name="b97ebced-a2c1-43e2-a3d0-09cf26647797"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The private `Initialize ()` member of the `KimonoShapeVector` class.

---

<a name="97a755c9-537e-42cc-beab-ce6111adad0a"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The private `Initialize ()` member of the `KimonoShapePolygon` class.

---

<a name="8cd20312-a562-44c6-9697-31b5424a3be8"></a>
##Public Void Initialize ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `Initialize ()` member of the `KimonoDesignSurface` class.

---

<a name="483414bd-ef0b-4659-80cc-2d33fa91a28f"></a>
##Void Initialize ()

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The  `Initialize ()` member of the `KimonoGradient` class.

---

<a name="6c4063d5-dda1-4f71-897f-636e7dfe97f0"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The private `Initialize ()` member of the `KimonoShapeStar` class.

---

<a name="8706535e-b00a-45ca-a5cb-c4ac7f432b4d"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The private `Initialize ()` member of the `KimonoShapeArrow` class.

---

<a name="566b4e7c-c11a-45f6-850a-698b8a507c22"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeOval](#68719e7d-0150-4764-ab5b-951410790c56)

###Summary

The private `Initialize ()` member of the `KimonoShapeOval` class.

---

<a name="8dbb508c-ab9e-4553-9216-af01de39ae2c"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeRect](#2ca1fe46-06b3-4864-bc70-9399db18d5b6)

###Summary

The private `Initialize ()` member of the `KimonoShapeRect` class.

---

<a name="2dd7ce7a-759f-4a7b-a28e-a298cac538f4"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The private `Initialize ()` member of the `KimonoShapeRoundRect` class.

---

<a name="4b5b034a-b9c0-417d-a4d9-255883d20483"></a>
##Void Initialize ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `Initialize ()` member of the `KimonoPortfolio` class.

---

<a name="7189f07d-ee7a-4a2d-8db1-4203b0e30971"></a>
##Void Initialize ()

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The  `Initialize ()` member of the `KimonoShape` class.

---

<a name="d4188863-2260-4fad-80dc-460bd752faf2"></a>
##Private Void Initialize ()

###Member of Type

[KimonoShapeLine](#6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8)

###Summary

The private `Initialize ()` member of the `KimonoShapeLine` class.

---

<a name="7e7ef4c0-4994-48a3-a070-14e95a27f1f8"></a>
##Private Void Initialize ()

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `Initialize ()` member of the `KimonoStyle` class.

---

<a name="35348465-41ad-4d59-b26b-0b7b3b1d5da6"></a>
##Private Void Initialize (System.Object)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The private `Initialize (System.Object)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p>The <code>parent</code> parameter of the Initialize method takes a <code>System.Object</code> value. </p>
</td></tr></table></p>


---

<a name="6200092a-52c8-4091-a475-7aed83829b2d"></a>
##Public Void KimonoBlur ()

###Constructor for Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The public `KimonoBlur ()` constructor for the `KimonoBlur` class.

---

<a name="ffbae91f-276a-4a85-98e2-3908f5bbf6e5"></a>
##Public Void KimonoBlur (System.Single, System.Single)

###Constructor for Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The public `KimonoBlur (System.Single, System.Single)` constructor for the `KimonoBlur` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' ><p>The <code>horizontalBlurAmount</code> parameter of the KimonoBlur method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p>The <code>verticalBlurAmount</code> parameter of the KimonoBlur method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="e34eea8e-4759-455c-b133-8422a51113f4"></a>
##Public Void KimonoBounds ()

###Constructor for Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `KimonoBounds ()` constructor for the `KimonoBounds` class.

---

<a name="569fa607-211f-4f34-9343-64156c821504"></a>
##Public Void KimonoBounds (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `KimonoBounds (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="d7c96676-62f5-418f-9e74-6e6763736595"></a>
##Public Void KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoBounds method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoBounds method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="3afb6312-8855-41a3-be5e-33c6f96a0823"></a>
##Public Void KimonoColor ()

###Constructor for Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `KimonoColor ()` constructor for the `KimonoColor` class.

---

<a name="3396a90d-76df-4a6d-b2fb-d26709d8a56d"></a>
##Public Void KimonoColor (KimonoCore.KimonoColor)

###Constructor for Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `KimonoColor (KimonoCore.KimonoColor)` constructor for the `KimonoColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p>The <code>baseColor</code> parameter of the KimonoColor method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="b5c41070-c604-433d-ae2a-7b78ce459336"></a>
##Public Void KimonoColor (SkiaSharp.SKColor)

###Constructor for Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The public `KimonoColor (SkiaSharp.SKColor)` constructor for the `KimonoColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the KimonoColor method takes a <code>SkiaSharp.SKColor</code> value. </p>
</td></tr></table></p>


---

<a name="81298765-94ef-4732-a6ec-b0d16a6d5fec"></a>
##Public Void KimonoDesignSurface ()

###Constructor for Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `KimonoDesignSurface ()` constructor for the `KimonoDesignSurface` class.

---

<a name="93536513-054e-473f-8956-a1de9dce3cff"></a>
##Public Void KimonoDesignSurface (CoreGraphics.CGRect)

###Constructor for Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `KimonoDesignSurface (CoreGraphics.CGRect)` constructor for the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p>The <code>frameRect</code> parameter of the KimonoDesignSurface method takes a <code>CoreGraphics.CGRect</code> value. </p>
</td></tr></table></p>


---

<a name="d5e84f1b-528d-48c4-8556-89dae78fa307"></a>
##Public Void KimonoDesignSurface (Foundation.NSCoder)

###Constructor for Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `KimonoDesignSurface (Foundation.NSCoder)` constructor for the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p>The <code>coder</code> parameter of the KimonoDesignSurface method takes a <code>Foundation.NSCoder</code> value. </p>
</td></tr></table></p>


---

<a name="5e4285a3-092d-4b12-83ea-6c49c6ec2960"></a>
##Public Void KimonoDesignSurface (System.IntPtr)

###Constructor for Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `KimonoDesignSurface (System.IntPtr)` constructor for the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoDesignSurface method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="a0e6aeb7-d0d5-47f5-9bc7-e3ade5ba0d78"></a>
##Public Void KimonoGradient ()

###Constructor for Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `KimonoGradient ()` constructor for the `KimonoGradient` class.

---

<a name="36e7f37e-cba4-40aa-a8af-e259ff7d18e6"></a>
##Public Void KimonoGradient (System.Single, System.Single)

###Constructor for Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `KimonoGradient (System.Single, System.Single)` constructor for the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p>The <code>barWidth</code> parameter of the KimonoGradient method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p>The <code>barHeight</code> parameter of the KimonoGradient method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="05ba3d16-1162-443c-83cc-61d4277bfc98"></a>
##Public Void KimonoGradient (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `KimonoGradient (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p>The <code>barWidth</code> parameter of the KimonoGradient method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p>The <code>barHeight</code> parameter of the KimonoGradient method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>previewWidth</td><td style='width:75%' ><p>The <code>previewWidth</code> parameter of the KimonoGradient method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>previewHeight</td><td style='width:75%' class='def'><p>The <code>previewHeight</code> parameter of the KimonoGradient method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="d442d207-b744-456e-9a1f-ab7d54917b3e"></a>
##Public Void KimonoGradientDesignBar ()

###Constructor for Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public `KimonoGradientDesignBar ()` constructor for the `KimonoGradientDesignBar` class.

---

<a name="548c2b68-36aa-49ae-8d90-86929965dec0"></a>
##Public Void KimonoGradientDesignBar (CoreGraphics.CGRect)

###Constructor for Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public `KimonoGradientDesignBar (CoreGraphics.CGRect)` constructor for the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p>The <code>frameRect</code> parameter of the KimonoGradientDesignBar method takes a <code>CoreGraphics.CGRect</code> value. </p>
</td></tr></table></p>


---

<a name="fcac7d01-7ca4-4121-bd22-4119b1ddf9f3"></a>
##Public Void KimonoGradientDesignBar (Foundation.NSCoder)

###Constructor for Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public `KimonoGradientDesignBar (Foundation.NSCoder)` constructor for the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p>The <code>coder</code> parameter of the KimonoGradientDesignBar method takes a <code>Foundation.NSCoder</code> value. </p>
</td></tr></table></p>


---

<a name="05b53324-6936-4fdb-b581-46e77a60fc10"></a>
##Public Void KimonoGradientDesignBar (System.IntPtr)

###Constructor for Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public `KimonoGradientDesignBar (System.IntPtr)` constructor for the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoGradientDesignBar method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="3e50b55a-9d07-45dc-8287-8dd2c01cf37b"></a>
##Public Void KimonoGradientDesignPreview ()

###Constructor for Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public `KimonoGradientDesignPreview ()` constructor for the `KimonoGradientDesignPreview` class.

---

<a name="f2c5d31a-ccf0-4366-adbc-0317cb815ae3"></a>
##Public Void KimonoGradientDesignPreview (CoreGraphics.CGRect)

###Constructor for Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public `KimonoGradientDesignPreview (CoreGraphics.CGRect)` constructor for the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p>The <code>frameRect</code> parameter of the KimonoGradientDesignPreview method takes a <code>CoreGraphics.CGRect</code> value. </p>
</td></tr></table></p>


---

<a name="d2434ae7-0c7d-4fc3-a137-a2e0a763f85c"></a>
##Public Void KimonoGradientDesignPreview (Foundation.NSCoder)

###Constructor for Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public `KimonoGradientDesignPreview (Foundation.NSCoder)` constructor for the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p>The <code>coder</code> parameter of the KimonoGradientDesignPreview method takes a <code>Foundation.NSCoder</code> value. </p>
</td></tr></table></p>


---

<a name="423b2565-4567-4891-b5c6-2a42fb2f90d9"></a>
##Public Void KimonoGradientDesignPreview (System.IntPtr)

###Constructor for Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public `KimonoGradientDesignPreview (System.IntPtr)` constructor for the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoGradientDesignPreview method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="b8310974-1103-47cc-93ea-322589842907"></a>
##Private Static Void KimonoHandle ()

###Constructor for Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The private static `KimonoHandle ()` constructor for the `KimonoHandle` class.

---

<a name="56013472-ab38-4319-af4c-744b69ec3a47"></a>
##Public Void KimonoHandle (System.Single, System.Single)

###Constructor for Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `KimonoHandle (System.Single, System.Single)` constructor for the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p>The <code>x</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p>The <code>y</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="6c13f6dd-7d7b-4642-943b-797e85a8bde5"></a>
##Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)

###Constructor for Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)` constructor for the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p>The <code>x</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p>The <code>y</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p>The <code>constraint</code> parameter of the KimonoHandle method takes a <code>KimonoCore.KimonoHandleConstraint</code> value. </p>
</td></tr></table></p>


---

<a name="c7fb39df-1590-4dc2-be24-94381d04c813"></a>
##Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)` constructor for the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p>The <code>x</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p>The <code>y</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p>The <code>constraint</code> parameter of the KimonoHandle method takes a <code>KimonoCore.KimonoHandleConstraint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p>The <code>state</code> parameter of the KimonoHandle method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="bdce73d6-4b5e-4803-ad34-88e042a370f5"></a>
##Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p>The <code>x</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p>The <code>y</code> parameter of the KimonoHandle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoHandle method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="83eb816c-ae88-4297-ab99-b23ebb0a9fd8"></a>
##Public Void KimonoPortfolio (System.Boolean)

###Constructor for Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The public `KimonoPortfolio (System.Boolean)` constructor for the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>initialize</td><td style='width:75%' ><p>The <code>initialize</code> parameter of the KimonoPortfolio method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="d7986c1d-5099-4a21-8310-e0e987f6b1c8"></a>
##Public Void KimonoShape ()

###Constructor for Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShape ()` constructor for the `KimonoShape` class.

---

<a name="d3b89118-5039-4030-b678-dcb145215a3f"></a>
##Public Void KimonoShape (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShape (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShape` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="e2cd08f4-490b-4a0d-8da0-75d2ae9043fc"></a>
##Public Void KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public `KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShape` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShape method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShape method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="52763ac7-ca21-46de-93a6-7e8f3b4246c6"></a>
##Public Void KimonoShapeArrow ()

###Constructor for Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `KimonoShapeArrow ()` constructor for the `KimonoShapeArrow` class.

---

<a name="75e2e659-d220-4969-83ce-7a0c62e06ad7"></a>
##Public Void KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="a4b5b3e1-848b-45f5-a07b-ec95697bf227"></a>
##Public Void KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeArrow](#2dd7ed00-7125-446f-a83a-4a1b7594819c)

###Summary

The public `KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeArrow method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeArrow method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="6d99a258-2c65-4694-a521-94b8359ead92"></a>
##Public Void KimonoShapeGroup (System.Object)

###Constructor for Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `KimonoShapeGroup (System.Object)` constructor for the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p>The <code>parent</code> parameter of the KimonoShapeGroup method takes a <code>System.Object</code> value. </p>
</td></tr></table></p>


---

<a name="c334c18a-1242-4f76-9f2a-73c2629a7dbb"></a>
##Public Void KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p>The <code>parent</code> parameter of the KimonoShapeGroup method takes a <code>System.Object</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p>The <code>left</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p>The <code>top</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p>The <code>right</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p>The <code>bottom</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="c12bbd6f-3e99-420e-aa91-4510b5a7805b"></a>
##Public Void KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p>The <code>parent</code> parameter of the KimonoShapeGroup method takes a <code>System.Object</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p>The <code>left</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p>The <code>top</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p>The <code>right</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p>The <code>bottom</code> parameter of the KimonoShapeGroup method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p>The <code>state</code> parameter of the KimonoShapeGroup method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="e26907ff-1c33-417a-aa45-e547bc6403d1"></a>
##Public Void KimonoShapeLine ()

###Constructor for Type

[KimonoShapeLine](#6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8)

###Summary

The public `KimonoShapeLine ()` constructor for the `KimonoShapeLine` class.

---

<a name="4653966c-a947-4c54-8423-edcc55cc3f9b"></a>
##Public Void KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeLine](#6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8)

###Summary

The public `KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeLine` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="062e89e9-dfcb-45b2-b0d3-adec2c7b69b9"></a>
##Public Void KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeLine](#6bb978ed-af7e-4ebe-83e4-4ae1825fd7b8)

###Summary

The public `KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeLine` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeLine method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeLine method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="57f63ef4-c231-4b88-81d2-906079cd4d60"></a>
##Public Void KimonoShapeOval ()

###Constructor for Type

[KimonoShapeOval](#68719e7d-0150-4764-ab5b-951410790c56)

###Summary

The public `KimonoShapeOval ()` constructor for the `KimonoShapeOval` class.

---

<a name="10da9e2b-0944-4b1c-9f7c-6ea78ac4293e"></a>
##Public Void KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeOval](#68719e7d-0150-4764-ab5b-951410790c56)

###Summary

The public `KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeOval` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="3d7b6959-7486-4467-b99d-020492c6e87c"></a>
##Public Void KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeOval](#68719e7d-0150-4764-ab5b-951410790c56)

###Summary

The public `KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeOval` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeOval method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeOval method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="7808282d-2577-400a-b1ff-ce42d2a02454"></a>
##Public Void KimonoShapePolygon ()

###Constructor for Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The public `KimonoShapePolygon ()` constructor for the `KimonoShapePolygon` class.

---

<a name="68093fa7-1a5f-407b-bd49-8dc6db1c863c"></a>
##Public Void KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The public `KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapePolygon` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="aa11bb4e-737c-4bed-bf8e-213134153f7b"></a>
##Public Void KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The public `KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapePolygon` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapePolygon method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapePolygon method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="dc455a1a-3bce-43e5-bd73-dd61b8ea22e4"></a>
##Public Void KimonoShapeRect ()

###Constructor for Type

[KimonoShapeRect](#2ca1fe46-06b3-4864-bc70-9399db18d5b6)

###Summary

The public `KimonoShapeRect ()` constructor for the `KimonoShapeRect` class.

---

<a name="c243331a-04c9-4ea3-818b-a13de793e00d"></a>
##Public Void KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeRect](#2ca1fe46-06b3-4864-bc70-9399db18d5b6)

###Summary

The public `KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="bd3081cd-d0bc-4da4-8ee5-bb181f8032d5"></a>
##Public Void KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeRect](#2ca1fe46-06b3-4864-bc70-9399db18d5b6)

###Summary

The public `KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeRect method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="c1605b28-8d33-4b8f-8b36-b771d682b32d"></a>
##Public Void KimonoShapeRoundRect ()

###Constructor for Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public `KimonoShapeRoundRect ()` constructor for the `KimonoShapeRoundRect` class.

---

<a name="56057e42-b218-4a3d-8a30-4121b3a13a33"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public `KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeRoundRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="4246fb6e-5052-4773-88a2-e7d0a41f0525"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public `KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeRoundRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeRoundRect method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="3eafea5d-7cc2-4064-a8f5-f4fd39741cfd"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public `KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeRoundRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p>The <code>cornerRadius</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="f475826c-1407-4203-9375-b98d57c52efd"></a>
##Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeRoundRect](#f030891f-b2f6-43bf-8b30-4bb33dcf09b2)

###Summary

The public `KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeRoundRect` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p>The <code>cornerRadius</code> parameter of the KimonoShapeRoundRect method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p>The <code>state</code> parameter of the KimonoShapeRoundRect method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="4ddca0fc-9994-41c9-a78f-69a14550f281"></a>
##Public Void KimonoShapeStar ()

###Constructor for Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public `KimonoShapeStar ()` constructor for the `KimonoShapeStar` class.

---

<a name="309859e5-d450-48be-95dc-2e28367f6968"></a>
##Public Void KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public `KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="f063e7f1-44ba-46c9-b4f1-c36346758a4d"></a>
##Public Void KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public `KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeStar method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeStar method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="ff04544b-3997-4051-8345-f5ce22394923"></a>
##Public Void KimonoShapeText ()

###Constructor for Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `KimonoShapeText ()` constructor for the `KimonoShapeText` class.

---

<a name="08c56fe9-135b-4fa4-8a06-22090ab1c5e4"></a>
##Public Void KimonoShapeText (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `KimonoShapeText (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeText` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="88814b44-6aeb-4501-9d38-2c9854b4677b"></a>
##Public Void KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeText](#1e3efe51-2fa7-41ca-80dd-505cdc283a79)

###Summary

The public `KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeText` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeText method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeText method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="2668d634-6af9-435a-a85f-35b8d5a35cf7"></a>
##Public Void KimonoShapeTriangle ()

###Constructor for Type

[KimonoShapeTriangle](#91eab6b8-c802-4441-a4b1-e9de268c98fc)

###Summary

The public `KimonoShapeTriangle ()` constructor for the `KimonoShapeTriangle` class.

---

<a name="2fc3f7de-9d8a-414e-85c4-cc0cdda7a154"></a>
##Public Void KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeTriangle](#91eab6b8-c802-4441-a4b1-e9de268c98fc)

###Summary

The public `KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeTriangle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="5bb82ca8-7008-4dca-9400-a002ff9312f7"></a>
##Public Void KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeTriangle](#91eab6b8-c802-4441-a4b1-e9de268c98fc)

###Summary

The public `KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeTriangle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeTriangle method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeTriangle method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="400605ae-b7ee-49b2-bfbf-9ab33c8f850a"></a>
##Public Void KimonoShapeVector ()

###Constructor for Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `KimonoShapeVector ()` constructor for the `KimonoShapeVector` class.

---

<a name="65812acf-941f-4a3b-b7d0-38efca5ae0e7"></a>
##Public Void KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)

###Constructor for Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)` constructor for the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="81e3235c-21c2-45a8-9ab1-49e5c67a44a1"></a>
##Public Void KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)

###Constructor for Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)` constructor for the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p>The <code>left</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p>The <code>top</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p>The <code>right</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p>The <code>bottom</code> parameter of the KimonoShapeVector method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p>The <code>state</code> parameter of the KimonoShapeVector method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>


---

<a name="7d21712d-6457-43c7-afc3-08b573dd0983"></a>
##Public Void KimonoSketch ()

###Constructor for Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `KimonoSketch ()` constructor for the `KimonoSketch` class.

---

<a name="6c072c7f-e305-4b65-8d47-03a5766040ed"></a>
##Public Void KimonoSketch (System.String, System.Single, System.Single)

###Constructor for Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `KimonoSketch (System.String, System.Single, System.Single)` constructor for the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p>The <code>name</code> parameter of the KimonoSketch method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>width</td><td style='width:75%' class='def'><p>The <code>width</code> parameter of the KimonoSketch method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>height</td><td style='width:75%' ><p>The <code>height</code> parameter of the KimonoSketch method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="4687cfa8-e49e-4262-b921-fe9bdfea4a0e"></a>
##Public Void KimonoStyle ()

###Constructor for Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The public `KimonoStyle ()` constructor for the `KimonoStyle` class.

---

<a name="8c2e47dd-6f2f-42fc-bf81-becbe172fffa"></a>
##Public Void KimonoUndoHandler ()

###Constructor for Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `KimonoUndoHandler ()` constructor for the `KimonoUndoHandler` class.

---

<a name="cd8cac1f-43c6-4e67-863f-67dbeb7138a1"></a>
##Private MakeDashInterval ()

###Return Type

`System.Collections.Generic.List<System.Single>`

###Member of Type

[KimonoStyle](#38ee5869-ef06-48de-b11a-0b101b8c9f56)

###Summary

The private `MakeDashInterval ()` member of the `KimonoStyle` class returns a `System.Collections.Generic.List<System.Single>` value.

---

<a name="3bd28291-d6ee-46c3-b497-750ca81e3691"></a>
##Private MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)

###Return Type

`SkiaSharp.SKPoint[]`

###Member of Type

[KimonoShapePolygon](#f0de3411-8576-4c57-8adc-c347de6f9e61)

###Summary

The private `MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)` member of the `KimonoShapePolygon` class returns a `SkiaSharp.SKPoint[]` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p>The <code>startTheta</code> parameter of the MakeSidePoints method takes a <code>System.Double</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p>The <code>numPoints</code> parameter of the MakeSidePoints method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' ><p>The <code>rect</code> parameter of the MakeSidePoints method takes a <code>SkiaSharp.SKRect</code> value. </p>
</td></tr></table></p>


---

<a name="dc23bf27-289f-4599-b43a-ed8b07476fb4"></a>
##Private MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)

###Return Type

`SkiaSharp.SKPoint[]`

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The private `MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)` member of the `KimonoShapeStar` class returns a `SkiaSharp.SKPoint[]` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p>The <code>startTheta</code> parameter of the MakeStarPoints method takes a <code>System.Double</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p>The <code>numPoints</code> parameter of the MakeStarPoints method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p>The <code>skip</code> parameter of the MakeStarPoints method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p>The <code>rect</code> parameter of the MakeStarPoints method takes a <code>SkiaSharp.SKRect</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>depth</td><td style='width:75%' ><p>The <code>depth</code> parameter of the MakeStarPoints method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="2ef7a30a-6b8a-4af4-90e5-66dd13a4b633"></a>
##Private Void MixColor ()

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The private `MixColor ()` member of the `KimonoColor` class.

---

<a name="2db51269-d075-48a4-b92f-f48b6d1d098d"></a>
##Public Virtual Void MouseDown (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public virtual `MouseDown (AppKit.NSEvent)` member of the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseDown method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="780995bd-1421-43db-8acc-d114c6e73734"></a>
##Public Virtual Void MouseDown (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public virtual `MouseDown (AppKit.NSEvent)` member of the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseDown method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="199033ab-e2a7-4fde-83e7-6495f3f53d80"></a>
##Public Virtual Void MouseDown (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public virtual `MouseDown (AppKit.NSEvent)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseDown method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="580d086e-5990-48de-af2c-a146fb9c7eaf"></a>
##Public Virtual Void MouseDragged (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public virtual `MouseDragged (AppKit.NSEvent)` member of the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseDragged method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="246223e4-bfdd-4049-9f7d-da07b80c1e0b"></a>
##Public Virtual Void MouseDragged (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public virtual `MouseDragged (AppKit.NSEvent)` member of the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseDragged method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="8e7e1c46-daf0-4825-bdb4-944d5b2e8904"></a>
##Public Virtual Void MouseDragged (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public virtual `MouseDragged (AppKit.NSEvent)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseDragged method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="4540c58f-ec37-4b8a-9106-e6a302bea1de"></a>
##Public Virtual Void MouseMoved (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public virtual `MouseMoved (AppKit.NSEvent)` member of the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseMoved method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="2f44d77b-08f2-413e-be47-8c68392ba787"></a>
##Public Virtual Void MouseMoved (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public virtual `MouseMoved (AppKit.NSEvent)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseMoved method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="2a7ce575-84cb-4038-ae06-6742a20d29d5"></a>
##Public Virtual Void MouseMoved (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public virtual `MouseMoved (AppKit.NSEvent)` member of the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseMoved method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="1f0fa740-d1be-4610-9c73-1490f434e687"></a>
##Public Virtual Void MouseUp (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public virtual `MouseUp (AppKit.NSEvent)` member of the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseUp method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="f76151c9-cc29-4d24-bff4-472d19971fac"></a>
##Public Virtual Void MouseUp (AppKit.NSEvent)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public virtual `MouseUp (AppKit.NSEvent)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseUp method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="ffd6a7d5-aefe-4825-a6c7-f940d1d1cff6"></a>
##Public Virtual Void MouseUp (AppKit.NSEvent)

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public virtual `MouseUp (AppKit.NSEvent)` member of the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p>The <code>theEvent</code> parameter of the MouseUp method takes a <code>AppKit.NSEvent</code> value. </p>
</td></tr></table></p>


---

<a name="7df68ad1-894d-41db-a570-dde520f6ee44"></a>
##Public Virtual Void MoveBounds (SkiaSharp.SKPoint)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `MoveBounds (SkiaSharp.SKPoint)` member of the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the MoveBounds method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="a605ccc9-3a7c-4ee1-bcea-752882c633be"></a>
##Public Void MoveLastPoint (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `MoveLastPoint (SkiaSharp.SKPoint)` member of the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the MoveLastPoint method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="c6f5400f-b70d-4229-9458-bc11e04bdda5"></a>
##Public Void MoveSelectedShapeBackwards ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `MoveSelectedShapeBackwards ()` member of the `KimonoShapeGroup` class.

---

<a name="032a59fe-7b83-4de6-a17a-76afd21633ef"></a>
##Public Void MoveSelectedShapeBackwards ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `MoveSelectedShapeBackwards ()` member of the `KimonoSketch` class.

---

<a name="58529416-d513-415a-bc8a-08d944f85799"></a>
##Public Void MoveSelectedShapeForwards ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `MoveSelectedShapeForwards ()` member of the `KimonoSketch` class.

---

<a name="fb2d38dc-f334-4580-b8e6-5f04a153bc78"></a>
##Public Void MoveSelectedShapeForwards ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `MoveSelectedShapeForwards ()` member of the `KimonoShapeGroup` class.

---

<a name="174ab2b5-fc99-4a01-92b2-7a9359be7177"></a>
##Public Void MoveSelectedShapeToBottom ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `MoveSelectedShapeToBottom ()` member of the `KimonoShapeGroup` class.

---

<a name="1b511c13-3ebe-40d7-af0d-b0775b8748ab"></a>
##Public Void MoveSelectedShapeToBottom ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `MoveSelectedShapeToBottom ()` member of the `KimonoSketch` class.

---

<a name="7d3e11aa-8daa-48eb-ae43-9b345793f13c"></a>
##Public Void MoveSelectedShapeToTop ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `MoveSelectedShapeToTop ()` member of the `KimonoSketch` class.

---

<a name="2c8014a3-19ff-4d86-ab82-f4023fc10050"></a>
##Public Void MoveSelectedShapeToTop ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `MoveSelectedShapeToTop ()` member of the `KimonoShapeGroup` class.

---

<a name="527435f9-da1d-41f8-93e1-238158dcd67c"></a>
##Public Void MoveTo (System.Single, System.Single)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `MoveTo (System.Single, System.Single)` member of the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p>The <code>x</code> parameter of the MoveTo method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="ff735239-3f9c-4448-9920-ac7fb1f4e8a8"></a>
##Public Void PlaceUnderConstruction (System.Boolean)

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `PlaceUnderConstruction (System.Boolean)` member of the `KimonoBounds` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>needsHandles</td><td style='width:75%' ><p>The <code>needsHandles</code> parameter of the PlaceUnderConstruction method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="5c57e4b6-44cc-4507-b65a-e9f41afd4118"></a>
##Public PointInBound (SkiaSharp.SKPoint)

###Return Type

`System.Boolean`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The public `PointInBound (SkiaSharp.SKPoint)` member of the `KimonoHandle` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the PointInBound method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="6ecbde43-70c7-4521-9bd4-ad50fdfcf1f9"></a>
##Public Virtual PointInBound (SkiaSharp.SKPoint)

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `PointInBound (SkiaSharp.SKPoint)` member of the `KimonoShapeGroup` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the PointInBound method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="896ee42e-13e8-4c96-b4de-1298227e9d0f"></a>
##Public Virtual PointInBound (SkiaSharp.SKPoint)

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public virtual `PointInBound (SkiaSharp.SKPoint)` member of the `KimonoShapeVector` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the PointInBound method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="8c54f5bb-ca25-45a3-935d-ec4cbf46ebba"></a>
##Public Virtual PointInBound (SkiaSharp.SKPoint)

###Return Type

`System.Boolean`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public virtual `PointInBound (SkiaSharp.SKPoint)` member of the `KimonoBounds` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the PointInBound method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="ffd8bc67-0465-4d07-9d4b-bf3562930a10"></a>
##Public PopRedoPoint (KimonoCore.KimonoPortfolio)

###Return Type

[KimonoCore.KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `PopRedoPoint (KimonoCore.KimonoPortfolio)` member of the `KimonoUndoHandler` class returns a `KimonoCore.KimonoPortfolio` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p>The <code>portfolio</code> parameter of the PopRedoPoint method takes a <code>KimonoCore.KimonoPortfolio</code> value. </p>
</td></tr></table></p>


---

<a name="d6a1e84a-633b-4f20-80e0-d2aed4da74a0"></a>
##Public PopUndoPoint (KimonoCore.KimonoPortfolio)

###Return Type

[KimonoCore.KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `PopUndoPoint (KimonoCore.KimonoPortfolio)` member of the `KimonoUndoHandler` class returns a `KimonoCore.KimonoPortfolio` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p>The <code>portfolio</code> parameter of the PopUndoPoint method takes a <code>KimonoCore.KimonoPortfolio</code> value. </p>
</td></tr></table></p>


---

<a name="efe189b8-4203-421c-9f40-1839c3256a67"></a>
##Public Void PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)` member of the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the PreviewToolDown method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p>The <code>clicks</code> parameter of the PreviewToolDown method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p>The <code>multiSelect</code> parameter of the PreviewToolDown method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="f80f2b58-512e-419d-b78e-a324c00da3ca"></a>
##Public Void PreviewToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `PreviewToolDrag (SkiaSharp.SKPoint)` member of the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the PreviewToolDrag method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="dcc47e13-178f-4503-a09a-6db7976d7804"></a>
##Public Void PreviewToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The public `PreviewToolUp (SkiaSharp.SKPoint)` member of the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the PreviewToolUp method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="13288ab6-d0be-4a0e-b7ef-c434790a2e68"></a>
##Public Void PushUndoPoint (KimonoCore.KimonoPortfolio)

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `PushUndoPoint (KimonoCore.KimonoPortfolio)` member of the `KimonoUndoHandler` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p>The <code>portfolio</code> parameter of the PushUndoPoint method takes a <code>KimonoCore.KimonoPortfolio</code> value. </p>
</td></tr></table></p>


---

<a name="0d085a12-a7be-4d66-8c0f-9d1824fef9b0"></a>
##Void RaiseBlurModified ()

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The  `RaiseBlurModified ()` member of the `KimonoBlur` class.

---

<a name="0292df71-9c6e-4763-8f39-7302dfadf2af"></a>
##Void RaiseColorChanged ()

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The  `RaiseColorChanged ()` member of the `KimonoColor` class.

---

<a name="f2479006-2f31-45cc-a21f-b18298f760b7"></a>
##Void RaiseColorsModified (KimonoCore.KimonoColor)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseColorsModified (KimonoCore.KimonoColor)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the RaiseColorsModified method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="2c4882a4-54d9-4510-ae0e-98c8c669193f"></a>
##Void RaiseColorsModified (KimonoCore.KimonoColor)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseColorsModified (KimonoCore.KimonoColor)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the RaiseColorsModified method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="89c063b0-9ca6-4522-9d96-03d423d5fca2"></a>
##Void RaiseGradientModified ()

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The  `RaiseGradientModified ()` member of the `KimonoGradientDesignPreview` class.

---

<a name="01f7a992-3338-4912-b079-faf9bf75fe1e"></a>
##Void RaiseGradientModified ()

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The  `RaiseGradientModified ()` member of the `KimonoGradient` class.

---

<a name="ef7f25b6-773a-4e4b-ae72-0323bb583eec"></a>
##Void RaiseGradientsModified (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseGradientsModified (KimonoCore.KimonoGradient)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the RaiseGradientsModified method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="e1970325-a2fb-45f0-aaea-ee9c39e17a17"></a>
##Void RaiseGradientsModified (KimonoCore.KimonoGradient)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseGradientsModified (KimonoCore.KimonoGradient)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the RaiseGradientsModified method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="f9274902-d018-450a-a270-051c344f0a64"></a>
##Void RaiseHandleSelected (KimonoCore.KimonoHandle)

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The  `RaiseHandleSelected (KimonoCore.KimonoHandle)` member of the `KimonoGradientDesignBar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the RaiseHandleSelected method takes a <code>KimonoCore.KimonoHandle</code> value. </p>
</td></tr></table></p>


---

<a name="472cd9a2-a496-430d-92cd-efcb38bc17ff"></a>
##Void RaiseHandleSelected (KimonoCore.KimonoHandle)

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The  `RaiseHandleSelected (KimonoCore.KimonoHandle)` member of the `KimonoGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the RaiseHandleSelected method takes a <code>KimonoCore.KimonoHandle</code> value. </p>
</td></tr></table></p>


---

<a name="d125a7b5-5248-4092-9f82-dcc025c9f225"></a>
##Void RaiseHandleSelected (KimonoCore.KimonoHandle)

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The  `RaiseHandleSelected (KimonoCore.KimonoHandle)` member of the `KimonoGradientDesignPreview` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the RaiseHandleSelected method takes a <code>KimonoCore.KimonoHandle</code> value. </p>
</td></tr></table></p>


---

<a name="c27e3f0f-9ee5-41e4-8e29-39592d67ed93"></a>
##Void RaiseImageBufferNeedsRefresh ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RaiseImageBufferNeedsRefresh ()` member of the `KimonoSketch` class.

---

<a name="c6533653-6c54-415e-b145-f9b74dd35d7e"></a>
##Void RaiseMoved (SkiaSharp.SKPoint)

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The  `RaiseMoved (SkiaSharp.SKPoint)` member of the `KimonoHandle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the RaiseMoved method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="82faffbf-e823-48ec-bdd7-692ec795ab4e"></a>
##Void RaiseReloadUI ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseReloadUI ()` member of the `KimonoDesignSurface` class.

---

<a name="9ec29807-08ac-4964-b86c-08057e743f8e"></a>
##Void RaiseRequestNewUndoPoint ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseRequestNewUndoPoint ()` member of the `KimonoPortfolio` class.

---

<a name="42a20b76-dfce-4470-8955-1c23d0a4c306"></a>
##Void RaiseRequestNewUndoPoint ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RaiseRequestNewUndoPoint ()` member of the `KimonoSketch` class.

---

<a name="f7ebe340-2e32-4108-9178-e12ed9d80a4d"></a>
##Void RaiseSelectedShapeChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseSelectedShapeChanged (KimonoCore.KimonoShape)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p>The <code>selected</code> parameter of the RaiseSelectedShapeChanged method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="9cb5de40-feee-47e6-8c61-2fa7184002f3"></a>
##Void RaiseSelectedShapeModified ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RaiseSelectedShapeModified ()` member of the `KimonoSketch` class.

---

<a name="35ce422b-79ca-4d0e-99c1-f6254075953c"></a>
##Void RaiseSelectedShapeModified ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseSelectedShapeModified ()` member of the `KimonoDesignSurface` class.

---

<a name="3452f671-1b77-4c88-8652-2a1ac454f95e"></a>
##Void RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the RaiseSelectedSketchDidChange method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="2d18de91-736b-44e4-944a-9c5ee3360855"></a>
##Void RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the RaiseSelectedSketchWillChange method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="4ae02175-fdb7-4cbc-960e-f8145f46849c"></a>
##Void RaiseSelectionChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RaiseSelectionChanged (KimonoCore.KimonoShape)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p>The <code>selected</code> parameter of the RaiseSelectionChanged method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="2fc9442c-4e40-406a-b0d7-11148e3302f8"></a>
##Void RaiseSelectionChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseSelectionChanged (KimonoCore.KimonoShape)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p>The <code>selected</code> parameter of the RaiseSelectionChanged method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="39cb7ef7-cc40-41f1-a6ce-79256cd0c103"></a>
##Void RaiseSketchesModified ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseSketchesModified ()` member of the `KimonoDesignSurface` class.

---

<a name="5847e6c9-0e55-47e0-9aa3-16fdb8aee566"></a>
##Void RaiseSketchesModified ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseSketchesModified ()` member of the `KimonoPortfolio` class.

---

<a name="3688e03d-e046-4d34-b363-2e6958904d48"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseSketchModified ()` member of the `KimonoDesignSurface` class.

---

<a name="1f6eecc5-976f-4369-b50e-d404916f3d43"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RaiseSketchModified ()` member of the `KimonoSketch` class.

---

<a name="5c15934b-d3d6-45ba-ae40-e3f14f9e46b9"></a>
##Void RaiseSketchSizeChanged ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RaiseSketchSizeChanged ()` member of the `KimonoSketch` class.

---

<a name="d8df1742-4b25-47a1-9fc1-903f45ff2def"></a>
##Void RaiseSketchSizeChanged ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseSketchSizeChanged ()` member of the `KimonoDesignSurface` class.

---

<a name="64a463e0-a219-4394-8b7c-7136b367f216"></a>
##Void RaiseStylesModified (KimonoCore.KimonoStyle)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseStylesModified (KimonoCore.KimonoStyle)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RaiseStylesModified method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="97780e9e-14b6-43c8-86c4-7a50442d4e96"></a>
##Void RaiseStylesModified (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RaiseStylesModified (KimonoCore.KimonoStyle)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RaiseStylesModified method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="c1050a25-c319-4227-a3d3-e8385e64d43f"></a>
##Void RaiseToolChanged (KimonoCore.KimonoTool)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RaiseToolChanged (KimonoCore.KimonoTool)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p>The <code>tool</code> parameter of the RaiseToolChanged method takes a <code>KimonoCore.KimonoTool</code> value. </p>
</td></tr></table></p>


---

<a name="23bc85ea-5fa0-49fe-a8b6-e6ee07a39788"></a>
##Void RaiseToolChanged (KimonoCore.KimonoTool)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseToolChanged (KimonoCore.KimonoTool)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p>The <code>tool</code> parameter of the RaiseToolChanged method takes a <code>KimonoCore.KimonoTool</code> value. </p>
</td></tr></table></p>


---

<a name="ab957055-bcd7-4d7e-86dc-cd82c8234292"></a>
##Void RaiseUndoStateChanged ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The  `RaiseUndoStateChanged ()` member of the `KimonoDesignSurface` class.

---

<a name="66ff73ee-5591-49be-8a35-e7e7c0b096b6"></a>
##Void RaiseUndoStateChanged ()

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The  `RaiseUndoStateChanged ()` member of the `KimonoUndoHandler` class.

---

<a name="e4cad308-d388-445d-99b2-c89720987e0a"></a>
##Public Void RecalculateGroupBounds ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `RecalculateGroupBounds ()` member of the `KimonoShapeGroup` class.

---

<a name="887aed35-070e-42c8-858b-4b80a7604446"></a>
##Public Void RecalculateLayerDepths ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `RecalculateLayerDepths ()` member of the `KimonoSketch` class.

---

<a name="7d9844f7-499d-4dca-9c33-5d1df16be38c"></a>
##Public Void RecalculateLayerDepths ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `RecalculateLayerDepths ()` member of the `KimonoShapeGroup` class.

---

<a name="b9ac85ab-d1e0-47ca-93b0-a3b4daceb41e"></a>
##Public Void RecalculateVectorBounds ()

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `RecalculateVectorBounds ()` member of the `KimonoShapeVector` class.

---

<a name="b864e33f-2815-469c-bbc6-eb452f939c74"></a>
##Public Void Redo (Foundation.NSObject)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `Redo (Foundation.NSObject)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Redo method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f66db2d5-cb03-4bab-9a1f-4218c0f81e9c"></a>
##Public Void RedoChange ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `RedoChange ()` member of the `KimonoDesignSurface` class.

---

<a name="ea168e56-709d-40ce-9391-50d744f403c7"></a>
##Public Void RefreshView ()

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The public `RefreshView ()` member of the `KimonoGradientDesignBar` class.

---

<a name="c818db69-fd40-43be-80eb-82ac83f50468"></a>
##Public Void RefreshView ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `RefreshView ()` member of the `KimonoDesignSurface` class.

---

<a name="411009d9-ef4f-4096-bdb0-0e2564a73289"></a>
##Public Void RefreshView ()

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The public `RefreshView ()` member of the `KimonoGradientDesignPreview` class.

---

<a name="df974b49-982f-4fc9-853e-decfdecc8042"></a>
##Void RelinkColors ()

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RelinkColors ()` member of the `KimonoPortfolio` class.

---

<a name="d62be691-18d2-4f95-8e9d-cb280de5bcc1"></a>
##Void RelinkGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RelinkGradient (KimonoCore.KimonoGradient)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the RelinkGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="92103ed7-3f05-48d0-b022-3d1cae01e203"></a>
##Void RelinkShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The  `RelinkShape (KimonoCore.KimonoShape)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RelinkShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="95fd683b-a66e-4c25-8d00-bb51511ec42f"></a>
##Void RelinkShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RelinkShape (KimonoCore.KimonoShape)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RelinkShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="3054ff45-b7c7-49ee-b247-0ad6cc997940"></a>
##Void RelinkShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The  `RelinkShape (KimonoCore.KimonoShape)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RelinkShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="064ea090-0461-4547-a1bb-1535d16043bf"></a>
##Void RelinkSketch (KimonoCore.KimonoSketch)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RelinkSketch (KimonoCore.KimonoSketch)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the RelinkSketch method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="a9cd293e-bdce-477d-9fcd-a988bcd97515"></a>
##Void RelinkStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The  `RelinkStyle (KimonoCore.KimonoStyle)` member of the `KimonoPortfolio` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RelinkStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="5c5f7dc5-6d6c-45b1-b947-03e47e43a0eb"></a>
##Void RemoveHandles ()

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The  `RemoveHandles ()` member of the `KimonoBounds` class.

---

<a name="f499a732-fdd8-4d65-a1fb-d221bb1a1683"></a>
##Public Void RemovePoint (System.Int32)

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public `RemovePoint (System.Int32)` member of the `KimonoShapeVector` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p>The <code>n</code> parameter of the RemovePoint method takes a <code>System.Int32</code> value. </p>
</td></tr></table></p>


---

<a name="884d6584-ed47-4e65-b301-63db26c4e221"></a>
##Public Void RemoveShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `RemoveShape (KimonoCore.KimonoShape)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RemoveShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="8a1565a5-d68f-4ec4-89b4-885ed651a89d"></a>
##Public Void ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The public `ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)` member of the `KimonoUndoHandler` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p>The <code>portfolio</code> parameter of the ReplaceLastUndoPoint method takes a <code>KimonoCore.KimonoPortfolio</code> value. </p>
</td></tr></table></p>


---

<a name="515c9370-98d7-4198-ac7c-3c5749f039b4"></a>
##Public Void ReplaceUndoPoint ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `ReplaceUndoPoint ()` member of the `KimonoDesignSurface` class.

---

<a name="0b2fee38-347c-45f5-94b5-072de9d21181"></a>
##Public Void ReturnToSketch ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `ReturnToSketch ()` member of the `KimonoShapeGroup` class.

---

<a name="75d01804-d85e-44b3-ae97-8d1ebe2dbb45"></a>
##Void SavePreviousBounds ()

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The  `SavePreviousBounds ()` member of the `KimonoBounds` class.

---

<a name="95bcdfd8-b3f3-4c6d-9454-0fde9742615a"></a>
##Private Void SavePreviousSize ()

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The private `SavePreviousSize ()` member of the `KimonoSketch` class.

---

<a name="5d613328-317a-408d-ad07-7e147fb77b7b"></a>
##Public Void SaveUndoPoint ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `SaveUndoPoint ()` member of the `KimonoDesignSurface` class.

---

<a name="bc1d94a6-5db1-467c-8010-fc0f1a1de879"></a>
##Public Void Select ()

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Select ()` member of the `KimonoBounds` class.

---

<a name="71dbabd6-e4c7-4acf-9b23-357a2377e7d0"></a>
##Public Void SelectShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `SelectShape (KimonoCore.KimonoShape)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the SelectShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="23198712-f52d-4fb3-a744-2affbc886a26"></a>
##Public Void SelectShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `SelectShape (KimonoCore.KimonoShape)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the SelectShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="f510773a-0afc-4714-ada8-508cd6e19760"></a>
##Public ShapeInGroup (KimonoCore.KimonoShape)

###Return Type

`System.Boolean`

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `ShapeInGroup (KimonoCore.KimonoShape)` member of the `KimonoShapeGroup` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the ShapeInGroup method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="56ef69b5-1214-48fe-bcea-e46ce5e66b9b"></a>
##Private SortedColors ()

###Return Type

`SkiaSharp.SKColor[]`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `SortedColors ()` member of the `KimonoGradient` class returns a `SkiaSharp.SKColor[]` value.

---

<a name="2b0a7d78-a02f-4923-b7f5-861687b001dd"></a>
##Private SortedWeights ()

###Return Type

`System.Single[]`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The private `SortedWeights ()` member of the `KimonoGradient` class returns a `System.Single[]` value.

---

<a name="7220a9d5-83a3-497e-bd74-335030f65f9e"></a>
##Public Virtual Void StartEditing ()

###Member of Type

[KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Summary

The public virtual `StartEditing ()` member of the `KimonoShapeVector` class.

---

<a name="325d3b01-fc67-48fc-b12d-84be6e9d1431"></a>
##Public Virtual Void StartEditing ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public virtual `StartEditing ()` member of the `KimonoShapeGroup` class.

---

<a name="bbc68275-738c-4314-898f-faaa4368955e"></a>
##Public Virtual Void StartEditing ()

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `StartEditing ()` member of the `KimonoShape` class.

---

<a name="061af8bc-1690-4c47-b988-a2040e72cba9"></a>
##Public Void StartGrouping ()

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `StartGrouping ()` member of the `KimonoBounds` class.

---

<a name="30526f4e-2567-473a-b479-a7e79f66f6ac"></a>
##Public Void ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the ToolDown method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p>The <code>clicks</code> parameter of the ToolDown method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p>The <code>multiSelect</code> parameter of the ToolDown method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="955e96b4-1248-4357-81cf-082ee011dbe9"></a>
##Public Void ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the ToolDown method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p>The <code>clicks</code> parameter of the ToolDown method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p>The <code>multiSelect</code> parameter of the ToolDown method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="b6e6722c-c43b-4ba6-9add-f0b8458881b1"></a>
##Public Void ToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `ToolDrag (SkiaSharp.SKPoint)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the ToolDrag method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="0ae7070d-6fda-4c57-a683-40a679d7e48b"></a>
##Public Void ToolDrag (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `ToolDrag (SkiaSharp.SKPoint)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the ToolDrag method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="814c5130-d480-4f06-903a-15a4a17bc364"></a>
##Public Void ToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The public `ToolUp (SkiaSharp.SKPoint)` member of the `KimonoSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the ToolUp method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="f9181f0c-5815-4be1-bc43-7aaba9ef9ae3"></a>
##Public Void ToolUp (SkiaSharp.SKPoint)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `ToolUp (SkiaSharp.SKPoint)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p>The <code>point</code> parameter of the ToolUp method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>


---

<a name="6e11bf97-c48f-4e26-bd60-0a6503335e8c"></a>
##Public Virtual ToVector ()

###Return Type

[KimonoCore.KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `ToVector ()` member of the `KimonoShape` class returns a `KimonoCore.KimonoShapeVector` value.

---

<a name="c12d0697-8d37-462e-ad4b-1c2a72502116"></a>
##Public Virtual ToVector ()

###Return Type

[KimonoCore.KimonoShapeVector](#18c66d58-56cf-40e1-8c23-663e3459f52b)

###Member of Type

[KimonoShapeStar](#64605364-e990-4030-80f9-303d6eea30c5)

###Summary

The public virtual `ToVector ()` member of the `KimonoShapeStar` class returns a `KimonoCore.KimonoShapeVector` value.

---

<a name="ae3e9cb4-1c60-4ee5-a9fe-847295e2218f"></a>
##Public Virtual Void UncoupleDeletedStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoShape](#874c9f2d-0904-4dcc-b1e0-96b8a0b65ac5)

###Summary

The public virtual `UncoupleDeletedStyle (KimonoCore.KimonoStyle)` member of the `KimonoShape` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deletedStyle</td><td style='width:75%' ><p>The <code>deletedStyle</code> parameter of the UncoupleDeletedStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="b205225c-4e2e-4220-90ab-97c4e206dbd9"></a>
##Public Void Undo (Foundation.NSObject)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `Undo (Foundation.NSObject)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Undo method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="5e45d3bd-0458-4241-9a65-25abda538d73"></a>
##Public Void UndoChange ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The public `UndoChange ()` member of the `KimonoDesignSurface` class.

---

<a name="de69f412-bf03-42e0-ba09-4577ab156040"></a>
##Public Void UngroupShapes ()

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `UngroupShapes ()` member of the `KimonoShapeGroup` class.

---

<a name="1869b5fd-fbe3-421d-9d26-c7833e508274"></a>
##Public Void UngroupShapes (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `UngroupShapes (KimonoCore.KimonoShapeGroup)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p>The <code>group</code> parameter of the UngroupShapes method takes a <code>KimonoCore.KimonoShapeGroup</code> value. </p>
</td></tr></table></p>


---

<a name="f2b57d2f-7723-45c4-86cd-67a6fbbb9b37"></a>
##Public Void UngroupShapes (KimonoCore.KimonoSketch)

###Member of Type

[KimonoShapeGroup](#d0e87798-7ac4-4bc0-b144-091e7a48bd33)

###Summary

The public `UngroupShapes (KimonoCore.KimonoSketch)` member of the `KimonoShapeGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the UngroupShapes method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="78f746a0-6359-43b9-bfa6-ef0fb45299af"></a>
##Public Void Unselect ()

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The public `Unselect ()` member of the `KimonoBounds` class.

---

<a name="6f3d6d54-3817-47d3-a1a5-61b8307b94b0"></a>
##Private Void UnwirePortfolioEvents ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `UnwirePortfolioEvents ()` member of the `KimonoDesignSurface` class.

---

<a name="48171e1e-24be-4893-8f0a-f610bc622781"></a>
##Private Void UnwireSketchEvents (KimonoCore.KimonoSketch)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `UnwireSketchEvents (KimonoCore.KimonoSketch)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the UnwireSketchEvents method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="463a8a92-95b5-45a6-9338-5ed07747276f"></a>
##ValueBetween (System.Single, System.Single, System.Single)

###Return Type

`System.Boolean`

###Member of Type

[KimonoBounds](#68f44f8c-f23b-468d-97ed-54e91abacbc6)

###Summary

The  `ValueBetween (System.Single, System.Single, System.Single)` member of the `KimonoBounds` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p>The <code>x</code> parameter of the ValueBetween method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>a</td><td style='width:75%' class='def'><p>The <code>a</code> parameter of the ValueBetween method takes a <code>System.Single</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>b</td><td style='width:75%' ><p>The <code>b</code> parameter of the ValueBetween method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>


---

<a name="a1481dfc-1aad-4fba-8860-4f9964d8f9f7"></a>
##Private Void WireupPortfolioEvents ()

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `WireupPortfolioEvents ()` member of the `KimonoDesignSurface` class.

---

<a name="6393e1b6-4c63-47ea-8307-9501897c48ab"></a>
##Private Void WireUpSketchEvents (KimonoCore.KimonoSketch)

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The private `WireUpSketchEvents (KimonoCore.KimonoSketch)` member of the `KimonoDesignSurface` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the WireUpSketchEvents method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>

<a name="Events"></a>
#Events


---

<a name="c56995fc-15d5-495e-9b4a-b9023042c1b5"></a>
##BlurModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoBlur](#ccd38be3-b55d-4a79-a6f7-d8aacd36968a)

###Summary

The `BlurModified` event of the `KimonoBlur` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="3b7c9534-f0ab-4f2c-a6e6-cba3410c2eb5"></a>
##ColorChanged

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoColor](#98619b0e-09fb-4b9b-9b74-891b3e79542f)

###Summary

The `ColorChanged` event of the `KimonoColor` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="bae454ce-6279-40d1-bc35-d9d1f1bbe2d4"></a>
##ColorsModified

###Return Type

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `ColorsModified` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="67945210-946a-4565-885f-f6def512d799"></a>
##ColorsModified

###Return Type

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `ColorsModified` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="d0b3c108-01ea-4e84-9232-bb7ad6a62f59"></a>
##GradientModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The `GradientModified` event of the `KimonoGradientDesignPreview` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="42e10075-fdd4-4724-aa0e-6e7ac6cf5612"></a>
##GradientModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The `GradientModified` event of the `KimonoGradient` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="1468c79c-2b7d-42a9-9c13-e3baf9c2b8df"></a>
##GradientsModified

###Return Type

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `GradientsModified` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="89f05dcd-d447-4beb-8232-ab5fd7aabe19"></a>
##GradientsModified

###Return Type

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `GradientsModified` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="611a6489-bf42-4af2-8c03-442351120efc"></a>
##HandleSelected

###Return Type

`KimonoCore.Kimono.HandleEventDelegate`

###Member of Type

[KimonoGradient](#a45a2698-077c-49c7-b694-b83ad29ea05f)

###Summary

The `HandleSelected` event of the `KimonoGradient` class returns a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="9832e90a-1bb3-407c-9518-cc5cd2815f1c"></a>
##HandleSelected

###Return Type

`KimonoCore.Kimono.HandleEventDelegate`

###Member of Type

[KimonoGradientDesignPreview](#e632d6b2-a18d-4d7d-8538-9d6bdea9a878)

###Summary

The `HandleSelected` event of the `KimonoGradientDesignPreview` class returns a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="7a5c1d8f-feb1-498d-802b-65fbeabb0c67"></a>
##HandleSelected

###Return Type

`KimonoCore.Kimono.HandleEventDelegate`

###Member of Type

[KimonoGradientDesignBar](#a2dc3fda-4f70-47a2-9ed4-fc5ac8129753)

###Summary

The `HandleSelected` event of the `KimonoGradientDesignBar` class returns a `KimonoCore.Kimono.HandleEventDelegate` value.

---

<a name="20f4b611-4e02-4a12-989d-1d8dfcec5737"></a>
##ImageBufferNeedsRefresh

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The `ImageBufferNeedsRefresh` event of the `KimonoSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="95592c4b-5ffd-4a18-8f8b-14394aeb7902"></a>
##Moved

###Return Type

`KimonoCore.Kimono.SkiaPointEventDelegate`

###Member of Type

[KimonoHandle](#b606af25-7c99-452e-a1c8-52c98d06a1ac)

###Summary

The `Moved` event of the `KimonoHandle` class returns a `KimonoCore.Kimono.SkiaPointEventDelegate` value.

---

<a name="bbdbbacd-2b57-4b4d-82e3-49b62df601bf"></a>
##ReloadUI

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `ReloadUI` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="b5c52844-317f-4502-8867-03c717723ca3"></a>
##RequestNewUndoPoint

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `RequestNewUndoPoint` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="b8f41f2b-5bb9-4bab-8647-a3577704442b"></a>
##RequestNewUndoPoint

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The `RequestNewUndoPoint` event of the `KimonoSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="79dd2777-5cd6-44e0-a2fb-e61134189429"></a>
##SelectedShapeChanged

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `SelectedShapeChanged` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="3463e17c-a843-4cfb-9f2e-e60da856255b"></a>
##SelectedShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `SelectedShapeModified` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="4c972696-5833-4c74-8e2d-be10773ca4e1"></a>
##SelectedShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The `SelectedShapeModified` event of the `KimonoSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="9bceb599-6d62-492f-9948-f70132b2738e"></a>
##SelectedSketchDidChange

###Return Type

`KimonoCore.Kimono.SketchEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `SelectedSketchDidChange` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="a2e32fff-8356-4212-9bf2-a89dea91d579"></a>
##SelectedSketchWillChange

###Return Type

`KimonoCore.Kimono.SketchEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `SelectedSketchWillChange` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="359d1882-c4f8-48d9-a86e-078b16fbd0b2"></a>
##SelectionChanged

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The `SelectionChanged` event of the `KimonoSketch` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="a0e083f2-06b8-4258-b180-93590fff649a"></a>
##SelectionChanged

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `SelectionChanged` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="6a80ee3d-3ac2-4777-9996-6b351afdd6fb"></a>
##SketchesModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `SketchesModified` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="0cfb2e7d-b21d-416b-975d-18b90535948f"></a>
##SketchesModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `SketchesModified` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="735bd482-aade-4963-9db7-b9eebba8a83b"></a>
##SketchModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `SketchModified` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="a0ce8321-1265-4d4f-8891-a3dc9381d697"></a>
##SketchModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The `SketchModified` event of the `KimonoSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="232e72f9-1f5d-4039-9c2f-b13afa3e6a12"></a>
##SketchSizeChanged

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `SketchSizeChanged` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="f4113db4-4f36-4dc0-bc49-7f83e6c88c6e"></a>
##SketchSizeChanged

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The `SketchSizeChanged` event of the `KimonoSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="8c878d64-164b-4982-b3c4-8721dbe5a629"></a>
##StylesModified

###Return Type

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoPortfolio](#667d7181-027e-4675-907d-34febce25be5)

###Summary

The `StylesModified` event of the `KimonoPortfolio` class returns a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="39a23caa-8f67-4844-b3d5-532a2ffbe058"></a>
##StylesModified

###Return Type

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `StylesModified` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="64a35305-c28b-4815-98eb-eba6704da47d"></a>
##ToolChanged

###Return Type

`KimonoCore.Kimono.ToolEventDelegate`

###Member of Type

[KimonoSketch](#580760e3-f281-48e0-b51d-b44cb97551f5)

###Summary

The `ToolChanged` event of the `KimonoSketch` class returns a `KimonoCore.Kimono.ToolEventDelegate` value.

---

<a name="327755c5-3733-4bb7-a3db-d523a9b1290b"></a>
##ToolChanged

###Return Type

`KimonoCore.Kimono.ToolEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `ToolChanged` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.ToolEventDelegate` value.

---

<a name="7afdab45-760f-47f1-87f3-5fcf23e24820"></a>
##UndoStateChanged

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoUndoHandler](#1fc62732-b04e-4e18-b8d6-222f8063115e)

###Summary

The `UndoStateChanged` event of the `KimonoUndoHandler` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="17385b8b-07af-4cc2-8500-9da2d316887c"></a>
##UndoStateChanged

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoDesignSurface](#1217c28d-4d87-4a20-ad9d-33dd6a58139e)

###Summary

The `UndoStateChanged` event of the `KimonoDesignSurface` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.
