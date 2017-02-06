using System;
using Foundation;
using AppKit;

namespace KimonoMac
{
	/// <summary>
	/// Handles the About Box for Kimono Designer.
	/// </summary>
	public partial class AboutViewController : NSViewController
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.AboutViewController"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public AboutViewController(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Custom Actions
		/// <summary>
		/// Shows the icons8 license.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ShowIcons8License(Foundation.NSObject sender)
		{
			// Display the license for Icons8
			NSWorkspace.SharedWorkspace.OpenUrl(NSUrl.FromString("https://icons8.com/license/"));
		}
		#endregion
	}
}
