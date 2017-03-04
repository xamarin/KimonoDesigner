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
		/// Converts the shapes path to C# Skia based code.
		/// </summary>
		/// <returns>The path as code.</returns>
		string ToSkiaSharpPath();

		/// <summary>
		/// Converts the shape to C# code using the Skia library.
		/// </summary>
		/// <returns>The shape as code.</returns>
		string ToSkiaSharp();

		/// <summary>
		/// Converts this shape C# using the KimonoCore library.
		/// </summary>
		/// <returns>The kimono core.</returns>
		string ToKimonoCore();

		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		string ToCSharp(CodeOutputLibrary outputLibrary);

		string ToFSharp(CodeOutputLibrary outputLibrary);
        string ToFSharpSkia ();
        string ToFSharpKimonoCore ();

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
