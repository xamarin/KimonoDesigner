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
	/// Handles the general <c>KimonoShape</c> inspector view.
	/// </summary>
	public partial class KimonoInspectorGeneralInfo : NSView
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
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoInspectorGeneralInfo"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoInspectorGeneralInfo(IntPtr handle) : base(handle)
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
			ShapeName.EditingEnded += (sender, e) =>
			{
				DesignSurface.SaveUndoPoint();
				SelectedShape.Name = ShapeName.StringValue;
				RaiseSketchModified();
			};

			ShapeX.EditingEnded += (sender, e) =>
			{
				var value = SelectedShape.Left;
				if (float.TryParse(ShapeX.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					SelectedShape.MoveBounds(new SKPoint(value, SelectedShape.Top));
					RaiseShapeModified();
				}
			};

			ShapeY.EditingEnded += (sender, e) =>
			{
				var value = SelectedShape.Top;
				if (float.TryParse(ShapeY.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					SelectedShape.MoveBounds(new SKPoint(SelectedShape.Left, value));
					RaiseShapeModified();
				}
			};

			ShapeWidth.EditingEnded += (sender, e) =>
			{
				var value = SelectedShape.Width;
				if (float.TryParse(ShapeWidth.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					SelectedShape.Width = value;
					RaiseShapeModified();
				}
			};

			ShapeHeight.EditingEnded += (sender, e) =>
			{
				var value = SelectedShape.Height;
				if (float.TryParse(ShapeHeight.StringValue, out value))
				{
					DesignSurface.SaveUndoPoint();
					SelectedShape.Height = value;
					RaiseShapeModified();
				}
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update fields with the current shape information
			ShapeName.StringValue = SelectedShape.Name;
			ShapeName.Enabled = (SelectedShape.State != KimonoShapeState.Constructing);
			ShapeX.StringValue = SelectedShape.Left.ToString("#");
			ShapeX.Enabled = (SelectedShape.State != KimonoShapeState.Editing);
			ShapeY.StringValue = SelectedShape.Top.ToString("#");
			ShapeY.Enabled = (SelectedShape.State != KimonoShapeState.Editing);
			ShapeWidth.StringValue = SelectedShape.Width.ToString("#");
			ShapeWidth.Enabled = (SelectedShape.State != KimonoShapeState.Editing);
			ShapeHeight.StringValue = SelectedShape.Height.ToString("#");
			ShapeHeight.Enabled = (SelectedShape.State != KimonoShapeState.Editing);
			RotationSlider.IntValue = SelectedShape.RotationDegrees;
			RotationSlider.Enabled = (SelectedShape.State != KimonoShapeState.Constructing);
			RotationValue.StringValue = RotationSlider.IntValue.ToString();
			RotationValue.Enabled = (SelectedShape.State != KimonoShapeState.Constructing);
			VisibleButton.Image = NSImage.ImageNamed((SelectedShape.Visible) ? "IconVisible" : "IconInvisible");
			EditButton.Hidden = (!SelectedShape.IsEditable);

			// Configure Group Based elements
			if (SelectedShape is KimonoShapeGroup)
			{
				// Get group
				var group = SelectedShape as KimonoShapeGroup;

				// Configure for groups
				ShapeType.StringValue = "Group";
				if (group.GroupType == KimonoShapeGroupType.Collection)
				{
					// Configure for ungrouping
					GroupUngroupButton.Image = NSImage.ImageNamed("IconUngroup");
					GroupUngroupButton.ToolTip = "Ungroup Shapes";
				}
				else
				{
					// Configure for grouping
					GroupUngroupButton.Image = NSImage.ImageNamed("IconGroup");
					GroupUngroupButton.ToolTip = "Group Shapes";
				}
				GroupUngroupButton.Hidden = false;
				EditButton.Enabled = (group.GroupType == KimonoShapeGroupType.Collection);
			}
			else
			{
				// Configure for shapes
				ShapeType.StringValue = "Shape";
				GroupUngroupButton.Hidden = true;
				EditButton.Enabled = true;
			}

			// Configure Edit Button
			if (SelectedShape.State == KimonoShapeState.Editing)
			{
				// Configure for finalize
				EditButton.Image = NSImage.ImageNamed("IconAccept");
				EditButton.ToolTip = "End Editing";
			}
			else
			{
				// Configure for editing
				var what = (SelectedShape is KimonoShapeGroup) ? "Group" : "Shape";
				EditButton.Image = NSImage.ImageNamed("IconEdit");
				EditButton.ToolTip = $"Edit {what}";
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
		/// Handles the rotation being changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void RotationChanged(Foundation.NSObject sender)
		{
			DesignSurface.SaveUndoPoint();
			SelectedShape.RotationDegrees = RotationSlider.IntValue;
			RotationValue.StringValue = RotationSlider.IntValue.ToString();
			RaiseShapeModified();
		}

		/// <summary>
		/// Handles the shape being deleted.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DeleteShape(Foundation.NSObject sender)
		{
			// Request this shape be deleted
			RaiseRemoveShape();
		}

		/// <summary>
		/// Handles the shape being duplicated.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void DuplicateShape(Foundation.NSObject sender)
		{
			// Request that a duplicate be made
			RaiseMakeDuplicate();
		}

		/// <summary>
		/// Handles the visibility changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void VisibilityChanged(Foundation.NSObject sender)
		{
			// Save an undo point
			DesignSurface.SaveUndoPoint();

			// Swap Visibility
			SelectedShape.Visible = !SelectedShape.Visible;
			RaiseShapeModified();

			// Update GUI
			VisibleButton.Image = NSImage.ImageNamed((SelectedShape.Visible) ? "IconVisible" : "IconInvisible");
		}

		/// <summary>
		/// Handles a collection of <c>KimonoShapes</c> being grouped and ungrouped.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void GroupUngroupShapes(Foundation.NSObject sender)
		{
			// Get group
			var group = SelectedShape as KimonoShapeGroup;

			// Take action based on type
			if (group.GroupType == KimonoShapeGroupType.Collection)
			{
				group.UngroupShapes();
			}
			else
			{
				group.GroupShapes();
			}

			// Update UI
			RaiseSketchModified();
			RaiseShapeModified();
			RaiseSelectionChanged(SelectedShape);
		}

		/// <summary>
		/// Edits the or finalize and editable shape such as a <c>KimonoShapeGroup</c> or <c>KimonoShapeVector</c>.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void EditOrFinalizeShape(Foundation.NSObject sender)
		{
			if (SelectedShape.State == KimonoShapeState.Editing)
			{
				SelectedShape.EndEditing();
			}
			else
			{
				SelectedShape.StartEditing();
			}

			// Update UI
			RaiseSketchModified();
			RaiseShapeModified();
			RaiseSelectionChanged(SelectedShape);
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when sketch modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchModified;

		/// <summary>
		/// Occurs when shape modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ShapeModified;

		/// <summary>
		/// Occurs when make duplicate.
		/// </summary>
		public event Kimono.PortfolioEventDelegate MakeDuplicate;

		/// <summary>
		/// Occurs when remove shape.
		/// </summary>
		public event Kimono.PortfolioEventDelegate RemoveShape;

		/// <summary>
		/// Occurs when selection changed.
		/// </summary>
		public event Kimono.ShapeEventDelegate SelectionChanged;

		/// <summary>
		/// Raises the sketch modified event.
		/// </summary>
		internal void RaiseSketchModified()
		{
			// Inform caller of event
			if (SketchModified != null) SketchModified();
		}

		/// <summary>
		/// Raises the shape modified event.
		/// </summary>
		internal void RaiseShapeModified()
		{
			// Inform caller of event
			if (ShapeModified != null) ShapeModified();
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
		/// Raises the remove shape event.
		/// </summary>
		internal void RaiseRemoveShape()
		{
			// Inform caller of event
			if (RemoveShape != null) RemoveShape();
		}

		/// <summary>
		/// Raises the selection changed event.
		/// </summary>
		/// <param name="selected">Selected.</param>
		internal void RaiseSelectionChanged(KimonoShape selected)
		{
			if (SelectionChanged != null) SelectionChanged(selected);
		}
		#endregion
	}
}
