using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using System.IO;
using Windows.Storage.Streams;
using System.Drawing;

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
        public Bitmap ToImage()
        {
            // Convert the image and return
            var skPngdata = Draw();
            var imageBytes = skPngdata.ToArray();
            ImageConverter ic = new ImageConverter();
            Image img = (Image)ic.ConvertFrom(imageBytes);
            Bitmap bitmap = new Bitmap(img);
            return bitmap;
        }
        #endregion
    }
}
