using System;
using System.Collections.Generic;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Defines as style that can be applied to a <c>KimonoShape</c> to control its
	/// appearance.
	/// </summary>
	[Table("Style")]
	public class KimonoStyle : IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Static Methods
		/// <summary>
		/// Clones the given <c>SKPaint</c> object.
		/// </summary>
		/// <returns>The new <c>SKPaint</c> instance.</returns>
		/// <param name="paint">The <c>SKPaint</c> object to clone.</param>
		public static SKPaint ClonePaint(SKPaint paint)
		{
			// Duplicate paint
			var newPaint = new SKPaint()
			{
				BlendMode = paint.BlendMode,
				Color = new SKColor(paint.Color.Red, paint.Color.Green, paint.Color.Blue, paint.Color.Alpha),
				ColorFilter = paint.ColorFilter,
				DeviceKerningEnabled = paint.DeviceKerningEnabled,
				FakeBoldText = paint.FakeBoldText,
				FilterQuality = paint.FilterQuality,
				HintingLevel = paint.HintingLevel,
				ImageFilter = paint.ImageFilter,
				IsAntialias = paint.IsAntialias,
				IsAutohinted = paint.IsAutohinted,
				IsDither = paint.IsDither,
				IsEmbeddedBitmapText = paint.IsEmbeddedBitmapText,
				IsLinearText = paint.IsLinearText,
				IsStroke = paint.IsStroke,
				IsVerticalText = paint.IsVerticalText,
				LcdRenderText = paint.LcdRenderText,
				MaskFilter = paint.MaskFilter,
				PathEffect = paint.PathEffect,
				Shader = paint.Shader,
				StrikeThruText = paint.StrikeThruText,
				StrokeCap = paint.StrokeCap,
				StrokeJoin = paint.StrokeJoin,
				StrokeMiter = paint.StrokeMiter,
				StrokeWidth = paint.StrokeWidth,
				Style = paint.Style,
				SubpixelText = paint.SubpixelText,
				TextAlign = paint.TextAlign,
				TextEncoding = paint.TextEncoding,
				TextScaleX = paint.TextScaleX,
				TextSize = paint.TextSize,
				TextSkewX = paint.TextSkewX,
				Typeface = paint.Typeface,
				UnderlineText = paint.UnderlineText
			};

			// Return new paint
			return newPaint;
		}
		#endregion

		#region Private Variables
		/// <summary>
		/// Holds a named <c>KimonoColor</c> attached to the style's frame color.
		/// </summary>
		private KimonoColor _frameColor = null;

		/// <summary>
		/// Holds a named <c>KimonoColor</c> attached to the style's fill color.
		/// </summary>
		private KimonoColor _fillColor = null;

		/// <summary>
		/// The frame gradient.
		/// </summary>
		private KimonoGradient _frameGradient = null;

		/// <summary>
		/// The fill gradient.
		/// </summary>
		private KimonoGradient _fillGradient = null;

		/// <summary>
		/// If <c>true</c>, the frame uses the jitter effect.
		/// </summary>
		private bool _hasFrameJitter = false;

		/// <summary>
		/// The length of the frame jitter.
		/// </summary>
		private float _frameJitterLength = 10;

		/// <summary>
		/// The frame jitter deviation.
		/// </summary>
		private float _frameJitterDeviation = 2;

		/// <summary>
		/// If <c>true</c>, the fill uses the jitter effect.
		/// </summary>
		private bool _hasFillJitter = false;

		/// <summary>
		/// The length of the fill jitter.
		/// </summary>
		private float _fillJitterLength = 10;

		/// <summary>
		/// The fill jitter deviation.
		/// </summary>
		private float _fillJitterDeviation = 2;

		/// <summary>
		/// If <c>true</c>, the frame has a dash effect.
		/// </summary>
		private bool _hasFrameDash = false;

		/// <summary>
		/// The has fill blur.
		/// </summary>
		private bool _hasFillBlur = false;

		/// <summary>
		/// The fill blur.
		/// </summary>
		private KimonoBlur _fillBlur = null;

		/// <summary>
		/// The has frame blur.
		/// </summary>
		private bool _hasFrameBlur = false;

		/// <summary>
		/// The frame blur.
		/// </summary>
		private KimonoBlur _frameBlur = null;

		/// <summary>
		/// The has fill shadow.
		/// </summary>
		private bool _hasFillShadow = false;

		/// <summary>
		/// The fill shadow.
		/// </summary>
		private KimonoShadow _fillShadow = null;

		/// <summary>
		/// The has frame shadow.
		/// </summary>
		private bool _hasFrameShadow = false;

		/// <summary>
		/// The frame shadow.
		/// </summary>
		private KimonoShadow _frameShadow = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		[PrimaryKey]
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the name of the element as it will be called in generated source
		/// code.
		/// </summary>
		/// <value>The name of the element.</value>
		internal string ElementName { get; set; } = "";

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; } = "New Style";

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> has a frame.
		/// </summary>
		/// <value><c>true</c> if has frame; otherwise, <c>false</c>.</value>
		public bool HasFrame { get; set; } = true;

		/// <summary>
		/// Gets or sets the frame paint style.
		/// </summary>
		/// <value>The <c>SKPaint</c> style for the frame.</value>
		[Ignore]
		public SKPaint Frame { get; set; } = new SKPaint();

		/// <summary>
		/// Gets or sets the frame blend mode.
		/// </summary>
		/// <value>The frame blend mode.</value>
		public SKBlendMode FrameBlendMode
		{
			get { return Frame.BlendMode; }
			set { Frame.BlendMode = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> frame is antialias.
		/// </summary>
		/// <value><c>true</c> if frame is antialias; otherwise, <c>false</c>.</value>
		public bool FrameIsAntialias
		{
			get { return Frame.IsAntialias; }
			set { Frame.IsAntialias = value; }
		}

		/// <summary>
		/// Gets or sets the color of the frame base.
		/// </summary>
		/// <value>The color of the frame base.</value>
		[Serializer("SKColor")]
		public SKColor FrameBaseColor
		{
			get { return Frame.Color; }
			set { Frame.Color = value; }
		}

		/// <summary>
		/// Gets or sets the width of the frame stroke.
		/// </summary>
		/// <value>The width of the frame stroke.</value>
		public float FrameStrokeWidth
		{
			get { return Frame.StrokeWidth; }
			set { Frame.StrokeWidth = value; }
		}

		/// <summary>
		/// Gets or sets the frame stroke miter.
		/// </summary>
		/// <value>The frame stroke miter.</value>
		public float FrameStrokeMiter
		{
			get { return Frame.StrokeMiter; }
			set { Frame.StrokeMiter = value; }
		}

		/// <summary>
		/// Gets or sets the frame stroke join.
		/// </summary>
		/// <value>The frame stroke join.</value>
		public SKStrokeJoin FrameStrokeJoin
		{
			get { return Frame.StrokeJoin; }
			set { Frame.StrokeJoin = value; }
		}

		/// <summary>
		/// Gets or sets the frame stroke cap.
		/// </summary>
		/// <value>The frame stroke cap.</value>
		public SKStrokeCap FrameStrokeCap
		{
			get { return Frame.StrokeCap; }
			set { Frame.StrokeCap = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> has frame blur.
		/// </summary>
		/// <value><c>true</c> if has frame blur; otherwise, <c>false</c>.</value>
		public bool HasFrameBlur
		{
			get { return _hasFrameBlur; }
			set
			{
				_hasFrameBlur = value;
				HandleFrameBlurOrShadowChange();
			}
		}

		/// <summary>
		/// Gets or sets the frame blur.
		/// </summary>
		/// <value>The <c>KimonoBlur</c> applied to the frame.</value>
		[Child]
		public KimonoBlur FrameBlur
		{
			get { return _frameBlur; }
			set
			{
				// Unwire previous blur
				if (_frameBlur != null)
				{
					_frameBlur.BlurModified -= HandleFrameBlurOrShadowChange;
				}

				// Save new value and apply
				_frameBlur = value;
				HandleFrameBlurOrShadowChange();

				// Wire up new blur
				if (_frameBlur != null)
				{
					_frameBlur.BlurModified += HandleFrameBlurOrShadowChange;
				}
			}
		}

		/// <summary>
		/// Gets or sets the frame blur horizontal amount.
		/// </summary>
		/// <value>The frame blur horizontal amount.</value>
		[Ignore]
		public float FrameBlurHorizontalAmount
		{
			get { return FrameBlur.HorizontalBlurAmount; }
			set { FrameBlur.HorizontalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets the frame blur vertical amount.
		/// </summary>
		/// <value>The frame blur vertical amount.</value>
		[Ignore]
		public float FrameBlurVerticalAmount
		{
			get { return FrameBlur.VerticalBlurAmount; }
			set { FrameBlur.VerticalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> has frame shadow.
		/// </summary>
		/// <value><c>true</c> if has frame shadow; otherwise, <c>false</c>.</value>
		public bool HasFrameShadow
		{
			get { return _hasFrameShadow; }
			set
			{
				_hasFrameShadow = value;
				HandleFrameBlurOrShadowChange();
			}
		}

		/// <summary>
		/// Gets or sets the frame shadow.
		/// </summary>
		/// <value>The frame shadow as a <c>KimonoShadow</c>.</value>
		[Child]
		public KimonoShadow FrameShadow
		{
			get { return _frameShadow; }
			set
			{
				// Unwire previous shadow
				if (_frameShadow != null)
				{
					_frameShadow.ShadowModified -= HandleFrameBlurOrShadowChange;
				}

				// Save new value and apply
				_frameShadow = value;
				HandleFrameBlurOrShadowChange();

				// Wire up new shadow
				if (_frameShadow != null)
				{
					_frameShadow.ShadowModified += HandleFrameBlurOrShadowChange;
				}
			}
		}

		/// <summary>
		/// Gets or sets the frame shadow horizontal offset.
		/// </summary>
		/// <value>The frame shadow horizontal offset.</value>
		[Ignore]
		public float FrameShadowHorizontalOffset
		{
			get { return FrameShadow.HorizontalOffset; }
			set { FrameShadow.HorizontalOffset = value; }
		}

		/// <summary>
		/// Gets or sets the frame shadow vertical offset.
		/// </summary>
		/// <value>The frame shadow vertical offset.</value>
		[Ignore]
		public float FrameShadowVerticalOffset
		{
			get { return FrameShadow.VerticalOffset; }
			set { FrameShadow.VerticalOffset = value; }
		}

		/// <summary>
		/// Gets or sets the frame shadow horizontal blur.
		/// </summary>
		/// <value>The frame shadow horizontal blur.</value>
		[Ignore]
		public float FrameShadowHorizontalBlur
		{
			get { return FrameShadow.HorizontalBlurAmount; }
			set { FrameShadow.HorizontalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets the frame shadow vertical blur.
		/// </summary>
		/// <value>The frame shadow vertical blur.</value>
		[Ignore]
		public float FrameShadowVerticalBlur
		{
			get { return FrameShadow.VerticalBlurAmount; }
			set { FrameShadow.VerticalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets the color of the frame shadow base.
		/// </summary>
		/// <value>The color of the frame shadow base.</value>
		[Ignore]
		public SKColor FrameShadowBaseColor
		{
			get { return FrameShadow.Color; }
			set { FrameShadow.Color = value; }
		}

		/// <summary>
		/// Gets or sets the color of the frame shadow linked.
		/// </summary>
		/// <value>The color of the frame shadow linked.</value>
		[Ignore]
		public KimonoColor FrameShadowLinkedColor
		{
			get { return FrameShadow.LinkedColor; }
			set { FrameShadow.LinkedColor = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> has fill blur.
		/// </summary>
		/// <value><c>true</c> if has fill blur; otherwise, <c>false</c>.</value>
		public bool HasFillBlur
		{
			get { return _hasFillBlur; }
			set
			{
				_hasFillBlur = value;
				HandleFillBlurOrShadowChange();
			}
		}

		/// <summary>
		/// Gets or sets the fill blur.
		/// </summary>
		/// <value>The <c>KimonoBlur</c> applied to the fill.</value>
		[Child]
		public KimonoBlur FillBlur
		{
			get { return _fillBlur; }
			set
			{
				// Unwire previous blur
				if (_fillBlur != null)
				{
					_fillBlur.BlurModified -= HandleFillBlurOrShadowChange;
				}

				// Save new value and apply
				_fillBlur = value;
				HandleFillBlurOrShadowChange();

				// Wire up new blur
				if (_fillBlur != null)
				{
					_fillBlur.BlurModified += HandleFillBlurOrShadowChange;
				}
			}
		}

		/// <summary>
		/// Gets or sets the Fill blur horizontal amount.
		/// </summary>
		/// <value>The Fill blur horizontal amount.</value>
		[Ignore]
		public float FillBlurHorizontalAmount
		{
			get { return FillBlur.HorizontalBlurAmount; }
			set { FillBlur.HorizontalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Fill blur vertical amount.
		/// </summary>
		/// <value>The Fill blur vertical amount.</value>
		[Ignore]
		public float FillBlurVerticalAmount
		{
			get { return FillBlur.VerticalBlurAmount; }
			set { FillBlur.VerticalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> has fill shadow.
		/// </summary>
		/// <value><c>true</c> if has fill shadow; otherwise, <c>false</c>.</value>
		public bool HasFillShadow
		{
			get { return _hasFillShadow; }
			set
			{
				_hasFillShadow = value;
				HandleFillBlurOrShadowChange();
			}
		}

		/// <summary>
		/// Gets or sets the fill shadow.
		/// </summary>
		/// <value>The fill shadow.</value>
		[Child]
		public KimonoShadow FillShadow
		{
			get { return _fillShadow; }
			set
			{
				// Unwire previous shadow
				if (_fillShadow != null)
				{
					_fillShadow.ShadowModified -= HandleFillBlurOrShadowChange;
				}

				// Save new value and apply
				_fillShadow = value;
				HandleFillBlurOrShadowChange();

				// Wire up new shadow
				if (_fillShadow != null)
				{
					_fillShadow.ShadowModified += HandleFillBlurOrShadowChange;
				}
			}
		}

		/// <summary>
		/// Gets or sets the Fill shadow horizontal offset.
		/// </summary>
		/// <value>The Fill shadow horizontal offset.</value>
		[Ignore]
		public float FillShadowHorizontalOffset
		{
			get { return FillShadow.HorizontalOffset; }
			set { FillShadow.HorizontalOffset = value; }
		}

		/// <summary>
		/// Gets or sets the Fill shadow vertical offset.
		/// </summary>
		/// <value>The Fill shadow vertical offset.</value>
		[Ignore]
		public float FillShadowVerticalOffset
		{
			get { return FillShadow.VerticalOffset; }
			set { FillShadow.VerticalOffset = value; }
		}

		/// <summary>
		/// Gets or sets the Fill shadow horizontal blur.
		/// </summary>
		/// <value>The Fill shadow horizontal blur.</value>
		[Ignore]
		public float FillShadowHorizontalBlur
		{
			get { return FillShadow.HorizontalBlurAmount; }
			set { FillShadow.HorizontalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Fill shadow vertical blur.
		/// </summary>
		/// <value>The Fill shadow vertical blur.</value>
		[Ignore]
		public float FillShadowVerticalBlur
		{
			get { return FillShadow.VerticalBlurAmount; }
			set { FillShadow.VerticalBlurAmount = value; }
		}

		/// <summary>
		/// Gets or sets the color of the Fill shadow base.
		/// </summary>
		/// <value>The color of the Fill shadow base.</value>
		[Ignore]
		public SKColor FillShadowBaseColor
		{
			get { return FillShadow.Color; }
			set { FillShadow.Color = value; }
		}

		/// <summary>
		/// Gets or sets the color of the Fill shadow linked.
		/// </summary>
		/// <value>The color of the Fill shadow linked.</value>
		[Ignore]
		public KimonoColor FillShadowLinkedColor
		{
			get { return FillShadow.LinkedColor; }
			set { FillShadow.LinkedColor = value; }
		}

		/// <summary>
		/// Gets or sets the color of the frame as a named Kimono Color.
		/// </summary>
		/// <value>The color of the frame.</value>
		[Child]
		public KimonoColor FrameColor
		{
			get { return _frameColor; }
			set
			{
				// Unwire previous color
				if (_frameColor != null)
				{
					_frameColor.ColorChanged -= HandleFrameColorChange;
				}

				// Save new value
				_frameColor = value;

				// Wireup new color
				if (_frameColor != null)
				{
					_frameColor.ColorChanged += HandleFrameColorChange;
					HandleFrameColorChange();
				}
			}
		}

		/// <summary>
		/// Gets or sets the frame gradient.
		/// </summary>
		/// <value>The frame gradient.</value>
		[Child]
		public KimonoGradient FrameGradient
		{
			get { return _frameGradient; }
			set
			{
				// Unwire previous gradient
				if (_frameGradient != null)
				{
					_frameGradient.GradientModified -= HandleFrameGradientChange;
				}

				// Save new value
				_frameGradient = value;

				// Wireup new gradient
				if (_frameGradient != null)
				{
					_frameGradient.GradientModified += HandleFrameGradientChange;
					Frame.Shader = _frameGradient.Shader;
				}
				else
				{
					Frame.Shader = null;
				}
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> has fill.
		/// </summary>
		/// <value><c>true</c> if has fill; otherwise, <c>false</c>.</value>
		public bool HasFill { get; set; } = true;

		/// <summary>
		/// Gets or sets the fill paint style.
		/// </summary>
		/// <value>The <c>SKPaint</c> style for the fill.</value>
		[Ignore]
		public SKPaint Fill { get; set; } = new SKPaint();

		/// <summary>
		/// Gets or sets the fill blend mode.
		/// </summary>
		/// <value>The fill blend mode.</value>
		public SKBlendMode FillBlendMode
		{
			get { return Fill.BlendMode; }
			set { Fill.BlendMode = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> fill is anti alias.
		/// </summary>
		/// <value><c>true</c> if fill is anti alias; otherwise, <c>false</c>.</value>
		public bool FillIsAntiAlias
		{
			get { return Fill.IsAntialias; }
			set { Fill.IsAntialias = value; }
		}

		/// <summary>
		/// Gets or sets the color of the fill base.
		/// </summary>
		/// <value>The color of the fill base.</value>
		[Serializer("SKColor")]
		public SKColor FillBaseColor
		{
			get { return Fill.Color; }
			set { Fill.Color = value; }
		}

		/// <summary>
		/// Gets or sets the color of the fill as a named Kimono Color.
		/// </summary>
		/// <value>The color of the fill.</value>
		[Child]
		public KimonoColor FillColor
		{
			get { return _fillColor; }
			set
			{
				// Unwire previous color
				if (_fillColor != null)
				{
					_fillColor.ColorChanged -= HandleFillColorChange;
				}

				// Save new value
				_fillColor = value;

				// Wireup new color
				if (_fillColor != null)
				{
					_fillColor.ColorChanged += HandleFillColorChange;
					HandleFillColorChange();
				}
			}
		}

		/// <summary>
		/// Gets or sets the fill gradient.
		/// </summary>
		/// <value>The fill gradient.</value>
		[Child]
		public KimonoGradient FillGradient
		{
			get { return _fillGradient; }
			set
			{
				// Unwire previous gradient
				if (_fillGradient != null)
				{
					_fillGradient.GradientModified -= HandleFillGradientChange;
				}

				// Save new value
				_fillGradient = value;

				// Wireup new gradient
				if (_fillGradient != null)
				{
					_fillGradient.GradientModified += HandleFillGradientChange;
					Fill.Shader = _fillGradient.Shader;
				}
				else
				{
					Fill.Shader = null;
				}
			}
		}

		/// <summary>
		/// Gets or sets the type of the style.
		/// </summary>
		/// <value>The type of the style.</value>
		public KimonoStyleType StyleType { get; set; } = KimonoStyleType.Standard;

		/// <summary>
		/// Gets the font metrics.
		/// </summary>
		/// <value>The font metrics.</value>
		[Ignore]
		public SKFontMetrics FontMetrics
		{
			get { return Fill.FontMetrics; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> is linear text.
		/// </summary>
		/// <value><c>true</c> if is linear text; otherwise, <c>false</c>.</value>
		public bool IsLinearText
		{
			get { return Fill.IsLinearText; }
			set
			{
				Fill.IsLinearText = value;
				Frame.IsLinearText = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> is vertical text.
		/// </summary>
		/// <value><c>true</c> if is vertical text; otherwise, <c>false</c>.</value>
		public bool IsVerticalText
		{
			get { return Fill.IsVerticalText; }
			set
			{
				Fill.IsVerticalText = value;
				Frame.IsVerticalText = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> strike thru text.
		/// </summary>
		/// <value><c>true</c> if strike thru text; otherwise, <c>false</c>.</value>
		public bool StrikeThruText
		{
			get { return Fill.StrikeThruText; }
			set
			{
				Fill.StrikeThruText = value;
				Frame.StrikeThruText = value;
			}
		}

		/// <summary>
		/// Gets or sets the text align.
		/// </summary>
		/// <value>The text align.</value>
		public SKTextAlign TextAlign
		{
			get { return Fill.TextAlign; }
			set
			{
				Fill.TextAlign = value;
				Frame.TextAlign = value;
			}
		}

		/// <summary>
		/// Gets or sets the text encoding.
		/// </summary>
		/// <value>The text encoding.</value>
		public SKTextEncoding TextEncoding
		{
			get { return Fill.TextEncoding; }
			set
			{
				Fill.TextEncoding = value;
				Frame.TextEncoding = value;
			}
		}

		/// <summary>
		/// Gets or sets the text scale x.
		/// </summary>
		/// <value>The text scale x.</value>
		public float TextScaleX
		{
			get { return Fill.TextScaleX; }
			set
			{
				Fill.TextScaleX = value;
				Frame.TextScaleX = value;
			}
		}

		/// <summary>
		/// Gets or sets the size of the text.
		/// </summary>
		/// <value>The size of the text.</value>
		public float TextSize
		{
			get { return Fill.TextSize; }
			set
			{
				Fill.TextSize = value;
				Frame.TextSize = value;
			}
		}

		/// <summary>
		/// Gets or sets the text skew x.
		/// </summary>
		/// <value>The text skew x.</value>
		public float TextSkewX
		{
			get { return Fill.TextSkewX; }
			set
			{
				Fill.TextSkewX = value;
				Frame.TextSkewX = value;
			}
		}

		/// <summary>
		/// Gets or sets the typeface.
		/// </summary>
		/// <value>The typeface.</value>
		[Ignore]
		public SKTypeface Typeface
		{
			get { return Fill.Typeface; }
			set
			{
				Fill.Typeface = value;
				Frame.Typeface = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the font family.
		/// </summary>
		/// <value>The name of the font family.</value>
		public string FontFamilyName
		{
			get { return (Fill.Typeface == null) ? "System" : Fill.Typeface.FamilyName; }
			set
			{
				Typeface = SKTypeface.FromFamilyName(value, TypefaceStyle);
			}
		}

		/// <summary>
		/// Gets or sets the typeface style.
		/// </summary>
		/// <value>The typeface style.</value>
		public SKTypefaceStyle TypefaceStyle
		{
			get { return (Fill.Typeface == null) ? SKTypefaceStyle.Normal : Fill.Typeface.Style; }
			set
			{
				Typeface = SKTypeface.FromFamilyName(FontFamilyName, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoStyle"/> underline text.
		/// </summary>
		/// <value><c>true</c> if underline text; otherwise, <c>false</c>.</value>
		public bool UnderlineText
		{
			get { return Fill.UnderlineText; }
			set
			{
				Fill.UnderlineText = value;
				Frame.UnderlineText = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the frame jitter is used.
		/// </summary>
		/// <value><c>true</c> if has frame jitter; otherwise, <c>false</c>.</value>
		public bool HasFrameJitter
		{
			get { return _hasFrameJitter; }
			set
			{
				_hasFrameJitter = value;
				ApplyFrameEffects();
			}
		}

		/// <summary>
		/// Gets or sets the length of the frame jitter.
		/// </summary>
		/// <value>The length of the frame jitter.</value>
		public float FrameJitterLength
		{
			get { return _frameJitterLength; }
			set
			{
				_frameJitterLength = value;
				ApplyFrameEffects();
			}
		}

		/// <summary>
		/// Gets or sets the frame jitter deviation.
		/// </summary>
		/// <value>The frame jitter deviation.</value>
		public float FrameJitterDeviation
		{
			get { return _frameJitterDeviation; }
			set
			{
				_frameJitterDeviation = value;
				ApplyFrameEffects();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the fill jitter is used.
		/// </summary>
		/// <value><c>true</c> if has fill jitter; otherwise, <c>false</c>.</value>
		public bool HasFillJitter
		{
			get { return _hasFillJitter; }
			set
			{
				_hasFillJitter = value;
				ApplyFillEffects();
			}
		}

		/// <summary>
		/// Gets or sets the length of the fill jitter.
		/// </summary>
		/// <value>The length of the fill jitter.</value>
		public float FillJitterLength
		{
			get { return _fillJitterLength; }
			set
			{
				_fillJitterLength = value;
				ApplyFillEffects();
			}
		}

		/// <summary>
		/// Gets or sets the fill jitter deviation.
		/// </summary>
		/// <value>The fill jitter deviation.</value>
		public float FillJitterDeviation
		{
			get { return _fillJitterDeviation; }
			set
			{
				_fillJitterDeviation = value;
				ApplyFillEffects();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the frame has a dash.
		/// </summary>
		/// <value><c>true</c> if the frame has a dash; otherwise, <c>false</c>.</value>
		public bool HasFrameDash
		{
			get { return _hasFrameDash; }
			set
			{
				_hasFrameDash = value;
				ApplyFrameEffects();
			}
		}

		/// <summary>
		/// Gets or sets the dash pattern.
		/// </summary>
		/// <value>The dash pattern.</value>
		[Children]
		public bool[] DashPattern { get; set; } = { true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false };

		/// <summary>
		/// Gets the possible connection points that a `KimonoProperty` can be connected to this
		/// `KimonoStyle`.
		/// </summary>
		/// <value>The array of `KimonoPropertyConnectionPoint`.</value>
		[Ignore]
		public virtual KimonoPropertyConnectionPoint[] ConnectionPoints
		{
			get
			{
				// Return available connection points
				return new KimonoPropertyConnectionPoint[] {
					KimonoPropertyConnectionPoint.HasFrame,
					KimonoPropertyConnectionPoint.HasFrameBlur,
					KimonoPropertyConnectionPoint.FrameHorizontalBlurAmount,
					KimonoPropertyConnectionPoint.FrameVerticalBlurAmount,
					KimonoPropertyConnectionPoint.HasFrameShadow,
					KimonoPropertyConnectionPoint.FrameShadowHorizontalOffset,
					KimonoPropertyConnectionPoint.FrameShadowVerticalOffset,
					KimonoPropertyConnectionPoint.FrameShadowHorizontalBlurAmount,
					KimonoPropertyConnectionPoint.FrameShadowVerticalBlurAmount,
					KimonoPropertyConnectionPoint.FrameShadowLinkedColor,
					KimonoPropertyConnectionPoint.HasFill,
					KimonoPropertyConnectionPoint.HasFillBlur,
					KimonoPropertyConnectionPoint.FillHorizontalBlurAmount,
					KimonoPropertyConnectionPoint.FillVerticalBlurAmount,
					KimonoPropertyConnectionPoint.HasFillShadow,
					KimonoPropertyConnectionPoint.FillShadowHorizontalOffset,
					KimonoPropertyConnectionPoint.FillShadowVerticalOffset,
					KimonoPropertyConnectionPoint.FillShadowHorizontalBlurAmount,
					KimonoPropertyConnectionPoint.FillShadowVerticalBlurAmount,
					KimonoPropertyConnectionPoint.FillShadowLinkedColor,
					KimonoPropertyConnectionPoint.FrameColor,
					KimonoPropertyConnectionPoint.FrameGradient,
					KimonoPropertyConnectionPoint.FillColor,
					KimonoPropertyConnectionPoint.FillGradient,
					KimonoPropertyConnectionPoint.IsVerticalText,
					KimonoPropertyConnectionPoint.StrikeThruText,
					KimonoPropertyConnectionPoint.TextScaleX,
					KimonoPropertyConnectionPoint.TextSize,
					KimonoPropertyConnectionPoint.TextSkewX,
					KimonoPropertyConnectionPoint.FontFamilyName,
					KimonoPropertyConnectionPoint.UnderlineText,
					KimonoPropertyConnectionPoint.HasFrameJitter,
					KimonoPropertyConnectionPoint.FrameJitterLength,
					KimonoPropertyConnectionPoint.FrameJitterDeviation,
					KimonoPropertyConnectionPoint.HasFillJitter,
					KimonoPropertyConnectionPoint.FillJitterLength,
					KimonoPropertyConnectionPoint.FillJitterDeviation,
					KimonoPropertyConnectionPoint.HasFrameDash
				};
			}
		}

		/// <summary>
		/// Gets or sets the list of `KimonoProperty` objects connected to the various 
		/// `KimonoPropertyConnectionPoint`s that will need to be evaulated before drawing
		/// this `KimonoShape`.
		/// </summary>
		/// <value>The property connections.</value>
		[Children]
		public List<KimonoPropertyConnection> PropertyConnections { get; set; } = new List<KimonoPropertyConnection>();
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoStyle"/> class.
		/// </summary>
		public KimonoStyle()
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set default values
			Frame.Style = SKPaintStyle.Stroke;
			Frame.StrokeWidth = 1;
			Frame.Color = KimonoColor.Black;
			Frame.IsAntialias = true;
			FrameBlur = new KimonoBlur();
			FrameShadow = new KimonoShadow();

			Fill.Style = SKPaintStyle.Fill;
			Fill.Color = KimonoColor.Mercury;
			Fill.IsAntialias = true;
			FillBlur = new KimonoBlur();
			FillShadow = new KimonoShadow();
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Handles the frame blur change.
		/// </summary>
		private void HandleFrameBlurOrShadowChange()
		{
			SKImageFilter blur;
			SKImageFilter shadow;

			// Is there an active filter?
			if (FrameBlur == null || !HasFrameBlur)
			{
				// No, remove
				blur = null;
			}
			else
			{
				// Yes, include the filter
				blur = FrameBlur.BlurFilter;
			}

			// Is there an active shadow filter?
			if (FrameShadow == null || !HasFrameShadow)
			{
				// No, remove
				shadow = null;
			}
			else
			{
				// Yes, include filter
				shadow = FrameShadow.ShadowFilter;
			}

			// Apply filters
			if (blur != null && shadow != null)
			{
				// Combine both filters
				Frame.ImageFilter = SKImageFilter.CreateCompose(shadow, blur);
			}
			else if (blur != null)
			{
				// Apply blur
				Frame.ImageFilter = blur;
			}
			else if (shadow != null)
			{
				// Apply shadow
				Frame.ImageFilter = shadow;
			}
			else
			{
				// Clear all filters
				Frame.ImageFilter = null;
			}
		}

		/// <summary>
		/// Handles the fill blur change.
		/// </summary>
		private void HandleFillBlurOrShadowChange()
		{
			SKImageFilter blur;
			SKImageFilter shadow;

			// Is there an active blur filter?
			if (FillBlur == null || !HasFillBlur)
			{
				// No, remove
				blur = null;
			}
			else
			{
				// Yes, include the filter
				blur = FillBlur.BlurFilter;
			}

			// Is there an active shadow filter?
			if (FillShadow == null || !HasFillShadow)
			{
				// No, remove
				shadow = null;
			}
			else
			{
				// Yes, include filter
				shadow = FillShadow.ShadowFilter;
			}

			// Apply filters
			if (blur != null && shadow != null)
			{
				// Combine both filters
				Fill.ImageFilter = SKImageFilter.CreateCompose(shadow, blur);
			}
			else if (blur != null)
			{
				// Apply blur
				Fill.ImageFilter = blur;
			}
			else if (shadow != null)
			{
				// Apply shadow
				Fill.ImageFilter = shadow;
			}
			else
			{
				// Clear all filters
				Fill.ImageFilter = null;
			}
		}


		/// <summary>
		/// Handles the frame color change.
		/// </summary>
		private void HandleFrameColorChange()
		{
			// Get new color from attached color
			Frame.Color = FrameColor.Color;
		}

		/// <summary>
		/// Handles the fill color change.
		/// </summary>
		private void HandleFillColorChange()
		{
			// Get new color from attached color
			Fill.Color = FillColor.Color;
		}

		/// <summary>
		/// Handles the frame gradient change.
		/// </summary>
		private void HandleFrameGradientChange()
		{
			// Get new gradient
			Frame.Shader = FrameGradient.Shader;
		}

		/// <summary>
		/// Handles the fill gradient change.
		/// </summary>
		private void HandleFillGradientChange()
		{
			// Get new gradient
			Fill.Shader = FillGradient.Shader;
		}

		/// <summary>
		/// Makes the dash interval from the dash pattern.
		/// </summary>
		/// <returns>The dash interval.</returns>
		private List<float> MakeDashInterval()
		{
			List<float> intervals = new List<float>();

			// Initialize
			var len = 0;
			var pattern = DashPattern[0];

			// Is the first block off?
			if (!pattern)
			{
				// Yes, insert a dot to start everything off
				intervals.Add(1);
			}

			// Count intervals
			foreach (bool v in DashPattern)
			{
				// Still in same pattern?
				if (v == pattern)
				{
					++len;
				}
				else
				{
					// Save pattern run
					intervals.Add(len);
					len = 1;
					pattern = v;
				}
			}

			// Save final pattern
			intervals.Add(len);

			// Even pattern number?
			if (intervals.Count % 2 != 0)
			{
				// No, make pattern even
				intervals.Add(1);
			}

			// Return results
			return intervals;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Connects the given `KimonoProperty` to the given `KimonoPropertyConnectionPoint` on
		/// this `KimonoStyle`.
		/// </summary>
		/// <param name="connectionPoint">The `KimonoPropertyConnectionPoint` to connect to.</param>
		/// <param name="property">The `KimonoProperty` to connect.</param>
		public virtual void AddPropertyConnection(KimonoPropertyConnectionPoint connectionPoint, KimonoProperty property)
		{
			// Is this connection point already used?
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Found?
				if (connection.ConnectionPoint == connectionPoint)
				{
					// Yes, replace the connected property
					connection.ConnectedProperty = property;
					return;
				}
			}

			// Not found, add
			PropertyConnections.Add(new KimonoPropertyConnection(connectionPoint, property));
		}

		/// <summary>
		/// Removes the property connection.
		/// </summary>
		/// <param name="connection">The `KimonoPropertyConnection` to remove.</param>
		public virtual void RemovePropertyConnection(KimonoPropertyConnection connection)
		{
			// Remove the connection from the collection
			PropertyConnections.Remove(connection);
		}

		/// <summary>
		/// Removes any connection using this property.
		/// </summary>
		/// <param name="property">The `KimonoProperty` to remove.</param>
		public virtual void RemoveProperty(KimonoProperty property)
		{
			// Remove any connection that is using this property
			for (int n = PropertyConnections.Count - 1; n >= 0; --n)
			{
				// Grab the connection
				var connection = PropertyConnections[n];

				// Found match?
				if (connection.ConnectedProperty == property)
				{
					// Yes, break this connection
					PropertyConnections.RemoveAt(n);
				}
			}
		}

		/// <summary>
		/// Evaluates all of the `KimonoProperty` objects attached to this `KimonoStyle` by
		/// executling their Obi Scripts and updating the values with the results.
		/// </summary>
		public virtual void EvaluateConnectedProperties()
		{
			// Process all property connections
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Evaluate the connection by executing any Obi Script
				// attached to it
				var result = connection.ConnectedProperty.Evaluate();

				// Did the script run successfully?
				if (result.Successful)
				{
					// Update the connected item on this shape
					UpdatePropertyConnectionPoint(connection);
				}
			}

			// Evaluate colors too
			//FillColor?.EvaluateConnectedProperties();
			//FrameColor?.EvaluateConnectedProperties();
			if (FillColor != null) HandleFillColorChange();
			if (FrameColor != null) HandleFrameColorChange();
		}

		/// <summary>
		/// Updates a `KimonoPropertyConnectionPoint` on this `KimonoStyle` with the results
		/// of a Obi Script run on an attached `KimonoProperty`.
		/// </summary>
		/// <param name="connection">Connection.</param>
		public virtual void UpdatePropertyConnectionPoint(KimonoPropertyConnection connection)
		{
			// Take action based on the connection point
			switch (connection.ConnectionPoint)
			{
				case KimonoPropertyConnectionPoint.HasFrame:
					HasFrame = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.HasFrameBlur:
					HasFrameBlur = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.FrameHorizontalBlurAmount:
					FrameBlur.HorizontalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FrameVerticalBlurAmount:
					FrameBlur.VerticalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.HasFrameShadow:
					HasFrameShadow = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.FrameShadowHorizontalOffset:
					FrameShadow.HorizontalOffset = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FrameShadowVerticalOffset:
					FrameShadow.VerticalOffset = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FrameShadowHorizontalBlurAmount:
					FrameShadow.HorizontalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FrameShadowVerticalBlurAmount:
					FrameShadow.VerticalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FrameShadowLinkedColor:
					FrameShadow.LinkedColor = connection.ConnectedProperty.ToColor();
					break;
				case KimonoPropertyConnectionPoint.HasFill:
					HasFill = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.HasFillBlur:
					HasFillBlur = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.FillHorizontalBlurAmount:
					FillBlur.HorizontalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FillVerticalBlurAmount:
					FillBlur.VerticalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.HasFillShadow:
					HasFillShadow = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.FillShadowHorizontalOffset:
					FillShadow.HorizontalOffset = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FillShadowVerticalOffset:
					FillShadow.VerticalOffset = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FillShadowHorizontalBlurAmount:
					FillShadow.HorizontalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FillShadowVerticalBlurAmount:
					FillShadow.VerticalBlurAmount = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FillShadowLinkedColor:
					FillShadow.LinkedColor = connection.ConnectedProperty.ToColor();
					break;
				case KimonoPropertyConnectionPoint.FrameColor:
					FrameColor = connection.ConnectedProperty.ToColor();
					break;
				case KimonoPropertyConnectionPoint.FrameGradient:
					FrameGradient = connection.ConnectedProperty.ToGradient();
					break;
				case KimonoPropertyConnectionPoint.FillColor:
					FillColor = connection.ConnectedProperty.ToColor();
					break;
				case KimonoPropertyConnectionPoint.FillGradient:
					FillGradient = connection.ConnectedProperty.ToGradient();
					break;
				case KimonoPropertyConnectionPoint.IsVerticalText:
					IsVerticalText = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.StrikeThruText:
					StrikeThruText = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.TextScaleX:
					TextScaleX = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.TextSize:
					TextSize = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.TextSkewX:
					TextSkewX = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FontFamilyName:
					FontFamilyName = connection.ConnectedProperty.ToString();
					break;
				case KimonoPropertyConnectionPoint.UnderlineText:
					UnderlineText = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.HasFrameJitter:
					HasFrameJitter = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.FrameJitterLength:
					FrameJitterLength = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FrameJitterDeviation:
					FrameJitterDeviation = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.HasFillJitter:
					HasFillJitter = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.FillJitterLength:
					FillJitterLength = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.FillJitterDeviation:
					FillJitterDeviation = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.HasFrameDash:
					HasFrameDash = connection.ConnectedProperty.ToBool();
					break;
			}
		}

		/// <summary>
		/// Applies the frame effects based on the style settings.
		/// </summary>
		public void ApplyFrameEffects()
		{
			SKPathEffect jitterEffect = null;
			SKPathEffect dashEffect = null;

			// Build effects
			if (HasFrameJitter)
			{
				jitterEffect = SKPathEffect.CreateDiscrete(FrameJitterLength, FrameJitterDeviation);
			}
			if (HasFrameDash)
			{
				var intervals = MakeDashInterval();
				dashEffect = SKPathEffect.CreateDash(intervals.ToArray(), 0);
			}

			// Apply effects
			if (jitterEffect != null && dashEffect != null)
			{
				Frame.PathEffect = SKPathEffect.CreateCompose(dashEffect, jitterEffect);
			}
			else if (jitterEffect != null)
			{
				Frame.PathEffect = jitterEffect;
			}
			else if (dashEffect != null)
			{
				Frame.PathEffect = dashEffect;
			}
			else
			{
				Frame.PathEffect = null;
			}
		}

		/// <summary>
		/// Applies the fill effects based on the style settings.
		/// </summary>
		public void ApplyFillEffects()
		{
			SKPathEffect jitterEffect = null;
			SKPathEffect dashEffect = null;

			// Build effects
			if (HasFillJitter)
			{
				jitterEffect = SKPathEffect.CreateDiscrete(FillJitterLength, FillJitterDeviation);
			}

			// Apply effects
			if (jitterEffect != null && dashEffect != null)
			{
				Fill.PathEffect = SKPathEffect.CreateCompose(jitterEffect, dashEffect);
			}
			else if (jitterEffect != null)
			{
				Fill.PathEffect = jitterEffect;
			}
			else if (dashEffect != null)
			{
				Fill.PathEffect = dashEffect;
			}
			else
			{
				Fill.PathEffect = null;
			}
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Checks to see if a property is attached to the given connection point. If so, the
		/// property is used in code generation, else the default code is used.
		/// </summary>
		/// <returns>The source code for the possible connection point.</returns>
		/// <param name="connectionPoint">The `KimonoPropertyConnectionPoint` to test for a connection.</param>
		/// <param name="defaultCode">The default source code that will be used if no code is attached to the given point.</param>
		public virtual string CheckForConnection(KimonoPropertyConnectionPoint connectionPoint, string defaultCode)
		{
			// Scan for used properties
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Is there an active connection to the given point?
				if (connection.ConnectionPoint == connectionPoint)
				{
					// Yes, add this property and return its name
					return KimonoCodeGenerator.AddSupportingProperty(connection.ConnectedProperty);
				}
			}

			// Not found, use the default code
			return defaultCode;
		}

		/// <summary>
		/// Converts all connected points to KimonoCore source code objects.
		/// </summary>
		/// <returns>The code to rebuild the connections are source code.</returns>
		public virtual string ConnectionsToKimonoCore()
		{
			var sourceCode = "";

			// Anything to process?
			if (PropertyConnections.Count < 1) return "";

			// Start list
			sourceCode += $"// Property connections for {Name}.\n";

			// Process all connections
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Accumulate the connection point
				KimonoCodeGenerator.AddSupportingProperty(connection.ConnectedProperty);

				// Add code for point
				sourceCode += $"{ElementName}.PropertyConnections.Add(new KimonoPropertyConnection(KimonoPropertyConnectionPoint.{connection.ConnectionPoint} , {connection.ConnectedProperty.ElementName}));\n";
			}

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this object to Obi Script represnetation.
		/// </summary>
		/// <returns>The obi script.</returns>
		public virtual string ToObiScript()
		{
			var sourceCode = "";

			// Generate code
			sourceCode = "// Obi Script Selector for this style\n";
			sourceCode += $"Return.Style(\"{Name}\");\n";

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts the shapes path to C# Skia based code.
		/// </summary>
		/// <returns>The path as code.</returns>
		public virtual string ToSkiaSharpPath()
		{
			return "";
		}


		/// <summary>
		/// Converts the shape to C# code using the Skia library.
		/// </summary>
		/// <returns>The shape as code.</returns>
		public virtual string ToSkiaSharp()
		{
			return "";
		}

		/// <summary>
		/// Converts this style's Fill to C# code using the Skia library.
		/// </summary>
		/// <returns>The Fill `SKPaint` as code.</returns>
		public virtual string FillToSkiaCode()
		{
			var sourceCode = "";

			// Build code
			sourceCode += FillToSkiaInitializer(true);

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this style's Fill to C# code using the Skia library.
		/// </summary>
		/// <returns>The Fill `SKPaint` as code.</returns>
		public virtual string FillToSkiaInitializer(bool constructor)
		{
			var sourceCode = "";
			var preCode = "";
			var colorName = "";

			// Using linked color?
			if (FillColor == null)
			{
				// Save color name
				colorName = $"{ElementName}FillColor";

				// No, generate a one off color
				sourceCode += $"// Fill color for {Name}\n" +
					$"var {colorName} = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, Fill.Color)};\n\n";
			}
			else
			{
				// Save linked color
				colorName = KimonoCodeGenerator.AddSupportingColor(FillColor);
			}

			var action = (constructor) ? "New" : "Initialize";
			var prefix = (constructor) ? "var " : "";

			// Assemble paint
			sourceCode += $"// {action} {Name} fill paint\n" +
				$"{prefix}{ElementName}FillPaint = new SKPaint()" + "{" +
				$"\n\tStyle = SKPaintStyle.Fill" +
				$",\n\tColor = {colorName}" +
				$",\n\tBlendMode = SKBlendMode.{Fill.BlendMode}" +
				$",\n\tIsAntialias = {Fill.IsAntialias.ToString().ToLower()}";

			// Has gradient?
			if (FillGradient != null)
			{
				// Yes, include
				sourceCode += $",\n\tShader = {KimonoCodeGenerator.AddSupportingGradient(FillGradient)}";
			}

			// Has Jitter Effect?
			if (HasFillJitter)
			{
				// Yes, include
				sourceCode += $",\n\tPathEffect = SKPathEffect.CreateDiscrete({FillJitterLength}f, {FillJitterDeviation}f)";
			}

			// Prepare for image effects
			var shadowEffect = "";
			var blurEffect = "";

			// Build Shadow if required
			if (HasFillShadow)
			{
				// Assign the same element name
				FillShadow.Name = $"{ElementName}Fill";

				// Add elements
				shadowEffect = $"{FillShadow.Name}Shadow";
				preCode += FillShadow.ToSkiaSharp() + "\n";
			}

			// Build blur if required
			if (HasFillBlur && (FillBlur.HorizontalBlurAmount > 0 || FillBlur.VerticalBlurAmount > 0))
			{
				// Assign the same element name
				FillBlur.Name = $"{ElementName}Fill";

				// Add elements
				blurEffect = $"{FillBlur.Name}Blur";
				preCode += FillBlur.ToSkiaSharp() + "\n";
			}

			// Apply blur and shadow
			if (blurEffect != "" && shadowEffect != "")
			{
				sourceCode += $",\n\tImageFilter = SKImageFilter.CreateCompose({shadowEffect}, {blurEffect})";
			}
			else if (blurEffect != "")
			{
				sourceCode += $",\n\tImageFilter = {blurEffect}";
			}
			else if (shadowEffect != "")
			{
				sourceCode += $",\n\tImageFilter = {shadowEffect}";
			}

			// Is text Style?
			if (StyleType == KimonoStyleType.CustomText || StyleType == KimonoStyleType.Text)
			{
				// Yes, include text properties
				sourceCode += $",\n\tTypeface = SKTypeface.FromFamilyName(\"{FontFamilyName}\", SKTypefaceStyle.{TypefaceStyle})" +
					$",\n\tTextSize = {Fill.TextSize}f" +
					$",\n\tTextAlign = SKTextAlign.{Fill.TextAlign}" +
					$",\n\tStrikeThruText = {Fill.StrikeThruText.ToString().ToLower()}" +
					$",\n\tUnderlineText = {Fill.UnderlineText.ToString().ToLower()}" +
					$",\n\tIsVerticalText = {Fill.IsVerticalText.ToString().ToLower()}" +
					$",\n\tTextScaleX = {Fill.TextScaleX}f" +
					$",\n\tTextSkewX = {Fill.TextSkewX}f";
			}

			// Finalize paint
			sourceCode += "};\n\n";

			// Apply any precode
			sourceCode = preCode + sourceCode;

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this style's Frame to C# code using the Skia library.
		/// </summary>
		/// <returns>The Frame `SKPaint` as code.</returns>
		public virtual string FrameToSkiaCode()
		{
			var sourceCode = "";

			// Add body
			sourceCode += FrameToSkiaInitializer(true);

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this style's Frame to C# code using the Skia library.
		/// </summary>
		/// <returns>The Frame `SKPaint` as code.</returns>
		public virtual string FrameToSkiaInitializer(bool constructor)
		{
			var sourceCode = "";
			var preCode = "";
			var colorName = "";

			// Using linked color?
			if (FrameColor == null)
			{
				// Save color name
				colorName = $"{ElementName}FrameColor";

				// No, generate a one off color
				sourceCode += $"// Frame color for {Name}\n" +
					$"var {colorName} = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, Frame.Color)};\n\n";
			}
			else
			{
				// Save linked color
				colorName = KimonoCodeGenerator.AddSupportingColor(FrameColor);
			}

			var action = (constructor) ? "New" : "Initialize";
			var prefix = (constructor) ? "var " : "";
			var joinType = (Frame.StrokeJoin == SKStrokeJoin.Miter) ? "Miter" : Frame.StrokeJoin.ToString();

			// Assemble paint
			sourceCode += $"// {action} {Name} frame paint\n" +
				$"{prefix}{ElementName}FramePaint = new SKPaint()" + "{" +
				$"\n\tStyle = SKPaintStyle.Stroke" +
				$",\n\tColor = {colorName}" +
				$",\n\tBlendMode = SKBlendMode.{Frame.BlendMode}" +
				$",\n\tIsAntialias = {Frame.IsAntialias.ToString().ToLower()}" +
				$",\n\tStrokeWidth = {Frame.StrokeWidth}f" +
				$",\n\tStrokeMiter = {Frame.StrokeMiter}f" +
				$",\n\tStrokeJoin = SKStrokeJoin.{joinType}" +
				$",\n\tStrokeCap = SKStrokeCap.{Frame.StrokeCap}";
			
			// Has gradient?
			if (FrameGradient != null)
			{
				// Yes, include
				sourceCode += $",\n\tShader = {KimonoCodeGenerator.AddSupportingGradient(FrameGradient)}";
			}

			var jitterEffect = "";
			var dashEffect = "";

			// Needs dash precode?
			if (HasFrameDash)
			{
				// Yes, construct intervals
				preCode += $"// Dash Interval for {Name} Frame\n";
				var intervals = MakeDashInterval();
				var start = true;

				// Process all intervals
				preCode += $"var float[] {ElementName}DashIntervals = " + "{";
				foreach (float interval in intervals)
				{
					// At start of list?
					if (!start) preCode += ", ";

					// Add interval
					preCode += $"{interval}f";

					// Set state
					start = false;
				}
				preCode += "};\n\n";

				// Assemble dash
				dashEffect = $"SKPathEffect.CreateDash({ElementName}DashIntervals, 0)";
			}

			// Needs Jitter precode?
			if (HasFrameJitter)
			{
				// Assemble jitter
				jitterEffect = $"SKPathEffect.CreateDiscrete({FrameJitterLength}f, {FrameJitterDeviation}f)";
			}

			// Apply Jitter and Dash effects to paint
			if (HasFrameJitter && HasFrameDash)
			{
				sourceCode += $",\n\tPathEffect = SKPathEffect.CreateCompose({dashEffect}, {jitterEffect})";
			}
			else if (HasFrameJitter)
			{
				sourceCode += $",\n\tPathEffect = {jitterEffect}";
			}
			else if (HasFrameDash)
			{
				sourceCode += $",\n\tPathEffect = {dashEffect}";
			}

			// Prepare for image effects
			var shadowEffect = "";
			var blurEffect = "";

			// Build Shadow if required
			if (HasFrameShadow)
			{
				// Assign the same element name
				FrameShadow.Name = $"{ElementName}Frame";

				// Add elements
				shadowEffect = $"{FrameShadow.Name}Shadow";
				preCode += FrameShadow.ToSkiaSharp() + "\n";
			}

			// Build blur if required
			if (HasFrameBlur && (FrameBlur.HorizontalBlurAmount > 0 || FrameBlur.VerticalBlurAmount > 0))
			{
				// Assign the same element name
				FrameBlur.Name = $"{ElementName}Frame";

				// Add elements
				blurEffect = $"{FrameBlur.Name}Blur";
				preCode += FrameBlur.ToSkiaSharp() + "\n";
			}

			// Apply blur and shadow
			if (blurEffect != "" && shadowEffect != "")
			{
				sourceCode += $",\n\tImageFilter = SKImageFilter.CreateCompose({shadowEffect}, {blurEffect})";
			}
			else if (blurEffect != "")
			{
				sourceCode += $",\n\tImageFilter = {blurEffect}";
			}
			else if (shadowEffect != "")
			{
				sourceCode += $",\n\tImageFilter = {shadowEffect}";
			}

			// Is text Style?
			if (StyleType == KimonoStyleType.CustomText || StyleType == KimonoStyleType.Text)
			{
				// Yes, include text properties
				sourceCode += $",\n\tTypeface = SKTypeface.FromFamilyName(\"{FontFamilyName}\", SKTypefaceStyle.{TypefaceStyle})" +
					$",\n\tTextSize = {Frame.TextSize}f" +
					$",\n\tTextAlign = SKTextAlign.{Frame.TextAlign}" +
					$",\n\tStrikeThruText = {Frame.StrikeThruText.ToString().ToLower()}" +
					$",\n\tUnderlineText = {Frame.UnderlineText.ToString().ToLower()}" +
					$",\n\tIsVerticalText = {Frame.IsVerticalText.ToString().ToLower()}" +
					$",\n\tTextScaleX = {Frame.TextScaleX}f" +
					$",\n\tTextSkewX = {Frame.TextSkewX}f";
			}

			// Finalize paint
			sourceCode += "};\n\n";

			// Apply any precode
			sourceCode = preCode + sourceCode;

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this style to C# code using the KimonoCore library.
		/// </summary>
		/// <returns>The kimono core.</returns>
		public virtual string ToKimonoCore()
		{
			var sourceCode = "";

			// Build body
			sourceCode += ToKimonoCoreInitializer(true);

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this style to C# code using the KimonoCore library.
		/// </summary>
		/// <returns>The kimono core.</returns>
		public virtual string ToKimonoCoreInitializer(bool constructor)
		{
			var sourceCode = "";
			var preCode = "";

			var action = (constructor) ? "Build new" : "Initialize";
			var prefix = (constructor) ? "var " : "";

			// Assemble code
			sourceCode += $"// {action} {Name}\n" +
				$"{prefix}{ElementName} = new KimonoStyle()" + "{" +
				$"\n\tStyleType = KimonoStyleType.{StyleType}";

			// Has fill?
			if (HasFill)
			{
				// Yes, include fill code
				sourceCode += $",\n\tHasFill = true";

				// Has gradient?
				if (FillGradient != null)
				{
					// Accumulate supporting gradient
					sourceCode += $",\n\tFillGradient = {KimonoCodeGenerator.AddSupportingGradient(FillGradient)}";
				}

				// Has Jitter Effect?
				if (HasFillJitter)
				{
					// Yes, include
					sourceCode += $",\n\tHasFillJitter = true" +
						$",\n\tFillJitterLength = {FillJitterLength}f" +
						$",\n\tFillJitterDeviation = {FillJitterDeviation}f";
				}

				// Assemble parts
				sourceCode += $",\n\tFillBlendMode = SKBlendMode.{FillBlendMode}" +
					$",\n\tFillIsAntiAlias = {FillIsAntiAlias.ToString().ToLower()}";

				// Linked color?
				if (FillColor == null)
				{
					// Add direct color
					sourceCode += $",\n\tFillBaseColor = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, FillBaseColor)}";
				}
				else
				{
					// Accumulate supporting color
					sourceCode += $",\n\tFillColor = {KimonoCodeGenerator.AddSupportingColor(FillColor)}";
				}

				// Has Blur?
				if (HasFillBlur)
				{
					// Yes, include
					sourceCode += $",\n\tHasFillBlur = true" +
						$",\n\tFillBlurHorizontalAmount = {FillBlurHorizontalAmount}f" +
						$",\n\tFillBlurVerticalAmount = {FillBlurVerticalAmount}f";
				}

				// Has shadow?
				if (HasFillShadow)
				{
					// Yes, include
					sourceCode += $",\n\tHasFillShadow = true" +
						$",\n\tFillShadowHorizontalOffset = {FillShadowHorizontalOffset}f" +
						$",\n\tFillShadowVerticalOffset = {FillShadowVerticalOffset}f" +
						$",\n\tFillShadowHorizontalBlur = {FillShadowHorizontalBlur}f" +
						$",\n\tFillShadowVerticalBlur = {FillShadowVerticalBlur}f";

					// Linked color?
					if (FillShadow.LinkedColor == null)
					{
						// Add direct color
						sourceCode += $",\n\tFillShadowBaseColor = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, FillShadowBaseColor)}";
					}
					else
					{
						// Accumulate supporting color
						sourceCode += $",\n\tFillShadowLinkedColor = {KimonoCodeGenerator.AddSupportingColor(FillShadowLinkedColor)}";
					}
				}
			}

			// Has Frame?
			if (HasFrame)
			{
				// Yes, include fill code
				sourceCode += $",\n\tHasFrame = true";

				// Has gradient?
				if (FrameGradient != null)
				{
					// Accumulate supporting gradient
					sourceCode += $",\n\tFrameGradient = {KimonoCodeGenerator.AddSupportingGradient(FrameGradient)}";
				}

				// Has Jitter Effect?
				if (HasFrameJitter)
				{
					// Yes, include
					sourceCode += $",\n\tHasFrameJitter = true" +
						$",\n\tFrameJitterLength = {FrameJitterLength}f" +
						$",\n\tFrameJitterDeviation = {FrameJitterDeviation}f";
				}

				// Assemble parts
				sourceCode += $",\n\tFrameBlendMode = SKBlendMode.{FrameBlendMode}" +
					$",\n\tFrameIsAntialias = {FrameIsAntialias.ToString().ToLower()}" +
					$",\n\tFrameStrokeWidth = {FrameStrokeWidth}f" +
					$",\n\tFrameStrokeMiter = {FrameStrokeMiter}f" +
					$",\n\tFrameStrokeJoin = SKStrokeJoin.{FrameStrokeJoin}" +
					$",\n\tFrameStrokeCap = SKStrokeCap.{FrameStrokeCap}";

				// Has dash effect?
				if (HasFrameDash)
				{
					// Yes, include
					sourceCode += $",\n\tHasFrameDash = true";
				}

				// Linked color?
				if (FrameColor == null)
				{
					// Add direct color
					sourceCode += $",\n\tFrameBaseColor = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, FrameBaseColor)}";
				}
				else
				{
					// Accumulate supporting color
					sourceCode += $",\n\tFrameColor = {KimonoCodeGenerator.AddSupportingColor(FrameColor)};\n";
				}

				// Has Blur?
				if (HasFrameBlur)
				{
					// Yes, include
					sourceCode += $",\n\tHasFrameBlur = true" +
						$",\n\tFrameBlurHorizontalAmount = {FrameBlurHorizontalAmount}f" +
						$",\n\tFrameBlurHorizontalAmount = {FrameBlurHorizontalAmount}f";
				}

				// Has shadow?
				if (HasFrameShadow)
				{
					// Yes, include
					sourceCode += $",\n\tHasFrameShadow = true" +
						$",\n\tFrameShadowHorizontalOffset = {FrameShadowHorizontalOffset}f" +
						$",\n\tFrameShadowVerticalOffset = {FrameShadowVerticalOffset}f" +
						$",\n\tFrameShadowHorizontalBlur = {FrameShadowHorizontalBlur}f" +
						$",\n\tFrameShadowVerticalBlur = {FrameShadowVerticalBlur}f";

					// Linked color?
					if (FrameShadow.LinkedColor == null)
					{
						// Add direct color
						sourceCode += $",\n\tFrameShadowBaseColor = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, FrameShadowBaseColor)}";
					}
					else
					{
						// Accumulate supporting color
						sourceCode += $",\n\tFrameShadowLinkedColor = {KimonoCodeGenerator.AddSupportingColor(FrameShadowLinkedColor)}";
					}
				}
			}

			// Is text Style?
			if (StyleType == KimonoStyleType.CustomText || StyleType == KimonoStyleType.Text)
			{
				// Yes, include text properties
				sourceCode += $",\n\tFontFamilyName = \"{FontFamilyName}\"" +
					$",\n\tTypefaceStyle = SKTypefaceStyle.{TypefaceStyle}" +
					$",\n\tTextSize = {TextSize}f" +
					$",\n\tTextAlign = SKTextAlign.{TextAlign}" +
					$",\n\tStrikeThruText = {StrikeThruText.ToString().ToLower()}" +
					$",\n\tUnderlineText = {UnderlineText.ToString().ToLower()}" +
					$",\n\tIsVerticalText = {IsVerticalText.ToString().ToLower()}" +
					$",\n\tTextScaleX = {TextScaleX}f" +
					$",\n\tTextSkewX = {TextSkewX}f";
			}

			// Finalize style
			sourceCode += "};\n";

			// Has dash effect?
			if (HasFrame && HasFrameDash)
			{
				// Yes, include
				sourceCode += $"// Dash pattern for {Name} frame\n";
				for (int n = 0; n < DashPattern.Length; ++n)
				{
					// Accumulate pattern
					sourceCode += $"{ElementName}.DashPattern[{n}] = {DashPattern[n].ToString().ToLower()};\n";
				}
			}

			// Close configuration section?
			if (HasFill || HasFrame)
			{
				sourceCode += $"\n";
			}

			// Apply any precode
			sourceCode = preCode + sourceCode;

			// Add any connections
			var connections = ConnectionsToKimonoCore();
			if (connections != null)
			{
				sourceCode += $"\n{connections}\n";
			}

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this styl to C# code.
		/// </summary>
		/// <returns>The style as code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to generate code in.</param>
		public virtual string ToCSharp(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Take action based on the library
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					// Assemble bits
					if (HasFill) sourceCode += FillToSkiaCode();
					if (HasFrame) sourceCode += FrameToSkiaCode();
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += ToKimonoCore();
					break;
			}

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this styl to C# code.
		/// </summary>
		/// <returns>The style as code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to generate code in.</param>
		public virtual string ToCSharpInitializer(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Take action based on the library
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					// Assemble bits
					if (HasFill) sourceCode += FillToSkiaInitializer(false);
					if (HasFrame) sourceCode += FrameToSkiaInitializer(false);
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += ToKimonoCoreInitializer(false);
					break;
			}

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this object to source code for the given OS, Language and Library.
		/// </summary>
		/// <returns>The object represented as source code in a `string`.</returns>
		/// <param name="outputOS">The `CodeOutputOS`.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage`.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary`.</param>
		public virtual string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";
			var preCode = "";

			// Create code name
			ElementName = KimonoCodeGenerator.MakeElementName(Name);

			// Take action based on the output language
			switch (outputLanguage)
			{
				case CodeOutputLanguage.CSharp:
					sourceCode += ToCSharp(outputLibrary);
					break;
				case CodeOutputLanguage.ObiScript:
					sourceCode += ToObiScript();
					break;
			}

			// Assemble precode items in reverse order to ensure dependencies are registered first
			preCode = KimonoCodeGenerator.CodeForSupportGradients(outputLanguage, outputLibrary);
			preCode = KimonoCodeGenerator.CodeForSupportingColors(outputLanguage, outputLibrary) + preCode;

			// Include any supporting elements
			sourceCode = preCode + sourceCode;

			// Return resulting code
			return sourceCode;
		}

        /// <summary>
        /// Visitor pattern: returns results of double-dispatch to code generator
        /// </summary>
        /// <returns>The code from the code generator visitor.</returns>
        /// <param name="visitor">A code generator.</param>
        /// <remarks>Note that implementation is always just `=>visitor.CodeGen(this)`</remarks>
        public string ToCode (IVisitorCodeGen visitor) => visitor.CodeGen (this);

		#endregion

		#region Cloning
		/// <summary>
		/// Clones the <c>KimonoStyle</c>.
		/// </summary>
		/// <returns>The a clone of the <c>KimonoStyle</c>.</returns>
		/// <param name="deepClone">If set to <c>true</c>, a deep clone of the style is made.</param>
		public KimonoStyle Clone(bool deepClone)
		{
			// Create new style and copy elements of existing style
			var newStyle = new KimonoStyle()
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				HasFill = this.HasFill,
				Fill = ClonePaint(this.Fill),
				FillColor = this.FillColor,
				HasFrame = this.HasFrame,
				Frame = ClonePaint(this.Frame),
				FrameColor = this.FrameColor,
				StyleType = this.StyleType,
				HasFrameJitter = this.HasFrameJitter,
				FrameJitterLength = this.FrameJitterLength,
				FrameJitterDeviation = this.FrameJitterDeviation,
				HasFillJitter = this.HasFillJitter,
				FillJitterLength = this.FillJitterLength,
				FillJitterDeviation = this.FillJitterDeviation,
				HasFrameDash = this.HasFrameDash,
				DashPattern = this.DashPattern,
				FrameGradient = this.FrameGradient?.Clone(),
				FillGradient = this.FillGradient?.Clone(),
				HasFillBlur = this.HasFillBlur,
				FillBlur = this.FillBlur?.Clone(),
				HasFrameBlur = this.HasFillBlur,
				FrameBlur = this.FrameBlur?.Clone(),
				HasFillShadow = this.HasFillShadow,
				FillShadow = this.FillShadow?.Clone(),
				HasFrameShadow = this.HasFrameShadow,
				FrameShadow = this.FrameShadow?.Clone()
			};

			// Are we deep cloning a default style?
			if (!deepClone && newStyle.StyleType == KimonoStyleType.Default)
			{
				// No, make this copy a standard style
				newStyle.StyleType = KimonoStyleType.Standard;
			}

			// Clone any property connections
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Add duplicate connection
				newStyle.PropertyConnections.Add(connection.Clone());
			}

			// Return duplicate style
			return newStyle;
		}
		#endregion
	}
}
