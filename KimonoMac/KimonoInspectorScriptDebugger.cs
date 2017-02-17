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
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorScriptDebugger"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorScriptDebugger (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Updates the status of a script execution.
		/// </summary>
		/// <param name="results">The results of the last script run.</param>
		private void UpdateStatus(ObiScriptResult results)
		{
			// Display the results
			if (results.Successful)
			{
				ErrorMessage.TextColor = NSColor.Black;
				ErrorMessage.Value = "Successful!\n";

				// Show named results
				if (SelectedProperty is KimonoPropertyColor)
				{
					ErrorMessage.Value += $"Resutls: {((KimonoPropertyColor)SelectedProperty).Value.Name}";
				}
				else if (SelectedProperty is KimonoPropertyGradient)
				{
					var gradient = ((KimonoPropertyGradient)SelectedProperty).Value as KimonoGradient;

					// Adding or removing a gradient?
					if (gradient == null)
					{
						ErrorMessage.Value += $"Resutls: Clears current gradient.";
					}
					else
					{
						ErrorMessage.Value += $"Resutls: {gradient.Name}";
					}
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
			UpdateStatus(ObiScriptEngine.EvaluationResult);
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

			// Update the UI
			UpdateStatus(results);
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
