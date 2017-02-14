using System;
using System.Collections.Generic;
using SkiaSharp;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace KimonoCore
{
	/// <summary>
	/// Provides Android platform specific extensions to the base `KimonoSketch` object.
	/// </summary>
	public partial class KimonoSketch
	{
		#region Extension Methods
		/// <summary>
		/// Converts the sketch to a bitmap image.
		/// </summary>
		/// <returns>The `UIImage` representation of the sketch.</returns>
		public Bitmap ToImage()
		{
			// Convert the image and return
			var skPngdata = Draw();
			var imageBytes = skPngdata.ToArray();
			return BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
		}
		#endregion
	}
}
