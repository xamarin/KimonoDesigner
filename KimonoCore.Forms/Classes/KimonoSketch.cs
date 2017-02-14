using System;
using System.Collections.Generic;
using SkiaSharp;

#if __Android__
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
#endif

#if __IOS__
using Foundation;
using UIKit;
#endif

#if __TVOS__
using Foundation;
using UIKit;
#endif

#if __MACOS__
using Foundation;
using AppKit;
#endif

#if (WINDOWS || WINDOWS_WPF)
using System.Drawing;
#endif

#if WINDOWS_UWP
using Windows.UI.Xaml.Media.Imaging;
using System.IO;
using Windows.Storage.Streams;
#endif

namespace KimonoCore
{
	/// <summary>
	/// Provides platform specific extensions to the base `KimonoSketch` object.
	/// </summary>
	public partial class KimonoSketch
	{
		#region Extension Methods

		#if __Android__
		public Bitmap ToImage(){
			// Get image data from sketch
			var skPngdata = Untitled1ToData();
		
			// Convert to image and return
			var imageBytes = skPngdata.ToArray();
			return BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
		}
		#endif

		#if (__IOS__ || __TVOS__)
		public UIImage ToImage(){
			// Get image data from sketch
			var skPngdata = Untitled1ToData();
		
			// Convert to image and return
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			return new UIImage(data);
		}
		#endif

		#if __MACOS__
		public NSImage ToImage(){
			// Get image data from sketch
			var skPngdata = Untitled1ToData();
		
			// Convert to image and return
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			return new NSImage(data);
		}
		#endif

		#if (WINDOWS || WINDOWS_WPF)
		public Bitmap ToImage(){
			// Get image data from sketch
			var skPngdata = Untitled1ToData();
		
			// Convert to image and return
			var imageBytes = skPngdata.ToArray();
			ImageConverter ic = new ImageConverter();
			Image img = (Image)ic.ConvertFrom(imageBytes);
			Bitmap bitmap = new Bitmap(img);
			return bitmap;
		}
		#endif

		#if WINDOWS_UWP
		public BitmapImage ToImage(){
			// Get image data from sketch
			var skPngdata = Untitled1ToData();
		
			// Convert to image and return
			var imageBytes = skPngdata.ToArray();
			var image = new BitmapImage();
			InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream();
			ms.AsStreamForWrite().Write(imageBytes, 0, imageBytes.Length);
			ms.Seek(0);
			image.SetSource(ms);
			return image;
		}
		#endif
		#endregion
	}
}
