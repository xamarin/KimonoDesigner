using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines a connection between a given Kimono Object and a `KimonoProperty`.
	/// </summary>
	public class KimonoPropertyConnection
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the point that a given `KimonoProperty` is connected to another Kimono
		/// Object.
		/// </summary>
		/// <value>The connection point as a `KimonoPropertyConnectionPoint`.</value>
		public KimonoPropertyConnectionPoint ConnectionPoint { get; set; } = KimonoPropertyConnectionPoint.Undefined;

		/// <summary>
		/// Gets or sets the connected property.
		/// </summary>
		/// <value>The connected `KimonoProperty`.</value>
		public KimonoProperty ConnectedProperty { get; set; } = null;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyConnection"/> class.
		/// </summary>
		public KimonoPropertyConnection()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyConnection"/> class.
		/// </summary>
		/// <param name="connectionPoint">Connection point.</param>
		/// <param name="property">Property.</param>
		public KimonoPropertyConnection(KimonoPropertyConnectionPoint connectionPoint, KimonoProperty property)
		{
			// Initialize
			ConnectionPoint = connectionPoint;
			ConnectedProperty = property;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public KimonoPropertyConnection Clone()
		{
			// Make copy
			var newConnection = new KimonoPropertyConnection(this.ConnectionPoint, this.ConnectedProperty)
			{
				UniqueID = this.UniqueID
			};

			// Return copy
			return newConnection;
		}
		#endregion
	}
}
