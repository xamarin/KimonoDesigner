using System;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

#if __IOS__ || __MACOS__ || __TVOS__
using Foundation;
#endif

namespace TextBase
{
	/// <summary>
	/// The TextBaseDatabase acts as the central controller to provide
	/// Object Relationship Management (ORM) between C# <c>Objects</c> and TextBase based records.
	/// The first time a C# Data Model Object is passed into the TextBaseDatabase
	/// a TableSchema is created and cached for reuse. This schema acts as a
	/// bridge between the C# <c>Object</c> and the records stored in the TextBase database.
	/// </summary>
	public class TextBaseDatabase
	{
		#region Computed Properties
		/// <summary>
		/// A dictionary of tables that have been defined against this CloudKit database connection.
		/// </summary>
		public List<TableSchema> Tables = new List<TableSchema>();
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseDatabase"/> class.
		/// </summary>
		public TextBaseDatabase()
		{

		}
		#endregion

		#region Schema Handlers
		/// <summary>
		/// Gets the table schema for the given object type. If the schema does not exist, it
		/// will be created first.
		/// </summary>
		/// <returns>The schema.</returns>
		/// <param name="type">Type.</param>
		public TableSchema GetSchema(Type type)
		{
			TableSchema schema;

			// Find schema
			foreach (TableSchema table in Tables)
			{
				// Found?
				if (type.FullName == table.FullName)
				{
					// Yes, return table
					return table;
				}
			}

			// Not found, create new schema and add to collection
			schema = new TableSchema(type);
			Tables.Add(schema);

			return schema;
		}

		/// <summary>
		/// Gets the schema for the given table name.
		/// </summary>
		/// <returns>The schema.</returns>
		/// <param name="tableName">Table name.</param>
		public TableSchema GetSchema(string tableName)
		{
			TableSchema schema = null;

			// Find schema
			foreach (TableSchema table in Tables)
			{
				// Found?
				if (table.TableName == tableName)
				{
					// Yes, return table
					return table;
				}
			}

			// Report issue
			Console.WriteLine("Error: Can't load schema for table '{0}'.", tableName);

			// Not found
			return schema;
		}

		/// <summary>
		/// Gets the table schema for the given object type. If the schema does not exist, it
		/// will be created first.
		/// </summary>
		/// <returns>The schema.</returns>
		/// <typeparam name="T">The class type to get the schema for.</typeparam>
		public TableSchema GetSchema<T>()
		{
			return GetSchema(typeof(T));
		}

		/// <summary>
		/// Registers a class definition as a TextBase Table Schema.
		/// </summary>
		/// <typeparam name="T">The type of class to register a table schema for.</typeparam>
		public void Register<T>()
		{
			// Use GetSchema to register a new table schema
			GetSchema(typeof(T));
		}

		/// <summary>
		/// Registers a class definition as a TextBase Table Schema.
		/// </summary>
		/// <param name="keyPrefix">Key prefix.</param>
		/// <typeparam name="T">The type of class to register a table schema for.</typeparam>
		public void Register<T>(string keyPrefix)
		{
			// Use GetSchema to register a new table schema
			var schema = GetSchema(typeof(T));
			schema.KeyPrefix = keyPrefix;
		}
		#endregion

		#region Save Records
		/// <summary>
		/// Save the specified Data Model Object to the TextBase database.
		/// </summary>
		/// <param name="obj">The C# object to save.</param>
		public string Save(object obj)
		{
			return Save(obj, obj.GetType());
		}

		/// <summary>
		/// Save the specified obj and type to the TextBase database.
		/// </summary>
		/// <param name="obj">The C# object to save.</param>
		/// <param name="type">The object's type.</param>
		internal string Save(object obj, Type type)
		{

			// Load the schema
			var schema = GetSchema(type);

			// Get the current record ID
			var recordID = PrimaryKey(obj, type, schema);

			// Convert to TextBase record
			var record = new TextBaseRecord(schema.TableName, ClassToRecord(schema, obj));

			// Return resulting record
			return record;
		}
		#endregion

		#region Load Records
		/// <summary>
		/// Load the specified record.
		/// </summary>
		/// <returns>A C# object of the given type, or `null` on error.</returns>
		/// <param name="record">The TextRecord formatted data.</param>
		/// <typeparam name="T">The type of the object to load.</typeparam>
		public T Load<T>(string record)
		{
			Object obj = null;

			// Strip terminator
			record = record.Replace("^", "");

			// Trap all errors
			try
			{
				// Grab schema for table
				var schema = GetSchema<T>();

				// Convert to table record
				var tableRecord = new TextBaseRecord(record);

				// Do the types match?
				if (schema.TableName == tableRecord.RecordName)
				{
					// Create new instance 
					var type = typeof(T);
					obj = Activator.CreateInstance<T>();

					// Populate class instance
					RecordToClass(schema, tableRecord.RecordValue, obj);
				}
				else
				{
					// Return default for failure
					obj = default(T);
				}
			}
			catch
			{
				// Return default for failure
				obj = default(T);
			}

			// Return results
			return (T)obj;
		}

		/// <summary>
		/// Load the specified record.
		/// </summary>
		/// <returns>A C# object of the type specified in the record data, or `null` on error.</returns>
		/// <param name="record">The TextRecord formatted data.</param>
		public object Load(string record)
		{
			// Strip terminator
			record = record.Replace("^", "");

			// Trap all errors
			try
			{
				// Convert to table record
				var tableRecord = new TextBaseRecord(record);

				// Grab schema for table
				var schema = GetSchema(tableRecord.RecordName);

				// Found schema?
				if (schema == null)
				{
					// Return default for failure
					return null;
				}
				else
				{
					// Create new instance 
					var obj = Activator.CreateInstance(schema.MappedTo);
					RecordToClass(schema, tableRecord.RecordValue, obj);

					// Return class
					return obj;
				}
			}
			catch
			{
				// Return null on failure
				return null;
			}
		}

		/// <summary>
		/// Load the specified record into the given object.
		/// </summary>
		/// <param name="record">The TextRecord formatted data.</param>
		/// <param name="obj">The object to load the data into.</param>
		public void Load(string record, object obj)
		{
			// Strip terminator
			record = record.Replace("^", "");

			// Trap all errors
			try
			{
				// Convert to table record
				var tableRecord = new TextBaseRecord(record);

				// Grab schema for table
				var schema = GetSchema(tableRecord.RecordName);

				// Was the schema found?
				if (schema == null)
				{
					// Get type and schema
					var type = obj.GetType();
					schema = GetSchema(type);
				}

				// Do the types match?
				if (schema.TableName == tableRecord.RecordName)
				{
					// Load instance from data 
					RecordToClass(schema, tableRecord.RecordValue, obj);

				}
			}
			catch
			{
				// Ignore errors
			}
		}
		#endregion

		#region Child Record Handlers
		/// <summary>
		/// Saves a child object to the TextBase stream.
		/// </summary>
		/// <returns>The child object converted to a TableRecord string.</returns>
		/// <param name="parentID">The ID of the parent object.</param>
		/// <param name="obj">The C# object to save.</param>
		/// <param name="requireForeignKey">If set to <c>true</c>, requires a foreign key.</param>
		internal string SaveChild(string parentID, object obj, bool requireForeignKey)
		{

			// Load the schema
			var type = obj.GetType();
			var schema = GetSchema(type);

			// Is a foreign key required?
			if (requireForeignKey ) {
				if (schema.ForeignKey == null)
				{
					throw new MissingForeignKeyException(string.Format("Class {0} has not defined the required ForeignKey attribute that is required to be used in a List marked with the Children attribute.", schema.TableName));
				}
				else
				{
					// Save the parent ID
					UpdateForeignKey(obj, type, schema, parentID);
				}
			}

			// Get the current record ID
			var recordID = PrimaryKey(obj, type, schema);

			// Convert to table record
			var record = new TextBaseRecord(schema.TableName, ClassToRecord(schema, obj));

			// Return record
			return record;
		}

		/// <summary>
		/// Loads a child object from a TableRecord string.
		/// </summary>
		/// <returns>The child C# object.</returns>
		/// <param name="type">The type of the object to create.</param>
		/// <param name="record">The TableRecord formatted string.</param>
		internal object LoadChild(Type type, string record)
		{
			// Strip terminator
			record = record.Replace("^", "");

			// Trap all errors
			try
			{
				// Convert to table record
				var tableRecord = new TextBaseRecord(record);

				// Grab schema for table
				var schema = GetSchema(tableRecord.RecordName);

				// Was the schema found?
				if (schema == null)
				{
					// No, try getting the requested type
					schema = GetSchema(type);
				}

				// Do the types match?
				if (schema.TableName == tableRecord.RecordName)
				{
					// Create new instance 
					var obj = Activator.CreateInstance(schema.MappedTo);
					RecordToClass(schema, tableRecord.RecordValue, obj);

					// Return class
					return obj;
				}
			}
			catch
			{
				// Stop processing on error
			}

			// Return default for failure
			return null;
		}

		/// <summary>
		/// Loads all children from a given RecordField.
		/// </summary>
		/// <returns>All C# child objects.</returns>
		/// <param name="type">The type of the object to create.</param>
		/// <param name="record">The RecordField formatted string to load the children from.</param>
		internal List<object> LoadAllChildren(Type type, string record)
		{
			List<object> results = new List<object>();

			// Split the data into it's base parts
			char[] delimiterChars = { '^' };
			string[] children = record.Split(delimiterChars);

			// Handle all sub records
			foreach (string child in children)
			{
				// Does this child contain data?
				if (child != "")
				{
					// Yes, attempt to load
					var obj = LoadChild(type, child);
					if (obj != null) results.Add(obj);
				}
			}

			// Return Results
			return results;
		}
		#endregion

		#region Record ID Handlers
		/// <summary>
		/// Checks to see if the primary key has already been defined. If not, the
		/// key is populated and returned.
		/// </summary>
		/// <returns>The primary key.</returns>
		/// <param name="obj">Object.</param>
		/// <param name="type">Type.</param>
		/// <param name="schema">Schema.</param>
		private string CreatePrimaryKey(object obj, Type type, TableSchema schema)
		{
			PropertyInfo key;
			string recordID = "";

			// Scan for primary key
			while (type != null)
			{
				// Get primary key
				var info = type.GetTypeInfo();
				key = info.GetDeclaredProperty(schema.PrimaryKey.PropertyName);

				// Key found?
				if (key != null)
				{
					// Get current value
					recordID = (string)key.GetValue(obj, null);

					// Is the key defined?
					if (string.IsNullOrEmpty(recordID))
					{
						// Create new ID
						recordID = Guid.NewGuid().ToString();
						key.SetValue(obj, recordID, null);
					}
					break;
				}

				// Move to parent object
				type = info.BaseType;
			}

			return recordID;
		}

		/// <summary>
		/// Gets the current primary key value
		/// </summary>
		/// <returns>The key.</returns>
		/// <param name="obj">Object.</param>
		/// <param name="type">Type.</param>
		/// <param name="schema">Schema.</param>
		private string PrimaryKey(object obj, Type type, TableSchema schema)
		{
			PropertyInfo key;
			string recordID = "";

			// Scan for primary key
			while (type != null)
			{
				// Get primary key
				var info = type.GetTypeInfo();
				key = info.GetDeclaredProperty(schema.PrimaryKey.PropertyName);

				// Key found?
				if (key != null)
				{
					// Get current value
					return (string)key.GetValue(obj, null);
				}

				// Move to parent object
				type = info.BaseType;
			}

			return recordID;
		}

		/// <summary>
		/// Updates the primary key.
		/// </summary>
		/// <param name="obj">Object.</param>
		/// <param name="type">Type.</param>
		/// <param name="schema">Schema.</param>
		/// <param name="recordID">Record I.</param>
		private void UpdatePrimaryKey(object obj, Type type, TableSchema schema, string recordID)
		{
			PropertyInfo key;

			// Scan for primary key
			while (type != null)
			{
				// Get primary key
				var info = type.GetTypeInfo();
				key = info.GetDeclaredProperty(schema.PrimaryKey.PropertyName);

				// Key found?
				if (key != null)
				{
					// Set new value and return
					key.SetValue(obj, recordID, null);
					break;
				}

				// Move to parent object
				type = info.BaseType;
			}

		}

		/// <summary>
		/// Updates the foreign key.
		/// </summary>
		/// <param name="obj">Object.</param>
		/// <param name="type">Type.</param>
		/// <param name="schema">Schema.</param>
		/// <param name="recordID">Record I.</param>
		private void UpdateForeignKey(object obj, Type type, TableSchema schema, string recordID)
		{
			PropertyInfo key;

			// Scan for primary key
			while (type != null)
			{
				// Get primary key
				var info = type.GetTypeInfo();
				key = info.GetDeclaredProperty(schema.ForeignKey.PropertyName);

				// Key found?
				if (key != null)
				{
					// Set new value and return
					key.SetValue(obj, recordID, null);
					break;
				}

				// Move to parent object
				type = info.BaseType;
			}

		}
		#endregion

		#region Record Converters			
		/// <summary>
		/// Converts a C# class instance into a <c>CKRecord</c>.
		/// </summary>
		/// <param name="schema">Schema.</param>
		/// <param name="obj">Object.</param>
		private string ClassToRecord(TableSchema schema, object obj)
		{

			var record = "";

			// Copy property values over to TextBase record
			foreach (TableColumn column in schema.Columns)
			{
				// Trap serilization errors
				try
				{
					// Take action based on the column type
					if (column.Serializer != "")
					{
						// This column is requestion a custom serializer
						if (RequestCustomSerialization != null)
						{
							// Serialize and store as string
							record += new TextBaseRecordField(schema.KeyPrefix, column.Name, RequestCustomSerialization(column.Serializer, column.GetValue(obj)));
						}
						else
						{
							throw new MissingSerializerException(string.Format("Unable to handle the request to use custom serializer {0} for column {1} because no custom serializer has been defined for event RequestCustomSerialization.", column.Serializer, column.Name));
						}
					}
					else if (column.IsChild)
					{
						// Is the object null?
						var child = column.GetValue(obj);
						if (child != null)
						{
							// Handle child records
							var childRecord = SaveChild(schema.TableName, child, false);
							record += new TextBaseRecordField(schema.KeyPrefix, column.Name, childRecord);
						}
					}
					else if (column.IsChildren)
					{
						// Get children
						IList children = (IList)column.GetValue(obj);
						if (children != null)
						{
							var childRecords = "";

							// Save each child object to the database
							foreach (object child in children)
							{
								// Handle child records
								childRecords += SaveChild(schema.TableName, child, false);
							}

							record += new TextBaseRecordField(schema.KeyPrefix, column.Name, childRecords);
						}
					}
					else if (column.SaveAsString)
					{
						// Force column to string value
						record += new TextBaseRecordField(schema.KeyPrefix, column.Name, column.GetValue(obj).ToString());
					}
					else if (column.ColumnType.BaseType == typeof(Enum))
					{
						var index = (int)column.GetValue(obj);
						record += new TextBaseRecordField(schema.KeyPrefix, column.Name, index.ToString());
					}
					else
					{
						// Save the string value
						record += new TextBaseRecordField(schema.KeyPrefix, column.Name, column.GetValue(obj).ToString());
					}
				}
				catch
				{
					// Ignore for now
				}
			}

			// Return results
			return record;
		}

		/// <summary>
		/// Converts a <c>CKRecord</c> into C# class instance.
		/// </summary>
		/// <param name="schema">Schema.</param>
		/// <param name="record">Record.</param>
		/// <param name="obj">Object.</param>
		private void RecordToClass(TableSchema schema, string record, object obj)
		{

			// Split the data into it's base parts
			char[] delimiterChars = { '~' };
			string[] fields = record.Split(delimiterChars);

			// Process all fields
			foreach (string field in fields)
			{
				// Anything in this field?
				if (field != "")
				{
					// Convert to record field
					var recordField = new TextBaseRecordField(field);

					// Load the column for this field
					var column = schema.FindColumn(recordField.FieldName);

					// Found?
					if (column != null)
					{
						// Yes, using a prefix?
						if (!string.IsNullOrEmpty(schema.KeyPrefix))
						{
							// Yes, use prefix to decode the record field's value
							recordField.Prefix = schema.KeyPrefix;
						}

						// Trap deserilization errors
						try
						{
							// Take action based on column type
							if (column.Serializer != "")
							{
								// This column is requestion a custom serializer
								if (RequestCustomDeserialization != null)
								{
									// Deserialize and save back to object
									column.SetValue(obj, RequestCustomDeserialization(column.Serializer, recordField.FieldValue));
								}
								else
								{
									throw new MissingSerializerException(string.Format("Unable to handle the request to use custom deserializer {0} for column {1} because no custom deserializer has been defined for event RequestCustomDeserialization.", column.Serializer, column.Name));
								}
							}
							else if (column.IsChild)
							{
								// Load child
								var child = LoadChild(column.ColumnType, recordField.FieldValue);

								// Save to property
								column.SetValue(obj, child);
							}
							else if (column.IsChildren)
							{
								// Load children
								IList children = (IList)column.GetValue(obj);
								IEnumerable myEnum = children as IEnumerable;
								Type entryType = myEnum.AsQueryable().ElementType;
								var items = LoadAllChildren(entryType, recordField.FieldValue);

								// Clone items into children
								children.Clear();
								foreach (object item in items)
								{
									children.Add(item);
								}
							}
							else if (column.ColumnType.BaseType == typeof(Enum))
							{
								column.SetValue(obj, Enum.Parse(column.ColumnType, recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(int))
							{
								column.SetValue(obj, int.Parse(recordField.FieldValue));
							}
							#if __IOS__ || __MACOS__ || __TVOS__
							else if (column.ColumnType == typeof(nint))
							{
								column.SetValue(obj, nint.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(nuint))
							{
								column.SetValue(obj, nuint.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(nfloat))
							{
								column.SetValue(obj, nfloat.Parse(recordField.FieldValue));
							}
							#endif
							else if (column.ColumnType == typeof(bool))
							{
								column.SetValue(obj, bool.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(double))
							{
								column.SetValue(obj, double.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(float))
							{
								column.SetValue(obj, float.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(DateTime))
							{
								column.SetValue(obj, DateTime.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(byte))
							{
								column.SetValue(obj, byte.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(Single))
							{
								column.SetValue(obj, Single.Parse(recordField.FieldValue));
							}
							else if (column.ColumnType == typeof(string))
							{
								column.SetValue(obj, recordField.FieldValue);
							}
						}
						catch
						{
							// Ignore for now
						}
					}
				}
			}
		}
		#endregion

		#region Delegates
		/// <summary>
		/// Database custom serializer.
		/// </summary>
		public delegate string DatabaseCustomSerializer(string serializer, object obj);

		/// <summary>
		/// Database custom deserializer.
		/// </summary>
		public delegate object DatabaseCustomDeserializer(string serializer, string value);
		#endregion

		#region Events
		/// <summary>
		/// Occurs when a class property has been marked with the Serializer(Name) attribute to 
		/// custom serialize the property for storage in the TextBase database.
		/// </summary>
		public event DatabaseCustomSerializer RequestCustomSerialization;

		/// <summary>
		/// Occurs when a class property has been marked with the Serializer(Name) attribute to
		/// custom deserialize a TextBase record into a class property.
		/// </summary>
		public event DatabaseCustomDeserializer RequestCustomDeserialization;
		#endregion
	}
}

