using System;
namespace TextBase
{
	/// <summary>
	/// Holds a name, value pair that will form the basis of a `TextBaseRecord` or
	/// `TextBaseRecordField`.
	/// </summary>
	public class TextBaseNamedValue
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name of the represented value.</value>
		public string Name { get; set; } = "";

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public string Value { get; set; } = "";
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseNamedValue"/> class.
		/// </summary>
		public TextBaseNamedValue()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseNamedValue"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="value">Value.</param>
		public TextBaseNamedValue(string name, string value)
		{
			// Initialize
			Name = name;
			Value = value;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseNamedValue"/> class.
		/// </summary>
		/// <param name="data">Data.</param>
		public TextBaseNamedValue(string data)
		{
			// Split parts
			var n = data.IndexOf(':');

			// Found?
			if (n < 1)
			{
				Name = data;
				Value = "";
			}
			else
			{
				Name = data.Substring(0, n);
				Value = data.Substring(n + 1, (data.Length - (n + 1)));
			}
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:TextBase.TextBaseNamedValue"/>.
		/// </summary>
		/// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:TextBase.TextBaseNamedValue"/>.</returns>
		public override string ToString()
		{
			return string.Format("{0}: {1}]", Name, Value);
		}
		#endregion
	}
}
