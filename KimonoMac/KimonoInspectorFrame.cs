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
	/// Handles the inspector view for the Frame section of a <c>KimonoStyle</c>.
	/// </summary>
	public partial class KimonoInspectorFrame : NSView
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
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorFrame"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorFrame(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Shows the color of the current.
		/// </summary>
		private void ShowCurrentColor()
		{
			// Update color selector
			FrameColor.Color = NSColor.FromRgba(SelectedStyle.Frame.Color.Red / 255f,
											   SelectedStyle.Frame.Color.Green / 255f,
											   SelectedStyle.Frame.Color.Blue / 255f,
											   SelectedStyle.Frame.Color.Alpha / 255f);

			OpacitySlider.IntValue = SelectedStyle.Frame.Color.Alpha;
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";

			AddColorButton.Hidden = (SelectedStyle.FrameColor != null);
			FrameColor.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			OpacitySlider.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			OpacityValue.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
		}

		/// <summary>
		/// Shows the color of the current shadow.
		/// </summary>
		private void ShowCurrentShadowColor()
		{
			// Update color selector
			ShadowColor.Color = NSColor.FromRgba(SelectedStyle.FrameShadow.ShadowColor.Red / 255f,
											   SelectedStyle.FrameShadow.ShadowColor.Green / 255f,
											   SelectedStyle.FrameShadow.ShadowColor.Blue / 255f,
											   SelectedStyle.FrameShadow.ShadowColor.Alpha / 255f);

			ShadowOpacitySlider.IntValue = SelectedStyle.FrameShadow.ShadowColor.Alpha;
			ShadowOpacityValue.StringValue = $"{(int)((ShadowOpacitySlider.IntValue / 255f) * 100f)}%";

			ShadowCheckbox.IntValue = (SelectedStyle.HasFrameShadow) ? 1 : 0;
			LinkedShadowColor.Enabled = SelectedStyle.HasFrameShadow;
			ShadowColor.Enabled = (SelectedStyle.HasFrameShadow && SelectedStyle.FrameShadow.LinkedColor == null);
			ShadowOpacitySlider.Enabled = ShadowColor.Enabled;
			ShadowOpacityValue.Enabled = ShadowColor.Enabled;
			HorizontalShadowOffsetSlider.Enabled = SelectedStyle.HasFrameShadow;
			VerticalShadowOffsetSlider.Enabled = SelectedStyle.HasFrameShadow;
			HorizontalShadowBlurSlider.Enabled = SelectedStyle.HasFrameShadow;
			VerticalShadowBlurSlider.Enabled = SelectedStyle.HasFrameShadow;
		}

		/// <summary>
		/// Shows the dash editor.
		/// </summary>
		private void ShowDashEditor()
		{
			DashCheckbox.IntValue = SelectedStyle.HasFrameDash ? 1 : 0;
			Dash1.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[0] ? "IconDashOn" : "IconDashOff");
			Dash2.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[1] ? "IconDashOn" : "IconDashOff");
			Dash3.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[2] ? "IconDashOn" : "IconDashOff");
			Dash4.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[3] ? "IconDashOn" : "IconDashOff");
			Dash5.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[4] ? "IconDashOn" : "IconDashOff");
			Dash6.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[5] ? "IconDashOn" : "IconDashOff");
			Dash7.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[6] ? "IconDashOn" : "IconDashOff");
			Dash8.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[7] ? "IconDashOn" : "IconDashOff");
			Dash9.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[8] ? "IconDashOn" : "IconDashOff");
			Dash10.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[9] ? "IconDashOn" : "IconDashOff");
			Dash11.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[10] ? "IconDashOn" : "IconDashOff");
			Dash12.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[11] ? "IconDashOn" : "IconDashOff");
			Dash13.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[12] ? "IconDashOn" : "IconDashOff");
			Dash14.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[13] ? "IconDashOn" : "IconDashOff");
			Dash15.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[14] ? "IconDashOn" : "IconDashOff");
			Dash16.Image = NSImage.ImageNamed(SelectedStyle.DashPattern[15] ? "IconDashOn" : "IconDashOff");

			Dash1.Enabled = SelectedStyle.HasFrameDash;
			Dash2.Enabled = SelectedStyle.HasFrameDash;
			Dash3.Enabled = SelectedStyle.HasFrameDash;
			Dash4.Enabled = SelectedStyle.HasFrameDash;
			Dash5.Enabled = SelectedStyle.HasFrameDash;
			Dash6.Enabled = SelectedStyle.HasFrameDash;
			Dash7.Enabled = SelectedStyle.HasFrameDash;
			Dash8.Enabled = SelectedStyle.HasFrameDash;
			Dash9.Enabled = SelectedStyle.HasFrameDash;
			Dash10.Enabled = SelectedStyle.HasFrameDash;
			Dash11.Enabled = SelectedStyle.HasFrameDash;
			Dash12.Enabled = SelectedStyle.HasFrameDash;
			Dash13.Enabled = SelectedStyle.HasFrameDash;
			Dash14.Enabled = SelectedStyle.HasFrameDash;
			Dash15.Enabled = SelectedStyle.HasFrameDash;
			Dash16.Enabled = SelectedStyle.HasFrameDash;

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
			FrameCheckbox.Title = (SelectedStyle.FrameColor == null) ? "Custom Frame" : $"{SelectedStyle.FrameColor.Name} Frame";
			FrameCheckbox.IntValue = SelectedStyle.HasFrame ? 1 : 0;
			ShowCurrentColor();
			WidthSlider.FloatValue = SelectedStyle.Frame.StrokeWidth;
			WidthValue.StringValue = WidthSlider.FloatValue.ToString();
			MiterSlider.FloatValue = SelectedStyle.Frame.StrokeMiter;
			MiterValue.StringValue = MiterSlider.FloatValue.ToString();
			AntialiasCheckbox.IntValue = (SelectedStyle.Frame.IsAntialias) ? 1 : 0;
			JitterCheckbox.IntValue = SelectedStyle.HasFrameJitter ? 1 : 0;
			LengthSlider.FloatValue = SelectedStyle.FrameJitterLength;
			LengthValue.StringValue = LengthSlider.IntValue.ToString();
			DeviationSlider.FloatValue = SelectedStyle.FrameJitterDeviation;
			DeviationValue.StringValue = DeviationSlider.IntValue.ToString();
			ShowDashEditor();
			BlurCheckbox.IntValue = (SelectedStyle.HasFrameBlur) ? 1 : 0;
			HorizontalBlurSlider.FloatValue = SelectedStyle.FrameBlur.HorizontalBlurAmount;
			HorizontalBlurSlider.Enabled = SelectedStyle.HasFrameBlur;
			HorizontalBlurValue.StringValue = HorizontalBlurSlider.IntValue.ToString();
			VerticalBlurSlider.FloatValue = SelectedStyle.FrameBlur.VerticalBlurAmount;
			VerticalBlurSlider.Enabled = SelectedStyle.HasFrameBlur;
			VerticalBlurValue.StringValue = VerticalBlurSlider.IntValue.ToString();
			ShowCurrentShadowColor();
			HorizontalShadowOffsetSlider.FloatValue = SelectedStyle.FrameShadow.HorizontalOffset;
			HorizontalShadowOffsetValue.StringValue = HorizontalShadowOffsetSlider.IntValue.ToString();
			VerticalShadowOffsetSlider.FloatValue = SelectedStyle.FrameShadow.VerticalOffset;
			VerticalShadowOffsetValue.StringValue = VerticalShadowOffsetSlider.IntValue.ToString();
			HorizontalShadowBlurSlider.FloatValue = SelectedStyle.FrameShadow.HorizontalBlurAmount;
			HorizontalShadowBlurValue.StringValue = HorizontalShadowBlurSlider.IntValue.ToString();
			VerticalShadowBlurSlider.FloatValue = SelectedStyle.FrameShadow.VerticalBlurAmount;
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
				if (SelectedStyle.FrameColor == color)
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
				if (SelectedStyle.FrameShadow.LinkedColor == color)
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
				if (SelectedStyle.FrameGradient == gradient)
				{
					// Yes, highlight it
					GradientDropdown.SelectItem(n);
				}
			}

			// Display blend mode
			switch (SelectedStyle.Frame.BlendMode)
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

			// Display join type
			switch (SelectedStyle.Frame.StrokeJoin)
			{
				case SKStrokeJoin.Bevel:
					JoinType.SelectItem(0);
					break;
				case SKStrokeJoin.Mitter:
					JoinType.SelectItem(1);
					break;
				case SKStrokeJoin.Round:
					JoinType.SelectItem(2);
					break;
			}

			// Display end cap type
			switch (SelectedStyle.Frame.StrokeCap)
			{
				case SKStrokeCap.Butt:
					EndCap.SelectItem(0);
					break;
				case SKStrokeCap.Round:
					EndCap.SelectItem(1);
					break;
				case SKStrokeCap.Square:
					EndCap.SelectItem(2);
					break;
			}

			// Update GUI
			FrameColor.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			OpacitySlider.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			OpacityValue.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			BlendMode.Enabled = SelectedStyle.HasFrame;
			WidthSlider.Enabled = SelectedStyle.HasFrame;
			WidthValue.Enabled = SelectedStyle.HasFrame;
			MiterSlider.Enabled = SelectedStyle.HasFrame;
			MiterValue.Enabled = SelectedStyle.HasFrame;
			JoinType.Enabled = SelectedStyle.HasFrame;
			EndCap.Enabled = SelectedStyle.HasFrame;
			LengthSlider.Enabled = SelectedStyle.HasFrameJitter;
			DeviationSlider.Enabled = SelectedStyle.HasFrameJitter;
		}

		/// <summary>
		/// Moves the inspector to the give location.
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
			SelectedStyle.HasFrameShadow = (ShadowCheckbox.IntValue == 1);

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
			SelectedStyle.FrameShadow.Color = new SKColor((byte)(red * 255),
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
				SelectedStyle.FrameShadow.LinkedColor = null;
			}
			else
			{
				// Base this color off of another color
				SelectedStyle.FrameShadow.LinkedColor = Portfolio.Colors[(int)LinkedShadowColor.IndexOfSelectedItem - 1];
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
			SelectedStyle.FrameShadow.Color = new SKColor((byte)(red * 255),
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
			SelectedStyle.FrameShadow.HorizontalBlurAmount = HorizontalShadowBlurSlider.FloatValue;

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
			SelectedStyle.FrameShadow.HorizontalOffset = HorizontalShadowOffsetSlider.FloatValue;

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
			SelectedStyle.FrameShadow.VerticalBlurAmount = VerticalShadowBlurSlider.FloatValue;

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
			SelectedStyle.FrameShadow.VerticalOffset = VerticalShadowOffsetSlider.FloatValue;

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
			SelectedStyle.HasFrameBlur = (BlurCheckbox.IntValue == 1);

			// Update UI
			HorizontalBlurSlider.Enabled = SelectedStyle.HasFrameBlur;
			VerticalBlurSlider.Enabled = SelectedStyle.HasFrameBlur;
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
			SelectedStyle.FrameBlur.HorizontalBlurAmount = HorizontalBlurSlider.FloatValue;

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
			SelectedStyle.FrameBlur.VerticalBlurAmount = VerticalBlurSlider.FloatValue;

			// Update UI
			VerticalBlurValue.StringValue = VerticalBlurSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the linked color changing.
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
				SelectedStyle.FrameColor = null;
			}
			else
			{
				// Base this color off of another color
				SelectedStyle.FrameColor = Portfolio.Colors[(int)LinkedColorSelector.IndexOfSelectedItem - 1];
			}

			// Update UI
			FrameCheckbox.Title = (SelectedStyle.FrameColor == null) ? "Custom Frame" : $"{SelectedStyle.FrameColor.Name} Frame";
			ShowCurrentColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the gradient changing.
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
				SelectedStyle.FrameGradient = null;
			}
			else
			{
				// Attach requested gradient
				SelectedStyle.FrameGradient = Portfolio.Gradients[(int)GradientDropdown.IndexOfSelectedItem - 1];
			}

			// Update the UI
			ShowCurrentColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the opacity changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OpacityChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			FrameColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedStyle.Frame.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the antialias changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AntialiasChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.Frame.IsAntialias = (AntialiasCheckbox.IntValue == 1);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DashChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.HasFrameDash = (DashCheckbox.IntValue == 1);
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash1Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[0] = !SelectedStyle.DashPattern[0];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash2Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[1] = !SelectedStyle.DashPattern[1];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash3Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[2] = !SelectedStyle.DashPattern[2];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash4Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[3] = !SelectedStyle.DashPattern[3];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash5Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[4] = !SelectedStyle.DashPattern[4];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash6Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[5] = !SelectedStyle.DashPattern[5];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash7Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[6] = !SelectedStyle.DashPattern[6];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash8Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[7] = !SelectedStyle.DashPattern[7];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash9Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[8] = !SelectedStyle.DashPattern[8];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash10Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[9] = !SelectedStyle.DashPattern[9];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash11Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[10] = !SelectedStyle.DashPattern[10];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash12Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[11] = !SelectedStyle.DashPattern[11];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash13Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[12] = !SelectedStyle.DashPattern[12];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash14Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[13] = !SelectedStyle.DashPattern[13];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash15Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[14] = !SelectedStyle.DashPattern[14];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a dash point changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void Dash16Changed(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.DashPattern[15] = !SelectedStyle.DashPattern[15];
			SelectedStyle.ApplyFrameEffects();
			ShowDashEditor();
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

			SelectedStyle.HasFrameJitter = (JitterCheckbox.IntValue == 1);
			LengthSlider.Enabled = SelectedStyle.HasFrameJitter;
			DeviationSlider.Enabled = SelectedStyle.HasFrameJitter;
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the jitter lenght changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void LengthChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.FrameJitterLength = LengthSlider.FloatValue;
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

			SelectedStyle.FrameJitterDeviation = DeviationSlider.FloatValue;
			DeviationValue.StringValue = DeviationSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the width changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void WidthChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.Frame.StrokeWidth = WidthSlider.FloatValue;
			WidthValue.StringValue = WidthSlider.FloatValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the Miter changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void MiterChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.Frame.StrokeMiter = MiterSlider.FloatValue;
			MiterValue.StringValue = MiterSlider.FloatValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the frame color changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void FrameColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			FrameColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedStyle.Frame.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the frame changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void FrameChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Inform caller of change
			SelectedStyle.HasFrame = (FrameCheckbox.IntValue == 1);
			RaiseShapeModified();

			// Update GUI
			FrameColor.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			OpacitySlider.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			OpacityValue.Enabled = (SelectedStyle.HasFrame && SelectedStyle.FrameColor == null);
			BlendMode.Enabled = SelectedStyle.HasFrame;
			WidthSlider.Enabled = SelectedStyle.HasFrame;
			WidthValue.Enabled = SelectedStyle.HasFrame;
			MiterSlider.Enabled = SelectedStyle.HasFrame;
			MiterValue.Enabled = SelectedStyle.HasFrame;
			JoinType.Enabled = SelectedStyle.HasFrame;
			EndCap.Enabled = SelectedStyle.HasFrame;
		}

		/// <summary>
		/// Handles the join type changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void JoinTypeChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Set new type
			switch (JoinType.IndexOfSelectedItem)
			{
				case 0:
					SelectedStyle.Frame.StrokeJoin = SKStrokeJoin.Bevel;
					break;
				case 1:
					SelectedStyle.Frame.StrokeJoin = SKStrokeJoin.Mitter;
					break;
				case 2:
					SelectedStyle.Frame.StrokeJoin = SKStrokeJoin.Round;
					break;
			}
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the end cap chainging.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void EndCapChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Set new type
			switch (EndCap.IndexOfSelectedItem)
			{
				case 0:
					SelectedStyle.Frame.StrokeCap = SKStrokeCap.Butt;
					break;
				case 1:
					SelectedStyle.Frame.StrokeCap = SKStrokeCap.Round;
					break;
				case 2:
					SelectedStyle.Frame.StrokeCap = SKStrokeCap.Square;
					break;
			}
			RaiseShapeModified();
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
					SelectedStyle.Frame.BlendMode = SKBlendMode.SrcOver;
					break;
				case 1:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Clear;
					break;
				case 2:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Color;
					break;
				case 3:
					SelectedStyle.Frame.BlendMode = SKBlendMode.ColorBurn;
					break;
				case 4:
					SelectedStyle.Frame.BlendMode = SKBlendMode.ColorDodge;
					break;
				case 5:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Darken;
					break;
				case 6:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Difference;
					break;
				case 7:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Dst;
					break;
				case 8:
					SelectedStyle.Frame.BlendMode = SKBlendMode.DstATop;
					break;
				case 9:
					SelectedStyle.Frame.BlendMode = SKBlendMode.DstIn;
					break;
				case 10:
					SelectedStyle.Frame.BlendMode = SKBlendMode.DstOut;
					break;
				case 11:
					SelectedStyle.Frame.BlendMode = SKBlendMode.DstOver;
					break;
				case 12:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Exclusion;
					break;
				case 13:
					SelectedStyle.Frame.BlendMode = SKBlendMode.HardLight;
					break;
				case 14:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Hue;
					break;
				case 15:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Lighten;
					break;
				case 16:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Luminosity;
					break;
				case 17:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Modulate;
					break;
				case 18:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Multiply;
					break;
				case 19:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Overlay;
					break;
				case 20:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Plus;
					break;
				case 21:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Saturation;
					break;
				case 22:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Screen;
					break;
				case 23:
					SelectedStyle.Frame.BlendMode = SKBlendMode.SoftLight;
					break;
				case 24:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Src;
					break;
				case 25:
					SelectedStyle.Frame.BlendMode = SKBlendMode.SrcATop;
					break;
				case 26:
					SelectedStyle.Frame.BlendMode = SKBlendMode.SrcIn;
					break;
				case 27:
					SelectedStyle.Frame.BlendMode = SKBlendMode.SrcOut;
					break;
				case 28:
					SelectedStyle.Frame.BlendMode = SKBlendMode.Xor;
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
			SelectedStyle.FrameColor = Portfolio.AddNewColor(SelectedStyle.Frame.Color);
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
