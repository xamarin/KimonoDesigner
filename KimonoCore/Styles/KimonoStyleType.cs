using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the type of a <c>KimonoStyle</c> that will be used to draw a given
	/// <c>KimonoShape</c> in.
	/// </summary>
	public enum KimonoStyleType
	{
		/// <summary>
		/// The default style for new shapes. This style cannot be deleted or renamed by the user.
		/// </summary>
		Default,

		/// <summary>
		/// A custom style that belongs only to an individual shape instance.
		/// </summary>
		Custom,

		/// <summary>
		/// A custom text style that belongs only to an individual <c>KimonoShapeText</c> instance.
		/// </summary>
		CustomText,

		/// <summary>
		/// A shared style that can be applied to multiple <c>Kimonoshape</c> instances.
		/// </summary>
		Standard,

		/// <summary>
		/// A shared text style that can be applied to multiple <c>KimonoShapeText</c> instances.
		/// </summary>
		Text
	}
}
