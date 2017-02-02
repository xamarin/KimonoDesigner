using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;
using SkiaSharp;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector view for the Fill properties of a <c>KimonoStyle</c>.
	/// </summary>
	public partial class KimonoInspectorFill : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected style.
		/// </summary>
		private KimonoStyle _selectedStyle = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets the portfolio.
		/// </summary>
		/// <value>The portfolio.</value>
		public KimonoPortfolio Portfolio
		{
			get { return DesignSurface.Portfolio; }
		}

		/// <summary>
		/// Gets or sets the selected style.
		/// </summary>
		/// <value>The selected style.</value>
		public KimonoStyle SelectedStyle
		{
			get { return _selectedStyle; }
			set
			{
				_selectedStyle = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorFill"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorFill(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Shows the values for the current color selected.
		/// </summary>
		private void ShowCurrentColor()
		{
			// Update color selector
			FillColor.Color = NSColor.FromRgba(SelectedStyle.Fill.Color.Red / 255f,
											   SelectedStyle.Fill.Color.Green / 255f,
											   SelectedStyle.Fill.Color.Blue / 255f,
											   SelectedStyle.Fill.Color.Alpha / 255f);

			OpacitySlider.IntValue = SelectedStyle.Fill.Color.Alpha;
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";

			AddColorButton.Hidden = (SelectedStyle.FillColor != null);
			FillColor.Enabled = (SelectedStyle.HasFill && SelectedStyle.FillColor == null);
			OpacitySlider.Enabled = FillColor.Enabled;
			OpacityValue.Enabled = FillColor.Enabled;
		}

		/// <summary>
		/// Shows the color of the current shadow.
		/// </summary>
		private void ShowCurrentShadowColor()
		{
			// Update color selector
			ShadowColor.Color = NSColor.FromRgba(SelectedStyle.FillShadow.ShadowColor.Red / 255f,
											   SelectedStyle.FillShadow.ShadowColor.Green / 255f,
											   SelectedStyle.FillShadow.ShadowColor.Blue / 255f,
											   SelectedStyle.FillShadow.ShadowColor.Alpha / 255f);

			ShadowOpacitySlider.IntValue = SelectedStyle.FillShadow.ShadowColor.Alpha;
			ShadowOpacityValue.StringValue = $"{(int)((ShadowOpacitySlider.IntValue / 255f) * 100f)}%";

			ShadowCheckbox.IntValue = (SelectedStyle.HasFillShadow) ? 1 : 0;
			LinkedShadowColor.Enabled = SelectedStyle.HasFillShadow;
			ShadowColor.Enabled = (SelectedStyle.HasFillShadow && SelectedStyle.FillShadow.LinkedColor == null);
			ShadowOpacitySlider.Enabled = ShadowColor.Enabled;
			ShadowOpacityValue.Enabled = ShadowColor.Enabled;
			HorizontalShadowOffsetSlider.Enabled = SelectedStyle.HasFillShadow;
			VerticalShadowOffsetSlider.Enabled = SelectedStyle.HasFillShadow;
			HorizontalShadowBlurSlider.Enabled = SelectedStyle.HasFillShadow;
			VerticalShadowBlurSlider.Enabled = SelectedStyle.HasFillShadow;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{

		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Set values
			FillCheckbox.Title = (SelectedStyle.FillColor == null) ? "Custom Fill" : $"{SelectedStyle.FillColor.Name} Fill";
			FillCheckbox.IntValue = SelectedStyle.HasFill ? 1 : 0;
			ShowCurrentColor();
			AntialiaseCheckbox.IntValue = (SelectedStyle.Fill.IsAntialias) ? 1 : 0;
			JitterCheckbox.IntValue = SelectedStyle.HasFillJitter ? 1 : 0;
			LengthSlider.FloatValue = SelectedStyle.FillJitterLength;
			LengthValue.StringValue = LengthSlider.IntValue.ToString();
			DeviationSlider.FloatValue = SelectedStyle.FillJitterDeviation;
			DeviationValue.StringValue = DeviationSlider.IntValue.ToString();
			BlurCheckbox.IntValue = (SelectedStyle.HasFillBlur) ? 1 : 0;
			HorizontalBlurSlider.FloatValue = SelectedStyle.FillBlur.HorizontalBlurAmount;
			HorizontalBlurSlider.Enabled = SelectedStyle.HasFillBlur;
			HorizontalBlurValue.StringValue = HorizontalBlurSlider.IntValue.ToString();
			VerticalBlurSlider.FloatValue = SelectedStyle.FillBlur.VerticalBlurAmount;
			VerticalBlurSlider.Enabled = SelectedStyle.HasFillBlur;
			VerticalBlurValue.StringValue = VerticalBlurSlider.IntValue.ToString();
			ShowCurrentShadowColor();
			HorizontalShadowOffsetSlider.FloatValue = SelectedStyle.FillShadow.HorizontalOffset;
			HorizontalShadowOffsetValue.StringValue = HorizontalShadowOffsetSlider.IntValue.ToString();
			VerticalShadowOffsetSlider.FloatValue = SelectedStyle.FillShadow.VerticalOffset;
			VerticalShadowOffsetValue.StringValue = VerticalShadowOffsetSlider.IntValue.ToString();
			HorizontalShadowBlurSlider.FloatValue = SelectedStyle.FillShadow.HorizontalBlurAmount;
			HorizontalShadowBlurValue.StringValue = HorizontalShadowBlurSlider.IntValue.ToString();
			VerticalShadowBlurSlider.FloatValue = SelectedStyle.FillShadow.VerticalBlurAmount;
			VerticalShadowBlurValue.StringValue = VerticalShadowBlurSlider.IntValue.ToString();

			// Populate the list of colors
			LinkedColorSelector.RemoveAllItems();
			LinkedColorSelector.AddItem("None");
			var n = 0;
			foreach (KimonoColor color in Portfolio.Colors)
			{
				// Add color
				LinkedColorSelector.AddItem(color.Name);
				++n;

				// Currently selected color?
				if (SelectedStyle.FillColor == color)
				{
					// Yes, highlight it
					LinkedColorSelector.SelectItem(n);
				}
			}

			// Populate the list of shadow colors
			LinkedShadowColor.RemoveAllItems();
			LinkedShadowColor.AddItem("None");
			n = 0;
			foreach (KimonoColor color in Portfolio.Colors)
			{
				// Add color
				LinkedShadowColor.AddItem(color.Name);
				++n;

				// Currently selected color?
				if (SelectedStyle.FillShadow.LinkedColor == color)
				{
					// Yes, highlight it
					LinkedShadowColor.SelectItem(n);
				}
			}

			// Populate the list of gradients
			GradientDropdown.RemoveAllItems();
			GradientDropdown.AddItem("None");
			n = 0;
			foreach (KimonoGradient gradient in Portfolio.Gradients)
			{
				// Add gradient
				GradientDropdown.AddItem(gradient.Name);
				++n;

				// Currently selected gradient?
				if (SelectedStyle.FillGradient == gradient)
				{
					// Yes, highlight it
					GradientDropdown.SelectItem(n);
				}
			}

			// Display blend mode
			switch (SelectedStyle.Fill.BlendMode)
			{
				case SKBlendMode.Clear:
					BlendMode.SelectItem(1);
					break;
				case SKBlendMode.Color:
					BlendMode.SelectItem(2);
					break;
				case SKBlendMode.ColorBurn:
					BlendMode.SelectItem(3);
					break;
				case SKBlendMode.ColorDodge:
					BlendMode.SelectItem(4);
					break;
				case SKBlendMode.Darken:
					BlendMode.SelectItem(5);
					break;
				case SKBlendMode.Difference:
					BlendMode.SelectItem(6);
					break;
				case SKBlendMode.Dst:
					BlendMode.SelectItem(7);
					break;
				case SKBlendMode.DstATop:
					BlendMode.SelectItem(8);
					break;
				case SKBlendMode.DstIn:
					BlendMode.SelectItem(9);
					break;
				case SKBlendMode.DstOut:
					BlendMode.SelectItem(10);
					break;
				case SKBlendMode.DstOver:
					BlendMode.SelectItem(11);
					break;
				case SKBlendMode.Exclusion:
					BlendMode.SelectItem(12);
					break;
				case SKBlendMode.HardLight:
					BlendMode.SelectItem(13);
					break;
				case SKBlendMode.Hue:
					BlendMode.SelectItem(14);
					break;
				case SKBlendMode.Lighten:
					BlendMode.SelectItem(15);
					break;
				case SKBlendMode.Luminosity:
					BlendMode.SelectItem(16);
					break;
				case SKBlendMode.Modulate:
					BlendMode.SelectItem(17);
					break;
				case SKBlendMode.Multiply:
					BlendMode.SelectItem(18);
					break;
				case SKBlendMode.Overlay:
					BlendMode.SelectItem(19);
					break;
				case SKBlendMode.Plus:
					BlendMode.SelectItem(20);
					break;
				case SKBlendMode.Saturation:
					BlendMode.SelectItem(21);
					break;
				case SKBlendMode.Screen:
					BlendMode.SelectItem(22);
					break;
				case SKBlendMode.SoftLight:
					BlendMode.SelectItem(23);
					break;
				case SKBlendMode.Src:
					BlendMode.SelectItem(24);
					break;
				case SKBlendMode.SrcATop:
					BlendMode.SelectItem(25);
					break;
				case SKBlendMode.SrcIn:
					BlendMode.SelectItem(26);
					break;
				case SKBlendMode.SrcOut:
					BlendMode.SelectItem(27);
					break;
				case SKBlendMode.SrcOver:
					BlendMode.SelectItem(0);
					break;
				case SKBlendMode.Xor:
					BlendMode.SelectItem(28);
					break;
			}

			// Update GUI
			FillColor.Enabled = (SelectedStyle.HasFill && SelectedStyle.FillColor == null);
			OpacitySlider.Enabled = (SelectedStyle.HasFill && SelectedStyle.FillColor == null);
			OpacityValue.Enabled = (SelectedStyle.HasFill && SelectedStyle.FillColor == null);
			BlendMode.Enabled = SelectedStyle.HasFill;
			LengthSlider.Enabled = SelectedStyle.HasFillJitter;
			DeviationSlider.Enabled = SelectedStyle.HasFillJitter;
		}

		/// <summary>
		/// Moves the inspector to the given location
		/// </summary>
		/// <returns>The next location based on the inspector's size.</returns>
		/// <param name="y">The y coordinate.</param>
		public nfloat MoveTo(nfloat y)
		{
			// Set position
			var offset = y - Frame.Height;
			Frame = new CGRect(0, offset, Frame.Width, Frame.Height);
			return offset;
		}
		#endregion

		#region Custom Actions
		/// <summary>
		/// Handles the shadow changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ShadowChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.HasFillShadow = (ShadowCheckbox.IntValue == 1);

			// Update UI
			ShowCurrentShadowColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the shadow color chainging.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ShadowColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			ShadowColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedStyle.FillShadow.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));

			// Update UI
			ShowCurrentShadowColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the linked shadow color changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void LinkedShadowColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on the item selected
			if (LinkedShadowColor.IndexOfSelectedItem == 0)
			{
				// None selected
				SelectedStyle.FillShadow.LinkedColor = null;
			}
			else
			{
				// Base this color off of another color
				SelectedStyle.FillShadow.LinkedColor = Portfolio.Colors[(int)LinkedShadowColor.IndexOfSelectedItem - 1];
			}

			// Update UI
			ShowCurrentShadowColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the shadow's opacity changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ShadowOpacityChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			ShadowColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedStyle.FillShadow.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));

			// Update UI
			ShowCurrentShadowColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the horizontal shadow blur changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void HorizontalShadowBlurChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.FillShadow.HorizontalBlurAmount = HorizontalShadowBlurSlider.FloatValue;

			// Update UI
			HorizontalShadowBlurValue.StringValue = HorizontalShadowBlurSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the horizontal shadow offset changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void HorizontalShadowOffsetChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.FillShadow.HorizontalOffset = HorizontalShadowOffsetSlider.FloatValue;

			// Update UI
			HorizontalShadowOffsetValue.StringValue = HorizontalShadowOffsetSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the vertical shadow blur changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void VerticalShadowBlurChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.FillShadow.VerticalBlurAmount = VerticalShadowBlurSlider.FloatValue;

			// Update UI
			VerticalShadowBlurValue.StringValue = VerticalShadowBlurSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the vertical shadow offset changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void VerticalShadowOffsetChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.FillShadow.VerticalOffset = VerticalShadowOffsetSlider.FloatValue;

			// Update UI
			VerticalShadowOffsetValue.StringValue = VerticalShadowOffsetSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the blur effect changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void BlurChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.HasFillBlur = (BlurCheckbox.IntValue == 1);

			// Update UI
			HorizontalBlurSlider.Enabled = SelectedStyle.HasFillBlur;
			VerticalBlurSlider.Enabled = SelectedStyle.HasFillBlur;
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the horizontal blur amount changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void HorizontalBlurChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.FillBlur.HorizontalBlurAmount = HorizontalBlurSlider.FloatValue;

			// Update UI
			HorizontalBlurValue.StringValue = HorizontalBlurSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the vertical blur amount changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void VerticalBlurChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedStyle.FillBlur.VerticalBlurAmount = VerticalBlurSlider.FloatValue;

			// Update UI
			VerticalBlurValue.StringValue = VerticalBlurSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the opacity value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OpacityChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			FillColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedStyle.Fill.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the antialias value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AntialiaseChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.Fill.IsAntialias = (AntialiaseCheckbox.IntValue == 1);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the jitter effect changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void JitterChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.HasFillJitter = (JitterCheckbox.IntValue == 1);
			LengthSlider.Enabled = SelectedStyle.HasFillJitter;
			DeviationSlider.Enabled = SelectedStyle.HasFillJitter;
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the jitter length changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void LengthChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.FillJitterLength = LengthSlider.FloatValue;
			LengthValue.StringValue = LengthSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the jitter deviation changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeviationChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.FillJitterDeviation = DeviationSlider.FloatValue;
			DeviationValue.StringValue = DeviationSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the fill color changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void FillColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			FillColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedStyle.Fill.Color = new SKColor((byte)(red * 255), 
			                                             (byte)(green * 255), 
			                                             (byte)(blue * 255), 
			                                             (byte)(OpacitySlider.IntValue));
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the linked <c>KimonoColor</c> changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void LinkedColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on the item selected
			if (LinkedColorSelector.IndexOfSelectedItem == 0)
			{
				// None selected
				SelectedStyle.FillColor = null;
			}
			else
			{
				// Base this color off of another color
				SelectedStyle.FillColor = Portfolio.Colors[(int)LinkedColorSelector.IndexOfSelectedItem - 1];
			}

			// Update UI
			FillCheckbox.Title = (SelectedStyle.FillColor == null) ? "Custom Fill" : $"{SelectedStyle.FillColor.Name} Fill";
			ShowCurrentColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the <c>KimonoGradient</c> changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void GradientChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on the selected item
			if (GradientDropdown.IndexOfSelectedItem == 0)
			{
				// None selected
				SelectedStyle.FillGradient = null;
			}
			else
			{
				// Attach requested gradient
				SelectedStyle.FillGradient = Portfolio.Gradients[(int)GradientDropdown.IndexOfSelectedItem - 1];
			}

			// Update the UI
			ShowCurrentColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the fill changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void FillChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Inform caller of change
			SelectedStyle.HasFill = (FillCheckbox.IntValue == 1);
			RaiseShapeModified();

			// Update GUI
			FillColor.Enabled = (SelectedStyle.HasFill && SelectedStyle.FillColor == null);
			OpacitySlider.Enabled = (SelectedStyle.HasFill && SelectedStyle.FillColor == null);
			OpacityValue.Enabled = (SelectedStyle.HasFill && SelectedStyle.FillColor == null);
			BlendMode.Enabled = SelectedStyle.HasFill;
		}

		/// <summary>
		/// Handles the blend mode changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void BlendModeChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Set new blend mode
			switch (BlendMode.IndexOfSelectedItem)
			{
				case 0:
					SelectedStyle.Fill.BlendMode = SKBlendMode.SrcOver;
					break;
				case 1:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Clear;
					break;
				case 2:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Color;
					break;
				case 3:
					SelectedStyle.Fill.BlendMode = SKBlendMode.ColorBurn;
					break;
				case 4:
					SelectedStyle.Fill.BlendMode = SKBlendMode.ColorDodge;
					break;
				case 5:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Darken;
					break;
				case 6:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Difference;
					break;
				case 7:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Dst;
					break;
				case 8:
					SelectedStyle.Fill.BlendMode = SKBlendMode.DstATop;
					break;
				case 9:
					SelectedStyle.Fill.BlendMode = SKBlendMode.DstIn;
					break;
				case 10:
					SelectedStyle.Fill.BlendMode = SKBlendMode.DstOut;
					break;
				case 11:
					SelectedStyle.Fill.BlendMode = SKBlendMode.DstOver;
					break;
				case 12:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Exclusion;
					break;
				case 13:
					SelectedStyle.Fill.BlendMode = SKBlendMode.HardLight;
					break;
				case 14:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Hue;
					break;
				case 15:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Lighten;
					break;
				case 16:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Luminosity;
					break;
				case 17:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Modulate;
					break;
				case 18:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Multiply;
					break;
				case 19:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Overlay;
					break;
				case 20:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Plus;
					break;
				case 21:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Saturation;
					break;
				case 22:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Screen;
					break;
				case 23:
					SelectedStyle.Fill.BlendMode = SKBlendMode.SoftLight;
					break;
				case 24:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Src;
					break;
				case 25:
					SelectedStyle.Fill.BlendMode = SKBlendMode.SrcATop;
					break;
				case 26:
					SelectedStyle.Fill.BlendMode = SKBlendMode.SrcIn;
					break;
				case 27:
					SelectedStyle.Fill.BlendMode = SKBlendMode.SrcOut;
					break;
				case 28:
					SelectedStyle.Fill.BlendMode = SKBlendMode.Xor;
					break;
			}
			RaiseShapeModified();
		}

		/// <summary>
		/// Adds the color.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AddColor(Foundation.NSObject sender)
		{
			SelectedStyle.FillColor = Portfolio.AddNewColor(SelectedStyle.Fill.Color);
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when shape modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ShapeModified;

		/// <summary>
		/// Occurs when make new color.
		/// </summary>
		public event Kimono.SkiaColorEventDelegate MakeNewColor;

		/// <summary>
		/// Raises the shape modified event.
		/// </summary>
		internal void RaiseShapeModified()
		{
			// Inform caller of event
			if (ShapeModified != null) ShapeModified();
		}

		/// <summary>
		/// Raises the color of the make new event.
		/// </summary>
		/// <param name="color">Color.</param>
		internal void RaiseMakeNewColor(SKColor color)
		{
			// Inform caller of event
			if (MakeNewColor != null) MakeNewColor(color);
		}
		#endregion
	}
}
