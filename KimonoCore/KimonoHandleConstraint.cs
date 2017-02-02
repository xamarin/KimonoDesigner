using System;
namespace KimonoCore
{
	/// <summary>
	/// Constrains the movement of a <c>KimonoHandle</c> when it is being moved by the
	/// user.
	/// </summary>
	public enum KimonoHandleConstraint
	{
		/// <summary>
		/// No movement constraint.
		/// </summary>
		None,

		/// <summary>
		/// The handle can only be moved horizontally.
		/// </summary>
		Horizontal,

		/// <summary>
		/// The handle can only be moved vertically.
		/// </summary>
		Vertical,

		/// <summary>
		/// The handle is locked in place and cannot be moved.
		/// </summary>
		Locked
	}
}
