using System;
using SkiaSharp;

namespace KimonoCore
{
    public static class GradientCodeGenFSharp
    {
        public static string ToFSharpSkiaImpl (this KimonoGradient self)
        {
            throw new NotImplementedException ("Cannot generate gradient code without start and end points");
        }

        public static string ToFSharpSkiaImpl (this KimonoGradient self, SKPoint start, SKPoint end)
        {
            Func<string, string, string, SKShaderTileMode, string> LinearGradientCode = (startPointCode, endPointCode, elementName, tileMode) =>
            {
                var snippets = new [] {
                    "CreateLinearGradient",
                    startPointCode,
                    endPointCode,
                    $"{elementName}Colors",
                    $"{elementName}Weights",
                    $"SKShaderTileMode.{tileMode.ToString()}"
                };
                return snippets.BuildFunctionCall ();
            };

            Func<string, double, string, SKShaderTileMode, string> RadialGradientCode = (startPointCode, radius, elementName, tileMode) =>
            {
                var snippets = new [] {
                    "CreateRadialGradient",
                    startPointCode,
                    $"{radius}f",
                    $"{elementName}.Colors",
                    $"{elementName}.Weights",
                    $"SKShaderTileMode.{tileMode.ToString()}"
                };
                return snippets.BuildFunctionCall ();
            };

            Func<string, string, double, string, SKShaderTileMode, string> ConicalGradientCode = (startPointCode, endPointCode, radius, elementName, tileMode) =>
            {
                var snippets = new [] {
                    "CreateTwoPointConicalGradient",
                    startPointCode,
                    $"{radius}f",
                    endPointCode,
                    $"{radius / 2f}f",
                    $"{elementName}Colors",
                    $"{elementName}Weights",
                    $"SKShaderTileMode.{tileMode.ToString()}"
                };
                return snippets.BuildFunctionCall ();
            };

            Func<string, string, string> SweepGradientCode = (startPointCode, elementName) =>
            {
                var snippets = new [] {
                    "CreateSweepGradient",
                    startPointCode,
                    $"{elementName}Colors",
                    $"{elementName}Weights"
                };
                return snippets.BuildFunctionCall ();
            };

            var spc = start.ToFSharpSkiaImpl ();
            var epc = end.ToFSharpSkiaImpl ();
            var shaderPrefix = "SKShader.";
            string gradientCode = null;
            switch (self.GradientType)
            {
            case KimonoGradientType.LinearGradient:
                gradientCode = LinearGradientCode (spc, epc, self.ElementName, self.TileMode);
                break;
            case KimonoGradientType.RadialGradient:
                gradientCode = RadialGradientCode (spc, self.Radius, self.ElementName, self.TileMode);
                break;
            case KimonoGradientType.ConicalGradient:
                gradientCode = ConicalGradientCode (spc, epc, self.Radius, self.ElementName, self.TileMode);
                break;
            case KimonoGradientType.SweepGradient:
                gradientCode = SweepGradientCode (spc, self.ElementName);
                break;
            default:
                throw new ArgumentOutOfRangeException ($"Unknown gradient type {self.GradientType}");
            }
            return shaderPrefix + gradientCode;
        }

        public static string ToFSharpKimonoCoreImpl (this KimonoGradient self)
        {
            throw new NotImplementedException ();
        }

    }
}