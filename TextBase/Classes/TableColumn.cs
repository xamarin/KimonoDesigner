using System;
using System.Reflection;
using System.Linq;

namespace TextBase
{
	/// <summary>
	/// Holds information about a Table Column defined in a TableSchema.
	/// </summary>
	public class TableColumn
	{
		#region Private Variables
		private PropertyInfo _property;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets the column name that will be used in the database.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; }

		/// <summary>
		/// Gets the name of the property that is the source of the column.
		/// </summary>
		/// <value>The name of the property.</value>
		public string PropertyName { get { return _property.Name; } } 

		/// <summary>
		/// Gets the type of the column.
		/// </summary>
		/// <value>The type of the column.</value>
		public Type ColumnType { get; }

		/// <summary>
		/// Gets a value indicating whether this column is a primary key.
		/// </summary>
		/// <value><c>true</c> if this instance is primary key; otherwise, <c>false</c>.</value>
		public bool IsPrimaryKey { get; }

		/// <summary>
		/// Gets a value indicating whether this column is a foreign key.
		/// </summary>
		/// <value><c>true</c> if this instance is foreign key; otherwise, <c>false</c>.</value>
		public bool IsForeignKey { get; }

		/// <summary>
		/// Gets a value indicating whether this column is a child.
		/// </summary>
		/// <value><c>true</c> if this instance is child; otherwise, <c>false</c>.</value>
		public bool IsChild { get; }

		/// <summary>
		/// Gets a value indicating whether this column contains children.
		/// </summary>
		/// <value><c>true</c> if this instance is children; otherwise, <c>false</c>.</value>
		public bool IsChildren { get; }

		/// <summary>
		/// Gets the comma separated list for columns used to sort any child objects loaded into
		/// this column.
		/// </summary>
		/// <value>The children sort.</value>
		/// <remarks>Add an astericks (*) to the end of the column name to sort descending.</remarks>
		public string ChildrenSort { get; }

		/// <summary>
		/// Gets a value indicating whether this <see cref="CloudKit.Net.TableColumn"/> is forced to save as a
		/// string in the database.
		/// </summary>
		/// <value><c>true</c> if save as string; otherwise, <c>false</c>.</value>
		public bool SaveAsString { get; }

		/// <summary>
		/// Gets the name of the custom serializer/deserializer used to store and retrieve this column
		/// from the database.
		/// </summary>
		/// <value>The serializer.</value>
		public string Serializer { get; } = "";
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TableColumn"/> class.
		/// </summary>
		/// <param name="property">The reflection information about a property.</param>
		public TableColumn (PropertyInfo property)
		{
			// Save property
			_property = property;

			// Set column name 
			var colAttr = property.GetCustomAttribute<ColumnAttribute> ();
			Name = (colAttr == null) ? property.Name : colAttr.Name;

			// Get column type
			ColumnType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

			// Is primary key?
			var primaryAttr = property.GetCustomAttribute<PrimaryKeyAttribute> ();
			IsPrimaryKey = (primaryAttr != null);

			// Is foreign key?
			var foreignAttr = property.GetCustomAttribute<ForeignKeyAttribute> ();
			IsForeignKey = (foreignAttr != null);

			// Is child?
			var childAttr = property.GetCustomAttribute<ChildAttribute> ();
			IsChild = (childAttr != null);

			// Is children?
			var childrenAttr = property.GetCustomAttribute<ChildrenAttribute> ();
			IsChildren = (childrenAttr != null);

			// Get children sort
			if (IsChildren) {
				ChildrenSort = childrenAttr.Sort;
			}

			// Save as string?
			var asStringAttr = property.GetCustomAttribute<AsStringAttribute> ();
			SaveAsString = (asStringAttr != null);

			// Set column name 
			var serializerAttr = property.GetCustomAttribute<SerializerAttribute> ();
			Serializer = (serializerAttr == null) ? "" : serializerAttr.Name;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Sets the value for this <see cref="CloudKit.Net.TableColumn"/> against an
		/// instance of the object that it was defined from.
		/// </summary>
		/// <param name="obj">The object to set value of this property on.</param>
		/// <param name="val">The new value.</param>
		public void SetValue (object obj, object val)
		{
			_property.SetValue (obj, val, null);
		}

		/// <summary>
		/// Gets the value for this <see cref="CloudKit.Net.TableColumn"/> from an instance
		/// of the object that is was defined from.
		/// </summary>
		/// <returns>The value of the property from the given object.</returns>
		/// <param name="obj">The object to read the property from.</param>
		public object GetValue (object obj)
		{
			return _property.GetValue (obj, null);
		}
		#endregion
	}
}

