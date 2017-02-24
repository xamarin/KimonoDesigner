using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// A Kimono specific version of the TextBase database engine with custom serializers
	/// for KimonoCore and SkiaSharp objects built in.
	/// </summary>
	public class KimonoTextBase : TextBaseDatabase
	{
		#region Constructors
		public KimonoTextBase()
		{
			// Preregister all of the objects with the database otherwise loading a saved
			// file will die.
			Register<SKPoint>();
			Register<KimonoBezierPoint>();
			Register<KimonoHandle>();
			Register<KimonoBlur>();
			Register<KimonoShadow>();
			Register<KimonoProperty>();
			Register<KimonoPropertyBoolean>();
			Register<KimonoPropertyColor>();
			Register<KimonoPropertyConnection>();
			Register<KimonoPropertyGradient>();
			Register<KimonoPropertyLibrary>();
			Register<KimonoPropertyNumber>();
			Register<KimonoPropertyRect>();
			Register<KimonoPropertyStyle>();
			Register<KimonoPropertyText>();
			Register<KimonoShape>();
			Register<KimonoShapeArrow>();
			Register<KimonoShapeBezier>();
			Register<KimonoShapeGroup>();
			Register<KimonoShapeLine>();
			Register<KimonoShapeOval>();
			Register<KimonoShapePolygon>();
			Register<KimonoShapeRect>();
			Register<KimonoShapeRoundRect>();
			Register<KimonoShapeStar>();
			Register<KimonoShapeText>();
			Register<KimonoShapeTriangle>();
			Register<KimonoShapeVector>();
			Register<KimonoColor>();
			Register<KimonoGradient>();
			Register<KimonoStyle>();
			Register<KimonoPortfolio>();
			Register<KimonoSketch>();

			// Add serialization of KimonoCore and SkiaSharp objects to the database
			this.RequestCustomSerialization += (serializer, obj) =>
			{
				var result = "";

				// Take action based on the serializer type
				switch (serializer)
				{
					case "SKColor":
						try
						{
							if (obj == null)
							{
								// Default to white
								result = "#FFFFFFFF";
							}
							else
							{
								// Encode color
								result = Kimono.ColorToHex((SKColor)obj, true);
							}
						}
						catch
						{
							// Default to white
							result = "#FFFFFFFF";
						}
						break;
				}

				// Return results
				return result;
			};

			// Add deserialization of KimonoCore and SkiaSharp objects to the database
			this.RequestCustomDeserialization += (serializer, value) =>
			{
				object result = null;

				// Take action based on the serializer type
				switch (serializer)
				{
					case "SKColor":
						try
						{
							if (string.IsNullOrEmpty(value))
							{
								// Default to white
								result = KimonoColor.White;
							}
							else
							{
								// Decode color
								result = KimonoCore.Kimono.HexToColor(value);
							}
						}
						catch
						{
							// Default to white
							result = KimonoColor.White;
						}
						break;
				}

				// Return results
				return result;
			};
		}
		#endregion
	}
}
