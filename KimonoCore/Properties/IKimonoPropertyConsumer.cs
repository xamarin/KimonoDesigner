using System;
using System.Collections.Generic;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Interface for any Kimono Object that can consume a `KimonoProperty`.
	/// </summary>
	public interface IKimonoPropertyConsumer
	{
		#region Required Properties
		/// <summary>
		/// Gets the possible connection points that a `KimonoProperty` can be connected to this
		/// `KimonoShape`.
		/// </summary>
		/// <value>The array of `KimonoPropertyConnectionPoint`.</value>
		KimonoPropertyConnectionPoint[] ConnectionPoints { get; }

		/// <summary>
		/// Gets or sets the list of `KimonoProperty` objects connected to the various 
		/// `KimonoPropertyConnectionPoint`s that will need to be evaulated before drawing
		/// this `KimonoShape`.
		/// </summary>
		/// <value>The property connections.</value>
		List<KimonoPropertyConnection> PropertyConnections { get; set; }
		#endregion
	}
}
