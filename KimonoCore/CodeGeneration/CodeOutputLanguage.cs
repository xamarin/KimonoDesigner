using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the language that code will be output in.
	/// </summary>
	public enum CodeOutputLanguage
	{
		/// <summary>
		/// Generate code for C#.
		/// </summary>
		CSharp,

		/// <summary>
		/// Generate code for the internal ObiScript scripting language.
		/// </summary>
		ObiScript,

        /// <summary>
        /// Generate code for F#
        /// </summary>
        FSharp
	}
}
