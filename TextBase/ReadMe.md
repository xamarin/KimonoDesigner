TextBase
============

TextBase is a simple ORM that can read and write .NET object to a string format that can be saved to files, included in applications or can be easily stored and transmitted over a cloud backend (such as Azure).

The design of the TextBase ORM is based off of [Sqlite.Net](https://github.com/praeclarum/sqlite-net) by Krueger Systems, Inc.

## Using TextBase

TextBase works by decorating the public properties of a .NET class with a custom set of attributes. From there, methods of the `TextBaseDatabase` class can be used to write and read those objects from a simple TextBase formatted string. For example:

```
using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	[Table("BezierPoint")]
	public class KimonoBezierPoint
	{
		#region Computed Properties
		[Child]
		public SKPoint ControlPoint { get; set; } = new SKPoint();

		[Child]
		public SKPoint EndPoint { get; set; } = new SKPoint();
		#endregion

		...
		
		#region Save and Load
		public string Save() {
			var database = new TextBaseDatabase();

			return database.Save(this);
		}
		
		public void Load(string data) {
			var database = new TextBaseDatabase();

			// Register this class
			database.Register<KimonoBezierPoint>();

			// Restore object from data
			database.Load(data, this);
		}
		#endregion
}
```

To ensure that a given object gets property loaded by TextBase, call the `Register` method against that object _before_ calling the Load method. For example:

```
Register<KimonoBezierPoint>();
```

## Available Attributes

The following attributes can be used control how an object get written to and read from a string:

* `[AsString]` - Forces the value to be written and read as a string.
* `[Child]` - Marks the property as a sub-object that will be written and read from the string.
* `[Children]` - Marks a collection of sub-objects that will be written and read from the string.
* `[Column(name)]` - Assigns a different name to the property that is written to the string.
* `[Ignore]` - Marks a property that will not be written and read from the string.
* `[Primarykey]` - Marks the property that will be used as the primary key for the object.
* `[Serializer(name)]` - Allows the developer to create a custom serializer/deserializer for a property. See below for more details.
* `[Table(name)]` - Assigns a different name to the class that is written to the string.

## Custom Serializers

By using the `[Serializer(name)]` attribute and the `RequestCustomSerialization` and `RequestCustomDeserialization` events, custom data types can be written and read by TextBase. For example:

```
var database = new TextBaseDatabase();

// Add custom serialization
database.RequestCustomSerialization += (serializer, obj) =>
{
	var result = "";

	// Take action based on the serializer type
	switch (serializer)
	{
		case "SKColor":
			// Encode object...
			break;
	}

	// Return results
	return result;
};

// Add custom deserialization
database.RequestCustomDeserialization += (serializer, value) =>
{
	object result = null;

	// Take action based on the serializer type
	switch (serializer)
	{
		case "SKColor":
			// Decode object...
			break;
	}

	// Return results
	return result;
};
```

With this code in place, use `[Serializer(SKColor)]` to have TextBase handle the custom type:

```
using System;
using System.Collections.Generic;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	[Table("Style")]
	public class KimonoStyle : IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		...
		
		[Serializer("SKColor")]
		public SKColor FrameBaseColor
		{
			get { return Frame.Color; }
			set { Frame.Color = value; }
		}
		
		...
	}
}
```

# License

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
