using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the result of attempting to execute an Obi Script on a `KimonoProperty`
	/// </summary>
	public class ObiScriptResult
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets a value indicating whether the Obi Script ran successfully.
		/// </summary>
		/// <value><c>true</c> if successful; otherwise, <c>false</c>.</value>
		public bool Successful { get; set; } = true;

		/// <summary>
		/// Gets or sets the error message if the Obi Script execution failed.
		/// </summary>
		/// <value>The error message or "" if the script ran successfully.</value>
		public string ErrorMessage { get; set; } = "";
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.ObiScriptResult"/> class.
		/// </summary>
		public ObiScriptResult()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.ObiScriptResult"/> class.
		/// </summary>
		/// <param name="isSuccessful">If set to <c>true</c> is successful.</param>
		/// <param name="errorMessage">Error message.</param>
		public ObiScriptResult(bool isSuccessful, string errorMessage)
		{
			// Initialize
			Successful = isSuccessful;
			ErrorMessage = errorMessage;
		}
		#endregion
	}
}
