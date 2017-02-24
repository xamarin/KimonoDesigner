using System;

namespace TextBase
{
	/// <summary>
	/// Defines the foreign key in a parent child relationship.
	/// </summary>
	[AttributeUsage (AttributeTargets.Property)]
	public class ForeignKeyAttribute : Attribute
	{
	}
}

