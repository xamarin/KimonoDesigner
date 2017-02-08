using System;
namespace KimonoCore
{
	/// <summary>
	/// Interface for any Kimono Object that support source code generation.
	/// </summary>
	public interface IKimonoCodeGeneration
	{
		#region Required Properties
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name of the element.</value>
		string Name { get; }
		#endregion

		#region Required Methods
		/// <summary>
		/// Converts this object to source code for the given OS, Language and Library.
		/// </summary>
		/// <returns>The object represented as source code in a `string`.</returns>
		/// <param name="outputOS">The `CodeOutputOS`.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage`.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary`.</param>
		string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary);
		#endregion
	}
}
