using System;
using System.Collections.Generic;
using SkiaSharp;
using Foundation;
using AppKit;

namespace KimonoCore
{
	/// <summary>
	/// Provides macOS platform specific extensions to the base `KimonoSketch` object.
	/// </summary>
	public partial class KimonoSketch
	{
		#region Extension Methods
		/// <summary>
		/// Converts the sketch to a bitmap image.
		/// </summary>
		/// <returns>The `NSImage` representation of the sketch.</returns>
		public NSImage ToImage()
		{
			// Convert the image and return
			var skPngdata = Draw();
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			return new NSImage(data);
		}
		#endregion
	}
}
