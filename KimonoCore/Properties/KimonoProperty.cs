using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a property that can be attached to another Kimono object (such as a `KimonoColor`,
	/// `KimonoStyle` or `KimonoShape`) and be used as a local variable, global variable or a 
	/// parameter or be the result of a calculation using the Obi Simple Scripting Language.
	/// </summary>
	public class KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name as a `string`.</value>
		public string Name { get; set; } = "Property";

		/// <summary>
		/// Gets or sets the usage of this property.
		/// </summary>
		/// <value>The `KimonoPropertyUsage` of this `KimonoProperty`.</value>
		public KimonoPropertyUsage Usage { get; set; } = KimonoPropertyUsage.GlobalVariable;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoProperty"/> is
		/// the result of an Obi Script.
		/// </summary>
		/// <value><c>true</c> if is Obi Script value; otherwise, <c>false</c>.</value>
		public virtual bool IsObiScriptValue { get; set; } = false;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoProperty"/> gets value from script.
		/// </summary>
		/// <value><c>true</c> if gets value from script; otherwise, <c>false</c>.</value>
		public virtual bool GetsValueFromScript { get; set; } = false;

		/// <summary>
		/// Gets or sets the obi script that will be used to calculate the value of this
		/// `KimonoProperty`.
		/// </summary>
		/// <value>The obi script.</value>
		public string ObiScript { get; set; } = "";
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoProperty"/> class.
		/// </summary>
		public KimonoProperty()
		{
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Evaluate this instance by executing any attached Obi Script to get the new
		/// value for the `KimonoProperty`.
		/// </summary>
		/// <returns>The result of the Obi Script execution as a `ObiScriptResult`.</returns>
		public virtual ObiScriptResult Evaluate()
		{
			var scriptResult = new ObiScriptResult();

			// Is there a script attached?
			if (IsObiScriptValue)
			{
				// TODO: Execute the script to get the new value
			}

			// Return the result of executing the script
			return scriptResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `SKRect`.
		/// </summary>
		/// <returns>The `SKRect` value.</returns>
		public virtual SKRect ToRect()
		{
			return new SKRect();
		}

		/// <summary>
		/// Converts this `KimonoProperty` to a `float`.
		/// </summary>
		/// <returns>The `float` value.</returns>
		public virtual float ToFloat()
		{
			return 0f;
		}

		/// <summary>
		/// Converts this `KimonoProperty` to an `int`.
		/// </summary>
		/// <returns>The `int` value.</returns>
		public virtual int ToInt()
		{
			return 0;
		}

		/// <summary>
		/// Converts this `KimonoProperty` to a `KimonoStyle`.
		/// </summary>
		/// <returns>The `KimonoStyle` value.</returns>
		public virtual KimonoStyle ToStyle()
		{
			return null;
		}

		/// <summary>
		/// Converts this `KimonoProperty` to a `bool`.
		/// </summary>
		/// <returns>The `bool` value.</returns>
		public virtual bool ToBool()
		{
			return false;
		}

		/// <summary>
		/// Converts this `KimonoProperty` to a `KimonoColor`.
		/// </summary>
		/// <returns>The color.</returns>
		public virtual KimonoColor ToColor()
		{
			return null;
		}

		/// <summary>
		/// Converts this `KimonoProperty` to a `KimonoGradient`.
		/// </summary>
		/// <returns>The gradient.</returns>
		public virtual KimonoGradient ToGradient()
		{
			return null;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public virtual KimonoProperty Clone()
		{
			// Make copy
			var newProperty = new KimonoProperty()
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				GetsValueFromScript = this.GetsValueFromScript,
				ObiScript = this.ObiScript
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
