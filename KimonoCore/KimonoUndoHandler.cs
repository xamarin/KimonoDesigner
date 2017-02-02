using System;
using System.Collections.Generic;

namespace KimonoCore
{
	/// <summary>
	/// Handles the undo/redo state for a <c>KimonoDesignSurface</c>.
	/// </summary>
	public class KimonoUndoHandler
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the maximum undo points.
		/// </summary>
		/// <value>The maximum undo points.</value>
		public int MaximumUndoPoints { get; set; } = 25;

		/// <summary>
		/// Gets or sets the undo stack.
		/// </summary>
		/// <value>The undo stack.</value>
		public List<KimonoPortfolio> UndoStack { get; set; } = new List<KimonoPortfolio>();

		/// <summary>
		/// Gets or sets the redo stack.
		/// </summary>
		/// <value>The redo stack.</value>
		public List<KimonoPortfolio> RedoStack { get; set; } = new List<KimonoPortfolio>();

		/// <summary>
		/// Gets a value indicating whether the user can undo their last action.
		/// </summary>
		/// <value><c>true</c> if can undo; otherwise, <c>false</c>.</value>
		public bool CanUndo
		{
			get { return (UndoStack.Count > 0); }
		}

		/// <summary>
		/// Gets a value indicating whether the user can redo their last action.
		/// </summary>
		/// <value><c>true</c> if can redo; otherwise, <c>false</c>.</value>
		public bool CanRedo
		{
			get { return (RedoStack.Count > 0); }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoUndoHandler"/> class.
		/// </summary>
		public KimonoUndoHandler()
		{
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Pushes the undo point onto the stack.
		/// </summary>
		/// <param name="portfolio">The current state of the <c>KimonoPortfolio</c>.</param>
		public void PushUndoPoint(KimonoPortfolio portfolio)
		{
			// Clear the redo stack
			RedoStack.Clear();

			// Save point and update UI
			UndoStack.Insert(0, portfolio.Clone());
			RaiseUndoStateChanged();

			// Have we reached the maximum number of points?
			if (UndoStack.Count >= MaximumUndoPoints)
			{
				// Yes, discard older points
				UndoStack.RemoveAt(UndoStack.Count - 1);
			}
		}

		/// <summary>
		/// Replaces the last undo point with the one being passed in.
		/// </summary>
		/// <param name="portfolio">The current state of the <c>KimonoPortfolio</c>.</param>
		public void ReplaceLastUndoPoint(KimonoPortfolio portfolio)
		{
			// Clear the redo stack
			RedoStack.Clear();

			// Save point
			if (UndoStack.Count > 0)
			{
				UndoStack[0] = portfolio;
			}
			else
			{
				UndoStack.Add(portfolio);
			}
			RaiseUndoStateChanged();
		}

		/// <summary>
		/// Pops the undo point off the stack.
		/// </summary>
		/// <returns>The prior state of the <c>KimonoPortfolio</c>.</returns>
		/// <param name="portfolio">The current state of the <c>KimonoPortfolio</c>.</param>
		public KimonoPortfolio PopUndoPoint(KimonoPortfolio portfolio)
		{
			// Anything to process?
			if (!CanUndo) return null;

			// Grab point
			var previousVersion = UndoStack[0];
			UndoStack.RemoveAt(0);

			// Save redo point and update UI
			RedoStack.Insert(0, portfolio);
			RaiseUndoStateChanged();

			// Return point
			return previousVersion;
		}

		/// <summary>
		/// Pops the redo point off the stack.
		/// </summary>
		/// <returns>The previous state of the <c>KimonoPortfolio</c>.</returns>
		/// <param name="portfolio">The current state of the <c>KimonoPortfolio</c>.</param>
		public KimonoPortfolio PopRedoPoint(KimonoPortfolio portfolio)
		{
			// Anything to process?
			if (!CanRedo) return null;

			// Grab point
			var previousVersion = RedoStack[0];
			RedoStack.RemoveAt(0);

			// Save redo point and update UI
			UndoStack.Insert(0, portfolio);
			RaiseUndoStateChanged();

			// Return point
			return previousVersion;
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when undo state changed.
		/// </summary>
		public event Kimono.PortfolioEventDelegate UndoStateChanged;

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
