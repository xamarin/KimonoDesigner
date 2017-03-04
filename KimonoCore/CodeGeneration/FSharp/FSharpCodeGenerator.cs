using System;
namespace KimonoCore
{
    public static class FSharpCodeGenerator
    {
        public static string ToCode (IKimonoCodeGeneration self, CodeOutputLibrary lib)
        {
            Func<string> ToCode = null;
            switch (lib)
            {
                case CodeOutputLibrary.SkiaSharp:
                    ToCode = self.ToFSharpSkia ;
                    break;
                case CodeOutputLibrary.KimonoCore:
                     throw new NotImplementedException ("Implement KimonoCore generation");
                  //ToCode = self.ToFSharpKimonoCore ;
                    break;
                default :
                    throw new ArgumentOutOfRangeException ($"Unrecognized CodeOutputLibrary: {lib}");   
            }
            var sourceCode = ToCode ();
            // Return code
            return sourceCode;
        }
    }
}
