using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector view for a given <c>KimonoShapeText</c>.
	/// </summary>
	public partial class KimonoInspectorText : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShapeText _selectedShape = null;

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
		/// Gets or sets the selected shape.
		/// </summary>
		/// <value>The selected shape.</value>
		public KimonoShapeText SelectedShape
		{
			get { return _selectedShape; }
			set
			{
				_selectedShape = value;
				UpdateInspector();
			}
		}
		#endregion

		#region
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorText"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorText(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
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

				SelectedShape.Text = text;
				RaiseShapeModified();
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update UI
			Contents.Value = SelectedShape.Text;
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
