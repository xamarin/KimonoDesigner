using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the point that a `KimonoProperty` value can be connected to another Kimono object
	/// such as the `Top` coordinate of a `KimonoShape`.
	/// </summary>
	public enum KimonoPropertyConnectionPoint
	{
		/// <summary>
		/// The connection point hasn't been defined.
		/// </summary>
		Undefined,

		/// <summary>
		/// The rectangle that defines the `KimonoShape` Bounds.
		/// </summary>
		Rect,

		/// <summary>
		/// The Top coordinate of a `KimonoShape` Bounds.
		/// </summary>
		Top,

		/// <summary>
		/// The Left coordinate of a `KimonoShape` Bounds.
		/// </summary>
		Left,

		/// <summary>
		/// The Bottom coordinate of a `KimonoShape` Bounds.
		/// </summary>
		Bottom,

		/// <summary>
		/// The Right coordinate of a `KimonoShape` Bounds.
		/// </summary>
		Right,

		/// <summary>
		/// The Widht of a `KimonoShape` Bounds.
		/// </summary>
		Width,

		/// <summary>
		/// The Height of a `KimonoShape` Bounds.
		/// </summary>
		Height,

		/// <summary>
		/// The Rotational Degrees of a `KimonoShape` Bounds.
		/// </summary>
		RotationDegrees,

		/// <summary>
		/// The `KimonoStyle` of a `KimonoShape`.
		/// </summary>
		Style,

		/// <summary>
		/// The visibility of a `KimonoShape`.
		/// </summary>
		Visible,

		/// <summary>
		/// The has start head of a `KimonoShapeArrow`.
		/// </summary>
		HasStartHead,

		/// <summary>
		/// The has end head of a `KimonoShapeArrow`.
		/// </summary>
		HasEndHead,

		/// <summary>
		/// The head inner ratio of a `KimonoShapeArrow`.
		/// </summary>
		HeadInnerRatio,

		/// <summary>
		/// The head outer ratio of a `KimonoShapeArrow`.
		/// </summary>
		HeadOuterRatio,

		/// <summary>
		/// The is streamlined of a `KimonoShapeArrow`.
		/// </summary>
		IsStreamlined,

		/// <summary>
		/// The number of sides of a `KimonoShapePolygon`.
		/// </summary>
		NumberOfSides,

		/// <summary>
		/// The corner radius of a `KimonoShapeRoundRect`.
		/// </summary>
		CornerRadius,

		/// <summary>
		/// The number of points of a `KimonoShapeStar`.
		/// </summary>
		NumberOfPoints,

		/// <summary>
		/// The skip points of a `KimonoShapeStar`.
		/// </summary>
		SkipPoints,

		/// <summary>
		/// The depth offset of a `KimonoShapeStar`.
		/// </summary>
		DepthOffset,

		/// <summary>
		/// The text of a `KimonoShapeText`.
		/// </summary>
		Text,

		/// <summary>
		/// The base color of a `KimonoColor`.
		/// </summary>
		BaseColor,

		/// <summary>
		/// The adjusts hue of a `KimonoColor`.
		/// </summary>
		AdjustsHue,

		/// <summary>
		/// The hue adjustment of a `KimonoColor`.
		/// </summary>
		HueAdjustment,

		/// <summary>
		/// The adjusts saturation of a `KimonoColor`.
		/// </summary>
		AdjustsSaturation,

		/// <summary>
		/// The saturation adjustment of a `KimonoColor`.
		/// </summary>
		SaturationAdjustment,

		/// <summary>
		/// The adjusts brightness of a `KimonoColor`.
		/// </summary>
		AdjustsBrightness,

		/// <summary>
		/// The brightness adjustment of a `KimonoColor`.
		/// </summary>
		BrightnessAdjustment,

		/// <summary>
		/// The adjusts alpha of a `KimonoColor`.
		/// </summary>
		AdjustsAlpha,

		/// <summary>
		/// The alpha adjustment of a `KimonoColor`.
		/// </summary>
		AlphaAdjustment,

		/// <summary>
		/// The has frame of a `KimonoStyle`.
		/// </summary>
		HasFrame,

		/// <summary>
		/// The has frame blur of a `KimonoStyle`.
		/// </summary>
		HasFrameBlur,

		/// <summary>
		/// The frame horizontal blur amount of a `KimonoStyle`.
		/// </summary>
		FrameHorizontalBlurAmount,

		/// <summary>
		/// The frame vertical blur amount of a `KimonoStyle`.
		/// </summary>
		FrameVerticalBlurAmount,

		/// <summary>
		/// The has frame shadow of a `KimonoStyle`.
		/// </summary>
		HasFrameShadow,

		/// <summary>
		/// The frame horizontal offset of a `KimonoStyle`.
		/// </summary>
		FrameShadowHorizontalOffset,

		/// <summary>
		/// The frame vertical offset of a `KimonoStyle`.
		/// </summary>
		FrameShadowVerticalOffset,

		/// <summary>
		/// The frame shadow horizontal blur amount of a `KimonoStyle.
		/// </summary>
		FrameShadowHorizontalBlurAmount,

		/// <summary>
		/// The frame shadow vertical blur amount of a `KimonoStyle`.
		/// </summary>
		FrameShadowVerticalBlurAmount,

		/// <summary>
		/// The color of the frame shadow linked of a `KimonoStyle`.
		/// </summary>
		FrameShadowLinkedColor,

		/// <summary>
		/// The has fill of a `KimonoStyle`.
		/// </summary>
		HasFill,

		/// <summary>
		/// The has fill blur of a `KimonoStyle`.
		/// </summary>
		HasFillBlur,

		/// <summary>
		/// The fill horizontal blur amount of a `KimonoStyle`.
		/// </summary>
		FillHorizontalBlurAmount,

		/// <summary>
		/// The fill vertical blur amount of a `KimonoStyle`.
		/// </summary>
		FillVerticalBlurAmount,

		/// <summary>
		/// The has fill shadow of a `KimonoStyle`.
		/// </summary>
		HasFillShadow,

		/// <summary>
		/// The fill shadow horizontal offset of a `KimonoStyle`.
		/// </summary>
		FillShadowHorizontalOffset,

		/// <summary>
		/// The fill shadow vertical offset of a `KimonoStyle`.
		/// </summary>
		FillShadowVerticalOffset,

		/// <summary>
		/// The fill shadow horizontal blur amount of a `KimonoStyle`.
		/// </summary>
		FillShadowHorizontalBlurAmount,

		/// <summary>
		/// The fill shadow vertical blur amount of a `KimonoStyle`.
		/// </summary>
		FillShadowVerticalBlurAmount,

		/// <summary>
		/// The color of the fill shadow linked of a `KimonoStyle`.
		/// </summary>
		FillShadowLinkedColor,

		/// <summary>
		/// The color of the frame of a `KimonoStyle`.
		/// </summary>
		FrameColor,

		/// <summary>
		/// The frame gradient of a `KimonoStyle`.
		/// </summary>
		FrameGradient,

		/// <summary>
		/// The color of the fill of a `KimonoStyle`.
		/// </summary>
		FillColor,

		/// <summary>
		/// The fill gradient of a `KimonoStyle`.
		/// </summary>
		FillGradient,

		/// <summary>
		/// The is vertical text of a `KimonoStyle`.
		/// </summary>
		IsVerticalText,

		/// <summary>
		/// The strike thru text of a `KimonoStyle`.
		/// </summary>
		StrikeThruText,

		/// <summary>
		/// The text scale x of a `KimonoStyle`.
		/// </summary>
		TextScaleX,

		/// <summary>
		/// The size of the text of a `KimonoStyle`.
		/// </summary>
		TextSize,

		/// <summary>
		/// The text skew x of a `KimonoStyle`.
		/// </summary>
		TextSkewX,

		/// <summary>
		/// The name of the font family of a `KimonoStyle`.
		/// </summary>
		FontFamilyName,

		/// <summary>
		/// The underline text of a `KimonoStyle`.
		/// </summary>
		UnderlineText,

		/// <summary>
		/// The has frame jitter of a `KimonoStyle`.
		/// </summary>
		HasFrameJitter,

		/// <summary>
		/// The length of the frame jitter of a `KimonoStyle`.
		/// </summary>
		FrameJitterLength,

		/// <summary>
		/// The frame jitter deviation of a `KimonoStyle`.
		/// </summary>
		FrameJitterDeviation,

		/// <summary>
		/// The has fill jitter of a `KimonoStyle`.
		/// </summary>
		HasFillJitter,

		/// <summary>
		/// The length of the fill jitter of a `KimonoStyle`.
		/// </summary>
		FillJitterLength,

		/// <summary>
		/// The fill jitter deviation of a `KimonoStyle`.
		/// </summary>
		FillJitterDeviation,

		/// <summary>
		/// The has frame dash of a `KimonoStyle`.
		/// </summary>
		HasFrameDash
	}
}
