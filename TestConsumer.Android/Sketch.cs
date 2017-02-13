using System;
using SkiaSharp;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

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
			canvas.Clear(new SKColor(255, 255, 255, 255));

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
		// Fill color for Oval Style
		var OvalStyleFillColor = new SKColor(128, 0, 255, 255);

		// New Oval Style fill paint
		var OvalStyleFillPaint = new SKPaint()
		{
			Style = SKPaintStyle.Fill,
			Color = OvalStyleFillColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true
		};

		// Frame color for Oval Style
		var OvalStyleFrameColor = new SKColor(0, 0, 0, 255);

		// New Oval Style frame paint
		var OvalStyleFramePaint = new SKPaint()
		{
			Style = SKPaintStyle.Stroke,
			Color = OvalStyleFrameColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			StrokeWidth = 1f,
			StrokeMiter = 4f,
			StrokeJoin = SKStrokeJoin.Mitter,
			StrokeCap = SKStrokeCap.Butt
		};

		// Draw Oval shape
		canvas.DrawOval(new SKRect(34.15234f, 38.17969f, 186.3086f, 179.0703f), OvalStyleFillPaint);
		canvas.DrawOval(new SKRect(34.15234f, 38.17969f, 186.3086f, 179.0703f), OvalStyleFramePaint);

		// Fill color for Round Rectangle Style
		var RoundRectangleStyleFillColor = new SKColor(255, 0, 255, 255);

		// New Round Rectangle Style fill paint
		var RoundRectangleStyleFillPaint = new SKPaint()
		{
			Style = SKPaintStyle.Fill,
			Color = RoundRectangleStyleFillColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true
		};

		// Frame color for Round Rectangle Style
		var RoundRectangleStyleFrameColor = new SKColor(0, 0, 0, 255);

		// New Round Rectangle Style frame paint
		var RoundRectangleStyleFramePaint = new SKPaint()
		{
			Style = SKPaintStyle.Stroke,
			Color = RoundRectangleStyleFrameColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			StrokeWidth = 1f,
			StrokeMiter = 4f,
			StrokeJoin = SKStrokeJoin.Mitter,
			StrokeCap = SKStrokeCap.Butt
		};

		// Draw Round Rectangle shape
		canvas.DrawRoundRect(new SKRect(163.0547f, 133.1445f, 442.7148f, 323.043f), 32f, 32f, RoundRectangleStyleFillPaint);
		canvas.DrawRoundRect(new SKRect(163.0547f, 133.1445f, 442.7148f, 323.043f), 32f, 32f, RoundRectangleStyleFramePaint);

		// Fill color for Star Style
		var StarStyleFillColor = new SKColor(255, 128, 0, 255);

		// New Star Style fill paint
		var StarStyleFillPaint = new SKPaint()
		{
			Style = SKPaintStyle.Fill,
			Color = StarStyleFillColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true
		};

		// Frame color for Star Style
		var StarStyleFrameColor = new SKColor(0, 0, 0, 255);

		// New Star Style frame paint
		var StarStyleFramePaint = new SKPaint()
		{
			Style = SKPaintStyle.Stroke,
			Color = StarStyleFrameColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			StrokeWidth = 1f,
			StrokeMiter = 4f,
			StrokeJoin = SKStrokeJoin.Mitter,
			StrokeCap = SKStrokeCap.Butt
		};

		// Define Star shape path
		var StarPath = new SKPath();
		StarPath.MoveTo(new SKPoint(480.6816f, 180.6094f));
		StarPath.LineTo(new SKPoint(511.2072f, 280.5293f));
		StarPath.LineTo(new SKPoint(609.9901f, 280.5293f));
		StarPath.LineTo(new SKPoint(530.0731f, 342.2832f));
		StarPath.LineTo(new SKPoint(560.5986f, 442.2031f));
		StarPath.LineTo(new SKPoint(480.6816f, 380.4492f));
		StarPath.LineTo(new SKPoint(400.7646f, 442.2031f));
		StarPath.LineTo(new SKPoint(431.2902f, 342.2832f));
		StarPath.LineTo(new SKPoint(351.3733f, 280.5293f));
		StarPath.LineTo(new SKPoint(450.1561f, 280.5293f));
		StarPath.LineTo(new SKPoint(480.6816f, 180.6094f));

		// Draw Star shape
		canvas.DrawPath(StarPath, StarStyleFillPaint);
		canvas.DrawPath(StarPath, StarStyleFramePaint);


	}
	public Bitmap SketchToImage()
	{
		// Get image data from sketch
		var skPngdata = SketchToData();

		// Convert to image and return
		var imageBytes = skPngdata.ToArray();
		return BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
	}

	#endregion

}
