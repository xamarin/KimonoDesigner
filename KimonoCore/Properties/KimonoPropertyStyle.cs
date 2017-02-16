using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `KimonoStyle` value.
	/// </summary>
	public class KimonoPropertyStyle : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The `KimonoStyle` value.</value>
		public KimonoStyle Value { get; set; } = new KimonoStyle();

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
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyStyle"/> class.
		/// </summary>
		public KimonoPropertyStyle()
		{
			// Initialize
			Name = "Style Property";
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
		/// Converts this `KimonoProperty` to a `KimonoStyle`.
		/// </summary>
		/// <returns>The `KimonoStyle` value.</returns>
		public override KimonoStyle ToStyle()
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
			var newProperty = new KimonoPropertyStyle()
			{
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				GetsValueFromScript = this.GetsValueFromScript,
				ObiScript = this.ObiScript,
				Value = this.Value.Clone(true)
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
