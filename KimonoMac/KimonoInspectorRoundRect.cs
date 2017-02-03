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
	/// Handles the inspector view for a <c>KimonoShapeRoundRect</c>.
	/// </summary>
	public partial class KimonoInspectorRoundRect : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShapeRoundRect _selectedRoundRect = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected round rectangle.
		/// </summary>
		/// <value>The selected round rectangle.</value>
		public KimonoShapeRoundRect SelectedRoundRect
		{
			get { return _selectedRoundRect; }
			set
			{
				_selectedRoundRect = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorRoundRect"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorRoundRect(IntPtr handle) : base(handle)
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
			// Update UI
			RadiusSlider.FloatValue = SelectedRoundRect.CornerRadius;
			RadiusValue.StringValue = RadiusSlider.IntValue.ToString();
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
		/// Handles the radius changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void RadiusChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedRoundRect.CornerRadius = RadiusSlider.FloatValue;

			// Update UI
			RadiusValue.StringValue = RadiusSlider.IntValue.ToString();
			RaiseShapeModified();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when shape modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ShapeModified;

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
