using System;
using AppKit;
using CoreGraphics;
using Foundation;
using SkiaSharp;
using KimonoCore;

namespace KimonoCore.Mac
{
	/// <summary>
	/// The Kimono Design Surface is a Xamarin.Mac specific editing surface that allows the
	/// user to modify a given <c>KimonoPortfolio</c> and the collection of <c>KimonoSketches</c>
	/// that it maintains.
	/// </summary>
	[Register("KimonoDesignSurface")]
	public class KimonoDesignSurface : NSImageView
	{
		#region Private Variables
		/// <summary>
		/// The portfolio currently being worked on.
		/// </summary>
		private KimonoPortfolio _portfolio = new KimonoPortfolio(true);

		/// <summary>
		/// The <c>KimonoUndoHandler</c> that handles undo and redo events for the 
		/// Design Surface.
		/// </summary>
		private KimonoUndoHandler UndoHandler = new KimonoUndoHandler();
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.Mac.KimonoDesignSurface"/> can become key view.
		/// </summary>
		/// <value><c>true</c> if can become key view; otherwise, <c>false</c>.</value>
		public override bool CanBecomeKeyView
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the user can undo their last action.
		/// </summary>
		/// <value><c>true</c> if can undo; otherwise, <c>false</c>.</value>
		public bool CanUndo
		{
			get { return UndoHandler.CanUndo; }
		}

		/// <summary>
		/// Gets a value indicating whether the user can redo their last action.
		/// </summary>
		/// <value><c>true</c> if can redo; otherwise, <c>false</c>.</value>
		public bool CanRedo
		{
			get { return UndoHandler.CanRedo; }
		}

		/// <summary>
		/// Gets or sets the portfolio currently being worked on.
		/// </summary>
		/// <value>The <c>KimonoPortfolio</c>.</value>
		public KimonoPortfolio Portfolio
		{
			get { return _portfolio; }
			set
			{
				// Save change
				UnwirePortfolioEvents();
				UnwireSketchEvents(SelectedSketch);
				_portfolio = value;
				WireupPortfolioEvents();
				WireUpSketchEvents(SelectedSketch);

				// Update UI
				RaiseReloadUI();
			}
		}

		/// <summary>
		/// Gets or sets the selected sketch.
		/// </summary>
		/// <value>The selected <c>KimonoSketch</c>.</value>
		public KimonoSketch SelectedSketch
		{
			get { return Portfolio.SelectedSketch; }
			set 
			{
				UnwireSketchEvents(Portfolio.SelectedSketch);
				Portfolio.SelectedSketch = value; 
			}
		}

		/// <summary>
		/// Gets or sets the selected shape.
		/// </summary>
		/// <value>The selected <c>KimonoShape</c>.</value>
		public KimonoShape SelectedShape
		{
			get { return (SelectedSketch == null) ? null : SelectedSketch.SelectedShape; }
			set
			{
				if (SelectedSketch != null) SelectedSketch.SelectShape(value);
			}
		}

		/// <summary>
		/// Gets the deeply selected shape.
		/// </summary>
		/// <value>The deeply selected <c>KimonoShape</c>.</value>
		public KimonoShape DeeplySelectedShape
		{
			get { return (SelectedSketch == null) ? null : SelectedSketch.DeeplySelectedShape; }
		}

		/// <summary>
		/// Gets the deeply selected group.
		/// </summary>
		/// <value>The deeply selected <c>KimonoGroup</c>.</value>
		public KimonoShapeGroup DeeplySelectedGroup
		{
			get { return (SelectedSketch == null) ? null : SelectedSketch.DeeplySelectedGroup; }
		}

		/// <summary>
		/// Gets or sets the tool.
		/// </summary>
		/// <value>The current <c>KimonoTool</c>.</value>
		public KimonoTool Tool
		{
			get { return (SelectedSketch == null) ? KimonoTool.Cursor : SelectedSketch.Tool; }
			set
			{
				if (SelectedSketch != null) SelectedSketch.Tool = value;
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoDesignSurface"/> class.
		/// </summary>
		public KimonoDesignSurface()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoDesignSurface"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoDesignSurface(IntPtr handle) : base(handle)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoDesignSurface"/> class.
		/// </summary>
		/// <param name="frameRect">Frame rect.</param>
		public KimonoDesignSurface(CGRect frameRect) : base(frameRect)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.Mac.KimonoDesignSurface"/> class.
		/// </summary>
		/// <param name="coder">Coder.</param>
		public KimonoDesignSurface(NSCoder coder) : base(coder)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Converts a raw macOS mouse event point into the coordinates of the currently selected
		/// sketch's Design Surface.
		/// </summary>
		/// <returns>An <c>SKPoint</c> adjusted to the sketch's coordinate system.</returns>
		/// <param name="theEvent">The raw mouse <c>NSEvent</c>.</param>
		private SKPoint ConvertToCanvasPoint(NSEvent theEvent)
		{
			// Convert to local coordinates
			var location = theEvent.LocationInWindow;
			var point = ConvertPointFromView(location, null);

			// Return in canvas coordinates
			return new SKPoint((float)point.X, SelectedSketch.Height - (float)point.Y);
		}

		/// <summary>
		/// Wires up sketch events to this Design Surface.
		/// </summary>
		/// <param name="sketch">The <c>KimonoStech</c> to wire events for.</param>
		private void WireUpSketchEvents(KimonoSketch sketch)
		{
			// Wireup sketch events to the design surface
			sketch.RequestNewUndoPoint += SaveUndoPoint;
			sketch.ImageBufferNeedsRefresh += RefreshView;
			sketch.SketchSizeChanged += RaiseSketchSizeChanged;
			sketch.SketchModified += RaiseSketchModified;
			sketch.SelectedShapeModified += RaiseSelectedShapeModified;
			sketch.SelectionChanged += RaiseSelectionChanged;
			sketch.ToolChanged += RaiseToolChanged;
		}

		/// <summary>
		/// Unwires the sketch events from this Design Surface.
		/// </summary>
		/// <param name="sketch">The <c>KimonoSketch</c> to remove events from.</param>
		private void UnwireSketchEvents(KimonoSketch sketch)
		{
			// Wireup sketch events to the design surface
			sketch.RequestNewUndoPoint -= SaveUndoPoint;
			sketch.ImageBufferNeedsRefresh -= RefreshView;
			sketch.SketchSizeChanged -= RaiseSketchSizeChanged;
			sketch.SketchModified -= RaiseSketchModified;
			sketch.SelectedShapeModified -= RaiseSelectedShapeModified;
			sketch.SelectionChanged -= RaiseSelectionChanged;
			sketch.ToolChanged -= RaiseToolChanged;
		}

		/// <summary>
		/// Handles the currently selected sketch changing.
		/// </summary>
		/// <param name="sketch">The new <c>KimonoSketch</c> being selected.</param>
		private void HandleSketchChanging(KimonoSketch sketch)
		{
			// Wireup events for the selected sketch
			WireUpSketchEvents(sketch);

			// Redraw interface
			RefreshView();

			// Fire events to reset UI
			RaiseToolChanged(Tool);
			RaiseSketchModified();
			RaiseSelectionChanged(SelectedShape);
		}

		/// <summary>
		/// Wireups the portfolio events to this Design Surface.
		/// </summary>
		private void WireupPortfolioEvents()
		{
			// Wireup portfolio events
			Portfolio.RequestNewUndoPoint += SaveUndoPoint;
			Portfolio.SketchesModified += RaiseSketchesModified;
			Portfolio.StylesModified += RaiseStylesModified;
			Portfolio.SelectedShapeChanged += RaiseSelectionChanged;
			Portfolio.SelectedSketchWillChange += UnwireSketchEvents;
			Portfolio.ColorsModified += RaiseColorsModified;
			Portfolio.SelectedSketchDidChange += HandleSketchChanging;
			Portfolio.GradientsModified += RaiseGradientsModified;
			Portfolio.PropertyModified += RaisePropertyModified;
		}

		/// <summary>
		/// Unwires the portfolio events from this Design Surface.
		/// </summary>
		private void UnwirePortfolioEvents()
		{
			// Wireup portfolio events
			Portfolio.RequestNewUndoPoint -= SaveUndoPoint;
			Portfolio.SketchesModified -= RaiseSketchesModified;
			Portfolio.StylesModified -= RaiseStylesModified;
			Portfolio.SelectedShapeChanged -= RaiseSelectionChanged;
			Portfolio.SelectedSketchWillChange -= UnwireSketchEvents;
			Portfolio.ColorsModified -= RaiseColorsModified;
			Portfolio.SelectedSketchDidChange -= HandleSketchChanging;
			Portfolio.GradientsModified -= RaiseGradientsModified;
			Portfolio.PropertyModified -= RaisePropertyModified;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
			// Wire-up events for the initial shape
			WireUpSketchEvents(SelectedSketch);

			// Wireup portfolio events
			WireupPortfolioEvents();

			// Save an initial undo point
			SaveUndoPoint();

			// Wireup undo events
			UndoHandler.UndoStateChanged += UndoStateChanged;
		}

		/// <summary>
		/// Refreshs the Design Surface's view by redrawing the currently selected <c>KimonoSketch</c>.
		/// </summary>
		public void RefreshView()
		{
			// Get image data from sketch and display
			Image = SelectedSketch.ToImage();
		}

		/// <summary>
		/// Saves a new undo point.
		/// </summary>
		public void SaveUndoPoint()
		{
			// Save the current state of the Kimono portfolio
			UndoHandler.PushUndoPoint(Portfolio);

			//Console.WriteLine("Undo Stack {0}, Redo Stack {1}", UndoHandler.UndoStack.Count, UndoHandler.RedoStack.Count);
		}

		/// <summary>
		/// Replaces the last undo point.
		/// </summary>
		public void ReplaceUndoPoint()
		{
			// Replace the last undo point with the current one
			UndoHandler.ReplaceLastUndoPoint(Portfolio);

			//Console.WriteLine("Undo Stack {0}, Redo Stack {1}", UndoHandler.UndoStack.Count, UndoHandler.RedoStack.Count);
		}

		/// <summary>
		/// Undoes the last change.
		/// </summary>
		public void UndoChange()
		{
			// Restore previous undo point
			var previousVersion = UndoHandler.PopUndoPoint(Portfolio);

			// Found?
			if (previousVersion != null)
			{
				// Yes, make it the current version
				Portfolio = previousVersion;
			}

			//Console.WriteLine("Undo Stack {0}, Redo Stack {1}", UndoHandler.UndoStack.Count, UndoHandler.RedoStack.Count);
		}

		/// <summary>
		/// Redoes the last change.
		/// </summary>
		public void RedoChange()
		{
			// Restore previous redo point
			var previousVersion = UndoHandler.PopRedoPoint(Portfolio);

			// Found?
			if (previousVersion != null)
			{
				// Yes, make it the current version
				Portfolio = previousVersion;
			}

			//Console.WriteLine("Undo Stack {0}, Redo Stack {1}", UndoHandler.UndoStack.Count, UndoHandler.RedoStack.Count);
		}

		/// <summary>
		/// Duplicates the selected shape.
		/// </summary>
		public void DuplicateSelectedShape()
		{
			// Make duplicate of the selected shape
			if (DeeplySelectedGroup == null)
			{
				SelectedSketch?.DuplicateSelectedShape();
			}
			else
			{
				DeeplySelectedGroup?.DuplicateSelectedShape();
			}
		}

		/// <summary>
		/// Deletes the selected shape.
		/// </summary>
		public void DeleteSelectedShape()
		{
			// Delete the selected shape
			if (DeeplySelectedGroup == null)
			{
				SelectedSketch?.DeleteSelectedShape();
			}
			else
			{
				DeeplySelectedGroup?.DeleteSelectedShape();
			}
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Accepts the first responder.
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
			SelectedSketch.ToolDown(point, (int)theEvent.ClickCount, shiftKeyDown);
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
			SelectedSketch.ToolDrag(point);
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
			SelectedSketch.ToolUp(point);
			RefreshView();
		}
		#endregion

		#region Custom Actions
		/// <summary>
		/// Udoes the last change.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("undo:")]
		public void Undo(NSObject sender)
		{
			UndoChange();
		}

		/// <summary>
		/// Redoes the last change.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("redo:")]
		public void Redo(NSObject sender)
		{
			RedoChange();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when the user interface needs to be fully reloaded.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ReloadUI;

		/// <summary>
		/// Occurs when sketch size changed.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchSizeChanged;

		/// <summary>
		/// Occurs when sketches collection is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchesModified;

		/// <summary>
		/// Occurs when a sketch is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchModified;

		/// <summary>
		/// Occurs when the selected shape is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SelectedShapeModified;

		/// <summary>
		/// Occurs when selection changed.
		/// </summary>
		public event Kimono.ShapeEventDelegate SelectionChanged;

		/// <summary>
		/// Occurs when tool changed.
		/// </summary>
		public event Kimono.ToolEventDelegate ToolChanged;

		/// <summary>
		/// Occurs when styles collection is modified.
		/// </summary>
		public event Kimono.StyleEventDelegate StylesModified;

		/// <summary>
		/// Occurs when colors collection is modified.
		/// </summary>
		public event Kimono.ColorEventDelegate ColorsModified;

		/// <summary>
		/// Occurs when undo state changed.
		/// </summary>
		public event Kimono.PortfolioEventDelegate UndoStateChanged;

		/// <summary>
		/// Occurs when gradients collection is modified.
		/// </summary>
		public event Kimono.GradientEventDelegate GradientsModified;

		/// <summary>
		/// Occurs when property collection is modified.
		/// </summary>
		public event Kimono.PropertyEventDelegate PropertyModified;

		/// <summary>
		/// Raises the property modified event.
		/// </summary>
		/// <param name="property">The `KimonoProperty` that was modified.</param>
		internal void RaisePropertyModified(KimonoProperty property)
		{
			// Inform caller of event
			if (PropertyModified != null) PropertyModified(property);
		}

		/// <summary>
		/// Raises the gradients modified event.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> that was modified.</param>
		internal void RaiseGradientsModified(KimonoGradient gradient)
		{
			// Inform caller of event
			if (GradientsModified != null) GradientsModified(gradient);
		}

		/// <summary>
		/// Raises the reload user interface event.
		/// </summary>
		internal void RaiseReloadUI()
		{
			// Inform caller of event
			if (ReloadUI != null) ReloadUI();
		}

		/// <summary>
		/// Raises the sketch size changed event.
		/// </summary>
		internal void RaiseSketchSizeChanged()
		{
			// Inform caller of event
			if (SketchSizeChanged != null) SketchSizeChanged();
		}

		/// <summary>
		/// Raises the sketches modified event.
		/// </summary>
		internal void RaiseSketchesModified()
		{
			// Inform caller of event
			if (SketchesModified != null) SketchesModified();
		}

		/// <summary>
		/// Raises the sketch modified event.
		/// </summary>
		internal void RaiseSketchModified()
		{
			// Inform caller of event
			if (SketchModified != null) SketchModified();
		}

		/// <summary>
		/// Raises the selected shape modified event.
		/// </summary>
		internal void RaiseSelectedShapeModified()
		{
			// Inform caller of event
			if (SelectedShapeModified != null) SelectedShapeModified();
		}

		/// <summary>
		/// Raises the selection changed event.
		/// </summary>
		/// <param name="selected">The new <c>KimonoShape</c> selected.</param>
		internal void RaiseSelectionChanged(KimonoShape selected)
		{
			if (SelectionChanged != null) SelectionChanged(selected);
		}

		/// <summary>
		/// Raises the tool changed event.
		/// </summary>
		/// <param name="tool">The new <c>KimonoTool</c> selected.</param>
		internal void RaiseToolChanged(KimonoTool tool)
		{
			if (ToolChanged != null) ToolChanged(tool);
		}

		/// <summary>
		/// Raises the styles modified event.
		/// </summary>
		/// <param name="style">The <c>KimonoStyle</c> that was modified.</param>
		internal void RaiseStylesModified(KimonoStyle style)
		{
			// Inform caller of event
			if (StylesModified != null) StylesModified(style);
		}

		/// <summary>
		/// Raises the colors modified event.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> that was modified.</param>
		internal void RaiseColorsModified(KimonoColor color)
		{
			// Inform caller of event
			if (ColorsModified != null) ColorsModified(color);
		}

		/// <summary>
		/// Raises the undo state changed event.
		/// </summary>
		internal void RaiseUndoStateChanged()
		{
			// Inform caller
			if (UndoStateChanged != null) UndoStateChanged();
		}
		#endregion
	}
}
