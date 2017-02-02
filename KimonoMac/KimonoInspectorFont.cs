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
	/// Handles the inspector view for the Font section of a <c>KimonoStyle</c>.
	/// </summary>
	public partial class KimonoInspectorFont : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected style.
		/// </summary>
		private KimonoStyle _selectedStyle = null;

		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShape _selectedShape = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

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

		/// <summary>
		/// Gets or sets the selected shape.
		/// </summary>
		/// <value>The selected shape.</value>
		public KimonoShape SelectedShape
		{
			get { return _selectedShape; }
			set
			{
				_selectedShape = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorFont"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorFont(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Selects the font family.
		/// </summary>
		/// <param name="family">Family.</param>
		private void SelectFontFamily(string family)
		{
			var items = TypefaceDropdown.Items();
			foreach (NSMenuItem item in items)
			{
				// Found?
				if (family == item.Title)
				{
					TypefaceDropdown.SelectItem(item);
					return;
				}
			}

			// Not found, select first item
			TypefaceDropdown.SelectItem(0);
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
			// Respond to size change
			Size.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				// Save changes
				SelectedStyle.TextSize = Size.FloatValue;
				RaiseShapeModified();
			};

			// Populate the list of available fonts
			foreach (string family in NSFontManager.SharedFontManager.AvailableFontFamilies)
			{
				TypefaceDropdown.AddItem(family);
			}
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update UI
			SelectFontFamily(SelectedStyle.FontFamilyName);
			Size.FloatValue = SelectedStyle.TextSize;
			StrikeThruCheckbox.IntValue = (SelectedStyle.StrikeThruText) ? 1 : 0;
			UnderlineCheckbox.IntValue = (SelectedStyle.UnderlineText) ? 1 : 0;
			VerticalCheckbox.IntValue = (SelectedStyle.IsVerticalText) ? 1 : 0;
			ScaleSlider.FloatValue = SelectedStyle.TextScaleX;
			ScaleValue.StringValue = ScaleSlider.FloatValue.ToString();
			SkewSlider.FloatValue = SelectedStyle.TextSkewX;
			SkewValue.StringValue = SkewSlider.FloatValue.ToString();

			// Display font weight
			switch (SelectedStyle.TypefaceStyle)
			{
				case SKTypefaceStyle.Normal:
					WeightDropdown.SelectItem(0);
					break;
				case SKTypefaceStyle.Bold:
					WeightDropdown.SelectItem(1);
					break;
				case SKTypefaceStyle.BoldItalic:
					WeightDropdown.SelectItem(2);
					break;
				case SKTypefaceStyle.Italic:
					WeightDropdown.SelectItem(3);
					break;
			}

			// Display alignment
			switch (SelectedStyle.TextAlign)
			{
				case SKTextAlign.Left:
					Alignment.SelectedSegment = 0;
					break;
				case SKTextAlign.Center:
					Alignment.SelectedSegment = 1;
					break;
				case SKTextAlign.Right:
					Alignment.SelectedSegment = 2;
					break;
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
		/// Handles the typeface changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void TypefaceChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save changes
			SelectedStyle.FontFamilyName = TypefaceDropdown.SelectedItem.Title;
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the font weight changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void WeightChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Set new value
			switch (WeightDropdown.IndexOfSelectedItem)
			{
				case 0:
					SelectedStyle.TypefaceStyle = SKTypefaceStyle.Normal;
					break;
				case 1:
					SelectedStyle.TypefaceStyle = SKTypefaceStyle.Bold;
					break;
				case 2:
					SelectedStyle.TypefaceStyle = SKTypefaceStyle.BoldItalic;
					break;
				case 3:
					SelectedStyle.TypefaceStyle = SKTypefaceStyle.Italic;
					break;
			}
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the size changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SizeChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save changes
			SelectedStyle.TextSize = Size.FloatValue;
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the alignmen changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AlignmentChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save changes
			switch (Alignment.SelectedSegment)
			{
				case 0:
					SelectedStyle.TextAlign = SKTextAlign.Left;
					break;
				case 1:
					SelectedStyle.TextAlign = SKTextAlign.Center;
					break;
				case 2:
					SelectedStyle.TextAlign = SKTextAlign.Right;
					break;
			}
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the strikethru changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void StrikeThruChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.StrikeThruText = (StrikeThruCheckbox.IntValue == 1);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the underline changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void UnderlineChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.UnderlineText = (UnderlineCheckbox.IntValue == 1);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the vertical text changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void VerticalChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.IsVerticalText = (VerticalCheckbox.IntValue == 1);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the scale changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ScaleChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.TextScaleX = ScaleSlider.FloatValue;
			ScaleValue.StringValue = ScaleSlider.FloatValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the skew changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SkewChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedStyle.TextSkewX = SkewSlider.FloatValue;
			SkewValue.StringValue = SkewSlider.FloatValue.ToString();
			RaiseShapeModified();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when style modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate StyleModified;

		/// <summary>
		/// Occurs when shape modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ShapeModified;

		/// <summary>
		/// Raises the style modified event.
		/// </summary>
		internal void RaiseStyleModified()
		{
			// Inform caller of event
			if (StyleModified != null) StyleModified();
		}

		/// <summary>
		/// Raises the shape modified event.
		/// </summary>
		internal void RaiseShapeModified()
		{
			// Inform caller of event
			if (ShapeModified != null) ShapeModified();
		}
		#endregion
	}
}
