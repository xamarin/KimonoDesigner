using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector view for a given <c>KimonoStyle</c>.
	/// </summary>
	public partial class KimonoInspectorStyle : NSView
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
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorStyle"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorStyle(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
			// Wire-up events
			StyleName.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				SelectedStyle.Name = StyleName.StringValue;
				RaiseStyleModified();
			};

		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update fields with the current shape information
			StyleName.StringValue = SelectedStyle.Name;
			ApplyButton.Enabled = (SelectedShape != null && SelectedShape.Style != SelectedStyle);
			DeleteButton.Enabled = (SelectedStyle.StyleType != KimonoStyleType.Default);
			Backbutton.Enabled = (SelectedShape != null && SelectedShape.Style == SelectedStyle);

			// Set type
			switch (SelectedStyle.StyleType)
			{
				case KimonoStyleType.Default:
					TypeDropdown.SelectItem(0);
					TypeDropdown.Enabled = false;
					StyleName.Enabled = false;
					break;
				case KimonoStyleType.Standard:
					TypeDropdown.SelectItem(0);
					TypeDropdown.Enabled = true;
					StyleName.Enabled = true;
					break;
				case KimonoStyleType.Text:
					TypeDropdown.SelectItem(1);
					TypeDropdown.Enabled = true;
					StyleName.Enabled = true;
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
		/// Applies the change to the currently selected <c>KimonShape</c>.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ApplyChange(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Apply style to selected shape
			SelectedShape.Style = SelectedStyle;
			Backbutton.Enabled = true;
			ApplyButton.Enabled = false;
			RaiseShapeModified();
		}

		/// <summary>
		/// Deletes the style.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeleteStyle(Foundation.NSObject sender)
		{
			// Request style be deleted
			RaiseRemoveStyle(SelectedStyle);
		}

		/// <summary>
		/// Duplicates the style.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicateStyle(Foundation.NSObject sender)
		{
			// Request a duplicate of this style
			RaiseMakeDuplicate(SelectedStyle);
		}

		/// <summary>
		/// Returns to the currently selected shape.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void GoBack(Foundation.NSObject sender)
		{
			// Request the selected shape to be displayed
			RaiseReturnToShape(SelectedShape);
		}

		/// <summary>
		/// Handles the <c>KimonoStyle</c>'s type changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void TypeChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Set style type
			switch (TypeDropdown.IndexOfSelectedItem)
			{
				case 0:
					SelectedStyle.StyleType = KimonoStyleType.Standard;
					break;
				case 1:
					SelectedStyle.StyleType = KimonoStyleType.Text;
					break;
			}

			// Inform caller of change
			RaiseStyleTypeChanged(SelectedStyle);
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
		/// Occurs when make duplicate.
		/// </summary>
		public event Kimono.StyleEventDelegate MakeDuplicate;

		/// <summary>
		/// Occurs when remove style.
		/// </summary>
		public event Kimono.StyleEventDelegate RemoveStyle;

		/// <summary>
		/// Occurs when style type changed.
		/// </summary>
		public event Kimono.StyleEventDelegate StyleTypeChanged;

		/// <summary>
		/// Occurs when return to shape.
		/// </summary>
		public event Kimono.ShapeEventDelegate ReturnToShape;

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

		/// <summary>
		/// Raises the make duplicate event.
		/// </summary>
		/// <param name="style">Style.</param>
		internal void RaiseMakeDuplicate(KimonoStyle style)
		{
			// Inform caller of event
			if (MakeDuplicate != null) MakeDuplicate(style);
		}

		/// <summary>
		/// Raises the remove style event.
		/// </summary>
		/// <param name="style">Style.</param>
		internal void RaiseRemoveStyle(KimonoStyle style)
		{
			// Inform caller of event
			if (RemoveStyle != null) RemoveStyle(style);
		}

		/// <summary>
		/// Raises the style type changed event.
		/// </summary>
		/// <param name="style">Style.</param>
		internal void RaiseStyleTypeChanged(KimonoStyle style)
		{
			// Inform caller of event
			if (StyleTypeChanged != null) StyleTypeChanged(style);
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
