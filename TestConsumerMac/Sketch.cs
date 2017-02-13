using System;
using SkiaSharp;

public class Sketch
{
	#region Private Variables
	// Private gradient Berry Blast vairables
	private SKColor[] BerryBlastColors;
	private float[] BerryBlastWeights;
	#endregion

	#region Computed Properties
	// Global color Orange
	public SKColor Orange { get; set; } = new SKColor(255, 128, 0, 255);

	// Global color Strawberry
	public SKColor Strawberry { get; set; } = new SKColor(255, 0, 128, 255);

	// Global color Grape
	public SKColor Grape { get; set; } = new SKColor(128, 0, 255, 255);

	// Global gradient Berry Blast
	public SKShader BerryBlast { get; set; }
	#endregion

	#region Constructors
	public Sketch()
	{
		// Initialize Berry Blast
		BerryBlastColors = new SKColor[] { new SKColor(255, 255, 255, 255), Strawberry, Grape, new SKColor(0, 0, 0, 255) };
		BerryBlastWeights = new float[] { 0f, 0.2834916f, 0.6944554f, 0.9662447f };
		BerryBlast = SKShader.CreateLinearGradient(new SKPoint(0f, 0f), new SKPoint(168f, 168f), BerryBlastColors, BerryBlastWeights, SKShaderTileMode.Clamp);
	}
	#endregion

	#region Public Methods
	public void DrawSketch(SKCanvas canvas)
	{
		// Fill color for Oval Style
		var OvalStyleFillColor = new SKColor(230, 230, 230, 255);

		// Create Oval Style fill paint
		var OvalStyleFillPaint = new SKPaint()
		{
			Style = SKPaintStyle.Fill,
			Color = OvalStyleFillColor,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			Shader = BerryBlast
		};

		// Create Oval Style frame paint
		var OvalStyleFramePaint = new SKPaint()
		{
			Style = SKPaintStyle.Stroke,
			Color = Orange,
			BlendMode = SKBlendMode.SrcOver,
			IsAntialias = true,
			StrokeWidth = 2.285407f,
			StrokeMiter = 4f,
			StrokeJoin = SKStrokeJoin.Miter,
			StrokeCap = SKStrokeCap.Butt
		};

		// Draw Oval shape
		OvalStyleFillPaint.Shader = SKShader.CreateLinearGradient(new SKPoint(48.94141f, 53.875f), new SKPoint(279.0689f, 257.9874f), BerryBlastColors, BerryBlastWeights, SKShaderTileMode.Clamp);
		canvas.DrawOval(new SKRect(48.94141f, 53.875f, 290.0273f, 267.707f), OvalStyleFillPaint);
		canvas.DrawOval(new SKRect(48.94141f, 53.875f, 290.0273f, 267.707f), OvalStyleFramePaint);
	}
	#endregion

}
