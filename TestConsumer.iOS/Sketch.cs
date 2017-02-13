using System;
using SkiaSharp;
using Foundation;
using UIKit;

public class Sketch
{
	#region Constructors
	public Sketch()
	{


	}
	#endregion

	#region Private Methods
	private SKData SketchToData()
	{
		using (var surface = SKSurface.Create(640, 480, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
		{
			// Create Canvas
			SKCanvas canvas = surface.Canvas;
			canvas.Clear();

			// Draw all shapes into the canvas
			DrawSketch(canvas);

			// Return data from sketch
			return surface.Snapshot().Encode();
		}
	}

	#endregion

	#region Public Methods
	public void DrawSketch(SKCanvas canvas)
	{
		// Build OvalStyleFill Blur
		var OvalStyleFillBlur = SKImageFilter.CreateBlur(9.522291f, 4.249391f, null, null);

		// Fill color for Oval Style
		var OvalStyleFillColor = new SKColor(255, 0, 128, 255);

		// New Oval Style fill paint
		var OvalStyleFillPaint = new SKPaint()
		{
			Style = SKPaintStyle.Fill,
			Color = OvalStyleFillColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			PathEffect = SKPathEffect.CreateDiscrete(11.70298f, 8.239141f),
			ImageFilter = OvalStyleFillBlur
		};

		// Frame color for Oval Style
		var OvalStyleFrameColor = new SKColor(204, 102, 255, 255);

		// New Oval Style frame paint
		var OvalStyleFramePaint = new SKPaint()
		{
			Style = SKPaintStyle.Stroke,
			Color = OvalStyleFrameColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			StrokeWidth = 1f,
			StrokeMiter = 4f,
			StrokeJoin = SKStrokeJoin.Miter,
			StrokeCap = SKStrokeCap.Butt
		};

		// Draw Oval shape
		canvas.DrawOval(new SKRect(51.79688f, 47.54688f, 235.5156f, 216.3242f), OvalStyleFillPaint);
		canvas.DrawOval(new SKRect(51.79688f, 47.54688f, 235.5156f, 216.3242f), OvalStyleFramePaint);


	}

	public UIImage SketchToImage()
	{
		// Get image data from sketch
		var skPngdata = SketchToData();

		// Convert to image and return
		var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
		return new UIImage(data);
	}

	#endregion

}
