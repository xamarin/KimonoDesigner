using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the current tool that is active in a <c>KimonoSketch</c> that
	/// the user can use to create or modify a <c>KimonoShape</c>.
	/// </summary>
	public enum KimonoTool
	{
		/// <summary>
		/// Use the Cursor tool to modify an existing <c>KimonoShape</c>.
		/// </summary>
		Cursor,

		/// <summary>
		/// Use the Line tool to add a new <c>KimonoShapeLine</c> to the sketch.
		/// </summary>
		Line,

		/// <summary>
		/// Use the Arrow tool to add a new <c>KimonoShapeArrow</c> to the sketch.
		/// </summary>
		Arrow,

		/// <summary>
		/// Use the Rectangle tool to add a new <c>KimonoShapeRect</c> to the sketch.
		/// </summary>
		Rectangle,

		/// <summary>
		/// Use the Oval tool to add a new <c>KimonoShapeOval</c> to the sketch.
		/// </summary>
		Oval,

		/// <summary>
		/// Use the Round Rect tool to add a new <c>KimonoShapeRoundRect</c> to the sketch.
		/// </summary>
		RoundRect,

		/// <summary>
		/// Use the Star tool to add a new <c>KimonoShapeStar</c> to the sketch.
		/// </summary>
		Star,

		/// <summary>
		/// Use the Polygon tool to add a new <c>KimonoShapePolygon</c> to the sketch.
		/// </summary>
		Polygon,

		/// <summary>
		/// Use the Triangle tool to add a new <c>KimonoShapeTriangle</c> to the sketch.
		/// </summary>
		Triangle,

		/// <summary>
		/// Use the Vector tool to add a new <c>KimonoShapeVector</c> to the sketch.
		/// </summary>
		Vector,

		/// <summary>
		/// Use the Bezier tool to add a new <c>KimonoShapeBezier</c> to the sketch.
		/// </summary>
		Bezier,

		/// <summary>
		/// Use the Text tool to add a new <c>KimonoShapeText</c> to the sketch.
		/// </summary>
		Text
	}
}
