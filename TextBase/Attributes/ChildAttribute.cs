using System;

namespace TextBase
{
	/// <summary>
	/// Marks a property as a child record of the parent record.
	/// </summary>
	[AttributeUsage (AttributeTargets.Property)]
	public class ChildAttribute : Attribute
	{
	}
}

