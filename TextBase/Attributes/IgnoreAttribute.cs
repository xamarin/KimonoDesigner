using System;

namespace TextBase
{
	/// <summary>
	/// Marks a given property as ignored when creating a TextBase table or record. Ignored properties
	/// will not be saved or restored.
	/// </summary>
	[AttributeUsage (AttributeTargets.Property)]
	public class IgnoreAttribute : Attribute
	{
	}
}

