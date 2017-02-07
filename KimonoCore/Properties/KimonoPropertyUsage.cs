using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines how a `KimonoProperty` is used when it is attached to a
	/// `KimonoShape`, `KimonoSketch` or `KimonoPortfolio`.
	/// </summary>
	public enum KimonoPropertyUsage
	{
		/// <summary>
		/// The given `KimonoProperty` will be used as a local variable in the 
		/// generated code for a Kimono object.
		/// </summary>
		LocalVariable,

		/// <summary>
		/// The given `KimonoProperty` will be used as a global variable in the
		/// generated code for a Kimono object.
		/// </summary>
		GlobalVariable,

		/// <summary>
		/// The given `KimonoProperty` will be used as a passed parameter in the
		/// generated code for a Kimono object.
		/// </summary>
		Parameter
	}
}
