using System;

namespace TextBase
{
	/// <summary>
	/// Defines a column in the TextBase record and allow you to override the name of the
	/// column in the TextBase database.
	/// </summary>
	[AttributeUsage (AttributeTargets.Property)]
	public class ColumnAttribute : Attribute
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the column name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:CloudKit.Net.ColumnAttribute"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		public ColumnAttribute (string name)
		{
			Name = name;
		}
		#endregion
	}
}

