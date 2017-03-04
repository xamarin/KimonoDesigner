using System;
using SkiaSharp;

namespace KimonoCore
{
    public static class StyleCodeGenFSharp
    {
        public static string ToFSharpSkiaImpl (this KimonoStyle self)
        {
            throw new NotImplementedException ("Cannot generate KimonoStyle source code without start and end points");
        }

        public static string ToFSharpSkiaImpl (this KimonoStyle self, SKPoint start, SKPoint end)
        {
            throw new NotImplementedException ();
        }

        public static string ToFSharpKimonoCoreImpl (this KimonoStyle self)
        {
            throw new NotImplementedException ();
        }
    }
}
