using System;
using System.Collections.Generic;
using System.Linq;
using SkiaSharp;

namespace KimonoCore
{
    public static class SketchCodeGenFSharp
    {
        public static string ToFSharpSkiaImpl (this KimonoSketch self)
        {
            var snippets = self.Shapes.Select (s => s.ToFSharpSkia ());
            var sourceCode = snippets.ToLines ();
            return sourceCode;
        }

        public static string ToFSharpKimonoCoreImpl (this KimonoSketch self)
        {
            throw new NotImplementedException ();
        }

    }
}