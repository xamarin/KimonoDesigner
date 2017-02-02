using System;

using Foundation;
using AppKit;

namespace KimonoMac
{
	/// <summary>
	/// A type of <c>NSToolbarItem</c> that the developer can enable/disable by adjusting the 
	/// <c>Active</c> property.
	/// </summary>
	[Register("ActivatableItem")]
	public class ActivatableItem : NSToolbarItem
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoMac.ActivatableItem"/> is active.
		/// </summary>
		/// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
		public bool Active { get; set; } = true;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.ActivatableItem"/> class.
		/// </summary>
		public ActivatableItem()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.ActivatableItem"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public ActivatableItem(IntPtr handle) : base(handle)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.ActivatableItem"/> class.
		/// </summary>
		/// <param name="t">T.</param>
		public ActivatableItem(NSObjectFlag t) : base(t)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.ActivatableItem"/> class.
		/// </summary>
		/// <param name="title">Title.</param>
		public ActivatableItem(string title) : base(title)
		{
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Validate this instance.
		/// </summary>
		public override void Validate()
		{
			base.Validate();

			Enabled = Active;
		}
		#endregion
	}
}