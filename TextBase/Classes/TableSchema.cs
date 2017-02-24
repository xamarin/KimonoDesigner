using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace TextBase
{
	/// <summary>
	/// Holds all schema information about the design of a Table (<c>Record Type</c>) that has been
	/// defined in a TextBase Database. This infomation is built by running reflection against a 
	/// C# object passed in as the data model for the table.
	/// </summary>
	public class TableSchema
	{
		#region Computed Properties
		/// <summary>
		/// Gets the class <c>Type</c> that this <see cref="CloudKit.Net.TableSchema"/> is mapped to.
		/// </summary>
		/// <value>The mapped to.</value>
		public Type MappedTo { get; }

		/// <summary>
		/// Gets the full name.
		/// </summary>
		/// <value>The full name.</value>
		public string FullName { get; }

		/// <summary>
		/// Gets or sets the list of <see cref="CloudKit.Net.TableColumn"/> that define the schema
		/// of this Table.
		/// </summary>
		/// <value>The columns.</value>
		public List<TableColumn> Columns { get; set; } = new List<TableColumn>();

		/// <summary>
		/// Gets the name of the table.
		/// </summary>
		/// <value>The name of the table.</value>
		public string TableName { get; }

		/// <summary>
		/// Gets the primary key.
		/// </summary>
		/// <value>The primary key.</value>
		public TableColumn PrimaryKey { get; }

		/// <summary>
		/// Gets the foreign key.
		/// </summary>
		/// <value>The foreign key.</value>
		public TableColumn ForeignKey { get; }

		/// <summary>
		/// Gets or sets the key prefix.
		/// </summary>
		/// <value>The key prefix.</value>
		/// <remarks>If the keys are not unique across all tables in the database, use this prefix to ensure that the record IDs stay unique.</remarks>
		public string KeyPrefix { get; set; } = "";
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TableSchema"/> class.
		/// </summary>
		/// <param name="type">The object type that a schema is being created for.</param>
		public TableSchema(Type type)
		{
			// Save type
			MappedTo = type;
			FullName = type.FullName;

			// Get table name
			var tableAttr = type.GetCustomAttribute<TableAttribute>();
			TableName = (tableAttr != null) ? tableAttr.Name : MappedTo.Name;

			// Get list of properties
			var properties = MappedTo.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty);

			// Assemble column list
			Columns.Clear();
			foreach (PropertyInfo property in properties)
			{
				// Ignore this column?
				var ignore = (property.GetCustomAttribute<IgnoreAttribute>() != null);

				// Add column to collection?
				if (property.CanWrite && !ignore)
				{
					var column = new TableColumn(property);

					// Is this the primary key?
					if (column.IsPrimaryKey)
						PrimaryKey = column;

					// Is this the foreign key?
					if (column.IsForeignKey)
						ForeignKey = column;

					// Save column
					Columns.Add(column);
				}
			}

			// Was a primary key found?
			if (PrimaryKey == null)
			{
				// No, make the first field a primary key
				PrimaryKey = Columns[0];
			}
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Finds the column.
		/// </summary>
		/// <returns>The column if found, else `null`.</returns>
		/// <param name="name">The name of the column to find.</param>
		public TableColumn FindColumn(string name)
		{
			// Scan all columns
			foreach (TableColumn column in Columns)
			{
				// Found?
				if (column.Name == name) return column;
			}

			// Not found
			return null;
		}
		#endregion
	}
}

