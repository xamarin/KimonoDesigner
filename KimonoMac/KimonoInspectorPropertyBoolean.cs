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
	/// Handles the boolean property inspector.
	/// </summary>
	public partial class KimonoInspectorPropertyBoolean : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected boolean.
		/// </summary>
		private KimonoPropertyBoolean _selectedBoolean = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected round rect.
		/// </summary>
		/// <value>The selected round rect.</value>
		public KimonoPropertyBoolean SelectedBoolean
		{
			get { return _selectedBoolean; }
			set
			{
				_selectedBoolean = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorPropertyBoolean (IntPtr handle) : base (handle)
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
			if (SelectedBoolean.Value)
			{
				ValueDropdown.SelectItem(0);
			}
			else
			{
				ValueDropdown.SelectItem(1);
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
		/// Handles the value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ValueChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save value
			SelectedBoolean.Value = (ValueDropdown.IndexOfSelectedItem == 0);

			// Update the UI
			RaisePropertyModified();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when shape modified.
		/// </summary>
		public event Kimono.PropertyEventDelegate PropertyModified;

		/// <summary>
		/// Raises the shape modified event.
		/// </summary>
		internal void RaisePropertyModified()
		{
			// Inform caller of event
			if (PropertyModified != null) PropertyModified(SelectedBoolean);
		}
		#endregion
	}
}
