using System;
using SkiaSharp;
using KimonoCore;
using System.Collections.Generic;

namespace CodeGenFSharp.SkiaSharp
{
	public static class StyleCodeGen
	{
		public static string CodeGen(KimonoStyle style)
		{
			//TODO: Implement
			return "//TODO: KimonoStyle.CodeGen()";

		}

		public static string ToCode(this KimonoStyle self, SKPoint start, SKPoint end)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<string> Initializer(this KimonoStyle self, bool isConstructor)
		{
			Func<string, string, string, IEnumerable<string>> FillCode = (styleName, colorNameArg, colorRGB) =>
			 {
				 var source = new[] {
						$"//Fill color for {styleName}",
						$"let {colorNameArg} = {colorRGB}",
					 };
				 return source;
			 };

			Func<string, string, string, string, string, string, string, IEnumerable<string>> AssemblePaint = (actionArg, name, prefixArg, elementName, colorNameArg, blendMode, antiAlias) =>
			{
				var assemblePaint = new[] {
					$"// {actionArg} {name} fill paint",
					$"{prefixArg}{elementName}FillPaint = new SKPaint()" + "{", //TODO: Ain't gonna work in F#
					$"Style = SKPaintStyle.Fill",
					$"Color = {colorNameArg}",
					$"BlendMode = SKBlendMode.{blendMode}",
					$"IsAntialias = {antiAlias}"
				};
				return assemblePaint;
			};

			Func<string, IEnumerable<string>> FillGradient = (code) => new[] { $"Shader = { code }" };

			Func<double, double, IEnumerable<string>> JitterCode = (length, deviation) => new[] { $"PathEffect = SKPathEffect.CreateDiscrete({ length }f, { deviation }f)" };

			Func<string, KimonoShadow, Tuple<IEnumerable<string>, IEnumerable<string>>> FillShadowBehavior = (elementNameArg, kimonoShadow) =>
			{
				// Assign the same element name
				kimonoShadow.Name = $"{elementNameArg}Fill";

				var shadowEffect = new string[] { $"{elementNameArg}FillShadow" };
				var preCode = kimonoShadow.ToCode();

				return new Tuple<IEnumerable<string>, IEnumerable<string>>(shadowEffect, preCode);
			};

			Func<string, KimonoBlur, Tuple<IEnumerable<string>, IEnumerable<string>>> BlurBehavior = (elementNameArg, kimonoBlur) =>
			{
				//Assign the same element name
				kimonoBlur.Name = $"{elementNameArg}Fill";

				var blurEffect = new string[] { $"{elementNameArg}FillBlur" };
				var preCode = kimonoBlur.ToCode();

				return new Tuple<IEnumerable<string>, IEnumerable<string>>(blurEffect, preCode);
			};

			Func<bool, bool, IEnumerable<string>, IEnumerable<string>, IEnumerable<string>> ApplyBlurAndShadow = (hasFillShadow, hasFillBlur, shadowEffect, blurEffect) =>
			 {
				 var twoBits = (hasFillShadow ? 2 : 0) + (hasFillBlur ? 1 : 0);
				 switch (twoBits)
				 {
					 case 0: //Neither shadow nor blur
						 return new string[] { };
					 case 1: //Has blur, but not shadow
						 return new string[] { $"ImageFilter = {blurEffect}" };
					 case 2: //Has shadow, but not blur
						 return new string[] { $"ImageFilter = {shadowEffect}" };
					 case 3: //Has both
						 return new string[] { $"ImageFilter = SKImageFilter.CreateCompose({shadowEffect}, {blurEffect})" };
					 default:
						 throw new ArgumentOutOfRangeException($"Two bits have somehow added to {twoBits}");
				 }
			 };

			Func<string, SKTypefaceStyle, double, SKTextAlign, string, string, string, double, double, IEnumerable<string>> TextCode = (fontFamilyName, typeFaceStyle, textSize, textAlign, strikeThru, underline, isVertical, scaleX, skewX) =>
			{
				return new[] {
						$"Typeface = SKTypeface.FromFamilyName(\"{fontFamilyName}\", SKTypefaceStyle.{typeFaceStyle})",
						$"TextSize = {textSize}f",
						$"TextAlign = SKTextAlign.{textAlign}",
						$"StrikeThruText = {strikeThru}",
						$"UnderlineText = {underline}",
						$"IsVerticalText = {isVertical}",
						$"TextScaleX = {scaleX}f",
						$"TextSkewX = {skewX}f"
				};
			};

			var colorName = self.FillColor == null ? $"{self.ElementName}FillColor" : KimonoCodeGenerator.AddSupportingColor(self.FillColor);

			//TODO: Check. It seems odd to me that HasFill == true leads to empty source, but compare to KimonoStyle.cs 1754 
			var fillCode = self.HasFill ? new string[] { } : FillCode(self.Name, colorName, KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, self.Fill.Color));
			var action = isConstructor ? "Build new" : "Initialize";
			var prefix = isConstructor ? "var " : "";
			var assemblePaintCode = AssemblePaint(action, self.Name, prefix, self.ElementName, colorName, self.Fill.BlendMode.ToString(), self.Fill.IsAntialias.ToString().ToLower());

			var gradientCode = self.FillGradient != null ? FillGradient(KimonoCodeGenerator.AddSupportingGradient(self.FillGradient)) : new string[] { };
			var jitterCode = self.HasFillJitter ? JitterCode(self.FillJitterLength, self.FillJitterDeviation) : new string[] { };

			//Note that the following effects are Tuples of code snippets, not just code
			var fillShadowResults = self.HasFillShadow ? FillShadowBehavior(self.ElementName, self.FillShadow) : new Tuple<IEnumerable<string>, IEnumerable<string>>(new string[] { }, new string[] { });
			var blurResults = self.HasFillBlur && (self.FillBlur.HorizontalBlurAmount > 0 || self.FillBlur.VerticalBlurAmount > 0) ? BlurBehavior(self.ElementName, self.FillBlur) : new Tuple<IEnumerable<string>, IEnumerable<string>>(new string[] { }, new string[] { });
			var precode = fillShadowResults.Item2.Append(blurResults.Item2);

			//Apply blur and shadow
			var imageFilterCode = ApplyBlurAndShadow(self.HasFillShadow, self.HasFillBlur, fillShadowResults.Item1, blurResults.Item1);
			var textCode = self.StyleType == KimonoStyleType.CustomText || self.StyleType == KimonoStyleType.Text ? TextCode(self.FontFamilyName, self.TypefaceStyle, self.Fill.TextSize, self.Fill.TextAlign, self.Fill.StrikeThruText.ToString().ToLower(), self.Fill.UnderlineText.ToString().ToLower(), self.Fill.IsVerticalText.ToString().ToLower(), self.Fill.TextScaleX, self.Fill.TextSkewX) : new string[] { };

			var snippets = new[]
			{
					precode,
					fillCode,
					assemblePaintCode,
					gradientCode,
					jitterCode,
					imageFilterCode,
					textCode
				}.Flatten();
			return snippets;
		}
	}
}
