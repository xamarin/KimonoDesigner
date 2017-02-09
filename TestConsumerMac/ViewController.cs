using System;
using AppKit;
using Foundation;
using KimonoCore;
using SkiaSharp;

namespace TestConsumerMac
{
	public partial class ViewController : NSViewController
	{
		#region Constructors
		public ViewController(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Override Methods
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
		}
		#endregion

		#region Public Methods
		public void DisplayDrawing()
		{
			// Get image data from sketch
			var skPngdata = Draw(640, 480);

			// Convert to image and display
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			ImageView.Image = new NSImage(data);
		}

		public SKData Draw(int width, int height)
		{
			// Draw all of the elements into the image buffer
			using (var surface = SKSurface.Create(width, height, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
			{
				// Create Canvas
				SKCanvas canvas = surface.Canvas;
				canvas.Clear(KimonoColor.White);

				// Draw all shapes into the canvas
				TestGeneratedShape(canvas);

				// Return data from sketch
				return surface.Snapshot().Encode();
			}
		}

		public void TestGeneratedShape(SKCanvas canvas)
		{
			// Build new Rectangle Style
			var RectangleStyle = new KimonoStyle()
			{
				StyleType = KimonoStyleType.Custom,
				HasFill = true,
				HasFrame = true
			};

			// Configure new Rectangle Style
			RectangleStyle.Fill.BlendMode = SKBlendMode.SrcOver;
			RectangleStyle.Fill.IsAntialias = true;
			RectangleStyle.Fill.Color = new SKColor(255, 0, 0, 255);
			RectangleStyle.Frame.BlendMode = SKBlendMode.SrcOver;
			RectangleStyle.Frame.IsAntialias = true;
			RectangleStyle.Frame.StrokeWidth = 1f;
			RectangleStyle.Frame.StrokeMiter = 4f;
			RectangleStyle.Frame.StrokeJoin = SKStrokeJoin.Mitter;
			RectangleStyle.Frame.StrokeCap = SKStrokeCap.Butt;
			RectangleStyle.Frame.Color = new SKColor(0, 0, 0, 255);

			// Draw Rectangle shape
			var Rectangle = new KimonoShapeRect(161.7266f, 122.8398f, 392.0703f, 282.7344f)
			{
				RotationDegrees = 0,
				Style = RectangleStyle
			};
			Rectangle.Draw(canvas);

		}

		public void TestGeneratedGradient(SKCanvas canvas)
		{
			// Create new Orange
			var Orange = new KimonoColor(255, 128, 0, 255);

			// Create new Purple
			var Purple = new KimonoColor(128, 0, 255, 255);

			// The Gradient's Color List
			SKColor[] GradientColors = { new SKColor(255, 255, 255, 255), Orange.Color, Purple.Color, new SKColor(0, 0, 0, 255) };

			// The Gradient's Weight List
			float[] GradientWeights = { 0f, 0.3047369f, 0.7118111f, 0.9662447f };

			// Create new Gradient
			var Gradient = new KimonoGradient(KimonoGradientType.LinearGradient, new KimonoHandle(0, 0), new KimonoHandle(168, 168), 88f, SKShaderTileMode.Clamp, GradientColors, GradientWeights);
			// Mix paint
			var paint = new SKPaint()
			{
				Shader = Gradient.Shader
			};

			// Draw rect
			var rect = new SKRect(0, 0, 640, 480);
			canvas.DrawRect(rect, paint);
		}

		public void TestGeneratedStyle(SKCanvas canvas)
		{
			// Build new New Style
			var NewStyle = new KimonoStyle()
			{
				StyleType = KimonoStyleType.Standard,
				HasFill = true,
				HasFillJitter = true,
				FillJitterLength = 10f,
				FillJitterDeviation = 2f,
				HasFrame = true,
				HasFrameJitter = true,
				FrameJitterLength = 10f,
				FrameJitterDeviation = 2f
			};

			// Configure new New Style
			NewStyle.Fill.BlendMode = SKBlendMode.SrcOver;
			NewStyle.Fill.IsAntialias = true;
			NewStyle.Fill.Color = new SKColor(230, 230, 230, 255);
			NewStyle.HasFillBlur = true;
			NewStyle.FillBlur.HorizontalBlurAmount = 0f;
			NewStyle.FillBlur.VerticalBlurAmount = 0f;
			NewStyle.HasFillShadow = true;
			NewStyle.FillShadow.HorizontalOffset = 0f;
			NewStyle.FillShadow.VerticalOffset = 0f;
			NewStyle.FillShadow.HorizontalBlurAmount = 0f;
			NewStyle.FillShadow.VerticalBlurAmount = 0f;
			NewStyle.FillShadow.Color = new SKColor(128, 128, 128, 255);
			NewStyle.Frame.BlendMode = SKBlendMode.SrcOver;
			NewStyle.Frame.IsAntialias = true;
			NewStyle.Frame.StrokeWidth = 1f;
			NewStyle.Frame.StrokeMiter = 4f;
			NewStyle.Frame.StrokeJoin = SKStrokeJoin.Mitter;
			NewStyle.Frame.StrokeCap = SKStrokeCap.Butt;
			NewStyle.HasFrameDash = true;
			NewStyle.DashPattern[0] = true;
			NewStyle.DashPattern[1] = true;
			NewStyle.DashPattern[2] = true;
			NewStyle.DashPattern[3] = true;
			NewStyle.DashPattern[4] = true;
			NewStyle.DashPattern[5] = true;
			NewStyle.DashPattern[6] = true;
			NewStyle.DashPattern[7] = true;
			NewStyle.DashPattern[8] = false;
			NewStyle.DashPattern[9] = false;
			NewStyle.DashPattern[10] = false;
			NewStyle.DashPattern[11] = false;
			NewStyle.DashPattern[12] = false;
			NewStyle.DashPattern[13] = false;
			NewStyle.DashPattern[14] = false;
			NewStyle.DashPattern[15] = false;
			NewStyle.Frame.Color = new SKColor(0, 0, 0, 255);
			NewStyle.HasFrameBlur = true;
			NewStyle.FrameBlur.HorizontalBlurAmount = 0f;
			NewStyle.FrameBlur.VerticalBlurAmount = 0f;
			NewStyle.HasFrameShadow = true;
			NewStyle.FrameShadow.HorizontalOffset = 0f;
			NewStyle.FrameShadow.VerticalOffset = 0f;
			NewStyle.FrameShadow.HorizontalBlurAmount = 0f;
			NewStyle.FrameShadow.VerticalBlurAmount = 0f;
			NewStyle.FrameShadow.Color = new SKColor(128, 128, 128, 255);

			// Draw rect
			var rect = new SKRect(0, 0, 200, 200);
			canvas.DrawRect(rect, NewStyle.Fill);
			canvas.DrawRect(rect, NewStyle.Frame);
		}
		#endregion

		#region Custom Actions
		partial void RunTest1(Foundation.NSObject sender)
		{
			DisplayDrawing();
		}
		#endregion
	}
}
