using System;
using SkiaSharp;

namespace KimonoCore
{
    public static class ShapeCodeGenFSharp
    {
        public static string ToFSharpSkiaImpl (this KimonoShape shape)
        {
            return "// Generating KimonoShapes in SkiaSharp is not yet supported";
        }

        public static string StyleFillPaintForCodeSkia (this KimonoShape self)
        {
            // Is this style using a custom type?
            var suffix = self.Style.StyleType == KimonoStyleType.Custom ? "Paint" : "";
            var snippet = $"{self.Style.ElementName}Fill" + suffix;
            return snippet;
        }

        public static string ConformedFillGradientCodeSkia (this KimonoShape self)
        {
            Func<string> FillGradientCode = () =>
            {
                // Get conforming coordinates
                var startPoint = new SKPoint ();
                var endPoint = new SKPoint ();
                //TODO: Refactor spelling mistake here
                //TODO: Refactor to return Tuple?
                self.CalculateConfromingGradientCoordinates (self.Style.FillGradient, out startPoint, out endPoint);
                var shaderPrefix = self.StyleFillPaintForCodeSkia ();
                var gradientCode = self.Style.ToFSharpSkiaImpl (startPoint, endPoint);
                // Conform gradient 
                var snippet = $"{shaderPrefix}.Shader = {gradientCode};";
                return snippet;
            };

            //TODO: Hoist check outside of function?
            return self.Style.FillGradient == null ? "" : FillGradientCode ();
        }

        public static string ToFSharpKimonoCoreImpl (this KimonoShape self)
        {
            throw new NotImplementedException ();
        }
    }
}