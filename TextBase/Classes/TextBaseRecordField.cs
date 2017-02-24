using System;
namespace TextBase
{
	/// <summary>
	/// Holds the instance of a Textbase record field.
	/// </summary>
	public class TextBaseRecordField
	{
		#region Private Variables
		/// <summary>
		/// Holds the internal representation of the fields value.
		/// </summary>
		private string _value = "";
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the prefix that is used to encode sub values.
		/// </summary>
		/// <value>The prefix.</value>
		public string Prefix { get; set; } = "";

		/// <summary>
		/// Gets or sets the name of the field.
		/// </summary>
		/// <value>The name of the field.</value>
		public string FieldName { get; set; } = "";

		/// <summary>
		/// Gets or sets the field value.
		/// </summary>
		/// <value>The field value.</value>
		public string FieldValue
		{
			get { return UnescapeValue(_value); }
			set { _value = EscapeValue(value); }
		}
		#endregion

		#region Type Conversion
		/// <summary>
		/// Converts a RecordField to a string.
		/// </summary>
		/// <returns>The RecordField as a string.</returns>
		/// <param name="field">The RecordField to convert.</param>
		public static implicit operator string(TextBaseRecordField field)
		{
			return field.ToString();
		}

		/// <summary>
		/// Converts a string to a RecordField.
		/// </summary>
		/// <returns>The RecordField represented by the string.</returns>
		/// <param name="record">The string holding a RecordField.</param>
		public static implicit operator TextBaseRecordField(string record)
		{
			return new TextBaseRecordField(record);
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecordField"/> class.
		/// </summary>
		public TextBaseRecordField()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecordField"/> class.
		/// </summary>
		/// <param name="fieldName">Field name.</param>
		/// <param name="fieldValue">Field value.</param>
		public TextBaseRecordField(string fieldName, string fieldValue)
		{
			// Initialize
			FieldName = fieldName;
			Prefix = FieldName.Substring(0, 3);
			FieldValue = fieldValue;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecordField"/> class.
		/// </summary>
		/// <param name="prefix">Prefix.</param>
		/// <param name="fieldName">Field name.</param>
		/// <param name="fieldValue">Field value.</param>
		public TextBaseRecordField(string prefix, string fieldName, string fieldValue)
		{
			// Initialize
			FieldName = fieldName;
			if (prefix == "")
			{
				Prefix = FieldName.Substring(0, 3);
			}
			else
			{
				Prefix = prefix;
			}
			FieldValue = fieldValue;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecordField"/> class.
		/// </summary>
		/// <param name="record">Record.</param>
		public TextBaseRecordField(string record)
		{
			// Split the data into it's base parts
			char[] delimiterChars = { ':' };
			string[] parts = record.Split(delimiterChars);

			// Restore field
			try
			{
				FieldName = parts[0];
				Prefix = FieldName.Substring(0, 3);
				_value = parts[1];
			}
			catch
			{
				// Ignore all errors
			}
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Escapes the given value so it can be safely saved to file.
		/// </summary>
		/// <returns>The value with any control characters escaped.</returns>
		/// <param name="value">The value to escape.</param>
		private string EscapeValue(string value)
		{
			// Skip on empty string
			if (string.IsNullOrEmpty(value)) return "";

			value = value.Replace("~", $"&{Prefix}3;");
			value = value.Replace("^", $"&{Prefix}4;");
			value = value.Replace(":", $"&{Prefix}5;");
			value = value.Replace("\t", $"&{Prefix}6;");
			value = value.Replace("\n", $"&{Prefix}7;");
			return value;
		}

		/// <summary>
		/// Unescapes the given value read from a saved file.
		/// </summary>
		/// <returns>The value with any escaped characters replaced with their original values.</returns>
		/// <param name="value">The value to unescape.</param>
		private string UnescapeValue(string value)
		{
			// Skip on empty string
			if (string.IsNullOrEmpty(value)) return "";

			value = value.Replace($"&{Prefix}3;", "~");
			value = value.Replace($"&{Prefix}4;", "^");
			value = value.Replace($"&{Prefix}5;", ":");
			value = value.Replace($"&{Prefix}6;", "\t");
			value = value.Replace($"&{Prefix}7;", "\n");
			return value;
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Returns a string that represents the current RecordField.
		/// </summary>
		/// <returns>A string that represents the current RecordField.</returns>
		public override string ToString()
		{
			return $"{FieldName}:{_value}~";
		}
  		#endregion
	}
}
