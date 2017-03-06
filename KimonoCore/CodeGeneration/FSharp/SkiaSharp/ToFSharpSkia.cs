using System;
using KimonoCore;

namespace CodeGenFSharp.SkiaSharp
{
    public class ToFSharpSkia : IVisitorCodeGen
    {
		public string CodeGen(KimonoBounds bounds) => BoundsCodeGen.CodeGen(bounds);

		public string CodeGen(KimonoBlur blur) => BlurCodeGen.CodeGen(blur);

		public string CodeGen(KimonoColor color) => ColorCodeGen.CodeGen(color);

		public string CodeGen(KimonoGradient gradient) => GradientCodeGen.CodeGen(gradient);

		public string CodeGen(KimonoShapeArrow arrow) => ArrowCodeGen.CodeGen(arrow);

		public string CodeGen(KimonoShadow shadow) => ShadowCodeGen.CodeGen(shadow);

		public string CodeGen(KimonoShape shape) => ShapeCodeGen.CodeGen(shape);

		public string CodeGen(KimonoShapeBezier bezier) => BezierCodeGen.CodeGen(bezier);

		public string CodeGen(KimonoShapeGroup group) => GroupCodeGen.CodeGen(group);

		public string CodeGen(KimonoShapeLine line) => LineCodeGen.CodeGen(line);

		public string CodeGen(KimonoShapeOval oval) => OvalCodeGen.CodeGen(oval);

		public string CodeGen(KimonoShapePolygon poly) => PolygonCodeGen.CodeGen(poly);

		public string CodeGen(KimonoShapeRect rect) => RectangleCodeGen.CodeGen(rect);

		public string CodeGen(KimonoShapeRoundRect rr) => RoundedRectCodeGen.CodeGen(rr);

		public string CodeGen(KimonoShapeStar star) => StarCodeGen.CodeGen(star);

		public string CodeGen(KimonoShapeText text) => TextCodeGen.CodeGen(text);

		public string CodeGen(KimonoShapeTriangle triangle) => TriangleCodeGen.CodeGen(triangle);

		public string CodeGen(KimonoShapeVector vector) => VectorCodeGen.CodeGen(vector);

		public string CodeGen(KimonoSketch sketch) => SketchCodeGen.CodeGen(sketch);

		public string CodeGen(KimonoPortfolio portfolio) => PortfolioCodeGenFSharp.CodeGen(portfolio);

		public string CodeGen(KimonoStyle style) => StyleCodeGenFSharp.CodeGen(style);
    }
}
