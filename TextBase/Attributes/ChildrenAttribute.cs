using System;

namespace TextBase
{
	/// <summary>
	/// Defines the property as a collection of children that are attached to the parent record. This ONLY
	/// works on <c>List</c> collection types and the sub type being stored in the TextBase database MUST
	/// include a ForeignKey attribute on one of its properties.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class ChildrenAttribute : Attribute
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets a comma separated list of column names used to sort the collection
		/// when the list is read back from the TextBase database. Add an astericks (*) to the
		/// end of a column name to sort descending.
		/// </summary>
		/// <value>The sort.</value>
		public string Sort { get; set; } = "";
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.ChildrenAttribute"/> class.
		/// </summary>
		public ChildrenAttribute()
		{
			// Initialize
			Sort = "";
		}
		#endregion
	}
}

