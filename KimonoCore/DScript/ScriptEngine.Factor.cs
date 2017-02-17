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
		private ScriptVarLink Factor(ref bool execute)
		{
			if (_currentLexer.TokenType == (ScriptLex.LexTypes)'(')
			{
				_currentLexer.Match((ScriptLex.LexTypes)'(');
				ScriptVarLink a = Base(ref execute);
				_currentLexer.Match((ScriptLex.LexTypes)')');
				return a;
			}
			if (_currentLexer.TokenType == ScriptLex.LexTypes.RTrue)
			{
				_currentLexer.Match(ScriptLex.LexTypes.RTrue);
				return new ScriptVarLink(new ScriptVar(1), null);
			}
			if (_currentLexer.TokenType == ScriptLex.LexTypes.RFalse)
			{
				_currentLexer.Match(ScriptLex.LexTypes.RFalse);
				return new ScriptVarLink(new ScriptVar(0), null);
			}
			if (_currentLexer.TokenType == ScriptLex.LexTypes.RNull)
			{
				_currentLexer.Match(ScriptLex.LexTypes.RUndefined);
				return new ScriptVarLink(new ScriptVar(null, ScriptVar.Flags.Null), null);
			}
			if (_currentLexer.TokenType == ScriptLex.LexTypes.RUndefined)
			{
				_currentLexer.Match(ScriptLex.LexTypes.RUndefined);
				return new ScriptVarLink(new ScriptVar(null, ScriptVar.Flags.Undefined), null);
			}
			if (_currentLexer.TokenType == ScriptLex.LexTypes.Id)
			{
				ScriptVarLink a = execute ? FindInScopes(_currentLexer.TokenString) : new ScriptVarLink(new ScriptVar(), null);

				ScriptVar parent = null;

				if (execute && a == null)
				{
					a = new ScriptVarLink(new ScriptVar(), _currentLexer.TokenString);
				}

				_currentLexer.Match(ScriptLex.LexTypes.Id);

				while (_currentLexer.TokenType == (ScriptLex.LexTypes)'(' || _currentLexer.TokenType == (ScriptLex.LexTypes)'.' || _currentLexer.TokenType == (ScriptLex.LexTypes)'[')
				{
					if (_currentLexer.TokenType == (ScriptLex.LexTypes)'(') // function call
					{
						a = FunctionCall(ref execute, a, parent);
					}
					else if (_currentLexer.TokenType == (ScriptLex.LexTypes)'.') // child access
					{
						_currentLexer.Match((ScriptLex.LexTypes)'.');
						if (execute)
						{
							if (!a.Var.IsObject)
							{
								throw new ScriptException("Trying to call object member on non object type");
							}

							String name = _currentLexer.TokenString;
							ScriptVarLink child = a.Var.FindChild(name);

							if (child == null)
							{
								child = FindInParentClasses(a.Var, name);
							}

							if (child == null)
							{
								if (a.Var.IsArray && name == "length")
								{
									Int32 length = a.Var.GetArrayLength();
									child = new ScriptVarLink(new ScriptVar(length), null);
								}
								else if (a.Var.IsString && name == "length")
								{
									Int32 length = a.Var.GetString().Length;
									child = new ScriptVarLink(new ScriptVar(length), null);
								}
								else
								{
									child = a.Var.AddChild(name, null);
								}
							}

							parent = a.Var;
							a = child;
						}

						_currentLexer.Match(ScriptLex.LexTypes.Id);
					}
					else if (_currentLexer.TokenType == (ScriptLex.LexTypes)'[') // array access
					{
						_currentLexer.Match((ScriptLex.LexTypes)'[');
						ScriptVarLink index = Base(ref execute);
						_currentLexer.Match((ScriptLex.LexTypes)']');

						if (execute)
						{
							ScriptVarLink child = a.Var.FindChildOrCreate(index.Var.GetString());
							parent = a.Var;
							a = child;
						}
					}
					else
					{
						throw new ScriptException("WTF?");
					}
				}

				return a;
			}

			if (_currentLexer.TokenType == ScriptLex.LexTypes.Int || _currentLexer.TokenType == ScriptLex.LexTypes.Float)
			{
				ScriptVar a = new ScriptVar(_currentLexer.TokenString, _currentLexer.TokenType == ScriptLex.LexTypes.Int ? ScriptVar.Flags.Integer : ScriptVar.Flags.Double);
				_currentLexer.Match(_currentLexer.TokenType);
				return new ScriptVarLink(a, null);
			}

			if (_currentLexer.TokenType == ScriptLex.LexTypes.Str)
			{
				ScriptVar a = new ScriptVar(_currentLexer.TokenString, ScriptVar.Flags.String);
				_currentLexer.Match(_currentLexer.TokenType);
				return new ScriptVarLink(a, null);
			}

			if (_currentLexer.TokenType == (ScriptLex.LexTypes)'{')
			{
				ScriptVar contents = new ScriptVar(null, ScriptVar.Flags.Object);
				//looking for JSON like objects
				_currentLexer.Match((ScriptLex.LexTypes)'{');
				while (_currentLexer.TokenType != (ScriptLex.LexTypes)'}')
				{
					String id = _currentLexer.TokenString;

					if (_currentLexer.TokenType == ScriptLex.LexTypes.Str)
					{
						_currentLexer.Match(ScriptLex.LexTypes.Str);
					}
					else
					{
						_currentLexer.Match(ScriptLex.LexTypes.Id);
					}

					_currentLexer.Match((ScriptLex.LexTypes)':');

					if (execute)
					{
						ScriptVarLink a = Base(ref execute);
						contents.AddChild(id, a.Var);
					}

					if (_currentLexer.TokenType != (ScriptLex.LexTypes)'}')
					{
						_currentLexer.Match((ScriptLex.LexTypes)',');
					}
				}
				_currentLexer.Match((ScriptLex.LexTypes)'}');

				return new ScriptVarLink(contents, null);
			}

			if (_currentLexer.TokenType == (ScriptLex.LexTypes)'[')
			{
				Int32 idx = 0;
				ScriptVar contents = new ScriptVar(null, ScriptVar.Flags.Array);
				//looking for JSON like arrays
				_currentLexer.Match((ScriptLex.LexTypes)'[');
				while (_currentLexer.TokenType != (ScriptLex.LexTypes)']')
				{
					if (execute)
					{
						String id = String.Format("{0}", idx);

						ScriptVarLink a = Base(ref execute);
						contents.AddChild(id, a.Var);
					}

					if (_currentLexer.TokenType != (ScriptLex.LexTypes)']')
					{
						_currentLexer.Match((ScriptLex.LexTypes)',');
					}

					idx++;
				}
				_currentLexer.Match((ScriptLex.LexTypes)']');

				return new ScriptVarLink(contents, null);
			}

			if (_currentLexer.TokenType == ScriptLex.LexTypes.RFunction)
			{
				ScriptVarLink funcVar = ParseFunctionDefinition();
				if (funcVar.Name != String.Empty)
				{
					System.Diagnostics.Trace.TraceWarning("Functions not defined at statement level are not supposed to have a name");
				}
				return funcVar;
			}

			if (_currentLexer.TokenType == ScriptLex.LexTypes.RNew) // new
			{
				_currentLexer.Match(ScriptLex.LexTypes.RNew);

				String className = _currentLexer.TokenString;
				if (execute)
				{
					ScriptVarLink classOrFuncObject = FindInScopes(className);
					if (classOrFuncObject == null)
					{
						System.Diagnostics.Trace.TraceWarning("{0} is not a valid class name", className);
						return new ScriptVarLink(new ScriptVar(), null);
					}

					_currentLexer.Match(ScriptLex.LexTypes.Id);

					ScriptVar obj = new ScriptVar(null, ScriptVar.Flags.Object);
					ScriptVarLink objLink = new ScriptVarLink(obj, null);

					if (classOrFuncObject.Var.IsFunction)
					{
						FunctionCall(ref execute, classOrFuncObject, obj);
					}
					else
					{
						//creating new instance of a class
						if (classOrFuncObject.Var.ClassType != null)
						{
							obj.ClassInstance = Activator.CreateInstance(classOrFuncObject.Var.ClassType);
						}

						obj.AddChild(ScriptVar.PrototypeClassName, classOrFuncObject.Var);

						if (_currentLexer.TokenType == (ScriptLex.LexTypes)'(')
						{
							_currentLexer.Match((ScriptLex.LexTypes)'(');
							_currentLexer.Match((ScriptLex.LexTypes)')');
						}
					}

					return objLink;
				}

				_currentLexer.Match(ScriptLex.LexTypes.Id);
				if (_currentLexer.TokenType == (ScriptLex.LexTypes)'(')
				{
					_currentLexer.Match((ScriptLex.LexTypes)'(');
					_currentLexer.Match((ScriptLex.LexTypes)')');
				}
			}

			_currentLexer.Match(ScriptLex.LexTypes.Eof);

			return null;
		}
    }
}
