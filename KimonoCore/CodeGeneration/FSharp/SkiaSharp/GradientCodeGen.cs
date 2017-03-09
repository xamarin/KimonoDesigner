using System;
using KimonoCore;
using SkiaSharp;
using System.Collections.Generic;
using System.Linq;

namespace CodeGenFSharp.SkiaSharp
{
    public static class GradientCodeGen
    {
        public static string CodeGen (KimonoGradient gradient)
        {
			//TODO: Implement
			return "//TODO: KimonoGradient.CodeGen()";

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

		static IEnumerable<string> ColorsToInitializerCode(this KimonoGradient self, bool isConstructor)
		{
			// Sort color list
			var list = self.ControlPoints.OrderBy(n => n.X).ToList();

			var arrayDeclCode = $"{self.ElementName}Colors = [| ";

			var colorCode = list.Aggregate("", (accum, handle) =>
				{
					Func<string> DirectColor = () => KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, handle.Color);
					Func<KimonoColor, string> LinkedColor = (c) => KimonoCodeGenerator.AddSupportingColor(c);

					var cc = handle.LinkedColor == null ? DirectColor() : LinkedColor(handle.LinkedColor);
					return accum + ", " + cc;
			});

			var arrayCloseCode = "|]";

			return new[]
			{
				arrayDeclCode,
				colorCode,
				arrayCloseCode
			};
		}

		static IEnumerable<string> WeightsToInitializerCode(this KimonoGradient self, bool isConstructor)
		{
			var weights = self.SortedWeights().Select(wt => wt.ToString() + "f");
			var arrayDeclCode = $"{self.ElementName}Weights = [| " ;

			var weightCode = weights.BuildString();

			var arrayCloseCode = "|]";
			return new[]
			{
				arrayDeclCode,
				weightCode,
				arrayCloseCode
			};
		}

		public static IEnumerable<string> ToInitializerCode(this KimonoGradient self)
		{
			Func<string, string, IEnumerable<string>> GradientCode = (name, elementName) =>
			{
				var colorCode = self.ColorsToInitializerCode(false);
				var weightCode = self.WeightsToInitializerCode(false);

				return $"// Initialize {name}"
				.AppendAll(colorCode)
				.Append(weightCode)
				.Append($"{elementName} = SKShader.");
			};

			Func<KimonoHandle, KimonoHandle, double, string, SKShaderTileMode, string> ConicalGradientCode = (start, end, radius, elementName, tileMode) =>
			{
				var code = new[]
				{
					$"CreateTwoPointConicalGradient(",
					KimonoCodeGenerator.PointToCode(CodeOutputLibrary.SkiaSharp, start),
					$"{radius}f",
					KimonoCodeGenerator.PointToCode(CodeOutputLibrary.SkiaSharp, end),
					$"{radius / 2f}f",
					$"{elementName}Colors, {elementName}Weights",
					$"SKShaderTileMode.{tileMode.ToString()}"
				}.BuildFunctionCall();
				return code;
			};

			Func<KimonoHandle, KimonoHandle, string, SKShaderTileMode, string> LinearGradientCode = (start, end, elementName, tileMode) =>
			{
				return new[]
				{
					$"CreateLinearGradient(",
					KimonoCodeGenerator.PointToCode(CodeOutputLibrary.SkiaSharp, start),
					KimonoCodeGenerator.PointToCode(CodeOutputLibrary.SkiaSharp, end),
					$"{elementName}Colors, {elementName}Weights",
					$"SKShaderTileMode.{tileMode.ToString()}"
				}.BuildFunctionCall();
			};

			Func<KimonoHandle, double, string, SKShaderTileMode, string> RadialGradientCode = (start, radius, elementName, tileMode) =>
			{
				return new[]
				{
					$"CreateRadialGradient(",
					KimonoCodeGenerator.PointToCode(CodeOutputLibrary.SkiaSharp, start),
					$"{radius}f",
					$"{elementName}Colors, {elementName}Weights",
					$"SKShaderTileMode.{tileMode.ToString()}"
				}.BuildFunctionCall();
			};

			Func<KimonoHandle, string, string> SweepGradientCode = (start, elementName) =>
			{
				return new[]
				{
					$"CreateSweepGradient(",
					KimonoCodeGenerator.PointToCode(CodeOutputLibrary.SkiaSharp, start),
					$"{elementName}Colors, {elementName}Weights"
				}.BuildFunctionCall();
			};

			var gradientCode = GradientCode(self.Name, self.ElementName);
			string generatorCode = null;

			switch (self.GradientType)
			{
				case KimonoGradientType.ConicalGradient : 
					generatorCode = ConicalGradientCode(self.StartPoint, self.EndPoint, self.Radius, self.ElementName, self.TileMode);
					break;
					case KimonoGradientType.LinearGradient :
					generatorCode = LinearGradientCode(self.StartPoint, self.EndPoint, self.ElementName, self.TileMode);
					break;
					case KimonoGradientType.RadialGradient :
					generatorCode = RadialGradientCode(self.StartPoint, self.Radius, self.ElementName, self.TileMode);
					break;
					case KimonoGradientType.SweepGradient :
					generatorCode = SweepGradientCode(self.StartPoint, self.ElementName);
					break;
					default:
					throw new ArgumentOutOfRangeException($"Unknown gradient type {self.GradientType}");
			}

			return gradientCode.Append(generatorCode);

		}

		public static IEnumerable<string> ToPrivateVariableCode(this KimonoGradient self)
		{
			return new[] {
				$"// Private gradient {self.Name} variables",
				$"private {self.ElementName}Colors : SKColor seq ",
				$"private {self.ElementName}Weights : float seq"
			};
		}
    }
}