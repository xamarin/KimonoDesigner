using System;
using System.Collections.Generic;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;
using SkiaSharp;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector view for a named <c>KimonoColor</c> that can be attached to
	/// other<c>KimonoShapes</c>.
	/// </summary>
	public partial class KimonoInspectorPaleteColor : NSView
	{
		#region Private Variables
		/// <summary>
		/// The color of the selected.
		/// </summary>
		private KimonoColor _selectedColor = null;

		/// <summary>
		/// The available base colors.
		/// </summary>
		private List<KimonoColor> AvailableBaseColors = new List<KimonoColor>();
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
		/// Gets or sets the selected shape.
		/// </summary>
		/// <value>The selected shape.</value>
		public KimonoShape SelectedShape { get; set; } = null;

		/// <summary>
		/// Gets or sets the color of the selected.
		/// </summary>
		/// <value>The color of the selected.</value>
		public KimonoColor SelectedColor
		{
			get { return _selectedColor; }
			set
			{
				_selectedColor = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorPaleteColor"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorPaleteColor(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Displays the current color
		/// </summary>
		private void DisplayCurrentColor()
		{
			Color.Color = NSColor.FromRgba(SelectedColor.Color.Red / 255f,
											   SelectedColor.Color.Green / 255f,
											   SelectedColor.Color.Blue / 255f,
											   SelectedColor.Color.Alpha / 255f);
		}

		/// <summary>
		/// Sets the color values.
		/// </summary>
		private void SetColorValues()
		{
			// Update fields with the current shape information
			ColorName.StringValue = SelectedColor.Name;
			DisplayCurrentColor();
			Color.Enabled = (SelectedColor.BaseColor == null);

			AdjustHueCheckbox.IntValue = SelectedColor.AdjustsHue ? 1 : 0;
			HueSlider.FloatValue = SelectedColor.HueAdjustment;
			HueSlider.Enabled = SelectedColor.AdjustsHue;
			HueValue.StringValue = HueSlider.IntValue.ToString();

			AdjustSaturationCheckbox.IntValue = SelectedColor.AdjustsSaturation ? 1 : 0;
			SaturationSlider.FloatValue = SelectedColor.SaturationAdjustment;
			SaturationSlider.Enabled = SelectedColor.AdjustsSaturation;
			SaturationValue.StringValue = $"{SaturationSlider.IntValue}%";

			AdjustBrightnessCheckbox.IntValue = SelectedColor.AdjustsBrightness ? 1 : 0;
			BrightnessSlider.FloatValue = SelectedColor.BrightnessAdjustment;
			BrightnessSlider.Enabled = SelectedColor.AdjustsBrightness;
			BrightnessValue.StringValue = $"{BrightnessSlider.IntValue}%";

			AdjustOpacityCheckbox.IntValue = SelectedColor.AdjustsAlpha ? 1 : 0;
			OpacitySlider.IntValue = SelectedColor.AlphaAdjustment;
			OpacitySlider.Enabled = SelectedColor.AdjustsAlpha;
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
			// Wire-up events
			ColorName.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				// Save name and ensure it's valid
				SelectedColor.Name = ColorName.StringValue;
				DesignSurface.Portfolio.EnsureColorNameIsValid(SelectedColor);

				// Udate UI
				ColorName.StringValue = SelectedColor.Name;
				RaiseColorModified(null);
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update fields with the current shape information
			SetColorValues();
			GoBackButton.Enabled = (SelectedShape != null);

			// Populate the list of colors
			BaseColorSelector.RemoveAllItems();
			BaseColorSelector.AddItem("None");
			AvailableBaseColors.Clear();
			var n = 0;
			foreach (KimonoColor color in Portfolio.Colors)
			{
				// Valid color?
				if (color != SelectedColor)
				{
					// Yes, add to collection
					BaseColorSelector.AddItem(color.Name);
					AvailableBaseColors.Add(color);
					++n;

					// Currently selected color?
					if (SelectedColor.BaseColor?.Name == color.Name)
					{
						// Yes, highlight it
						BaseColorSelector.SelectItem(n);
					}
				}
			}

		}

		/// <summary>
		/// Moves the inspector to the given location.
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
		/// Adjusts the brightness changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AdjustBrightnessChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.AdjustsBrightness = (AdjustBrightnessCheckbox.IntValue == 1);
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Adjusts the hue changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AdjustHueChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.AdjustsHue = (AdjustHueCheckbox.IntValue == 1);
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Adjusts the opacity changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AdjustOpacityChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.AdjustsAlpha = (AdjustOpacityCheckbox.IntValue == 1);
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Adjusts the saturation changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AdjustSaturationChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.AdjustsSaturation = (AdjustSaturationCheckbox.IntValue == 1);
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Handles the base color changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void BaseColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on the item selected
			if (BaseColorSelector.IndexOfSelectedItem == 0)
			{
				// None selected
				SelectedColor.BaseColor = null;
			}
			else
			{
				// Base this color off of another color
				SelectedColor.BaseColor = AvailableBaseColors[(int)BaseColorSelector.IndexOfSelectedItem - 1];
			}

			// Update UI
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Handles the brightness chanigng.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void BrightnessChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.BrightnessAdjustment = BrightnessSlider.FloatValue;
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Handles the color changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			Color.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedColor.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(alpha * 255));
		
			// Update UI
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Handles the color name changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ColorNameChanged(Foundation.NSObject sender)
		{
			// Save undo point
			//DesignSurface.SaveUndoPoint();

			SelectedColor.Name = ColorName.StringValue;
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Deletes the color.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeleteColor(Foundation.NSObject sender)
		{
			RaiseRemoveColor(SelectedColor);
		}

		/// <summary>
		/// Duplicates the color.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicateColor(Foundation.NSObject sender)
		{
			RaiseMakeDuplicate(SelectedColor);
		}

		/// <summary>
		/// Handles the hue changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void HueChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.HueAdjustment = HueSlider.FloatValue;
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Handles the opacity changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OpacityChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.AlphaAdjustment = OpacitySlider.IntValue;
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Handles the saturation changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SaturationChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedColor.SaturationAdjustment = SaturationSlider.FloatValue;
			SetColorValues();
			RaiseColorModified(SelectedColor);
		}

		/// <summary>
		/// Returns the to the selected shape.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void GoBack(Foundation.NSObject sender)
		{
			// Request the selected shape to be displayed
			RaiseReturnToShape(SelectedShape);
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when color modified.
		/// </summary>
		public event Kimono.ColorEventDelegate ColorModified;

		/// <summary>
		/// Occurs when make duplicate.
		/// </summary>
		public event Kimono.ColorEventDelegate MakeDuplicate;

		/// <summary>
		/// Occurs when remove color.
		/// </summary>
		public event Kimono.ColorEventDelegate RemoveColor;

		/// <summary>
		/// Occurs when return to shape.
		/// </summary>
		public event Kimono.ShapeEventDelegate ReturnToShape;

		/// <summary>
		/// Raises the color modified event.
		/// </summary>
		/// <param name="color">Color.</param>
		internal void RaiseColorModified(KimonoColor color)
		{
			// Inform caller of event
			if (ColorModified != null) ColorModified(color);
		}

		/// <summary>
		/// Raises the make duplicate event.
		/// </summary>
		/// <param name="color">Color.</param>
		internal void RaiseMakeDuplicate(KimonoColor color)
		{
			// Inform caller of event
			if (MakeDuplicate != null) MakeDuplicate(color);
		}

		/// <summary>
		/// Raises the color of the remove event.
		/// </summary>
		/// <param name="color">Color.</param>
		internal void RaiseRemoveColor(KimonoColor color)
		{
			// Inform caller of event
			if (RemoveColor != null) RemoveColor(color);
		}

		/// <summary>
		/// Raises the return to shape event.
		/// </summary>
		/// <param name="shape">Shape.</param>
		internal void RaiseReturnToShape(KimonoShape shape)
		{
			// Inform caller of event
			if (ReturnToShape != null) ReturnToShape(shape);
		}
		#endregion
	}
}
