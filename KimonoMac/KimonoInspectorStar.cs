using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector view for a <c>KimonoShapeStar</c>.
	/// </summary>
	public partial class KimonoInspectorStar : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShapeStar _selectedShape = null;
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
		public KimonoShapeStar SelectedShape
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
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorStar"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorStar(IntPtr handle) : base(handle)
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
			PointsSlider.IntValue = SelectedShape.NumberOfPoints;
			PointsValue.StringValue = PointsSlider.IntValue.ToString();
			SkipSlider.IntValue = SelectedShape.SkipPoints;
			SkipValue.StringValue = SkipSlider.IntValue.ToString();
			DepthSlider.IntValue = SelectedShape.DepthOffset;
			DepthValue.StringValue = DepthSlider.IntValue.ToString();
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
		/// Handles the number of points changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void PointsChanged(Foundation.NSObject sender)
		{
			DesignSurface.SaveUndoPoint();
			SelectedShape.NumberOfPoints = PointsSlider.IntValue;
			PointsValue.StringValue = PointsSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the skip points number changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SkipChanged(Foundation.NSObject sender)
		{
			DesignSurface.SaveUndoPoint();
			SelectedShape.SkipPoints = SkipSlider.IntValue;
			SkipValue.StringValue = SkipSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the point depth value chainging.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DepthChanged(Foundation.NSObject sender)
		{
			DesignSurface.SaveUndoPoint();
			SelectedShape.DepthOffset = DepthSlider.IntValue;
			DepthValue.StringValue = DepthSlider.IntValue.ToString();
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
