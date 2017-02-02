using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the type of a <c>KimonoHandle</c> that can be used as a general purpose
	/// control point to adjust the bounds of a <c>KimonoShape</c> or as a point for a
	/// vector or bezier object.
	/// </summary>
	public enum KimonoHandleType
	{
		/// <summary>
		/// A general purpose handle for a shape's bound or a control point on a 
		/// vector or bezier.
		/// </summary>
		ControlPoint,

		/// <summary>
		/// Defines a color inside of a gradient.
		/// </summary>
		GradientColor,

		/// <summary>
		/// Defines the position of a gradient in a shape object.
		/// </summary>
		GradientPosition
	}
}
