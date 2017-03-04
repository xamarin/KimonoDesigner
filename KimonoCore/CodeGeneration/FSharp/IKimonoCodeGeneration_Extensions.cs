using System;
using KimonoCore;

namespace KimonoCore
{
   public static class IKimonoCodeGeneration_Extensions
   {
      public static string ToFSharp (this IKimonoCodeGeneration self, CodeOutputLibrary outputLibrary)
      {
            Func<string> ToCode = null;
            switch (outputLibrary)
            {
                case CodeOutputLibrary.SkiaSharp:
                    ToCode = self.ToFSharpSkia ;
                    break;
                case CodeOutputLibrary.KimonoCore:
                    //TODO: ToCode = self.ToFSharpKimonoCore ;
                    break;
                default :
                    throw new ArgumentOutOfRangeException ($"Unrecognized CodeOutputLibrary: {outputLibrary}");   
            }
            var sourceCode = ToCode ();
            // Return code
            return sourceCode;
      }

   }
}