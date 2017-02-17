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
using System.Collections.Generic;
using System.Reflection;
using KimonoCore;

namespace DScript
{
	public partial class ScriptEngine : IDisposable
	{
		#region IDisposable
		private bool _disposed;
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_stringClass.UnRef();
					_arrayClass.UnRef();
					_objectClass.UnRef();
					Root.UnRef();

					if (_currentLexer != null)
					{
						_currentLexer.Dispose();
					}
				}

				// Indicate that the instance has been disposed.
				_disposed = true;
			}
		}
		#endregion

		private readonly ScriptVar _stringClass;
		private readonly ScriptVar _objectClass;
		private readonly ScriptVar _arrayClass;
		private Stack<ScriptVar> _scopes;
		private readonly Stack<String> _callStack;

		private ScriptLex _currentLexer;

		public delegate void ScriptCallbackCB(ScriptVar var, object userdata, ScriptVar parent = null);

		public ScriptVar Root { get; private set; }

		public ScriptEngine(bool loadProviders = true)
		{
			_currentLexer = null;

			_scopes = new Stack<ScriptVar>();
			_callStack = new Stack<string>();

			Root = (new ScriptVar(null, ScriptVar.Flags.Object)).Ref();

			_stringClass = (new ScriptVar(null, ScriptVar.Flags.Object)).Ref();
			_objectClass = (new ScriptVar(null, ScriptVar.Flags.Object)).Ref();
			_arrayClass = (new ScriptVar(null, ScriptVar.Flags.Object)).Ref();

			Root.AddChild("String", _stringClass);
			Root.AddChild("Object", _objectClass);
			Root.AddChild("Array", _arrayClass);

			if (loadProviders)
			{
				LoadAllFunctionProviders();
			}
		}

		public void Trace()
		{
			Root.Trace(0, null);
		}

		public void Execute(String code)
		{
			ScriptLex oldLex = _currentLexer;
			Stack<ScriptVar> oldScopes = _scopes;

			using (_currentLexer = new ScriptLex(code))
			{
				_scopes.Clear();
				_scopes.Push(Root);
				_callStack.Clear();

				// Clear results
				ObiScriptEngine.EvaluationResult.Successful = true;
				ObiScriptEngine.EvaluationResult.ErrorMessage = "";
				ObiScriptEngine.EvaluationResult.Value = this;

				try
				{
					while (_currentLexer.TokenType != 0)
					{
						bool execute = true;
						Statement(ref execute);
					}
				}
				catch (ScriptException ex)
				{
					// Record error
					ObiScriptEngine.EvaluationResult.Successful = false;
					ObiScriptEngine.EvaluationResult.ErrorMessage = String.Format("ERROR on line {0} column {1} [{2}]", _currentLexer.LineNumber, _currentLexer.ColumnNumber, ex.Message);

					int i = 0;
					foreach (ScriptVar scriptVar in _scopes)
					{
						ObiScriptEngine.EvaluationResult.ErrorMessage += "\n" + i++ + ": " + scriptVar;
					}

					// Clear result
					ObiScriptEngine.EvaluationResult.Value = null;
				}
			}

			_currentLexer = oldLex;
			_scopes = oldScopes;
		}

		public ScriptVarLink EvalComplex(String code)
		{
			ScriptLex oldLex = _currentLexer;
			Stack<ScriptVar> oldScopes = _scopes;

			_currentLexer = new ScriptLex(code);

			_callStack.Clear();
			_scopes.Clear();
			_scopes.Push(Root);

			ScriptVarLink v = null;

			try
			{
				bool execute = true;
				do
				{
					v = Base(ref execute);
					if (_currentLexer.TokenType != ScriptLex.LexTypes.Eof)
					{
						_currentLexer.Match((ScriptLex.LexTypes) ';');
					}
				} while (_currentLexer.TokenType != ScriptLex.LexTypes.Eof);
			}
			catch (ScriptException ex)
			{
				String errorMessage = ex.Message;
				int i = 0;
				foreach (ScriptVar scriptVar in _scopes)
				{
					errorMessage += "\n" + i++ + ": " + scriptVar;
				}

				Console.Write(errorMessage);
			}

			_currentLexer = oldLex;
			_scopes = oldScopes;

			if (v != null)
			{
				return v;
			}

			return new ScriptVarLink(new ScriptVar(null), null);
		}

		public void AddObject(String[] ns, String objectName, ScriptVar val)
		{
			ScriptVar baseVar = Root;

			if (ns != null)
			{
				int x = 0;
				for (; x < ns.Length; x++)
				{
					ScriptVarLink link = baseVar.FindChild(ns[x]);

					if (link == null)
					{
						link = baseVar.AddChild(ns[x], new ScriptVar(null, ScriptVar.Flags.Object));
					}

					baseVar = link.Var;
				}
			}

			baseVar.AddChild(objectName, val);
		}

		public void AddMethod(String[] ns, String funcName, String[] args, ScriptCallbackCB callback, Object userdata)
		{
			String fName = funcName;
			ScriptVar baseVar = Root;

			if (ns != null)
			{
				int x = 0;
				for (; x < ns.Length; x++)
				{
					ScriptVarLink link = baseVar.FindChild(ns[x]);

					if (link == null)
					{
						link = baseVar.AddChild(ns[x], new ScriptVar(null, ScriptVar.Flags.Object));
					}

					baseVar = link.Var;
				}
			}


			ScriptVar funcVar = new ScriptVar(null, ScriptVar.Flags.Function | ScriptVar.Flags.Native);
			funcVar.SetCallback(callback, userdata);

			//do we have any arguments to create?
			if (args != null)
			{
				foreach (string arg in args)
				{
					funcVar.AddChildNoDup(arg, null);
				}
			}

			baseVar.AddChild(fName, funcVar);
		}

		public void AddMethod(String funcName, String[] args, ScriptCallbackCB callback, Object userdata)
		{
			ScriptVar funcVar = new ScriptVar(null, ScriptVar.Flags.Function | ScriptVar.Flags.Native);
			funcVar.SetCallback(callback, userdata);

			//do we have any arguments to create?
			if (args != null)
			{
				foreach (string arg in args)
				{
					funcVar.AddChildNoDup(arg, null);
				}
			}

			Root.AddChild(funcName, funcVar);
		}

		public void LoadAllFunctionProviders()
		{
			Assembly execAssembly = Assembly.GetExecutingAssembly();

			TestForAttribute(execAssembly);

			AssemblyName[] referencedAssemblies = execAssembly.GetReferencedAssemblies();
			foreach (AssemblyName assembly in referencedAssemblies)
			{
				Assembly asm = Assembly.Load(assembly);

				TestForAttribute(asm);
			}
		}

		private void TestForAttribute(Assembly asm)
		{
			Type[] types = asm.GetTypes();
			foreach (Type type in types)
			{
				object[] scObjects = type.GetCustomAttributes(typeof(ScriptClassAttribute), false);
				if (scObjects.Length > 0)
				{
					ProcessType(type, scObjects[0] as ScriptClassAttribute);
				}
			}
		}

		private void ProcessType(Type type, ScriptClassAttribute attr)
		{
			AddObject(attr.Namespace ?? new string[0], attr.ClassName ?? type.Name, new ScriptVar(null, ScriptVar.Flags.Object | ScriptVar.Flags.Native) { ClassType = type });

			MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
			ProcessMethods(methods, attr);

			methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);
			ProcessMethods(methods, attr);

			PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
			//ProcessProperties(properties, attr, Activator.CreateInstance(type));

			properties = type.GetProperties(BindingFlags.Public | BindingFlags.Static);
			ProcessProperties(properties, attr, null);
		}

		private void ProcessMethods(MethodInfo[] methods, ScriptClassAttribute attr)
		{
			foreach (MethodInfo method in methods)
			{
				if (method.IsSpecialName) continue;

				ParameterInfo[] parameters = method.GetParameters();
				if (parameters.Length < 1) continue;

				String[] argNames = new string[parameters.Length - 1];
				for (int i = 0; i < parameters.Length - 1; i++)
				{
					argNames[i] = parameters[i].Name;
				}

				MethodInfo methodCopy = method;
				String[] ns = attr.Namespace ?? new string[0];

				if (attr.ClassName == null && ns.Length == 0)
				{
					ns = null;
				}
				else
				{
					Array.Resize(ref ns, ns.Length + 1);
					ns[ns.Length - 1] = attr.ClassName;
				}

				AddMethod(ns, method.Name, argNames, CreateScriptFunction(methodCopy, parameters), this);
			}
		}

		private void ProcessProperties(PropertyInfo[] properties, ScriptClassAttribute attr, object instance)
		{
			foreach (PropertyInfo property in properties)
			{
				if (property.IsSpecialName) continue;

				PropertyInfo propertyCopy = property;
				String[] ns = attr.Namespace ?? new string[0];

				if (attr.ClassName == null && ns.Length == 0)
				{
					ns = null;
				}
				else
				{
					Array.Resize(ref ns, ns.Length + 1);
					ns[ns.Length - 1] = attr.ClassName;
				}

				if (property.PropertyType == typeof(bool))
				{
					AddObject(ns, property.Name, new ScriptVar((bool)property.GetValue(instance, null)));
				}
				else if (property.PropertyType == typeof(string))
				{
					AddObject(ns, property.Name, new ScriptVar((string)property.GetValue(instance, null)));
				}
				else if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(float) || property.PropertyType == typeof(double))
				{
					AddObject(ns, property.Name, new ScriptVar((double)property.GetValue(instance, null)));
				}
				else if (property.PropertyType == typeof(Int32))
				{
					AddObject(ns, property.Name, new ScriptVar((Int32)property.GetValue(instance, null)));
				}
			}
		}

		private ScriptCallbackCB CreateScriptFunction(MethodInfo method, ParameterInfo[] parameters)
		{
			return delegate(ScriptVar var, object userdata, ScriptVar parent)
			{
				object[] args = new object[parameters.Length];

				int i = 0;
				for (; i < parameters.Length - 1; i++)
				{
					args[i] = var.GetParameter(parameters[i].Name).GetData();
				}

				args[i] = userdata;

				object returnVal;

				if (method.IsStatic)
				{
					returnVal = method.Invoke(null, args);
				}
				else
				{
					returnVal = method.Invoke(parent.ClassInstance, args);
				}

				if (method.ReturnType == typeof (Int32))
				{
					var.SetReturnVar(new ScriptVar(Convert.ToInt32(returnVal), ScriptVar.Flags.Integer));
				}
				else if (method.ReturnType == typeof (bool))
				{
					var.SetReturnVar(new ScriptVar(Convert.ToBoolean(returnVal) ? 1 : 0, ScriptVar.Flags.Integer));
				}
				else if (method.ReturnType == typeof (double) || method.ReturnType == typeof(float))
				{
					var.SetReturnVar(new ScriptVar(Convert.ToDouble(returnVal), ScriptVar.Flags.Double));
				}
				else if (method.ReturnType == typeof (String))
				{
					var.SetReturnVar(new ScriptVar(Convert.ToString(returnVal), ScriptVar.Flags.String));
				}
			};
		}

		[Obsolete("Do not use, this is the old way of binding native methods to language functions")]
		public void AddMethod(String funcProto, ScriptCallbackCB callback, Object userdata)
		{
			ScriptLex oldLex = _currentLexer;

			using (_currentLexer = new ScriptLex(funcProto))
			{
				ScriptVar baseVar = Root;

				_currentLexer.Match(ScriptLex.LexTypes.RFunction);
				String funcName = _currentLexer.TokenString;
				_currentLexer.Match(ScriptLex.LexTypes.Id);

				while (_currentLexer.TokenType == (ScriptLex.LexTypes) '.')
				{
					_currentLexer.Match((ScriptLex.LexTypes) '.');
					ScriptVarLink link = baseVar.FindChild(funcName);

					if (link == null)
					{
						link = baseVar.AddChild(funcName, new ScriptVar(null, ScriptVar.Flags.Object));
					}

					baseVar = link.Var;
					funcName = _currentLexer.TokenString;
					_currentLexer.Match(ScriptLex.LexTypes.Id);
				}

				ScriptVar funcVar = new ScriptVar(null, ScriptVar.Flags.Function | ScriptVar.Flags.Native);
				funcVar.SetCallback(callback, userdata);

				ParseFunctionArguments(funcVar);

				baseVar.AddChild(funcName, funcVar);
			}

			_currentLexer = oldLex;
		}

		private ScriptVarLink FindInScopes(String name)
		{
			foreach (ScriptVar scriptVar in _scopes)
			{
				ScriptVarLink a = scriptVar.FindChild(name);
				if (a != null)
				{
					return a;
				}
			}

			return null;
		}

		private ScriptVarLink FindInParentClasses(ScriptVar obj, String name)
		{
			ScriptVarLink implementation;
			ScriptVarLink parentClass = obj.FindChild(ScriptVar.PrototypeClassName);

			while (parentClass != null)
			{
				implementation = parentClass.Var.FindChild(name);
				if (implementation != null) return implementation;
				parentClass = parentClass.Var.FindChild(ScriptVar.PrototypeClassName);
			}

			if (obj.IsString)
			{
				implementation = _stringClass.FindChild(name);
				if (implementation != null) return implementation;
			}

			if (obj.IsArray)
			{
				implementation = _arrayClass.FindChild(name);
				if (implementation != null) return implementation;
			}

			implementation = _objectClass.FindChild(name);
			if (implementation != null) return implementation;

			return null;
		}

		private ScriptVarLink ParseFunctionDefinition()
		{
			_currentLexer.Match(ScriptLex.LexTypes.RFunction);
			String funcName = String.Empty;

			//named function
			if (_currentLexer.TokenType == ScriptLex.LexTypes.Id)
			{
				funcName = _currentLexer.TokenString;
				_currentLexer.Match(ScriptLex.LexTypes.Id);
			}

			ScriptVarLink funcVar = new ScriptVarLink(new ScriptVar(null, ScriptVar.Flags.Function), funcName);
			ParseFunctionArguments(funcVar.Var);

			Int32 funcBegin = _currentLexer.TokenStart;
			bool execute = false;
			Block(ref execute);
			funcVar.Var.SetData(_currentLexer.GetSubString(funcBegin));

			return funcVar;
		}

		private void ParseFunctionArguments(ScriptVar funcVar)
		{
			_currentLexer.Match((ScriptLex.LexTypes)'(');
			while (_currentLexer.TokenType != (ScriptLex.LexTypes)')')
			{
				funcVar.AddChildNoDup(_currentLexer.TokenString, null);
				_currentLexer.Match(ScriptLex.LexTypes.Id);

				if (_currentLexer.TokenType != (ScriptLex.LexTypes)')')
				{
					_currentLexer.Match((ScriptLex.LexTypes)',');
				}
			}

			_currentLexer.Match((ScriptLex.LexTypes)')');
		}
	}
}
