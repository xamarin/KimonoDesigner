using System;
using System.Linq;

namespace KimonoCore
{
    public static class ArrowCodeGenFSharp
    {
        public static string ToFSharpSkiaImpl (this KimonoShapeArrow self)
        {
            // Update any attached properties
            self.EvaluateConnectedProperties ();

            // Snippet functions
            // Note: Closure over self for non-public access 
            Func<string> ToPath = () =>
            {
                return "foo";
            };

            Func<double, double, double, string> RotationPush = (rot, hC, vC) =>
            {
                return new [] {
                    $"canvas.Save();",
                    $"canvas.RotateDegrees({rot}f, {hC}f, {vC}f);"
                }.ToLines ();
            };

            Func<string> RotationPop = () =>
            {
                return "canvas.Restore();";
            };

            Func<string, string, string, string> Fill = (gradientCode, styleFill, pathName) =>
            {
                var pathCode = $"canvas.DrawPath({pathName}, {styleFill});";
                var fillCode = new [] {
                    gradientCode,
                    pathCode
                }.ToLines ();
                return fillCode;
            };

            Func<string> Frame = () => { throw new NotImplementedException ("TODO"); };

            // Create necessary snippets
            var path = self.Visible ? ToPath () : null;
            var drawWithSkia = $"// Draw {self.Name} shape";
            var rotationPush = self.RotationDegrees != 0 ? RotationPush (self.RotationDegrees, self.HorizontalCenter, self.VerticalCenter) : null;
            var rotationPop = self.RotationDegrees != 0 ? RotationPop () : null;
            var fill = self.Visible && self.Style.HasFill ? Fill (self.ConformedFillGradientCodeSkia (), self.StyleFillPaintForCodeSkia (), path) : null;
            var frame = self.Visible && self.Style.HasFrame ? Frame () : null;

            // Order snippets and remove empties
            var structure = new [] { path, drawWithSkia, rotationPush, fill, frame, rotationPop }.Select (s => s != null);

            // Reduce and return
            var code = structure.ToLines ();
            return code;
        }

        public static string ToFSharpKimonoCoreImpl (this KimonoShapeArrow self)
        {
            throw new NotImplementedException ();
        }
    }
}