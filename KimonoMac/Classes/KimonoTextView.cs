using System;
using AppKit;
using CoreGraphics;
using Foundation;

namespace KimonoMac
{
	/// <summary>
	/// A type of <c>NSTextView</c> that provides a <c>TextChanged</c> event to monitor
	/// when the user adjust the text of the <c>KimonoShapeText</c> instance.
	/// </summary>
	[Register("KimonoTextView")]
	public class KimonoTextView : NSTextView
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoTextView"/> class.
		/// </summary>
		public KimonoTextView()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoTextView"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public KimonoTextView(IntPtr handle) : base(handle)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoTextView"/> class.
		/// </summary>
		/// <param name="frameRect">Frame rect.</param>
		public KimonoTextView(CGRect frameRect) : base(frameRect)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.KimonoTextView"/> class.
		/// </summary>
		/// <param name="coder">Coder.</param>
		public KimonoTextView(NSCoder coder) : base(coder)
		{
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Handles the value of the text field changing 
		/// </summary>
		public override void DidChangeText()
		{
			base.DidChangeText();
			RaiseTextChanged(Value);
		}
		#endregion

		#region Events
		/// <summary>
		/// Text changed delegate.
		/// </summary>
		public delegate void TextChangedDelegate(string text);

		/// <summary>
		/// Occurs when text changed.
		/// </summary>
		public event TextChangedDelegate TextChanged;

		/// <summary>
		/// Raises the text changed event.
		/// </summary>
		/// <param name="text">Text.</param>
		internal void RaiseTextChanged(string text)
		{
			if (TextChanged != null) TextChanged(text);
		}
		#endregion
	}
}
