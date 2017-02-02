using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector view for the <c>KimonoShapePolygon</c>.
	/// </summary>
	public partial class KimonoInspectorPolygon : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShapePolygon _selectedShape = null;
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
		public KimonoShapePolygon SelectedShape
		{
			get { return _selectedShape; }
			set
			{
				_selectedShape = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorPolygon"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorPolygon(IntPtr handle) : base(handle)
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
			SidesSlider.IntValue = SelectedShape.NumberOfSides;
			SidesValue.StringValue = SidesSlider.IntValue.ToString();

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
		/// Handles the number of sides changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SidesChanged(Foundation.NSObject sender)
		{
			DesignSurface.SaveUndoPoint();
			SelectedShape.NumberOfSides = SidesSlider.IntValue;
			SidesValue.StringValue = SidesSlider.IntValue.ToString();
			RaiseShapeModified();
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
