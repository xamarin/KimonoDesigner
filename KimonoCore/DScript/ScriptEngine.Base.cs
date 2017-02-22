/*
Copyright (c) 2014 Darren Horrocks

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace DScript
{
	public partial class ScriptEngine
	{
		private ScriptVarLink Base(ref bool execute)
		{
			ScriptVarLink a = Ternary(ref execute);

			if (_currentLexer.TokenType == (ScriptLex.LexTypes) '=' ||
			    _currentLexer.TokenType == ScriptLex.LexTypes.PlusEqual ||
			    _currentLexer.TokenType == ScriptLex.LexTypes.MinusEqual)
			{
				if (execute && a.Owned)
				{
					if (a.Name.Length > 0)
					{
						ScriptVarLink aReal = Root.AddChildNoDup(a.Name, a.Var);
						a = aReal;
					}
					else
					{
						// Hit an unknow error here
						System.Diagnostics.Trace.TraceWarning("Trying to assign to an unnamed type...");
					}
				}


				ScriptLex.LexTypes op = _currentLexer.TokenType;
				_currentLexer.Match(op);

				ScriptVarLink b = Base(ref execute);

				if (execute)
				{
					switch (op)
					{
						case (ScriptLex.LexTypes) '=':
							a.ReplaceWith(b);
							break;
						case ScriptLex.LexTypes.PlusEqual:
						{
							ScriptVar res = a.Var.MathsOp(b.Var, (ScriptLex.LexTypes) '+');
							a.ReplaceWith(res);
						}
							break;
						case ScriptLex.LexTypes.MinusEqual:
						{
							ScriptVar res = a.Var.MathsOp(b.Var, (ScriptLex.LexTypes) '-');
							a.ReplaceWith(res);
						}
							break;
						default:
							throw new ScriptException("Base broke");
					}
				}

			}

			return a;
		}
	}
}
