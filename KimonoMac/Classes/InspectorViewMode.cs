using System;
namespace KimonoMac
{
	/// <summary>
	/// Used to set the current inspectors type being shown in the inspector sidebar.
	/// </summary>
	public enum InspectorViewMode
	{
		/// <summary>
		/// The general details view.
		/// </summary>
		DetailsView,

		/// <summary>
		/// The fill style view.
		/// </summary>
		FillStyleView,

		/// <summary>
		/// The border style view.
		/// </summary>
		BorderStyleView,

		/// <summary>
		/// The connection view.
		/// </summary>
		ConnectionView
	}
}
