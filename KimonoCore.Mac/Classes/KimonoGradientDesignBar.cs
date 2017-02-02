using System;
using AppKit;
using CoreGraphics;
using Foundation;
using SkiaSharp;
using KimonoCore;

namespace KimonoCore.Mac
{
	/// <summary>
	/// The Kimono Gradient Design Bar handles the control points that a user uses to graphically
	/// design a gradient in the editor.
	/// </summary>
	[Register("KimonoGradientDesignBar")]
	public class KimonoGradientDesignBar : NSImageView
	{
		#region Private Variables
		private KimonoGradient _gradient = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the gradient.
		/// </summary>
		/// <value>The gradient.</value>
		public KimonoGradient Gradient
		{
			get { return _gradient; }
			set
			{
				// Unwire any previos gradient
				if (_gradient != null)
				{
					_gradient.GradientModified -= HandleGradientModified;
					_gradient.HandleSelected -= RaiseHandleSelected;
				}

				// Save new gradient
				_gradient = value;
				RefreshView();

				// Wireup any new gradient
				if (_gradient != null)
				{
					_gradient.GradientModified += HandleGradientModified;
					_gradient.HandleSelected += RaiseHandleSelected;
				}
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoGradientDesignBar"/> class.
		/// </summary>
		public KimonoGradientDesignBar()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoGradientDesignBar"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoGradientDesignBar(IntPtr handle) : base(handle)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoGradientDesignBar"/> class.
		/// </summary>
		/// <param name="frameRect">Frame rect.</param>
		public KimonoGradientDesignBar(CGRect frameRect) : base(frameRect)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoGradientDesignBar"/> class.
		/// </summary>
		/// <param name="coder">Coder.</param>
		public KimonoGradientDesignBar(NSCoder coder) : base(coder)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Converts a raw macOS mouse event point into the coordinates of the currently selected
		/// bar's Design Surface.
		/// </summary>
		/// <returns>An <c>SKPoint</c> adjusted to the bar's coordinate system.</returns>
		/// <param name="theEvent">The raw mouse <c>NSEvent</c>.</param>
		private SKPoint ConvertToCanvasPoint(NSEvent theEvent)
		{
			// Convert to local coordinates
			var location = theEvent.LocationInWindow;
			var point = ConvertPointFromView(location, null);

			// Return in canvas coordinates
			return new SKPoint((float)point.X, (float)Frame.Height - (float)point.Y);
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Handles the gradient being modified.
		/// </summary>
		public void HandleGradientModified()
		{
			// Update the UI
			RefreshView();
		}

		/// <summary>
		/// Refreshs the view by redrawing the gradient design bar.
		/// </summary>
		public void RefreshView()
		{
			// Get image data from sketch
			var skPngdata = Gradient.DrawBar();

			// Convert to image and display
			var data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);
			Image = new NSImage(data);
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Acceptses the first responder.
		/// </summary>
		/// <returns><c>true</c>, if first responder was accepted, <c>false</c> otherwise.</returns>
		public override bool AcceptsFirstResponder()
		{
			return true;
		}

		/// <summary>
		/// Handles the user clicking the mouse
		/// </summary>
		/// <param name="theEvent">The <c>NSEvent</c> representing the mouse down.</param>
		public override void MouseDown(NSEvent theEvent)
		{
			base.MouseDown(theEvent);

			// Get the location
			var point = ConvertToCanvasPoint(theEvent);
			var shiftKeyDown = ((theEvent.ModifierFlags & NSEventModifierMask.ShiftKeyMask) == NSEventModifierMask.ShiftKeyMask);

			// Send the location to the sketch
			Gradient.BarToolDown(point, (int)theEvent.ClickCount, shiftKeyDown);
		}

		/// <summary>
		/// Handles the user dragging the mouse.
		/// </summary>
		/// <param name="theEvent">The <c>NSEvent</c> representing the mouse drag.</param>
		public override void MouseDragged(NSEvent theEvent)
		{
			base.MouseDragged(theEvent);

			// Get the location
			var point = ConvertToCanvasPoint(theEvent);

			// Send the drag to the Sketch and refresh the view
			Gradient.BarToolDrag(point);
			RefreshView();
		}

		/// <summary>
		/// Handles the user moving the mouse.
		/// </summary>
		/// <param name="theEvent">The <c>NSEvent</c> representing the mouse move.</param>
		public override void MouseMoved(NSEvent theEvent)
		{
			base.MouseMoved(theEvent);
		}

		/// <summary>
		/// Handles the user releasing a mouse button.
		/// </summary>
		/// <param name="theEvent">The <c>NSEvent</c> representing the mouse up.</param>
		public override void MouseUp(NSEvent theEvent)
		{
			base.MouseUp(theEvent);

			// Get the location
			var point = ConvertToCanvasPoint(theEvent);

			// Send mouse up to the Sketch and refresh the view
			Gradient.BarToolUp(point);
			RefreshView();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when a handle is selected.
		/// </summary>
		public event Kimono.HandleEventDelegate HandleSelected;

		/// <summary>
		/// Raises the handle selected event.
		/// </summary>
		/// <param name="handle">Handle.</param>
		internal void RaiseHandleSelected(KimonoHandle handle)
		{
			// Inform caller
			if (HandleSelected != null) HandleSelected(handle);
		}
		#endregion
	}
}
