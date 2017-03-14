using System;
using SkiaSharp;
using Foundation;
using AppKit;

namespace Kimono
{
	public class Portfolio
	{
		#region Private Variables
		// Private gradient Berry Blast vairables
		private SKColor[] BerryBlastColors;
		private float[] BerryBlastWeights;

		#endregion

		#region Computed Properties
		// Global color Strawberry Cream
		public SKColor StrawberryCream { get; set; } = new SKColor(255, 138, 196, 255);

		// Global color Strawberry
		public SKColor Strawberry { get; set; } = new SKColor(255, 0, 128, 255);

		// Global color Grape
		public SKColor Grape { get; set; } = new SKColor(128, 0, 255, 255);

		// Global gradient Berry Blast
		public SKShader BerryBlast { get; set; }

		// Global style Very Berry
		public SKPaint VeryBerryFillPaint { get; set; }
		public SKPaint VeryBerryFramePaint { get; set; }

		// Global style Custom
		public SKPaint CustomFillPaint { get; set; }
		public SKPaint CustomFramePaint { get; set; }

		#endregion

		#region Constructors
		public Portfolio()
		{
			Initialize();
		}

		internal void Initialize()
		{
			// Initialize Berry Blast
			BerryBlastColors = new SKColor[] { new SKColor(255, 255, 255, 255), Strawberry, Grape, new SKColor(0, 0, 0, 255) };
			BerryBlastWeights = new float[] { 0f, 0.2490276f, 0.7245682f, 0.9662447f };
			BerryBlast = SKShader.CreateLinearGradient(new SKPoint(82.51563f, 6.023438f), new SKPoint(79.83594f, 168.4258f), BerryBlastColors, BerryBlastWeights, SKShaderTileMode.Clamp);

			// Shadow color for VeryBerryFill
			var VeryBerryFillShadowColor = new SKColor(51, 51, 51, 255);

			// Build shadow for VeryBerryFill
			var VeryBerryFillShadow = SKImageFilter.CreateDropShadow(1.864249f, 13.81737f, 7.484411f, 7.639765f, VeryBerryFillShadowColor, SKDropShadowImageFilterShadowMode.DrawShadowAndForeground, null, null);

			// Fill color for Very Berry
			var VeryBerryFillColor = new SKColor(230, 230, 230, 255);

			// Initialize Very Berry fill paint
			VeryBerryFillPaint = new SKPaint()
			{
				Style = SKPaintStyle.Fill,
				Color = VeryBerryFillColor,
				BlendMode = SKBlendMode.SrcOver,
				IsAntialias = true,
				Shader = BerryBlast,
				ImageFilter = VeryBerryFillShadow
			};

			// Initialize Very Berry frame paint
			VeryBerryFramePaint = new SKPaint()
			{
				Style = SKPaintStyle.Stroke,
				Color = StrawberryCream,
				BlendMode = SKBlendMode.SrcOver,
				IsAntialias = true,
				StrokeWidth = 1.897327f,
				StrokeMiter = 4f,
				StrokeJoin = SKStrokeJoin.Mitter,
				StrokeCap = SKStrokeCap.Butt
			};


			// Fill color for Custom
			var CustomFillColor = new SKColor(255, 255, 255, 255);

			// Initialize Custom fill paint
			CustomFillPaint = new SKPaint()
			{
				Style = SKPaintStyle.Fill,
				Color = CustomFillColor,
				BlendMode = SKBlendMode.SrcOver,
				IsAntialias = true,
				Typeface = SKTypeface.FromFamilyName("System", SKTypefaceStyle.Normal),
				TextSize = 24f,
				TextAlign = SKTextAlign.Center,
				StrikeThruText = false,
				UnderlineText = false,
				IsVerticalText = false,
				TextScaleX = 1f,
				TextSkewX = 0f
			};

		}
		#endregion

		#region Private Methods
		private SKData LaunchScreenToData()
		{
			using (var surface = SKSurface.Create(640, 480, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
			{
				// Create Canvas
				SKCanvas canvas = surface.Canvas;
				canvas.Clear(new SKColor(0, 128, 255, 255));

				// Draw all shapes into the canvas
				DrawLaunchScreen(canvas);

				// Return data from sketch
				return surface.Snapshot().Encode();
			}
		}
		private SKData LoginButtonToData()
		{
			using (var surface = SKSurface.Create(200, 100, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
			{
				// Create Canvas
				SKCanvas canvas = surface.Canvas;
				canvas.Clear();

				// Draw all shapes into the canvas
				DrawLoginButton(canvas);

				// Return data from sketch
				return surface.Snapshot().Encode();
			}
		}

		#endregion

		#region Public Methods
		public void DrawLaunchScreen(SKCanvas canvas)
		{
			//-----------------------------------------------------------------------------
			// Draw Sheild shape group
			// Define Oval shape path
			var OvalPath = new SKPath();
			OvalPath.AddOval(new SKRect(215.3477f, 114.1523f, 414.7578f, 317.2344f), SKPathDirection.Clockwise);
			var SheildPath = OvalPath;

			// Define Star shape path
			var StarPath = new SKPath();
			StarPath.MoveTo(new SKPoint(315.4297f, 128.6055f));
			StarPath.LineTo(new SKPoint(334.3599f, 191.2784f));
			StarPath.LineTo(new SKPoint(395.6194f, 191.2784f));
			StarPath.LineTo(new SKPoint(346.0594f, 230.0125f));
			StarPath.LineTo(new SKPoint(364.9896f, 292.6854f));
			StarPath.LineTo(new SKPoint(315.4297f, 253.9514f));
			StarPath.LineTo(new SKPoint(265.8698f, 292.6854f));
			StarPath.LineTo(new SKPoint(284.8f, 230.0125f));
			StarPath.LineTo(new SKPoint(235.24f, 191.2784f));
			StarPath.LineTo(new SKPoint(296.4995f, 191.2784f));
			StarPath.LineTo(new SKPoint(315.4297f, 128.6055f));
			SheildPath = SheildPath.Op(StarPath, SKPathOp.Difference);


			// Draw Sheild boolean shape
			VeryBerryFillPaint.Shader = SKShader.CreateLinearGradient(new SKPoint(308.8389f, 121.1026f), new SKPoint(305.8028f, 308.4947f), BerryBlastColors, BerryBlastWeights, SKShaderTileMode.Clamp);
			canvas.DrawPath(SheildPath, VeryBerryFillPaint);
			canvas.DrawPath(SheildPath, VeryBerryFramePaint);
			//-----------------------------------------------------------------------------


			// Draw Text shape
			canvas.DrawText("Berry Blaster", 316.8008f, 364.5391f, CustomFillPaint);


		}
		public NSImage LaunchScreenToImage()
		{
			// Get image data from sketch
			var skPngdata = LaunchScreenToData();

			// Convert to image and return
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			return new NSImage(data);
		}
		public void DrawLoginButton(SKCanvas canvas)
		{
			// Draw Round Rectangle shape
			VeryBerryFillPaint.Shader = SKShader.CreateLinearGradient(new SKPoint(94.86246f, 11.37462f), new SKPoint(92.07168f, 69.92178f), BerryBlastColors, BerryBlastWeights, SKShaderTileMode.Clamp);
			canvas.DrawRoundRect(new SKRect(8.925781f, 9.203125f, 192.2227f, 72.65234f), 32f, 32f, VeryBerryFillPaint);
			canvas.DrawRoundRect(new SKRect(8.925781f, 9.203125f, 192.2227f, 72.65234f), 32f, 32f, VeryBerryFramePaint);

			// Draw Text shape
			canvas.DrawText("Login", 100.0859f, 48.83594f, CustomFillPaint);


		}
		public NSImage LoginButtonToImage()
		{
			// Get image data from sketch
			var skPngdata = LoginButtonToData();

			// Convert to image and return
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			return new NSImage(data);
		}

		#endregion

	}
}
