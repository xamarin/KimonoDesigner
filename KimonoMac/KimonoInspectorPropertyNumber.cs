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
	/// Handles the inspector view for a `KimonoPropertyNumber`.
	/// </summary>
	public partial class KimonoInspectorPropertyNumber : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected number.
		/// </summary>
		private KimonoPropertyNumber _selectedNumber = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected number.
		/// </summary>
		/// <value>The selected number.</value>
		public KimonoPropertyNumber SelectedNumber
		{
			get { return _selectedNumber; }
			set
			{
				_selectedNumber = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorPropertyNumber (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
			// Wireup events
			ValueField.EditingEnded += (sender, e) =>
			{
				var value = SelectedNumber.Value;
				if (float.TryParse(ValueField.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					SelectedNumber.Value = value;
					RaisePropertyModified();
				}
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update UI
			ValueField.FloatValue = SelectedNumber.Value;
			ValueField.Enabled = !SelectedNumber.GetsValueFromScript;
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
			if (PropertyModified != null) PropertyModified(SelectedNumber);
		}
		#endregion
	}
}
