using System;
using SkiaSharp;
using Foundation;
using AppKit;

public class Portfolio
{
	#region Private Variables
	// Private gradient Orange Gradient vairables
	private SKColor[] OrangeGradientColors;
	private float[] OrangeGradientWeights;

	#endregion

	#region Computed Properties
	// Global gradient Orange Gradient
	public SKShader OrangeGradient { get; set; }

	// Global style Orange Style
	public SKPaint OrangeStyleFillPaint { get; set; }
	public SKPaint OrangeStyleFramePaint { get; set; }


	#endregion

	#region Constructors
	public Portfolio()
	{
		Initialize();
	}

	internal void Initialize()
	{
		// Initialize Orange Gradient
		OrangeGradientColors = new SKColor[] { new SKColor(255, 128, 0, 255), new SKColor(0, 0, 0, 255) };
		OrangeGradientWeights = new float[] { 0f, 0.9662447f };
		OrangeGradient = SKShader.CreateLinearGradient(new SKPoint(0f, 0f), new SKPoint(168f, 168f), OrangeGradientColors, OrangeGradientWeights, SKShaderTileMode.Clamp);

		// Fill color for Orange Style
		var OrangeStyleFillColor = new SKColor(230, 230, 230, 255);

		// Initialize Orange Style fill paint
		OrangeStyleFillPaint = new SKPaint()
		{
			Style = SKPaintStyle.Fill,
			Color = OrangeStyleFillColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			Shader = OrangeGradient
		};

		// Frame color for Orange Style
		var OrangeStyleFrameColor = new SKColor(0, 0, 0, 255);

		// Initialize Orange Style frame paint
		OrangeStyleFramePaint = new SKPaint()
		{
			Style = SKPaintStyle.Stroke,
			Color = OrangeStyleFrameColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			StrokeWidth = 1f,
			StrokeMiter = 4f,
			StrokeJoin = SKStrokeJoin.Mitter,
			StrokeCap = SKStrokeCap.Butt
		};



	}
	#endregion

	#region Private Methods
	private SKData CircleToData()
	{
		using (var surface = SKSurface.Create(640, 480, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
		{
			// Create Canvas
			SKCanvas canvas = surface.Canvas;
			canvas.Clear(new SKColor(255, 255, 255, 255));

			// Draw all shapes into the canvas
			DrawCircle(canvas);

			// Return data from sketch
			return surface.Snapshot().Encode();
		}
	}

	#endregion

	#region Public Methods
	public void DrawCircle(SKCanvas canvas)
	{
		// Draw Oval shape
		OrangeStyleFillPaint.Shader = SKShader.CreateLinearGradient(new SKPoint(67.97656f, 50.74219f), new SKPoint(251.5961f, 222.4821f), OrangeGradientColors, OrangeGradientWeights, SKShaderTileMode.Clamp);
		canvas.DrawOval(new SKRect(67.97656f, 50.74219f, 260.3398f, 230.6602f), OrangeStyleFillPaint);
		canvas.DrawOval(new SKRect(67.97656f, 50.74219f, 260.3398f, 230.6602f), OrangeStyleFramePaint);


	}
	public NSImage CircleToImage()
	{
		// Get image data from sketch
		var skPngdata = CircleToData();

		// Convert to image and return
		var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
		return new NSImage(data);
	}

	#endregion

}
