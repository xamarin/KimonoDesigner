using System;
using System.Collections.Generic;
using Foundation;
using AppKit;

namespace AppKit.TextKit.Formatter
{
	/// <summary>
	/// Defines how C# should be colorized using a <see cref="AppKit.TextKit.Formatter.LanguageFormatter"/>.
	/// </summary>
	public class ObiScriptDescriptor : LanguageDescriptor
	{
		#region Computed Properties
		/// <summary>
		/// Gets the language identifier.
		/// </summary>
		/// <value>The language identifier.</value>
		public override string LanguageIdentifier
		{
			get { return "CSharp"; }
		}

		/// <summary>
		/// Gets or sets the language separators for C#
		/// </summary>
		/// <value>The language separators.</value>
		public override char[] LanguageSeparators { get; set; } = new char[] { '=', '+', '-', '*', '/', '%', '&', '<', '>', ';', ':', '^', '!', '~', '?', '|', ',', '"', '\'', '(', ')', '[', ']', '{', '}' };
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AppKit.TextKit.Formatter.CSharpDescriptor"/> class.
		/// </summary>
		public ObiScriptDescriptor()
		{
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Define this instance.
		/// </summary>
		public override void Define()
		{
			// Call base class
			base.Define();

			// Value Types
			// Keywords.Add("", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.GetBoolean", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.SetBoolean", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.GetNumber", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.SetNumber", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.GetText", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.SetText", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.SetRect", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.SetColor", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.SetNamedColor", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.HasColor", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.HasGradient", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.HasStyle", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));
			Keywords.Add("Portfolio.HasProperty", new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, ""));

			// Reference Types
			// Keywords.Add("", new KeywordDescriptor(KeywordType.ReferenceType, ReferenceTypeColor, ""));
			Keywords.Add("class", new KeywordDescriptor(KeywordType.ReferenceType, ReferenceTypeColor, "Classes are declared using the keyword class."));
			Keywords.Add("function", new KeywordDescriptor(KeywordType.ReferenceType, ReferenceTypeColor, "Defines a reusable function."));

			// Generic Types
			// Keywords.Add("", new KeywordDescriptor(KeywordType.Type, TypeColor, ""));
			Keywords.Add("var", new KeywordDescriptor(KeywordType.Type, TypeColor, "An implicitly typed local variable is strongly typed just as if you had declared the type yourself, but the compiler determines the type."));

			// Access modifiers
			// Keywords.Add("", new KeywordDescriptor(KeywordType.AccessModifier, AccessModifierColor, ""));

			// Modifiers
			// Keywords.Add("", new KeywordDescriptor(KeywordType.Modifier, ModifierColor, ""));

			// Selection Statements
			// Keywords.Add("", new KeywordDescriptor(KeywordType.SelectionStatement, SelectionStatementColor, ""));
			Keywords.Add("if", new KeywordDescriptor(KeywordType.SelectionStatement, SelectionStatementColor, "An if statement identifies which statement to run based on the value of a Boolean expression."));
			Keywords.Add("else", new KeywordDescriptor(KeywordType.SelectionStatement, SelectionStatementColor, "In an if-else statement, if condition evaluates to true, the then-statement runs. If condition is false, the else-statement runs. "));
			Keywords.Add("switch", new KeywordDescriptor(KeywordType.SelectionStatement, SelectionStatementColor, "The switch statement is a control statement that selects a switch section to execute from a list of candidates."));
			Keywords.Add("case", new KeywordDescriptor(KeywordType.SelectionStatement, SelectionStatementColor, "Each case label specifies a constant value."));
			Keywords.Add("default", new KeywordDescriptor(KeywordType.SelectionStatement, SelectionStatementColor, "f no case label contains a matching value, control is transferred to the default section, if there is one."));

			// Iteration Statements
			// Keywords.Add("", new KeywordDescriptor(KeywordType.IterationStatement, IterationStatementColor, ""));
			Keywords.Add("do", new KeywordDescriptor(KeywordType.IterationStatement, IterationStatementColor, "The do statement executes a statement or a block of statements repeatedly until a specified expression evaluates to false. "));
			Keywords.Add("for", new KeywordDescriptor(KeywordType.IterationStatement, IterationStatementColor, "By using a for loop, you can run a statement or a block of statements repeatedly until a specified expression evaluates to false."));
			Keywords.Add("foreach", new KeywordDescriptor(KeywordType.IterationStatement, IterationStatementColor, "The foreach statement repeats a group of embedded statements for each element in an array or an object collection that implements the System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T> interface. "));
			Keywords.Add("while", new KeywordDescriptor(KeywordType.IterationStatement, IterationStatementColor, "The while statement executes a statement or a block of statements until a specified expression evaluates to false."));

			// Jump Statements
			// Keywords.Add("", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, ""));
			Keywords.Add("break", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "The break statement terminates the closest enclosing loop or switch statement in which it appears. Control is passed to the statement that follows the terminated statement, if any."));
			Keywords.Add("continue", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "The continue statement passes control to the next iteration of the enclosing while, do, for, or foreach statement in which it appears."));
			Keywords.Add("goto", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "The goto statement transfers the program control directly to a labeled statement."));
			Keywords.Add("return", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "The return statement terminates execution of the method in which it appears and returns control to the calling method. It can also return an optional value."));
			Keywords.Add("Return.Text", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Returns a string result to the Kimono Property."));
			Keywords.Add("Return.Boolean", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Returns a boolean result to the Kimono Property."));
			Keywords.Add("Return.Color", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Returns a named color to the Kimono Property."));
			Keywords.Add("Return.Gradient", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Returns a named gradient to the Kimono Property."));
			Keywords.Add("Return.NoGradient", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Removes the gradient from the Kimono Property."));
			Keywords.Add("Return.Style", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Returns a named style to the Kimono Property."));
			Keywords.Add("Return.NoStyle", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Removes the style from the Kimono Property."));
			Keywords.Add("Return.Property", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Returns the value of another property to the Kimono Property."));
			Keywords.Add("Return.Rect", new KeywordDescriptor(KeywordType.JumpStatement, JumpStatementColor, "Returns a rectangular result to the Kimono Property."));


			// Exception Handling Statements
			// Keywords.Add("", new KeywordDescriptor(KeywordType.ExceptionHandlingStatement, ExceptionHandlingColor, ""));
			Keywords.Add("throw", new KeywordDescriptor(KeywordType.ExceptionHandlingStatement, ExceptionHandlingColor, "The throw statement is used to signal the occurrence of an anomalous situation (exception) during the program execution."));
			Keywords.Add("try", new KeywordDescriptor(KeywordType.ExceptionHandlingStatement, ExceptionHandlingColor, "The try-catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different exceptions."));
			Keywords.Add("catch", new KeywordDescriptor(KeywordType.ExceptionHandlingStatement, ExceptionHandlingColor, "The try-catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different exceptions."));
			Keywords.Add("finally", new KeywordDescriptor(KeywordType.ExceptionHandlingStatement, ExceptionHandlingColor, "A common usage of catch and finally together is to obtain and use resources in a try block, deal with exceptional circumstances in a catch block, and release the resources in the finally block."));

			// Statements
			// Keywords.Add("", new KeywordDescriptor(KeywordType.Statement, StatementColor, ""));
			Keywords.Add("Console.WriteLine", new KeywordDescriptor(KeywordType.Statement, StatementColor, ""));
			Keywords.Add("Console.Write", new KeywordDescriptor(KeywordType.Statement, StatementColor, ""));
			Keywords.Add("Console.ReadLine", new KeywordDescriptor(KeywordType.Statement, StatementColor, ""));
			Keywords.Add("Console.ReadChar", new KeywordDescriptor(KeywordType.Statement, StatementColor, ""));

			// Method Parameters
			// Keywords.Add("", new KeywordDescriptor(KeywordType.MethodParameters, MethodParameterColor, ""));
			Keywords.Add("params", new KeywordDescriptor(KeywordType.MethodParameters, MethodParameterColor, "By using the params keyword, you can specify a method parameter that takes a variable number of arguments."));
			Keywords.Add("ref", new KeywordDescriptor(KeywordType.MethodParameters, MethodParameterColor, "The ref keyword causes an argument to be passed by reference, not by value."));
			Keywords.Add("out", new KeywordDescriptor(KeywordType.MethodParameters, MethodParameterColor, "The out keyword causes arguments to be passed by reference. This is like the ref keyword, except that ref requires that the variable be initialized before it is passed. "));

			// Namespace Keywords
			// Keywords.Add("", new KeywordDescriptor(KeywordType.NamespaceKeyword, NamespaceColor, ""));
			Keywords.Add("namespace", new KeywordDescriptor(KeywordType.NamespaceKeyword, NamespaceColor, "The namespace keyword is used to declare a scope that contains a set of related objects."));
			Keywords.Add("using", new KeywordDescriptor(KeywordType.MethodParameters, NamespaceColor, "Allows the use of types in a namespace so that you do not have to qualify the use of a type in that namespace."));

			// Operator Keywords
			// Keywords.Add("", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Pi", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.E", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Abs", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Round", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Ceil", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Floor", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Min", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Max", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Range", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Sign", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Sin", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Cos", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Tan", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Sinh", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Cosh", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Tanh", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.ASin", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.ACos", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.ATan", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.ASinh", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.ACosh", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.ATan2", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Pow", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Sqrt", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Log", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Log10", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));
			Keywords.Add("Math.Exp", new KeywordDescriptor(KeywordType.OperatorKeyword, OperatorKeywordColor, ""));

			// Conversion Keywords
			// Keywords.Add("", new KeywordDescriptor(KeywordType.ConversionKeyword, ConversionKeywordColor, ""));
			Keywords.Add("Convert.IntToString", new KeywordDescriptor(KeywordType.ConversionKeyword, ConversionKeywordColor, ""));
			Keywords.Add("Convert.FloatToString", new KeywordDescriptor(KeywordType.ConversionKeyword, ConversionKeywordColor, ""));
			Keywords.Add("Convert.FloatToInt", new KeywordDescriptor(KeywordType.ConversionKeyword, ConversionKeywordColor, ""));
			Keywords.Add("Convert.StringToFloat", new KeywordDescriptor(KeywordType.ConversionKeyword, ConversionKeywordColor, ""));
			Keywords.Add("Convert.StringToInt", new KeywordDescriptor(KeywordType.ConversionKeyword, ConversionKeywordColor, ""));

			// Access Keywords
			// Keywords.Add("", new KeywordDescriptor(KeywordType.AccessKeywords, AccessKeywordColor, ""));
			Keywords.Add("base", new KeywordDescriptor(KeywordType.AccessKeywords, AccessKeywordColor, "Accesses the members of the base class."));
			Keywords.Add("this", new KeywordDescriptor(KeywordType.AccessKeywords, AccessKeywordColor, "Refers to the current instance of the class."));

			// Literal Keywords
			// Keywords.Add("", new KeywordDescriptor(KeywordType.LiteralKeywords, LiteralKeywordColor, ""));
			Keywords.Add("null", new KeywordDescriptor(KeywordType.LiteralKeywords, LiteralKeywordColor, "The null keyword is a literal that represents a null reference, one that does not refer to any object. null is the default value of reference-type variables."));

			// Contextual Keywords
			// Keywords.Add("", new KeywordDescriptor(KeywordType.ContextualKeywords, ContextualKeywordColor, ""));
			Keywords.Add("Random.Next", new KeywordDescriptor(KeywordType.ContextualKeywords, ContextualKeywordColor, ""));
			Keywords.Add("Random.NextMax", new KeywordDescriptor(KeywordType.ContextualKeywords, ContextualKeywordColor, ""));
			Keywords.Add("Random.NextMinMax", new KeywordDescriptor(KeywordType.ContextualKeywords, ContextualKeywordColor, ""));

			// Query Keywords (LINQ)
			// Keywords.Add("", new KeywordDescriptor(KeywordType.QueryKeywords, QueryKeywordColor, ""));

			// Preprocessor Directive
			// Keywords.Add("", new KeywordDescriptor(KeywordType.PreprocessorDirective, PreprocessorDirectiveColor, ""));
			Keywords.Add("Return.RaiseError", new KeywordDescriptor(KeywordType.PreprocessorDirective, JumpStatementColor, "Raises an error in the ObiScript."));
			Keywords.Add("Return.ClearResults", new KeywordDescriptor(KeywordType.PreprocessorDirective, JumpStatementColor, "Clears the last execution results."));

			// Define formats
			Formats.Add(new FormatDescriptor("//", CommentColor));
			Formats.Add(new FormatDescriptor("/*", "*/", CommentColor));
			Formats.Add(new FormatDescriptor("\"", "\"", StringLiteralColor));
			Formats.Add(new FormatDescriptor("'", "'", StringLiteralColor));

			// Define formatting commands
			FormattingCommands.Add(new LanguageFormatCommand("Comment", "//"));
			FormattingCommands.Add(new LanguageFormatCommand("Block Comment", "/*", "*/"));
			FormattingCommands.Add(new LanguageFormatCommand());
		}

		/// <summary>
		/// Formats the passed in string of text for previewing.
		/// </summary>
		/// <returns>The string formatted for preview.</returns>
		/// <param name="text">Text.</param>
		public override string FormatForPreview(string text)
		{
			return "<pre><code>" + text + "</code></pre>";
		}
		#endregion
	}
}

