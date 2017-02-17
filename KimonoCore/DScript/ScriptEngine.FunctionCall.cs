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

using System;

namespace DScript
{
	public partial class ScriptEngine
    {
		private ScriptVarLink FunctionCall(ref bool execute, ScriptVarLink function, ScriptVar parent)
		{
			if (execute)
			{
				if (!function.Var.IsFunction)
				{
					throw new ScriptException(String.Format("{0} is not a function", function.Name));
				}

				_currentLexer.Match((ScriptLex.LexTypes) '(');
				ScriptVar functionRoot = new ScriptVar(null, ScriptVar.Flags.Function);

				if (parent != null)
				{
					functionRoot.AddChildNoDup("this", parent);
				}

				ScriptVarLink v = function.Var.FirstChild;
				while (v != null)
				{
					ScriptVarLink value = Base(ref execute);
					if (value.Var.IsBasic)
					{
						//pass by val
						functionRoot.AddChild(v.Name, value.Var.DeepCopy());
					}
					else
					{
						//pass by ref
						functionRoot.AddChild(v.Name, value.Var);
					}

					if (_currentLexer.TokenType != (ScriptLex.LexTypes) ')')
					{
						_currentLexer.Match((ScriptLex.LexTypes) ',');
					}

					v = v.Next;
				}

				_currentLexer.Match((ScriptLex.LexTypes) ')');

				ScriptVarLink returnVarLink = functionRoot.AddChild(ScriptVar.ReturnVarName, null);

				_scopes.Push(functionRoot);

				_callStack.Push(String.Format("{0} from line {1}", function.Name, _currentLexer.LineNumber));

				if (function.Var.IsNative)
				{
					ScriptCallbackCB func = function.Var.GetCallback();
					if (func != null)
					{
						func(functionRoot, function.Var.GetCallbackUserData(), parent);
					}
				}
				else
				{
					ScriptException ex = null;
					ScriptLex oldLex = _currentLexer;
					ScriptLex newLex = new ScriptLex(function.Var.GetString());
					_currentLexer = newLex;

					try
					{
						Block(ref execute);

						execute = true;
					}
					catch (ScriptException e)
					{
						ex = e;
					}

					_currentLexer = oldLex;

					if (ex != null)
					{
						throw ex;
					}
				}

				_callStack.Pop();
				_scopes.Pop();

				ScriptVarLink returnVar = new ScriptVarLink(returnVarLink.Var, null);
				functionRoot.RemoveLink(returnVarLink);

				return returnVar;
			}

			//not executing the function, just parsing it out
			_currentLexer.Match((ScriptLex.LexTypes)'(');

			while (_currentLexer.TokenType != (ScriptLex.LexTypes) ')')
			{
				Base(ref execute);

				if (_currentLexer.TokenType != (ScriptLex.LexTypes) ')')
				{
					_currentLexer.Match((ScriptLex.LexTypes)',');
				}
			}

			_currentLexer.Match((ScriptLex.LexTypes)')');

			if (_currentLexer.TokenType == (ScriptLex.LexTypes) '{') //WTF?
			{
				Block(ref execute);
			}

			return function;
		}
    }
}
