using System;

namespace TextBase
{
	/// <summary>
	/// Used to define a custom serializer for a property type that is not
	/// natively handled by TextBase. To use this attribute the 
	/// <c>RequestCustomSerialization</c> and <c>RequestCustomDeserialization</c> events 
	/// MUST be defined on the database instance.
	/// </summary>
	[AttributeUsage (AttributeTargets.Property)]
	public class SerializerAttribute : Attribute
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the name of the custom serializer. 
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.SerializerAttribute"/> class.
		/// </summary>
		/// <param name="name">The name of the custom serializer.</param>
		public SerializerAttribute (string name)
		{
			Name = name;
		}
		#endregion
	}
}

