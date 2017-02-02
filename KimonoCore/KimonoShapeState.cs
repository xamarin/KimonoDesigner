using System;
namespace KimonoCore
{
	/// <summary>
	/// Holds the current state of a <c>KimonoShape</c> while it is being edited
	/// by the user.
	/// </summary>
	public enum KimonoShapeState
	{
		/// <summary>
		/// The shape is unselected.
		/// </summary>
		Unselected,

		/// <summary>
		/// The shape is being selected.
		/// </summary>
		Selected,

		/// <summary>
		/// The shape is in the edit mode and individual control points can be
		/// added, deleted, moved or adjusted.
		/// </summary>
		Editing,

		/// <summary>
		/// The shape is leaving the edit mode and needs to be completed.
		/// </summary>
		Finalizing,

		/// <summary>
		/// The shape is in the process of being built. For example, a set of
		/// shapes being added to a group.
		/// </summary>
		Constructing,

		/// <summary>
		/// The shape is being added to a group.
		/// </summary>
		Grouping
	}
}
