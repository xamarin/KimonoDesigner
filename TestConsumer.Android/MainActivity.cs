using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using SkiaSharp;

namespace TestConsumer.Android
{
	[Activity(Label = "TestConsumer.Android", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);
			ImageView imageView = FindViewById<ImageView>(Resource.Id.myImage);

			button.Click += delegate { button.Text = $"{count++} clicks!"; };

			var sketch = new Sketch();
			imageView.SetImageBitmap(sketch.SketchToImage());

			//var skPngdata = new SKData();
			//var imageBytes = skPngdata.ToArray();
			//Bitmap image = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
		}
	}
}

