using System;
namespace KimonoCore
{
    /// <summary>
    /// Visitor pattern: defines overloaded code generation function for each type of `IKimonoCodeGeneration`. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This defines the "Visitor" that visits the objects for which code gen is desired (implementors of `IKomonoCodeGeneration`). Such subtypes must implement `string ToCode(IVisitorCodeGen visitor)`, and 
    /// that implementation is just the double-dispatching boilerplate `=> visitor.CodeGen(this)`. 
    /// </para>
    /// <para>
    /// Implementors of `IKimonoCodeGeneration` must also extend this interface, which of course means they must change all existing implementations of `IVisitorCodeGen`. 
    /// </para>
    /// </remarks>
    public interface IVisitorCodeGen
    {
        string CodeGen (KimonoBounds self);
        string CodeGen (KimonoBlur self);
        string CodeGen (KimonoShapeArrow self);
        string CodeGen (KimonoShadow self);
        string CodeGen (KimonoPortfolio self);
        string CodeGen (KimonoSketch self);
        string CodeGen (KimonoShape self);
        string CodeGen (KimonoShapeBezier self);
        string CodeGen (KimonoShapeGroup self);
        string CodeGen (KimonoShapeLine self);
        string CodeGen (KimonoShapeOval self);
        string CodeGen (KimonoShapePolygon self);
        string CodeGen (KimonoShapeRect self);
        string CodeGen (KimonoShapeRoundRect self);
        string CodeGen (KimonoShapeStar self);
        string CodeGen (KimonoShapeText self);
        string CodeGen (KimonoShapeTriangle self);
        string CodeGen (KimonoShapeVector self);
        string CodeGen (KimonoColor self);
        string CodeGen (KimonoGradient self);
        string CodeGen (KimonoStyle self);
    }
}
