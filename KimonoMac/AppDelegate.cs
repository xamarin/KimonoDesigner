using AppKit;
using Foundation;

namespace KimonoMac
{
	/// <summary>
	/// App delegate.
	/// </summary>
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.AppDelegate"/> class.
		/// </summary>
		public AppDelegate()
		{
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Did finish launching.
		/// </summary>
		/// <param name="notification">Notification.</param>
		public override void DidFinishLaunching(NSNotification notification)
		{
			// Insert code here to initialize your application
		}

		/// <summary>
		/// Will terminate.
		/// </summary>
		/// <param name="notification">Notification.</param>
		public override void WillTerminate(NSNotification notification)
		{
			// Insert code here to tear down your application
		}
		#endregion
	}
}
