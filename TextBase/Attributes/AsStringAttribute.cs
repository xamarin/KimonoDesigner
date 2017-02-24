using System;

namespace TextBase
{
	/// <summary>
	/// Force a property to be stored to the TextBase database as a string.
	/// </summary>
	[AttributeUsage (AttributeTargets.Property)]
	public class AsStringAttribute : Attribute
	{
	}
}

