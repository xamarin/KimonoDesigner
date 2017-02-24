using System;

namespace TextBase
{
	/// <summary>
	/// Defines a table (Record Type) in the TextBase database
	/// </summary>
	[AttributeUsage (AttributeTargets.Class)]
	public class TableAttribute : Attribute
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the table name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TableAttribute"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		public TableAttribute (string name)
		{
			Name = name;
		}
		#endregion
	}
}

