using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the type of a <c>KimonoShapeGroup</c>.
	/// </summary>
	public enum KimonoShapeGroupType
	{
		/// <summary>
		/// The group is a current active selection.
		/// </summary>
		Selection,

		/// <summary>
		/// The group is a drag to select selection that is underway.
		/// </summary>
		DragSelect,

		/// <summary>
		/// The group is a collection of shape that have been grouped
		/// together and are treated as a single object in the editor.
		/// </summary>
		Collection
	}
}
