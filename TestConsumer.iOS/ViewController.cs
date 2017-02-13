using System;
using UIKit;
using SkiaSharp;
using Foundation;

namespace TestConsumer.iOS
{
	public partial class ViewController : UIViewController
	{
		#region Constructors
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		#endregion

		#region Override Methods
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			// Display image from Kimono Designer Sketch
			var sketch = new Sketch();
			ImageView.Image = sketch.SketchToImage();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
		#endregion
	}
}
