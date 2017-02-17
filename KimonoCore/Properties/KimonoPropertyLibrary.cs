using System;
using SkiaSharp;

namespace KimonoCore
{
	public class KimonoPropertyLibrary : KimonoProperty
	{
		#region Computed Properties
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
		public KimonoPropertyLibrary()
		{
			// Initialize
			Name = "Script Library";
			ObiScript = "// Add one or more ObiScript `function` definitions to this library,\n" +
				"// then add `using library-name;` to the top of any other ObiScript to use these\n" +
				"// functions inside of that script.";
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
				// Execute the script to check for errors
				ObiScriptEngine.Runtime.Execute(ObiScript);

			}

			// Return the result of executing the script
			return ObiScriptEngine.EvaluationResult;
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
			var newProperty = new KimonoPropertyLibrary()
			{
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
