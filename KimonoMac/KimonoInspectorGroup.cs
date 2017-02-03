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
	/// Handles the inspector view for a given <c>KimonoShapeGroup</c>.
	/// </summary>
	public partial class KimonoInspectorGroup : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShapeGroup _selectedGroup = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the selected group.
		/// </summary>
		/// <value>The selected group.</value>
		public KimonoShapeGroup SelectedGroup
		{
			get { return _selectedGroup; }
			set
			{
				_selectedGroup = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorGroup(IntPtr handle) : base(handle)
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
			// Update UI
			BooleanCheckbox.IntValue = (SelectedGroup.IsBooleanConstruct) ? 1 : 0;
			Operation.Enabled = SelectedGroup.IsBooleanConstruct;

			// Set current operation value
			switch (SelectedGroup.BooleanOperation)
			{
				case SKPathOp.Union:
					Operation.SelectItem(0);
					break;
				case SKPathOp.Intersect:
					Operation.SelectItem(1);
					break;
				case SKPathOp.Difference:
					Operation.SelectItem(2);
					break;
				case SKPathOp.ReverseDifference:
					Operation.SelectItem(3);
					break;
				case SKPathOp.Xor:
					Operation.SelectItem(4);
					break;
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
		/// Handles the boolean operation being changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void BooleanChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			SelectedGroup.IsBooleanConstruct = (BooleanCheckbox.IntValue == 1);

			// Update UI
			Operation.Enabled = SelectedGroup.IsBooleanConstruct;
			RaiseGroupModified(SelectedGroup);
		}

		/// <summary>
		/// Handles the boolean operation changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OperationChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Save new value
			switch (Operation.IndexOfSelectedItem)
			{
				case 0:
					SelectedGroup.BooleanOperation = SKPathOp.Union;
					break;
				case 1:
					SelectedGroup.BooleanOperation = SKPathOp.Intersect;
					break;
				case 2:
					SelectedGroup.BooleanOperation = SKPathOp.Difference;
					break;
				case 3:
					SelectedGroup.BooleanOperation = SKPathOp.ReverseDifference;
					break;
				case 4:
					SelectedGroup.BooleanOperation = SKPathOp.Xor;
					break;
			}

			// Update UI
			RaiseGroupModified(SelectedGroup);
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when group modified.
		/// </summary>
		public event Kimono.GroupEventDelegate GroupModified;

		/// <summary>
		/// Raises the group modified event.
		/// </summary>
		/// <param name="group">The <c>KimonoShapeGroup</c> that was modified.</param>
		internal void RaiseGroupModified(KimonoShapeGroup group)
		{
			// Inform caller of event
			if (GroupModified != null) GroupModified(group);
		}
		#endregion
	}
}
