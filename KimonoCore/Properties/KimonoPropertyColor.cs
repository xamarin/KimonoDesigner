using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `KimonoColor` value.
	/// </summary>
	public class KimonoPropertyColor : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The `KimonoColor` value.</value>
		public KimonoColor Value { get; set; } = new KimonoColor();

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.KimonoProperty"/> gets value from script.
		/// </summary>
		/// <value><c>true</c> if gets value from script; otherwise, <c>false</c>.</value>
		public override bool GetsValueFromScript
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.KimonoPropertyColor"/> is obi script value.
		/// </summary>
		/// <value><c>true</c> if is obi script value; otherwise, <c>false</c>.</value>
		public override bool IsObiScriptValue
		{
			get
			{
				return true;
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyText"/> class.
		/// </summary>
		public KimonoPropertyColor()
		{
			// Initialize
			Name = "Color Property";
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
					if (ObiScriptEngine.EvaluationResult.Value is KimonoColor)
					{
						// Yes, save it
						Value = ObiScriptEngine.EvaluationResult.Value as KimonoColor;
					}
					else
					{
						// Report this as an error
						ObiScriptEngine.EvaluationResult.Successful = false;
						ObiScriptEngine.EvaluationResult.ErrorMessage = "Error: Script did not return a named color. " +
							"Call `Return.Color(\"name\");` to return the required value.";
					}
				}
			}

			// Return the result of executing the script
			return ObiScriptEngine.EvaluationResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `KimonoColor`.
		/// </summary>
		/// <returns>The color.</returns>
		public override KimonoColor ToColor()
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
			var newProperty = new KimonoPropertyColor()
			{
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				ObiScript = this.ObiScript,
				GetsValueFromScript = this.GetsValueFromScript,
				Value = this.Value.Clone()
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
