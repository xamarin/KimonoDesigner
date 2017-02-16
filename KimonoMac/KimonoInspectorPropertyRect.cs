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
	/// Handles the inspector view for a `KimonoPropertyRect`.
	/// </summary>
	public partial class KimonoInspectorPropertyRect : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected rect.
		/// </summary>
		private KimonoPropertyRect _selectedRect = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected rect.
		/// </summary>
		/// <value>The selected rect.</value>
		public KimonoPropertyRect SelectedRect
		{
			get { return _selectedRect; }
			set
			{
				_selectedRect = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorPropertyRect (IntPtr handle) : base (handle)
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
			XField.EditingEnded += (sender, e) =>
			{
				var value = SelectedRect.Left;
				if (float.TryParse(XField.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					var width = SelectedRect.Width;
					SelectedRect.Left = value;
					SelectedRect.Right = SelectedRect.Left + width;
					RaisePropertyModified();
				}
			};

			YField.EditingEnded += (sender, e) =>
			{
				var value = SelectedRect.Top;
				if (float.TryParse(YField.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					var height = SelectedRect.Height;
					SelectedRect.Top = value;
					SelectedRect.Bottom = SelectedRect.Top + height;
					RaisePropertyModified();
				}
			};

			WidthField.EditingEnded += (sender, e) =>
			{
				var value = SelectedRect.Width;
				if (float.TryParse(WidthField.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					SelectedRect.Width = value;
					RaisePropertyModified();
				}
			};

			HeightField.EditingEnded += (sender, e) =>
			{
				var value = SelectedRect.Height;
				if (float.TryParse(HeightField.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					SelectedRect.Height = value;
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
			XField.FloatValue = SelectedRect.Left;
			YField.FloatValue = SelectedRect.Top;
			WidthField.FloatValue = SelectedRect.Width;
			HeightField.FloatValue = SelectedRect.Height;
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
			if (PropertyModified != null) PropertyModified(SelectedRect);
		}
		#endregion
	}
}
