using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `bool` value.
	/// </summary>
	public class KimonoPropertyBoolean : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The `bool` value.</value>
		public bool Value { get; set; } = false;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyBoolean"/> class.
		/// </summary>
		public KimonoPropertyBoolean()
		{
			// Initialize
			Name = "Boolean Property";
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Evaluate this instance by executing any attached Obi Script to get the new
		/// value for the `KimonoProperty`.
		/// </summary>
		/// <returns>The result of the Obi Script execution as a `ObiScriptResult`.</returns>
		public override ObiScriptResult Evaluate()
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
		/// Converts this `KimonoProperty` to a `bool`.
		/// </summary>
		/// <returns><c>true</c>, if bool was toed, <c>false</c> otherwise.</returns>
		public override bool ToBool()
		{
			return Value;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public override KimonoProperty Clone()
		{
			// Make copy
			var newProperty = new KimonoPropertyBoolean()
			{
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				GetsValueFromScript = this.GetsValueFromScript,
				ObiScript = this.ObiScript,
				Value = this.Value
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
