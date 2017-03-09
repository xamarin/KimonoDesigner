using System;
using KimonoCore;

namespace CodeGenFSharp.SkiaSharp
{
    public static class ColorCodeGen
    {
        public static string CodeGen (KimonoColor color)
        {
			//TODO: Implement
			return "//TODO: KimonoColor.CodeGen()";

        }

		public static string ToCode(this KimonoColor self)
		{
			var comment = $"// Create new {self.Name}";

			var source = $"let {KimonoCodeGenerator.MakeElementName(self.Name)} = new SKColor({self.Color.Red}, {self.Color.Green}, {self.Color.Blue}, {self.Color.Alpha})";

			return new[]
			{
				comment,
				source
			}.ToLines();
		}
    }
}
