using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `float` or `int` value.
	/// </summary>
	public class KimonoPropertyNumber : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The `float` value.</value>
		public float Value { get; set; } = 0f;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyNumber"/> class.
		/// </summary>
		public KimonoPropertyNumber()
		{
			// Initialize
			Name = "Number Property";
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
			// Is there a script attached?
			if (GetsValueFromScript)
			{
				// Execute the script to get the new value
				ObiScriptEngine.Runtime.Execute(ObiScript);

				// Was the script successful?
				if (ObiScriptEngine.EvaluationResult.Successful)
				{
					// Was the right type returned?
					if (ObiScriptEngine.EvaluationResult.Value is double || ObiScriptEngine.EvaluationResult.Value is int)
					{
						// Yes, save it
						Value = (float)ObiScriptEngine.EvaluationResult.Value;
					}
					else
					{
						// Report this as an error
						ObiScriptEngine.EvaluationResult.Successful = false;
						ObiScriptEngine.EvaluationResult.ErrorMessage = "Error: Script did not return a numeric value. " +
							"Call `Return.Number(1234);` to return the required value.";
					}
				}
			}

			// Return the result of executing the script
			return ObiScriptEngine.EvaluationResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `float`.
		/// </summary>
		/// <returns>The `float` value.</returns>
		public override float ToFloat()
		{
			return Value;
		}

		/// <summary>
		/// Converts this `KimonoProperty` to an `int`.
		/// </summary>
		/// <returns>The `int` value.</returns>
		public override int ToInt()
		{
			return (int)Value;
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
			var newProperty = new KimonoPropertyNumber()
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
