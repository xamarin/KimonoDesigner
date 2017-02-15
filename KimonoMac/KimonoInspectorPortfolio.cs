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
	/// Handles the inspector view for a `KimonoPortfolio`.
	/// </summary>
	public partial class KimonoInspectorPortfolio : NSView
	{
		#region Private Variables
		/// <summary>
		/// The selected portfolio.
		/// </summary>
		private KimonoPortfolio _selectedPortfolio = null;

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
		/// Gets or sets the selected portfolio.
		/// </summary>
		/// <value>The selected portfolio.</value>
		public KimonoPortfolio SelectedPortfolio
		{
			get { return _selectedPortfolio; }
			set
			{
				_selectedPortfolio = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorPortfolio(IntPtr handle) : base(handle)
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
			NameField.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				SelectedPortfolio.Name = NameField.StringValue;
				RaisePortfolioModified();
			};

			NamespaceField.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				SelectedPortfolio.Namespace = NamespaceField.StringValue;
				RaisePortfolioModified();
			};

			AuthorField.EditingEnded += (sender, e) =>
			{
				// Save undo point
				DesignSurface.SaveUndoPoint();

				SelectedPortfolio.Author = AuthorField.StringValue;
				RaisePortfolioModified();
			};

			CopyrightField.TextChanged += (text) =>
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

				SelectedPortfolio.Copyright = text;
				RaisePortfolioModified();
			};
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update fields with the current shape information
			NameField.StringValue = SelectedPortfolio.Name;
			NamespaceField.StringValue = SelectedPortfolio.Namespace;
			AuthorField.StringValue = SelectedPortfolio.Author;
			CopyrightField.Value = SelectedPortfolio.Copyright;
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

		#endregion

		#region Events
		/// <summary>
		/// Occurs when portfolio modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate PortfolioModified;

		/// <summary>
		/// Raises the portfolio modified event.
		/// </summary>
		internal void RaisePortfolioModified()
		{
			// Inform caller of event
			if (PortfolioModified != null) PortfolioModified();
		}
		#endregion
	}
}
