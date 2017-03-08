using System;
using KimonoCore;
using System.Linq;
using System.Collections.Generic;

namespace CodeGenFSharp.SkiaSharp
{
	public static class SketchCodeGen
	{
		public static string CodeGen(KimonoSketch sketch, CodeOutputOS codeOutputOs, IVisitorCodeGen visitor)
		{
			var openStatements = BuildUsingStatements(sketch, codeOutputOs);
			var sourceCode = BuildSourceCode(sketch, codeOutputOs);
			var drawCode = BuildDrawingCode(sketch, codeOutputOs);
			var initializers = BuildInitializers();
			var privateVars = BuildPrivateVars();
			var privateMethods = sketch.GenerateCodeToOuputToCanvas == false ? sketch.BuildToCanvasMethod(visitor) : new string[] { };
			var publicMethods = sketch.GenerateCodeToOuputToCanvas ? sketch.BuildToCanvasMethod(visitor) : new string[] { };
			var computedProperties = BuildComputedProperties();
			var overrideMethods = sketch.GenerateCodeToOuputToCanvas ? BuildOverrideMethods(sketch, codeOutputOs) : new string[] { };

			var ordered = new[]
			{
				openStatements,
				sourceCode,
				drawCode,
				initializers,
				privateVars,
				privateMethods,
				publicMethods,
				computedProperties,
				overrideMethods
			};

			var compilationUnitCode = AssembleCompilationUnit(ordered);
			return compilationUnitCode;

		}

		static IEnumerable<string> BuildUsingStatements(KimonoSketch sketch, CodeOutputOS codeOutputOs)
		{
			var universals = new[] {
				"open System",
				"open SkiaSharp"
			};

			var views = sketch.GenerateCodeToOuputToSkiaSharpViews ? new[] { "open SkiaSharp.Views.Forms" } : new string[] { };

			Func<CodeOutputOS, string[]> OSSpecificUsings = (os) =>
			{
				var androidUsings = new[] {
					"open Android.App",
					"open Android.Widget",
					"open Android.OS",
					"open Android.Graphics"
				};

				var iOSAndTvOSUsings = new[] {
					"open Foundation",
					"open UIKit"
				};

				var macUsings = new[] {
					"open Foundation",
					"open AppKit"
				};

				var winUsings = new[] {
					"open System.Drawing"
				};

				var uwpUsings = new[] {
					"open Windows.UI.Xaml.Media.Imaging",
					"open System.IO",
					"open Windows.Storage.Streams"
				};

				Func<string[]> CrossPlatformUsings = () =>
				{
					var android = GeneratorUtils.BuildConditionalCompilation("__ANDROID__", androidUsings);
					var ios = GeneratorUtils.BuildConditionalCompilation("(__IOS__ || __TVOS__)", iOSAndTvOSUsings);
					var macos = GeneratorUtils.BuildConditionalCompilation("__MACOS__", macUsings);
					var win = GeneratorUtils.BuildConditionalCompilation("(WINDOWS || WINDOWS_WPF)", winUsings);
					var uwp = GeneratorUtils.BuildConditionalCompilation("WINDOWS_UWP", uwpUsings);

					return new[]
					{
						android,
						ios,
						macos,
						win,
						uwp
					}.Flatten().ToArray();
				};

				switch (os)
				{
					case (CodeOutputOS.CrossPlatform) : return CrossPlatformUsings();
					case (CodeOutputOS.Android) : return androidUsings;
					case (CodeOutputOS.iOS) : return iOSAndTvOSUsings;
					case (CodeOutputOS.tvOS) : return iOSAndTvOSUsings;
					case (CodeOutputOS.macOS) : return macUsings;
					case (CodeOutputOS.Windows) : return winUsings;
					case (CodeOutputOS.WindowsUWP) : return uwpUsings;
						default:
						throw new ArgumentOutOfRangeException($"Unknown CodeOutputOS {os}");
				}
			};

			Func<CodeOutputOS, IEnumerable<string>, IEnumerable<string>> WithPlatformSpecificSkiaSharpViews = (os, usings) =>
			{
				switch (os)
				{
					case CodeOutputOS.CrossPlatform: return usings;
					case CodeOutputOS.Android: return usings.Append("open SkiaSharp.Views.Android");
					case CodeOutputOS.iOS: return usings.Append("open SkiaSharp.Views.iOS");
					case CodeOutputOS.macOS: return usings.Append("open SkiaSharp.Views.MacOS");
					case CodeOutputOS.tvOS: return usings.Append("open SkiaSharp.Views.tvOS");
					case CodeOutputOS.Windows: return usings.Append("open SkiaSharp.Views.Desktop");
					case CodeOutputOS.WindowsUWP: return usings.Append("open SkiaSharp.Views.UWP");
					case CodeOutputOS.WindowsWPF: return usings.Append("open SkiaSharp.Views.WPF");
					default:
						throw new ArgumentOutOfRangeException($"Unknown CodeOutputOS {os}");
				}
			};

			var all = new [] 
			{
				universals,
				views,
				WithPlatformSpecificSkiaSharpViews(codeOutputOs, OSSpecificUsings(codeOutputOs))
			}.Flatten();

			return all;
		}

		static IEnumerable<string> BuildSourceCode(KimonoSketch sketch, CodeOutputOS codeOutputOS)
		{
			var ws = new Indenter();

			Func<string, CodeOutputOS, IEnumerable<string>> MakePlatformSpecificClassDecl = (name, os) =>
			{
				switch (os)
				{
					case CodeOutputOS.Android :
					case CodeOutputOS.CrossPlatform :
						return new[] {
							$"public class {name}() = ",
							ws[1] + "inherit SKCanvasView()"
						};
					case CodeOutputOS.iOS :
					case CodeOutputOS.tvOS:
					case CodeOutputOS.macOS:
						return new[] {
							$"[Register(\"{name}\")]",
							$"public class {name}() = ",
							ws[1] + "inherit SKCanvasView() "
						};
					case CodeOutputOS.Windows :
						return new[] {
							$"public class {name}() = ",
							ws[1] + "inherit SKControl()"
						};
					case CodeOutputOS.WindowsUWP :
						return new[] {
							$"public class {name}() = ",
							ws[1] + "inherit SKXamlCanvas()"
						};
					case CodeOutputOS.WindowsWPF :
						return new[] {
							$"public class {name}() = ",
							ws[1] + "inherit SKElement()"
						};
					default :
					throw new ArgumentOutOfRangeException($"Unknown CodeOutputOs {os}");
				}
			};

			Func<string, string, string, string, IEnumerable<string>> MakeNamespaceAndSummary = (cn, a, cr, t) =>
			{
				var namespaceExpr = $"namespace {cn} ";

				var commentBlock = new[] {
					"<summary>",
					$"{ws[1]}Author: {a}",
					$"{ws[1]}{cr}",
					"</summary>",
					$"<remarks>{ws[1]}Generated by Kimono Designer {t}. </remarks>"
				};

				return namespaceExpr
					.AppendAll(commentBlock);
			};

			Func<string, IEnumerable<string>> MakeGenericClassDecl = (c) =>
			{

				return new string[] { $"public class {c}" };
			};

			var codeNamespace = KimonoCodeGenerator.MakeElementName(sketch.Portfolio.Namespace);
			var author = sketch.Portfolio.Author;
			var copyright = sketch.Portfolio.Copyright;
			var generatedTime = DateTime.Now.ToString("D");
			var className = sketch.ElementName;

			IEnumerable<string> sourceCode = MakeNamespaceAndSummary(codeNamespace, author, copyright, generatedTime);
			if (sketch.GenerateCodeToOuputToSkiaSharpViews)
			{
				sourceCode.Append(MakePlatformSpecificClassDecl(className, codeOutputOS));
			}
			else
			{
				sourceCode.Append(MakeGenericClassDecl(className));
			}

			return sourceCode;
		}

		static IEnumerable<string> BuildDrawingCode(KimonoSketch sketch, CodeOutputOS codeOutputOs)
		{
			var ws = new Indenter();

			Func<string, CodeOutputOS, IEnumerable<string>> DrawCodeForOS = (name, os) =>
			{
				var form1 = new[] {
					ws[2] + "// Call the base method",
					ws[2] + "base.OnDraw surface info",
					ws[2] + "// Draw the sketch into the canvas",
					ws[2] + $"Draw{name} surface.Canvas",
					ws[2] + "surface.Canvas.Flush()"
				};

				var form2 = new string[] {
					ws[1] + "protected override void OnPaintSurface (e : SKPaintSurfaceEventArgs e) =",
					ws[2] + "// Call the base method",
					ws[2] + "base.OnPaintSurface (e)",
					ws[2],
					ws[2] + "// Get surface",
					ws[2] + "let surface = e.Surface",
					ws[2] + "// Draw the sketch into the canvas",
					ws[2] + $"Draw{name} (surface.Canvas)",
					ws[2] + "surface.Canvas.Flush()"
				};

				switch (os)
				{
					case CodeOutputOS.Android:
						return
							(ws[1] + "protected override void OnDraw (surface : SKSurface) (info : SKImageInfo) = ")
							.AppendAll(form1);

					case CodeOutputOS.iOS:
					case CodeOutputOS.tvOS:
					case CodeOutputOS.macOS:
						return
							(ws[1] + "protected override void DrawInSurface (surface : SKSurface) (info : SKImageInfo) =")
							.AppendAll(form1);

					case CodeOutputOS.CrossPlatform:
					case CodeOutputOS.Windows:
					case CodeOutputOS.WindowsUWP:
					case CodeOutputOS.WindowsWPF:
						return form2;
					default:
						throw new ArgumentOutOfRangeException($"Unknown CodeOutputOs {os}");
				}
			};

			if (sketch.GenerateCodeToOuputToSkiaSharpViews)
			{
				return DrawCodeForOS(sketch.ElementName, codeOutputOs);
			}
			else
			{
				return new string[] { };
			}
		}

		static IEnumerable<string> BuildInitializers()
		{
			var styleInitializers = KimonoCodeGenerator.SupportingStyles.SelectMany(s => s.Initializer(false));
			var gradientInitializers = KimonoCodeGenerator.SupportingGradients.SelectMany(g => g.ToInitializerCode());
			return styleInitializers.Append("").Concat(gradientInitializers);
		}

		static IEnumerable<string> BuildPrivateVars()
		{
			var gradients = KimonoCodeGenerator.SupportingGradients;
			var privateVars = gradients.Select(g => g.ToPrivateVariableCode()).Flatten();
			return privateVars;
		}

		static IEnumerable<string> ShapesToCode(this KimonoSketch self, IVisitorCodeGen visitor)
		{
			return self.Shapes.Select(shape => shape.ToCode(visitor));
		}

		static IEnumerable<string> BuildToCanvasMethod(this KimonoSketch self, IVisitorCodeGen visitor)
		{
			var commentBlock = new[]
			{
				"/// <summary>",
				$"/// Draw the {self.Name} sketch into the given SkiaSharp canvas.",
				"/// </summary>," ,
				"/// <param name=\"canvas\">The <c>SKCanvas</c> to draw the sketch into.</param>"
			};

			var visibility = self.GenerateCodeToOuputToCanvas ? "public" : "private";
			var fnDecl = $"let Draw{ self.ElementName} (SKCanvas canvas) = ";

			//Use unit for empty function body
			var fnBody = self.Shapes.Count > 0 ? self.ShapesToCode(visitor) : new string[] { "()" };

			var ws = new Indenter();
			//Indent function body
			var fnBodyIndented = fnBody.Select(s => ws[1] + s);
			return fnDecl.AppendAll(fnBodyIndented);

		}


		static IEnumerable<string> BuildComputedProperties()
		{
			Func<IEnumerable<KimonoColor>, IEnumerable<string>> PropertyForSupportingColors = (cs) =>
			{
				var classType = "SKColor";
				//TODO: Convert to F#
				var colorCodes = cs.SelectMany(c =>
				{
					return new[] {
						$"// Global color {c.Name}",
						$"public static {classType} {c.ElementName} ",
						"{get; set;} ",
						$"= {c.ToCode()}"
					};
				});

				var code = classType.AppendAll(colorCodes);
				return code;
			};

			Func<IEnumerable<KimonoGradient>, IEnumerable<string>> PropertyForSupportingGradients = (gs) =>
			{
				var classType = "SKShader";
				//TODO: Convert to F#
				var gradientCodes = gs.SelectMany(g =>
				{
					return new[] {
						$"// Global gradient {g.Name}",
						$"public static {classType} {g.ElementName} ",
						"{get; set;}"
					};
				});

				return classType.AppendAll(gradientCodes);
			};

			Func<IEnumerable<KimonoStyle>, IEnumerable<string>> PropertyForSupportingStyles = (ss) =>
			{
				Func<string, IEnumerable<string>> FillCode = (elementName) =>
				{
					return new[] {
						$"public static SKPaint {elementName}FillPaint ",
						"{get; set;}"
					};
				};

				Func<string, IEnumerable<string>> FrameCode = (elementName) =>
				{
					return new[] {
						$"public static SKPaint {elementName}FramePaint ",
						"{get; set; }"
					};
				};

				var styleCodes = ss.SelectMany(supportingStyle =>
				{
					var comment = $"// Global style {supportingStyle.Name}";
					var fillCode = supportingStyle.HasFill ? FillCode(supportingStyle.ElementName) : new string[] { };
					var frameCode = supportingStyle.HasFill ? FrameCode(supportingStyle.ElementName) : new string[] { };
					return comment.AppendAll(fillCode).Append(frameCode);
				});
				return styleCodes;
			};

			var propertyForSupportingColors = PropertyForSupportingColors(KimonoCodeGenerator.SupportingColors);
			var propertyForSupportingGradients = PropertyForSupportingGradients(KimonoCodeGenerator.SupportingGradients);
			var propertyForSupportingStyles = PropertyForSupportingStyles(KimonoCodeGenerator.SupportingStyles);

			return propertyForSupportingColors
					.Append(propertyForSupportingGradients)
					.Append(propertyForSupportingStyles);
		}

		static IEnumerable<string> BuildOverrideMethods(KimonoSketch sketch, CodeOutputOS codeOutputOs)
		{
			Func<string, IEnumerable<string>> AndroidMethod = (elementName) =>
			{
				var ws = new Indenter();
				return new[] {
					ws[1] + "protected override void OnDraw (surface : SKSurface) (info : SKImageInfo) :",
					ws[2] + "// Call the base method",
					ws[2] + "base.OnDraw (surface, info)",
					"",
					ws[2] + "// Draw the sketch into the canvas",
					ws[2] + $"Draw{elementName}(surface.Canvas)",
					ws[2] + "surface.Canvas.Flush()"
				};
			};

			Func<string, IEnumerable<string>> AppleMethod = (elementName) =>
			{
				var ws = new Indenter();
				return new[] {
					ws[1] + "protected override void DrawInSurface (surface : SKSurface) (info : SKImageInfo) :",
					ws[2] + "// Call the base method",
					ws[2] + "base.DrawInSurface (surface, info)",
					"",
					ws[2] + "// Draw the sketch into the canvas",
					ws[2] + $"Draw{elementName}(surface.Canvas)",
					ws[2] + "surface.Canvas.Flush()"
				};
			};

			Func<string, IEnumerable<string>> WindowsMethod = (elementName) =>
			{
				var ws = new Indenter();
				return new[] {
					ws[1] + "protected override void OnPaintSurface (e : SKPaintSurfaceEventArgs) :",
					ws[2] + "// Call the base method",
					ws[2] + "base.OnPaintSurface (e)",
					"",
					ws[2] + "// Get surface",
					ws[2] + "let surface = e.Surface",
					ws[2] + "// Draw the sketch into the canvas",
					ws[2] + $"Draw{elementName}(surface.Canvas)",
					ws[2] + "surface.Canvas.Flush()"
				};
			};


			IEnumerable<string> code = null;
			switch (codeOutputOs)
			{
				case CodeOutputOS.Android :
					code = AndroidMethod(sketch.ElementName);
					break;
				case CodeOutputOS.iOS:
				case CodeOutputOS.tvOS:
				case CodeOutputOS.macOS:
					code = AppleMethod(sketch.ElementName);
					break;

				case CodeOutputOS.Windows:
				case CodeOutputOS.WindowsUWP:
				case CodeOutputOS.WindowsWPF:
					code = WindowsMethod(sketch.ElementName);
					break;

				default:
					throw new ArgumentOutOfRangeException($"Unknown code output OS {codeOutputOs}");
			}
			return code;
		}

		static string AssembleCompilationUnit(IEnumerable<IEnumerable<string>> orderedSections)
		{
			return orderedSections.Select(ss => ss.Append(Environment.NewLine)).Flatten().ToLines();
		}
	}
}
