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
	/// Handles the inspector view for a `KimonoPropertyText`
	/// </summary>
	public partial class KimonoInspectorPropertyText : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected text.
		/// </summary>
		private KimonoPropertyText _selectedText = null;

		/// <summary>
		/// Indicates of the first change has been made to a textbox. This is used to keep from
		/// creating an undo point on every character that the user chages in the textbox's text.
		/// </summary>
		private bool FirstChange = true;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected text.
		/// </summary>
		/// <value>The selected text.</value>
		public KimonoPropertyText SelectedText
		{
			get { return _selectedText; }
			set
			{
				_selectedText = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorPropertyText (IntPtr handle) : base (handle)
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
			Contents.TextChanged += (text) =>
			{   // Save undo point based on edit state
				if (FirstChange)
				{
					DesignSurface.SaveUndoPoint();
					FirstChange = false;
				}
				else
				{
					DesignSurface.ReplaceUndoPoint();
				}

				SelectedText.Value = text;
				RaisePropertyModified();
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update UI
			Contents.Value = SelectedText.Value;
			Contents.Editable = !SelectedText.GetsValueFromScript;
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
			if (PropertyModified != null) PropertyModified(SelectedText);
		}
		#endregion
	}
}
