using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Displays the inspector for a <c>KimonoStyle</c> attached to a <c>KimonoShape</c>.
	/// </summary>
	public partial class KimonoInspectorAttachedStyle : NSView
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
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorAttachedStyle"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorAttachedStyle(IntPtr handle) : base(handle)
		{
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
			// Update fields with the current shape information
			if (SelectedStyle.StyleType == KimonoStyleType.Custom ||
				SelectedStyle.StyleType == KimonoStyleType.CustomText)
			{
				EditButton.Image = NSImage.ImageNamed("IconStyleAdd");
				EditButton.ToolTip = "Create new style";
			}
			else
			{
				EditButton.Image = NSImage.ImageNamed("IconEdit");
				EditButton.ToolTip = "Edit attached style";
			}

			// Populate the list of colors
			StyleSelector.RemoveAllItems();
			StyleSelector.AddItem("Custom");
			var n = 0;
			foreach (KimonoStyle style in Portfolio.Styles)
			{
				// Add color
				StyleSelector.AddItem(style.Name);
				++n;

				// Currently selected color?
				if (SelectedStyle == style)
				{
					// Yes, highlight it
					StyleSelector.SelectItem(n);
				}
			}
		}

		/// <summary>
		/// Moves the inspector to the given location
		/// </summary>
		/// <returns>The next location based on the size of the inspector.</returns>
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
		/// Hnadles the style changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void StyleChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on selected item
			if (StyleSelector.IndexOfSelectedItem == 0)
			{
				// Moving to a custom item
				if (SelectedStyle.StyleType != KimonoStyleType.Custom &&
				SelectedStyle.StyleType != KimonoStyleType.CustomText)
				{
					// Request style be deleted
					SelectedShape.UncoupleDeletedStyle(SelectedStyle);
					RaiseRemoveStyle(SelectedStyle);
				}
			}
			else
			{
				// Attach new style
				SelectedShape.Style = Portfolio.Styles[(int)StyleSelector.IndexOfSelectedItem - 1];
				RaiseShapeModified(SelectedShape);
			}
		}

		/// <summary>
		/// Calls the editor for the given style.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void EditStyle(Foundation.NSObject sender)
		{
			// Take action based on style type
			if (SelectedStyle.StyleType == KimonoStyleType.Custom ||
				SelectedStyle.StyleType == KimonoStyleType.CustomText)
			{
				// Ask caller to convert to style
				RaiseConvertToStyle();
			}
			else
			{
				// Request edit this style
				RaiseEditAttachedStyle(SelectedStyle);
			}
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
		public event Kimono.ShapeEventDelegate ShapeModified;

		/// <summary>
		/// Occurs when edit attached style.
		/// </summary>
		public event Kimono.StyleEventDelegate EditAttachedStyle;

		/// <summary>
		/// Occurs when remove style.
		/// </summary>
		public event Kimono.StyleEventDelegate RemoveStyle;

		/// <summary>
		/// Occurs when convert to style.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ConvertToStyle;

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
		/// <param name="shape">Shape.</param>
		internal void RaiseShapeModified(KimonoShape shape)
		{
			// Inform caller of event
			if (ShapeModified != null) ShapeModified(shape);
		}

		/// <summary>
		/// Raises the edit attached style event.
		/// </summary>
		/// <param name="style">Style.</param>
		internal void RaiseEditAttachedStyle(KimonoStyle style)
		{
			// Inform caller of event
			if (EditAttachedStyle != null) EditAttachedStyle(style);
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
		/// Raises the convert to style event.
		/// </summary>
		internal void RaiseConvertToStyle()
		{
			// Inform caller of event
			if (ConvertToStyle != null) ConvertToStyle();
		}
		#endregion
	}
}
