using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using Windows.UI.Xaml.Media.Imaging;
using System.IO;
using Windows.Storage.Streams;

namespace KimonoCore
{
    /// <summary>
	/// Provides Windows UWP platform specific extensions to the base `KimonoSketch` object.
	/// </summary>
    public partial class KimonoSketch
    {
        #region Extension Methods
        /// <summary>
        /// Converts the sketch to a bitmap image.
        /// </summary>
        /// <returns>The `UIImage` representation of the sketch.</returns>
        public BitmapImage ToImage()
        {
            // Convert the image and return
            var skPngdata = Draw();
            var imageBytes = skPngdata.ToArray();
            var image = new BitmapImage();
            InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream();
            ms.AsStreamForWrite().Write(imageBytes, 0, imageBytes.Length);
            ms.Seek(0);
            image.SetSource(ms);
            return image;
        }
        #endregion
    }
}
