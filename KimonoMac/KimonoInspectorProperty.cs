using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles the general property inspector for `KimonoProperty` objects.
	/// </summary>
	public partial class KimonoInspectorProperty : NSView
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
		public KimonoInspectorProperty(IntPtr handle) : base(handle)
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
			PropertyName.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				SelectedProperty.Name = PropertyName.StringValue;
				RaisePropertyModified();
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update fields with the current shape information
			PropertyName.StringValue = SelectedProperty.Name;
			ValueFromScriptCheckbox.IntValue = (SelectedProperty.GetsValueFromScript) ? 1 : 0;
			ValueFromScriptCheckbox.Enabled = !SelectedProperty.IsObiScriptValue;

			// Show Usage
			switch (SelectedProperty.Usage)
			{
				case KimonoPropertyUsage.LocalVariable:
					PropertyUsage.SelectItem(0);
					break;
				case KimonoPropertyUsage.GlobalVariable:
					PropertyUsage.SelectItem(1);
					break;
				case KimonoPropertyUsage.Parameter:
					PropertyUsage.SelectItem(2);
					break;
			}
			PropertyUsage.Enabled = !SelectedProperty.GetsValueFromScript;

			// Show property type
			if (SelectedProperty is KimonoPropertyBoolean)
			{
				PropertyType.StringValue = "Boolean Property";
			} else if (SelectedProperty is KimonoPropertyColor)
			{
				PropertyType.StringValue = "Color Property";
			} else if (SelectedProperty is KimonoPropertyGradient)
			{
				PropertyType.StringValue = "Gradient Property";
			} else if (SelectedProperty is KimonoPropertyNumber)
			{
				PropertyType.StringValue = "Number Property";
			} else if (SelectedProperty is KimonoPropertyRect)
			{
				PropertyType.StringValue = "Rect Property";
			} else if (SelectedProperty is KimonoPropertyStyle)
			{
				PropertyType.StringValue = "Style Property";
			} else if (SelectedProperty is KimonoPropertyText)
			{
				PropertyType.StringValue = "Text Property";
			} else if (SelectedProperty is KimonoPropertyLibrary)
			{
				PropertyType.StringValue = "Script Library";
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
		/// Requests the property be deleted.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeleteProperty(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Update the UI
			RaiseRequestDeleteProperty();
		}

		/// <summary>
		/// Duplicates the property.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicateProperty(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Update the UI
			RaiseRequestDuplicateProperty();
		}

		/// <summary>
		/// Handles the value from script changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ValueFromScriptChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedProperty.GetsValueFromScript = (ValueFromScriptCheckbox.IntValue == 1);
			ObiScriptEngine.ClearResults();
			if (SelectedProperty.GetsValueFromScript) SelectedProperty.Usage = KimonoPropertyUsage.GlobalVariable;

			// Update UI
			RaisePropertyModified();
		}

		/// <summary>
		/// Usage the changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void UsageChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			switch (PropertyUsage.IndexOfSelectedItem)
			{
				case 0:
					SelectedProperty.Usage = KimonoPropertyUsage.LocalVariable;
					break;
				case 1:
					SelectedProperty.Usage = KimonoPropertyUsage.GlobalVariable;
					break;
				case 2:
					SelectedProperty.Usage = KimonoPropertyUsage.Parameter;
					break;
			}

			// Update UI
			RaisePropertyModified();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when property modified.
		/// </summary>
		public event Kimono.PropertyEventDelegate PropertyModified;

		/// <summary>
		/// Occurs when duplicate property.
		/// </summary>
		public event Kimono.PropertyEventDelegate RequestDuplicateProperty;

		/// <summary>
		/// Occurs when delete property.
		/// </summary>
		public event Kimono.PropertyEventDelegate RequestDeleteProperty;

		/// <summary>
		/// Raises the property modified event.
		/// </summary>
		internal void RaisePropertyModified()
		{
			// Inform caller of event
			if (PropertyModified != null) PropertyModified(SelectedProperty);
		}

		/// <summary>
		/// Raises the request duplicate property event.
		/// </summary>
		internal void RaiseRequestDuplicateProperty()
		{
			// Inform caller of event
			if (RequestDuplicateProperty != null) RequestDuplicateProperty(SelectedProperty);
		}

		/// <summary>
		/// Raises the request delete property event.
		/// </summary>
		internal void RaiseRequestDeleteProperty()
		{
			// Inform caller of event
			if (RequestDeleteProperty != null) RequestDeleteProperty(SelectedProperty);
		}
		#endregion
	}
}
