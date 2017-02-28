using System;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles a vector or bezier point inspector.
	/// </summary>
	public partial class KimonoInspectorPoint : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShape _selectedShape = null;
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
		public KimonoShape SelectedShape
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
		public KimonoInspectorPoint(IntPtr handle) : base(handle)
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
			var pointCount = 0;
			var valid = false;

			// Take action based on shape type
			if (SelectedShape is KimonoShapeVector)
			{
				var vector = SelectedShape as KimonoShapeVector;
				pointCount = vector.Points.Count;
				valid = (vector.HitHandle != null);
			}
			else if (SelectedShape is KimonoShapeBezier)
			{
				var bezier = SelectedShape as KimonoShapeBezier;
				pointCount = bezier.Points.Count;
				valid = (bezier.HitHandle != null && bezier.HitHandle.HandleType != KimonoHandleType.BezierControlPoint);
			}

			// Update UI
			DuplicateButton.Enabled = (SelectedShape.State == KimonoShapeState.Editing && valid);
			DeleteButton.Enabled = (DuplicateButton.Enabled && pointCount > 3);
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
		/// Deletes the point.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeletePoint(Foundation.NSObject sender)
		{
			var pointCount = 0;

			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on shape type
			if (SelectedShape is KimonoShapeVector)
			{
				var vector = SelectedShape as KimonoShapeVector;
				vector.RemoveSelectedPoint();
				pointCount = vector.Points.Count;
			}
			else if (SelectedShape is KimonoShapeBezier)
			{
				var bezier = SelectedShape as KimonoShapeBezier;
				bezier.RemoveSelectedPoint();
				pointCount = bezier.Points.Count;
			}

			// Update UI
			DuplicateButton.Enabled = (SelectedShape.State == KimonoShapeState.Editing && SelectedShape.HitHandle != null);
			DeleteButton.Enabled = (DuplicateButton.Enabled && pointCount > 3);
			RaiseShapeModified();
		}

		/// <summary>
		/// Duplicates the point.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicatePoint(Foundation.NSObject sender)
		{
			var pointCount = 0;

			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on shape type
			if (SelectedShape is KimonoShapeVector)
			{
				var vector = SelectedShape as KimonoShapeVector;
				vector.DuplicateSelectedPoint();
				pointCount = vector.Points.Count;
			}
			else if (SelectedShape is KimonoShapeBezier)
			{
				var bezier = SelectedShape as KimonoShapeBezier;
				bezier.DuplicateSelectedPoint();
				pointCount = bezier.Points.Count;
			}

			// Update UI
			DuplicateButton.Enabled = (SelectedShape.State == KimonoShapeState.Editing && SelectedShape.HitHandle != null);
			DeleteButton.Enabled = (DuplicateButton.Enabled && pointCount > 3);
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
