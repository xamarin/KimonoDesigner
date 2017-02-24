using System;

namespace TextBase
{
	/// <summary>
	/// Marks a given column in the TextBase record as the primary key. If no value is given,
	/// a unique UUID will automatically be generated when a new record is created.
	/// </summary>
	[AttributeUsage (AttributeTargets.Property)]
	public class PrimaryKeyAttribute : Attribute
	{
	}
}

