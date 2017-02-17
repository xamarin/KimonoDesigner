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
	/// Handles the script debugger inspector.
	/// </summary>
	public partial class KimonoInspectorScriptDebugger : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected property.
		/// </summary>
		private KimonoProperty _selectedProperty = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected property.
		/// </summary>
		/// <value>The selected property.</value>
		public KimonoProperty SelectedProperty
		{
			get { return _selectedProperty; }
			set
			{
				_selectedProperty = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorScriptDebugger (IntPtr handle) : base (handle)
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
		/// Evaluate the current script
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void EvalScript(Foundation.NSObject sender)
		{
			// Execute the script
			var results = SelectedProperty.Evaluate();

			// Display the results
			if (results.Successful)
			{
				ErrorMessage.TextColor = NSColor.Black;
				ErrorMessage.Value = "Successful!\n\n";

				// Show named results
				if (SelectedProperty is KimonoPropertyColor)
				{
					ErrorMessage.Value += $"Resutls: {((KimonoPropertyColor)SelectedProperty).Value.Name}";
				}
				else if (SelectedProperty is KimonoPropertyGradient)
				{
					ErrorMessage.Value += $"Resutls: {((KimonoPropertyGradient)SelectedProperty).Value.Name}";
				}
				else if (SelectedProperty is KimonoPropertyStyle)
				{
					ErrorMessage.Value += $"Resutls: {((KimonoPropertyStyle)SelectedProperty).Value.Name}";
				}
			}
			else
			{
				ErrorMessage.TextColor = NSColor.Red;
				ErrorMessage.Value = results.ErrorMessage;
			}

			// Update the UI
			RaisePropertyModified();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when property modified.
		/// </summary>
		public event Kimono.PropertyEventDelegate PropertyModified;

		/// <summary>
		/// Raises the property modified event.
		/// </summary>
		internal void RaisePropertyModified()
		{
			// Inform caller of event
			if (PropertyModified != null) PropertyModified(SelectedProperty);
		}
		#endregion
	}
}
