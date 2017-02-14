using System;
using System.Collections.Generic;
using SkiaSharp;
using Foundation;
using UIKit;

namespace KimonoCore
{
	/// <summary>
	/// Provides tvOS platform specific extensions to the base `KimonoSketch` object.
	/// </summary>
	public partial class KimonoSketch
	{
		#region Extension Methods
		/// <summary>
		/// Converts the sketch to a bitmap image.
		/// </summary>
		/// <returns>The `UIImage` representation of the sketch.</returns>
		public UIImage ToImage()
		{
			// Convert the image and return
			var skPngdata = Draw();
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			return new UIImage(data);
		}
		#endregion
	}
}
