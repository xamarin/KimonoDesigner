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
	/// Handles the inspector view for a given <c>KimonoSketch</c>.
	/// </summary>
	public partial class KimonoInspectorSketch : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected sketch.
		/// </summary>
		private KimonoSketch _selectedSketch = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected sketch.
		/// </summary>
		/// <value>The selected sketch.</value>
		public KimonoSketch SelectedSketch
		{
			get { return _selectedSketch; }
			set
			{
				_selectedSketch = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorSketch"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorSketch(IntPtr handle) : base(handle)
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
			SketchName.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				SelectedSketch.Name = SketchName.StringValue;
				RaiseSketchModified();
			};

			SketchWidth.EditingEnded += (sender, e) =>
			{
				var value = SelectedSketch.Width;
				if (float.TryParse(SketchWidth.StringValue, out value))
				{
					// Save undo point
					DesignSurface.SaveUndoPoint();

					SelectedSketch.Width = value;
				}
			};

			SketchHeight.EditingEnded += (sender, e) =>
			{
				var value = SelectedSketch.Height;
				if (float.TryParse(SketchHeight.StringValue, out value))
				{
					// Save undo point
					DesignSurface.SaveUndoPoint();

					SelectedSketch.Height = value;
				}
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update fields with the current shape information
			SketchName.StringValue = SelectedSketch.Name;
			SketchWidth.StringValue = SelectedSketch.Width.ToString();
			SketchHeight.StringValue = SelectedSketch.Height.ToString();
			CanvasColorCheckbox.IntValue = SelectedSketch.DrawCanvas ? 1 : 0;
			CanvasColor.Color = NSColor.FromRgba(SelectedSketch.CanvasColor.Red / 255f,
											   SelectedSketch.CanvasColor.Green / 255f,
											   SelectedSketch.CanvasColor.Blue / 255f,
											   SelectedSketch.CanvasColor.Alpha / 255f);
			OpacitySlider.IntValue = SelectedSketch.CanvasColor.Alpha;
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";

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
		/// Deletes the sketch.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeleteSketch(Foundation.NSObject sender)
		{
			// Request this shape be deleted
			RaiseRemoveSketch();
		}

		/// <summary>
		/// Duplicates the sketch.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicateSketch(Foundation.NSObject sender)
		{
			// Request that a duplicate be made
			RaiseMakeDuplicate();
		}

		/// <summary>
		/// Handles the opacity changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OpacityChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			CanvasColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedSketch.CanvasColor = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));
			OpacityValue.StringValue = $"{(int)((OpacitySlider.IntValue / 255f) * 100f)}%";
		}

		/// <summary>
		/// Handles the canvas color changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void CanvasColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Get color components
			nfloat red, green, blue, alpha;
			CanvasColor.Color.GetRgba(out red, out green, out blue, out alpha);

			// Set new color and inform caller
			SelectedSketch.CanvasColor = new SKColor((byte)(red * 255),
														 (byte)(green * 255),
														 (byte)(blue * 255),
														 (byte)(OpacitySlider.IntValue));
		}

		/// <summary>
		/// Does the canvas include a colored background?
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void HasCanvasColorChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedSketch.DrawCanvas = (CanvasColorCheckbox.IntValue == 1);
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when sketch modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchModified;

		/// <summary>
		/// Occurs when make duplicate.
		/// </summary>
		public event Kimono.PortfolioEventDelegate MakeDuplicate;

		/// <summary>
		/// Occurs when remove sketch.
		/// </summary>
		public event Kimono.PortfolioEventDelegate RemoveSketch;

		/// <summary>
		/// Raises the sketch modified event.
		/// </summary>
		internal void RaiseSketchModified()
		{
			// Inform caller of event
			if (SketchModified != null) SketchModified();
		}


		/// <summary>
		/// Raises the make duplicate event.
		/// </summary>
		internal void RaiseMakeDuplicate()
		{
			// Inform caller of event
			if (MakeDuplicate != null) MakeDuplicate();
		}

		/// <summary>
		/// Raises the remove sketch event.
		/// </summary>
		internal void RaiseRemoveSketch()
		{
			// Inform caller of event
			if (RemoveSketch != null) RemoveSketch();
		}
		#endregion
	}
}
