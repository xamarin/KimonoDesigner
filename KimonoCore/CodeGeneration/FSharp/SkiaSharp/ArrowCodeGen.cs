using System;
using System.Linq;
using KimonoCore;

namespace CodeGenFSharp.SkiaSharp
{
    public static class ArrowCodeGen
    {
        public static string CodeGen (KimonoShapeArrow arrow)
        {
            // Update any attached properties
            arrow.EvaluateConnectedProperties ();

            // Snippet functions
            // Note: Closure over self for non-public access 
            Func<string> ToPath = () =>
            {
				//TODO: Implement
				return "//TODO: KimonoShapeArrow.ToPath()";
            };

            Func<double, double, double, string> RotationPush = (rot, hC, vC) =>
            {
                return new [] {
                    $"canvas.Save",
                    $"canvas.RotateDegrees {rot}f {hC}f {vC}f"
                }.ToLines ();
            };

            Func<string> RotationPop = () =>
            {
                return "canvas.Restore";
            };

            Func<string, string, string, string> Fill = (gradientCode, styleFill, pathName) =>
            {
                var pathCode = $"canvas.DrawPath {pathName} {styleFill}";
                var fillCode = new [] {
                    gradientCode,
                    pathCode
                }.ToLines ();
                return fillCode;
            };

			Func<string> Frame = () => "//TODO: KimonoShapeArrow.Frame()";

            // Create necessary snippets
            var path = arrow.Visible ? ToPath () : null;
            var drawWithSkia = $"// Draw {arrow.Name} shape";
            var rotationPush = arrow.RotationDegrees != 0 ? RotationPush (arrow.RotationDegrees, arrow.HorizontalCenter, arrow.VerticalCenter) : null;
            var rotationPop = arrow.RotationDegrees != 0 ? RotationPop () : null;
            var fill = arrow.Visible && arrow.Style.HasFill ? Fill (arrow.ConformedFillGradientCodeSkia (), arrow.StyleFillPaintForCodeSkia (), path) : null;
            var frame = arrow.Visible && arrow.Style.HasFrame ? Frame () : null;

            // Order snippets and remove empties
            var structure = new [] { path, drawWithSkia, rotationPush, fill, frame, rotationPop }.Select (s => s != null);

            // Reduce and return
            var code = structure.ToLines ();
            return code;
        }
    }
}