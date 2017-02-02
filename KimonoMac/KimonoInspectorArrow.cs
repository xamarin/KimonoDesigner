using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector view for a <c>KimonoShapeArrow</c>.
	/// </summary>
	public partial class KimonoInspectorArrow : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShapeArrow _selectedShape = null;
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
		public KimonoShapeArrow SelectedShape
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
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorArrow"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorArrow(IntPtr handle) : base(handle)
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
			InnerSlider.FloatValue = SelectedShape.HeadInnerRatio;
			InnerValue.StringValue = InnerSlider.FloatValue.ToString();
			OuterSlider.FloatValue = SelectedShape.HeadOuterRatio;
			OuterValue.StringValue = OuterSlider.FloatValue.ToString();
			StreamlinedCheckbox.IntValue = (SelectedShape.IsStreamlined) ? 1 : 0;
			HeadCheckbox.IntValue = (SelectedShape.HasStartHead) ? 1 : 0;
			TailCheckbox.IntValue = (SelectedShape.HasEndHead) ? 1 : 0;
		}

		/// <summary>
		/// Moves the inspector to the give location.
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
		/// Handles the inner value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void InnerChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedShape.HeadInnerRatio = InnerSlider.FloatValue;
			InnerValue.StringValue = InnerSlider.FloatValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the outer value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OuterChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedShape.HeadOuterRatio = OuterSlider.FloatValue;
			OuterValue.StringValue = OuterSlider.FloatValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the streamline value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void StreamlinedChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedShape.IsStreamlined = (StreamlinedCheckbox.IntValue == 1);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the has head value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void HeadChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedShape.HasStartHead = (HeadCheckbox.IntValue == 1);
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the has tail value changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void TailChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			SelectedShape.HasEndHead = (TailCheckbox.IntValue == 1);
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
