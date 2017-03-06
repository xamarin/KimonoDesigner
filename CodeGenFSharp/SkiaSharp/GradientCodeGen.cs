using System;
using KimonoCore;
using SkiaSharp;

namespace CodeGenFSharp.SkiaSharp
{
    public static class GradientCodeGen
    {
        public static string CodeGen (KimonoGradient gradient)
        {
            throw new NotImplementedException ("Cannot generate gradient code without start and end points");
        }

        public static string CodeGen (this ToFSharpSkia self,  KimonoGradient gradient, SKPoint start, SKPoint end)
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

            var spc = start.CodeGen ();
            var epc = end.CodeGen ();
            var shaderPrefix = "SKShader.";
            string gradientCode = null;
            switch (gradient.GradientType)
            {
            case KimonoGradientType.LinearGradient:
                gradientCode = LinearGradientCode (spc, epc, gradient.ElementName, gradient.TileMode);
                break;
            case KimonoGradientType.RadialGradient:
                gradientCode = RadialGradientCode (spc, gradient.Radius, gradient.ElementName, gradient.TileMode);
                break;
            case KimonoGradientType.ConicalGradient:
                gradientCode = ConicalGradientCode (spc, epc, gradient.Radius, gradient.ElementName, gradient.TileMode);
                break;
            case KimonoGradientType.SweepGradient:
                gradientCode = SweepGradientCode (spc, gradient.ElementName);
                break;
            default:
                throw new ArgumentOutOfRangeException ($"Unknown gradient type {gradient.GradientType}");
            }
            return shaderPrefix + gradientCode;
        }
    }
}