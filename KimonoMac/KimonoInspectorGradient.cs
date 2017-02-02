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
	/// Handles the inspector view for a <c>KimonoGradient</c>.
	/// </summary>
	public partial class KimonoInspectorGradient : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected gradient.
		/// </summary>
		private KimonoGradient _selectedGradient = null;

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
		/// Gets the portfolio.
		/// </summary>
		/// <value>The portfolio.</value>
		public KimonoPortfolio Portfolio
		{
			get { return DesignSurface.Portfolio; }
		}

		/// <summary>
		/// Gets or sets the selected gradient.
		/// </summary>
		/// <value>The selected gradient.</value>
		public KimonoGradient SelectedGradient
		{
			get { return _selectedGradient; }
			set
			{
				_selectedGradient = value;
				DesignPreview.Gradient = SelectedGradient;
				DesignBar.Gradient = SelectedGradient;
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
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorGradient"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorGradient(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Shows current color values.
		/// </summary>
		private void ShowCurrentColor()
		{
			// Get the active color
			var color = (SelectedGradient == null) ? KimonoColor.Black : SelectedGradient.SelectedColor;

			// Update color selector
			PointColor.Color = NSColor.FromRgba(color.Red / 255f,
											   color.Green / 255f,
											   color.Blue / 255f,
											   color.Alpha / 255f);

			OpacitySlider.IntValue = color.Alpha;
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";

			// Populate the list of colors
			LinkedColorDropdown.RemoveAllItems();
			LinkedColorDropdown.AddItem("None");
			var n = 0;
			foreach (KimonoColor namedColor in Portfolio.Colors)
			{
				// Add color
				LinkedColorDropdown.AddItem(namedColor.Name);
				++n;

				// Currently selected color?
				if (SelectedGradient.SelectedHandle?.LinkedColor == namedColor)
				{
					// Yes, highlight it
					LinkedColorDropdown.SelectItem(n);
				}
			}

			// Is a gradient selected?
			if (SelectedGradient.SelectedHandle == null || SelectedGradient.SelectedHandle.HandleType == KimonoHandleType.GradientPosition)
			{
				LinkedColorDropdown.Enabled = false;
				AddColorButton.Hidden = true;
				PointColor.Enabled = false;
				OpacitySlider.Enabled = false;
				OpacityValue.Enabled = false;
				DeletePointButton.Enabled = false;
				DuplicatePointButton.Enabled = false;
			}
			else
			{
				LinkedColorDropdown.Enabled = true;
				DuplicatePointButton.Enabled = true;
				AddColorButton.Hidden = (SelectedGradient.SelectedHandle.LinkedColor != null);
				PointColor.Enabled = (SelectedGradient.SelectedHandle.LinkedColor == null);
				OpacitySlider.Enabled = PointColor.Enabled;
				OpacityValue.Enabled = PointColor.Enabled;
				DeletePointButton.Enabled = (SelectedGradient.SelectedHandle.Constraint != KimonoHandleConstraint.Locked);
			}
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
			// Wire-up events
			GradientName.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				SelectedGradient.Name = GradientName.StringValue;
				RaiseGradientModified(SelectedGradient);
			};

			DesignBar.HandleSelected += (handle) =>
			{
				// Update color information
				ShowCurrentColor();
			};

			DesignPreview.GradientModified += () =>
			{
				// Update shape
				RaiseShapeModified();
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update fields with the current shape information
			if (SelectedGradient != null) GradientName.StringValue = SelectedGradient.Name;
			BackButton.Enabled = (SelectedShape != null);
			ShowCurrentColor();
			TileDropdown.Enabled = (SelectedGradient.GradientType != KimonoGradientType.SweepGradient);
			RadiusSlider.FloatValue = SelectedGradient.Radius;
			RadiusValue.StringValue = RadiusSlider.IntValue.ToString();
			RadiusSlider.Enabled = (SelectedGradient.GradientType == KimonoGradientType.RadialGradient || 
			                        SelectedGradient.GradientType == KimonoGradientType.ConicalGradient );

			// Set type
			switch (SelectedGradient.GradientType)
			{
				case KimonoGradientType.LinearGradient:
					TypeDropdown.SelectItem(0);
					break;
				case KimonoGradientType.RadialGradient:
					TypeDropdown.SelectItem(1);
					break;
				case KimonoGradientType.SweepGradient:
					TypeDropdown.SelectItem(2);
					break;
				case KimonoGradientType.ConicalGradient:
					TypeDropdown.SelectItem(3);
					break;
			}

			// Set tile mode
			switch (SelectedGradient.TileMode)
			{
				case SKShaderTileMode.Clamp:
					TileDropdown.SelectItem(0);
					break;
				case SKShaderTileMode.Repeat:
					TileDropdown.SelectItem(1);
					break;
				case SKShaderTileMode.Mirror:
					TileDropdown.SelectItem(2);
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
		/// Handles the gradient's type changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void TypeChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on the selected type
			switch (TypeDropdown.IndexOfSelectedItem)
			{
				case 0:
					SelectedGradient.GradientType = KimonoGradientType.LinearGradient;
					break;
				case 1:
					SelectedGradient.GradientType = KimonoGradientType.RadialGradient;
					break;
				case 2:
					SelectedGradient.GradientType = KimonoGradientType.SweepGradient;
					break;
				case 3:
					SelectedGradient.GradientType = KimonoGradientType.ConicalGradient;
					break;
			}

			// Update UI
			TileDropdown.Enabled = (SelectedGradient.GradientType != KimonoGradientType.SweepGradient);
			RadiusSlider.Enabled = (SelectedGradient.GradientType == KimonoGradientType.RadialGradient ||
									SelectedGradient.GradientType == KimonoGradientType.ConicalGradient);
			RaiseGradientModified(SelectedGradient);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the tile mode changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void TileChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on the selected type
			switch (TileDropdown.IndexOfSelectedItem)
			{
				case 0:
					SelectedGradient.TileMode = SKShaderTileMode.Clamp;
					break;
				case 1:
					SelectedGradient.TileMode = SKShaderTileMode.Repeat;
					break;
				case 2:
					SelectedGradient.TileMode = SKShaderTileMode.Mirror;
					break;
			}

			// Update UI
			RaiseGradientModified(SelectedGradient);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles a point color changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void PointColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			PointColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedGradient.SelectedHandle.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));

			// Update UI
			DesignPreview.RefreshView();
			DesignBar.RefreshView();
			RaiseGradientModified(SelectedGradient);
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
			PointColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedGradient.SelectedHandle.Color = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";

			// Update UI
			RaiseGradientModified(SelectedGradient);
			RaiseShapeModified();
		}

		/// <summary>
		/// Sends the user back to the selected shape.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void GoBack(Foundation.NSObject sender)
		{
			// Return to the selected shape
			RaiseReturnToShape(SelectedShape);
		}

		/// <summary>
		/// Duplicates the gradient.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicateGradient(Foundation.NSObject sender)
		{
			// Duplicate this gradient
			RaiseMakeDuplicate(SelectedGradient);
		}

		/// <summary>
		/// Deletes the gradient.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeleteGradient(Foundation.NSObject sender)
		{
			// Delete current gradient
			RaiseRemoveGradient(SelectedGradient);
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
			if (LinkedColorDropdown.IndexOfSelectedItem == 0)
			{
				// None selected
				SelectedGradient.SelectedHandle.LinkedColor = null;
			}
			else
			{
				// Base this color off of another color
				SelectedGradient.SelectedHandle.LinkedColor = Portfolio.Colors[(int)LinkedColorDropdown.IndexOfSelectedItem - 1];
			}

			// Update UI
			DesignPreview.RefreshView();
			DesignBar.RefreshView();
			ShowCurrentColor();
			RaiseShapeModified();
		}

		/// <summary>
		/// Adds the point.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AddPoint(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Add new control point
			SelectedGradient.AddControlPoint();

			// Update UI
			RaiseGradientModified(SelectedGradient);
			RaiseShapeModified();
		}

		/// <summary>
		/// Deletes the point.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeletePoint(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Delete control point
			SelectedGradient.DeleteSelectedControlPoint();

			// Update UI
			RaiseGradientModified(SelectedGradient);
			RaiseShapeModified();
		}

		/// <summary>
		/// Duplicates the point.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicatePoint(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Duplicate control point
			SelectedGradient.DuplicateSelectedControlPoint();

			// Update UI
			RaiseGradientModified(SelectedGradient);
			RaiseShapeModified();
		}

		/// <summary>
		/// Adds the color.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void AddColor(Foundation.NSObject sender)
		{
			SelectedGradient.SelectedHandle.LinkedColor = Portfolio.AddNewColor(SelectedGradient.SelectedHandle.Color);
		}

		/// <summary>
		/// Handles the radius changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void RadiusChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new radius
			SelectedGradient.Radius = RadiusSlider.FloatValue;

			// Update UI
			RadiusValue.StringValue = RadiusSlider.IntValue.ToString();
			RaiseGradientModified(SelectedGradient);
			RaiseShapeModified();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when gradient modified.
		/// </summary>
		public event Kimono.GradientEventDelegate GradientModified;

		/// <summary>
		/// Occurs when shape modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ShapeModified;

		/// <summary>
		/// Occurs when make duplicate.
		/// </summary>
		public event Kimono.GradientEventDelegate MakeDuplicate;

		/// <summary>
		/// Occurs when remove gradient.
		/// </summary>
		public event Kimono.GradientEventDelegate RemoveGradient;

		/// <summary>
		/// Occurs when return to shape.
		/// </summary>
		public event Kimono.ShapeEventDelegate ReturnToShape;

		/// <summary>
		/// Raises the gradient modified event.
		/// </summary>
		/// <param name="gradient">Gradient.</param>
		internal void RaiseGradientModified(KimonoGradient gradient)
		{
			// Inform caller of event
			if (GradientModified != null) GradientModified(gradient);
		}

		/// <summary>
		/// Raises the shape modified event.
		/// </summary>
		internal void RaiseShapeModified()
		{
			// Inform caller of event
			if (ShapeModified != null) ShapeModified();
		}

		/// <summary>
		/// Raises the make duplicate event.
		/// </summary>
		/// <param name="gradient">Gradient.</param>
		internal void RaiseMakeDuplicate(KimonoGradient gradient)
		{
			// Inform caller of event
			if (MakeDuplicate != null) MakeDuplicate(gradient);
		}

		/// <summary>
		/// Raises the remove gradient event.
		/// </summary>
		/// <param name="gradient">Gradient.</param>
		internal void RaiseRemoveGradient(KimonoGradient gradient)
		{
			// Inform caller of event
			if (RemoveGradient != null) RemoveGradient(gradient);
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
