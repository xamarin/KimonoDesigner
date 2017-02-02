using System;
using System.Collections.Generic;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines as style that can be applied to a <c>KimonoShape</c> to control its
	/// appearance.
	/// </summary>
	public class KimonoStyle
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
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

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
		public SKPaint Frame { get; set; } = new SKPaint();

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
				HandleFrameBlurChange();
			}
		}

		/// <summary>
		/// Gets or sets the frame blur.
		/// </summary>
		/// <value>The <c>KimonoBlur</c> applied to the frame.</value>
		public KimonoBlur FrameBlur
		{
			get { return _frameBlur; }
			set
			{
				// Unwire previous blur
				if (_frameBlur != null)
				{
					_frameBlur.BlurModified -= HandleFrameBlurChange;
				}

				// Save new value and apply
				_frameBlur = value;
				HandleFrameBlurChange();

				// Wire up new blur
				if (_frameBlur != null)
				{
					_frameBlur.BlurModified += HandleFrameBlurChange;
				}
			}
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
				HandleFillBlurChange();
			}
		}

		/// <summary>
		/// Gets or sets the fill blur.
		/// </summary>
		/// <value>The <c>KimonoBlur</c> applied to the fill.</value>
		public KimonoBlur FillBlur
		{
			get { return _fillBlur; }
			set
			{
				// Unwire previous blur
				if (_fillBlur != null)
				{
					_fillBlur.BlurModified -= HandleFillBlurChange;
				}

				// Save new value and apply
				_fillBlur = value;
				HandleFillBlurChange();

				// Wire up new blur
				if (_fillBlur != null)
				{
					_fillBlur.BlurModified += HandleFillBlurChange;
				}
			}
		}

		/// <summary>
		/// Gets or sets the color of the frame as a named Kimono Color.
		/// </summary>
		/// <value>The color of the frame.</value>
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
		public SKPaint Fill { get; set; } = new SKPaint();

		/// <summary>
		/// Gets or sets the color of the fill as a named Kimono Color.
		/// </summary>
		/// <value>The color of the fill.</value>
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
		public bool[] DashPattern { get; set; } = { true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false };
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

			Fill.Style = SKPaintStyle.Fill;
			Fill.Color = KimonoColor.Mercury;
			Fill.IsAntialias = true;
			FillBlur = new KimonoBlur();
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Handles the frame blur change.
		/// </summary>
		private void HandleFrameBlurChange()
		{
			// Is there an active filter?
			if (FrameBlur == null || !HasFrameBlur)
			{
				// No, remove
				Frame.ImageFilter = null;
			}
			else
			{
				// Yes, include the filter
				Frame.ImageFilter = FrameBlur.BlurFilter;
			}
		}

		/// <summary>
		/// Handles the fill blur change.
		/// </summary>
		private void HandleFillBlurChange()
		{
			// Is there an active filter?
			if (FillBlur == null || !HasFillBlur)
			{
				// No, remove
				Fill.ImageFilter = null;
			}
			else
			{
				// Yes, include the filter
				Fill.ImageFilter = FillBlur.BlurFilter;
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
				FrameBlur = this.FrameBlur?.Clone()
			};

			// Are we deep cloning a default style?
			if (!deepClone && newStyle.StyleType == KimonoStyleType.Default)
			{
				// No, make this copy a standard style
				newStyle.StyleType = KimonoStyleType.Standard;
			}

			// Return duplicate style
			return newStyle;
		}
		#endregion
	}
}
