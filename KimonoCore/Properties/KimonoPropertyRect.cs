using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `SKRect`.
	/// </summary>
	public class KimonoPropertyRect : KimonoProperty
	{
		#region Public Variables
		/// <summary>
		/// The base value of this rectangle.
		/// </summary>
		public SKRect Value = new SKRect();
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the left.
		/// </summary>
		/// <value>The left.</value>
		public float Left
		{
			get { return Value.Left; }
			set { Value.Left = value; }
		}

		/// <summary>
		/// Gets or sets the top.
		/// </summary>
		/// <value>The top.</value>
		public float Top
		{
			get { return Value.Top; }
			set { Value.Top = value; }
		}

		/// <summary>
		/// Gets or sets the right.
		/// </summary>
		/// <value>The right.</value>
		public float Right
		{
			get { return Value.Right; }
			set { Value.Right = value; }
		}

		/// <summary>
		/// Gets or sets the bottom.
		/// </summary>
		/// <value>The bottom.</value>
		public float Bottom
		{
			get { return Value.Bottom; }
			set { Value.Bottom = value; }
		}

		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width.</value>
		public float Width
		{
			get { return Value.Width; }
			set { Value.Right = Value.Left + value; }
		}

		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height.</value>
		public float Height
		{
			get { return Value.Height; }
			set { Value.Bottom = Value.Top + value; }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyRect"/> class.
		/// </summary>
		public KimonoPropertyRect()
		{
			// Initialize
			Name = "Rect Property";
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
		/// Converts this `KimonoProperty` to a `SKRect`.
		/// </summary>
		/// <returns>The `SKRect` value.</returns>
		public override SKRect ToRect()
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
			var newProperty = new KimonoPropertyRect()
			{
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				ObiScript = this.ObiScript,
				Value = new SKRect(this.Value.Left, this.Value.Top, this.Value.Right, this.Value.Bottom)
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
