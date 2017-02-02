using System;
using AppKit;
using CoreGraphics;
using Foundation;

namespace KimonoMac
{
	/// <summary>
	/// Centering clip view.
	/// </summary>
	/// <remarks>
	/// Adapted from this blog post: 
	/// http://phoenixtoews.net/blog/2016/3/25/centering-a-resizable-content-view-within-a-nsscrollview-with-swift-22-and-xcode-73
	/// </remarks>
	[Register("CenteringClipView")]
	public class CenteringClipView : NSClipView
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.CenteringClipView"/> class.
		/// </summary>
		public CenteringClipView()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.CenteringClipView"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public CenteringClipView(IntPtr handle) : base(handle)
		{

		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Converts the size of the content insets to proposed bounds.
		/// </summary>
		/// <returns>The content insets to proposed bounds size.</returns>
		/// <param name="proposedBoundsSize">Proposed bounds size.</param>
		private NSEdgeInsets ConvertContentInsetsToProposedBoundsSize(CGSize proposedBoundsSize)
		{
			// Get scaling factor
			var fromBoundsToProposedBoundsFactor = (Bounds.Width > 0) ? (proposedBoundsSize.Width / Bounds.Width) : 1.0f;

			// Scale insets
			var newContentInsets = ContentInsets;
			newContentInsets.Top *= fromBoundsToProposedBoundsFactor;
			newContentInsets.Left *= fromBoundsToProposedBoundsFactor;
			newContentInsets.Bottom *= fromBoundsToProposedBoundsFactor;
			newContentInsets.Right *= fromBoundsToProposedBoundsFactor;

			// Return new insets
			return newContentInsets;
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Constrains the bounds rect.
		/// </summary>
		/// <returns>The bounds rect.</returns>
		/// <param name="proposedBounds">Proposed bounds.</param>
		public override CoreGraphics.CGRect ConstrainBoundsRect(CoreGraphics.CGRect proposedBounds)
		{
			// Anything to process
			if (DocumentView == null) return base.ConstrainBoundsRect(proposedBounds);

			// Get new bounds and insets
			var newClipBoundsRect = base.ConstrainBoundsRect(proposedBounds);
			var insets = ConvertContentInsetsToProposedBoundsSize(newClipBoundsRect.Size);

			// Get the insets in terms of the view geometry edges
			var minYInset = IsFlipped ? insets.Top : insets.Bottom;
			var maxYInset = IsFlipped ? insets.Bottom : insets.Top;
			var minXInset = insets.Left;
			var maxXInset = insets.Right;

			// Get and outset the `documentView`'s frame by the scaled contentInsets.
			var documentFrame = DocumentView.Frame;
			var outsetDocumentFrame = new CGRect(documentFrame.GetMinX() - minXInset,
												 documentFrame.GetMinY() - minYInset,
												 (documentFrame.Width + (minXInset + maxXInset)),
												 (documentFrame.Height + (minYInset + maxYInset)));

			if (newClipBoundsRect.Width > outsetDocumentFrame.Width)
			{
				newClipBoundsRect.X = outsetDocumentFrame.GetMinX() - (newClipBoundsRect.Width - outsetDocumentFrame.Width) / 2.0f;
			}
			else if (newClipBoundsRect.Width < outsetDocumentFrame.Width)
			{
				if (newClipBoundsRect.GetMaxX() > outsetDocumentFrame.GetMaxX())
				{
					newClipBoundsRect.X = outsetDocumentFrame.GetMaxX() - newClipBoundsRect.Width;
				}
				else if (newClipBoundsRect.GetMinX() < outsetDocumentFrame.GetMinX())
				{
					newClipBoundsRect.X = outsetDocumentFrame.GetMinX();
				}
			}

			if (newClipBoundsRect.Height > outsetDocumentFrame.Height)
			{
				newClipBoundsRect.Y = outsetDocumentFrame.GetMinY() - (newClipBoundsRect.Height - outsetDocumentFrame.Height) / 2.0f;
			}
			else if (newClipBoundsRect.Height < outsetDocumentFrame.Height)
			{
				if (newClipBoundsRect.GetMaxY() > outsetDocumentFrame.GetMaxY())
				{
					newClipBoundsRect.Y = outsetDocumentFrame.GetMaxY() - newClipBoundsRect.Height;
				}
				else if (newClipBoundsRect.GetMinY() < outsetDocumentFrame.GetMinY())
				{
					newClipBoundsRect.Y = outsetDocumentFrame.GetMinY();
				}
			}

			return BackingAlignedRect(newClipBoundsRect, NSAlignmentOptions.AllEdgesNearest);
		}
		#endregion

	}
}
