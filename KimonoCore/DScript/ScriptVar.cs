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
	public class ScriptVar : IDisposable
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
					RemoveAllChildren();
				}

				// Indicate that the instance has been disposed.
				_disposed = true;
			}
		}
		#endregion

		private int _refs;
		private Flags _flags;
		private object _data;
		private int _intData;
		private double _doubleData;
		private ScriptEngine.ScriptCallbackCB _callback;
		private object _callbackUserData;

		public const String ReturnVarName = "return";
		public const String PrototypeClassName = "prototype";

		[Flags]
		public enum Flags
		{
			Undefined = 1,
			Function = 2,
			Object = 4,
			Array = 8,
			Double = 16,
			Integer = 32,
			String = 64,
			Null = 128,
			Native = 256,
			Class = 512,
			NumericMask = Null | Double | Integer,
			VarTypeMask = Double | Integer | String | Function | Object | Array | Null
		}

		public ScriptVarLink FirstChild { get; set; }
		public ScriptVarLink LastChild { get; set; }

		public ScriptVar()
		{
			_refs = 0;
			_flags = Flags.Undefined;
			Init();
		}

		public ScriptVar(int val)
		{
			_refs = 0;
			_flags = Flags.Integer;
			Init();
			_intData = val;
		}

		public ScriptVar(double val)
		{
			_refs = 0;
			_flags = Flags.Double;
			Init();
			_doubleData = val;
		}

		public ScriptVar(string val)
		{
			_refs = 0;
			_flags = Flags.String;
			Init();
			_data = val;
		}

		public ScriptVar(bool val)
		{
			_refs = 0;
			_flags = Flags.Integer;
			Init();
			_intData = val ? 1 : 0;
		}

		public ScriptVar(object val, Flags flags)
		{
			_refs = 0;
			_flags = flags;
			Init();
			_data = val;
		}

		private void Init()
		{
			FirstChild = null;
			LastChild = null;
			_callback = null;
			_callbackUserData = null;
			_data = null;
			_intData = 0;
			_doubleData = 0;
		}

		public bool IsInt
		{
			get { return (_flags & Flags.Integer) != 0; }
		}

		public bool IsDouble
		{
			get { return (_flags & Flags.Double) != 0; }
		}

		public bool IsString
		{
			get { return (_flags & Flags.String) != 0; }
		}

		public bool IsNumeric
		{
			get { return (_flags & Flags.NumericMask) != 0; }
		}

		public bool IsFunction
		{
			get { return (_flags & Flags.Function) != 0; }
		}

		public bool IsObject
		{
			get { return (_flags & Flags.Object) != 0; }
		}

		public bool IsArray
		{
			get { return (_flags & Flags.Array) != 0; }
		}

		public bool IsNative
		{
			get { return (_flags & Flags.Native) != 0; }
		}

		public bool IsUndefined
		{
			get { return (_flags & Flags.VarTypeMask) == Flags.Undefined; }
		}

		public bool IsNull
		{
			get { return (_flags & Flags.Null) != 0; }
		}

		public bool IsBasic
		{
			get { return FirstChild == null; }
		}

		public bool IsClass
		{
			get { return (_flags & Flags.Class) != 0; }
		}

		public ScriptVar this[String index]
		{
			get { return GetParameter(index); }
		}

		public int GetInt()
		{
			if (IsInt && _data == null) return _intData;
			if (IsInt && _data != null) return Convert.ToInt32(_data);
			if (IsNull) return 0;
			if (IsUndefined) return 0;
			if (IsDouble) return (int)_doubleData;
			return 0;
		}

		public bool GetBool()
		{
			return GetInt() != 0;
		}

		public double GetDouble()
		{
			if (IsDouble && _data == null) return _doubleData;
			if (IsDouble && _data != null) return Convert.ToDouble(_data);
			if (IsInt) return _intData;
			if (IsNull) return 0;
			if (IsUndefined) return 0;
			return 0;
		}

		public String GetString()
		{
			if (IsInt)
			{
				return String.Format("{0:D}", _intData);
			}
			if (IsDouble)
			{
				return String.Format("{0}", _doubleData);
			}
			if (IsNull) return "null";
			if (IsUndefined) return "undefined";

			return (String)_data;
		}

		public object GetData()
		{
			if (IsNull) return null;
			if (IsUndefined) return null;
			if (IsInt && _data == null) return _intData;
			if (IsInt && _data != null) return Convert.ToInt32(_data);
			if (IsDouble && _data == null) return _doubleData;
			if (IsDouble && _data != null) return Convert.ToDouble(_data);

			return _data;
		}

		public void SetInt(int num)
		{
			_flags = (_flags & ~Flags.VarTypeMask) | Flags.Integer;
			_intData = num;
			_doubleData = 0;
			_data = null;
		}

		public void SetDouble(double num)
		{
			_flags = (_flags & ~Flags.VarTypeMask) | Flags.Double;
			_intData = 0;
			_doubleData = num;
			_data = null;
		}

		public void SetString(string str)
		{
			_flags = (_flags & ~Flags.VarTypeMask) | Flags.String;
			_intData = 0;
			_doubleData = 0;
			_data = str;
		}

		public void SetUndefined()
		{
			_flags = (_flags & ~Flags.VarTypeMask) | Flags.Undefined;
			_intData = 0;
			_doubleData = 0;
			_data = null;
			RemoveAllChildren();
		}

		public void SetArray()
		{
			_flags = (_flags & ~Flags.VarTypeMask) | Flags.Array;
			_intData = 0;
			_doubleData = 0;
			_data = null;
			RemoveAllChildren();
		}

		public ScriptVar Ref()
		{
			_refs++;
			return this;
		}

		public void UnRef()
		{
			if (_refs <= 0) throw new ScriptException("No refs to unref");

			if ((--_refs) == 0)
			{
				Dispose(true);
			}
		}

		public int GetRefs()
		{
			return _refs;
		}

		public ScriptVarLink FindChild(String childName)
		{
			ScriptVarLink v = FirstChild;

			while (v != null)
			{
				if (v.Name == childName)
				{
					return v;
				}

				v = v.Next;
			}

			return null;
		}

		public ScriptVarLink FindChildOrCreate(String childName, Flags varFlags = Flags.Undefined)
		{
			ScriptVarLink l = FindChild(childName);
			if (l != null) return l;

			return AddChild(childName, new ScriptVar(null, varFlags));
		}

		public ScriptVarLink FindChildOrCreateByPath(String path)
		{
			Int32 p = path.IndexOf('.');
			if (p < 0) return FindChildOrCreate(path);

			String[] parts = path.Split('.');

			return FindChildOrCreate(parts[0], Flags.Object).Var.FindChildOrCreateByPath(parts[1]);
		}

		public ScriptVarLink AddChild(String childName, ScriptVar child)
		{
			if (IsUndefined)
			{
				_flags = Flags.Object;
			}

			ScriptVar c = child ?? new ScriptVar();

			ScriptVarLink link = new ScriptVarLink(c, childName)
			{
				Owned = true
			};

			if (LastChild != null)
			{
				LastChild.Next = link;
				link.Prev = LastChild;
				LastChild = link;
			}
			else
			{
				FirstChild = link;
				LastChild = link;
			}

			return link;
		}

		public ScriptVarLink AddChildNoDup(String childName, ScriptVar child)
		{
			ScriptVar c = child ?? new ScriptVar();

			ScriptVarLink v = FindChild(childName);
			if (v != null)
			{
				v.ReplaceWith(c);
			}
			else
			{
				v = AddChild(childName, c);
			}

			return v;
		}

		public void RemoveChild(ScriptVar child)
		{
			ScriptVarLink link = FirstChild;

			while (link != null)
			{
				if(link.Var == child) break;

				link = link.Next;
			}

			RemoveLink(link);
		}

		public void RemoveLink(ScriptVarLink link)
		{
			if (link == null) return;

			if (link.Next != null)
			{
				link.Next.Prev = link.Prev;
			}
			if (link.Prev != null)
			{
				link.Prev.Next = link.Next;
			}
			if (LastChild == link)
			{
				LastChild = link.Prev;
			}
			if (FirstChild == link)
			{
				FirstChild = link.Next;
			}
		}

		public void RemoveAllChildren()
		{
			ScriptVarLink c = FirstChild;

			while (c != null)
			{
				ScriptVarLink t = c.Next;
				c = t;
			}

			FirstChild = null;
			LastChild = null;
		}

		public ScriptVar ReturnVar
		{
			get
			{
				return GetReturnVar();
			}
			set
			{
				SetReturnVar(value);
			}
		}

		public ScriptVar GetReturnVar()
		{
			return GetParameter(ReturnVarName);
		}

		public void SetReturnVar(ScriptVar var)
		{
			FindChildOrCreate(ReturnVarName).ReplaceWith(var);
		}

		public ScriptVar GetParameter(String name)
		{
			return FindChildOrCreate(name).Var;
		}

		public ScriptVar GetArrayIndex(Int32 idx)
		{
			ScriptVarLink link = FindChild(String.Format("{0}", idx));
			if (link != null) return link.Var;

			return new ScriptVar(null, Flags.Null);
		}

		public void SetArrayIndex(Int32 idx, ScriptVar value)
		{
			ScriptVarLink link = FindChild(String.Format("{0}", idx));

			if (link != null)
			{
				if (value.IsUndefined)
				{
					RemoveLink(link);
				}
				else
				{
					link.ReplaceWith(value);
				}
			}
			else
			{
				if (!value.IsUndefined)
				{
					AddChild(String.Format("{0}", idx), value);
				}
			}
		}

		public Int32 GetArrayLength()
		{
			Int32 highest = -1;

			if (!IsArray) return 0;

			ScriptVarLink link = FirstChild;

			while (link != null)
			{
				Int32 outputVal;
				if (Int32.TryParse(link.Name, out outputVal))
				{
					if (outputVal > highest) highest = outputVal;
				}

				link = link.Next;
			}

			return highest + 1;
		}

		public Int32 GettChildren()
		{
			Int32 n = 0;
			ScriptVarLink link = FirstChild;
			while (link != null)
			{
				n++;
				link = link.Next;
			}
			return n;
		}

		public bool Equal(ScriptVar v)
		{
			bool res;

			using (ScriptVar resV = MathsOp(v, ScriptLex.LexTypes.Equal))
			{
				res = resV.GetBool();
			}

			return res;
		}

		public ScriptVar MathsOp(ScriptVar b, ScriptLex.LexTypes op)
		{
			ScriptVar a = this;

			char opc = (char)op;

			if (op == ScriptLex.LexTypes.TypeEqual || op == ScriptLex.LexTypes.NTypeEqual)
			{
				bool equal = ((a._flags & Flags.VarTypeMask) == (b._flags & Flags.VarTypeMask));

				if (equal)
				{
					ScriptVar contents = a.MathsOp(b, ScriptLex.LexTypes.Equal);
					if (!contents.GetBool()) equal = false;
				}

				if (op == ScriptLex.LexTypes.TypeEqual)
				{
					return new ScriptVar(equal);
				}

				return new ScriptVar(!equal);
			}

			if (a.IsUndefined && b.IsUndefined)
			{
				if (op == ScriptLex.LexTypes.Equal)
				{
					return new ScriptVar(true);
				}
				if (op == ScriptLex.LexTypes.NEqual)
				{
					return new ScriptVar(false);
				}

				return new ScriptVar();
			}

			if ((a.IsNumeric || a.IsUndefined) && (b.IsNumeric || b.IsUndefined))
			{
				if (!a.IsDouble && !b.IsDouble)
				{
					//ints
					int da = a.GetInt();
					int db = b.GetInt();

					switch (opc)
					{
						case '+': return new ScriptVar(da + db);
						case '-': return new ScriptVar(da - db);
						case '*': return new ScriptVar(da * db);
						case '/': return new ScriptVar(da / db);
						case '&': return new ScriptVar(da & db);
						case '|': return new ScriptVar(da | db);
						case '^': return new ScriptVar(da ^ db);
						case '%': return new ScriptVar(da % db);
						case (char)ScriptLex.LexTypes.Equal: return new ScriptVar(da == db);
						case (char)ScriptLex.LexTypes.NEqual: return new ScriptVar(da != db);
						case '<': return new ScriptVar(da < db);
						case (char)ScriptLex.LexTypes.LEqual: return new ScriptVar(da <= db);
						case '>': return new ScriptVar(da > db);
						case (char)ScriptLex.LexTypes.GEqual: return new ScriptVar(da >= db);

						default: throw new ScriptException("Operation not supported on the Int datatype");
					}
				}
				else
				{
					//doubles
					double da = a.GetDouble();
					double db = b.GetDouble();

					switch (opc)
					{
						case '+': return new ScriptVar(da + db);
						case '-': return new ScriptVar(da - db);
						case '*': return new ScriptVar(da * db);
						case '/': return new ScriptVar(da / db);
						case (char)ScriptLex.LexTypes.Equal: return new ScriptVar(da == db);
						case (char)ScriptLex.LexTypes.NEqual: return new ScriptVar(da != db);
						case '<': return new ScriptVar(da < db);
						case (char)ScriptLex.LexTypes.LEqual: return new ScriptVar(da <= db);
						case '>': return new ScriptVar(da > db);
						case (char)ScriptLex.LexTypes.GEqual: return new ScriptVar(da >= db);

						default: throw new ScriptException("Operation not supported on the Int datatype");
					}
				}
			}

			if (a.IsArray)
			{
				switch (op)
				{
					case ScriptLex.LexTypes.Equal: return new ScriptVar(a == b);
					case ScriptLex.LexTypes.NEqual: return new ScriptVar(a != b);

					default: throw new ScriptException("Operation not supported on the Array datatype");
				}
			}

			if (a.IsObject)
			{
				switch (op)
				{
					case ScriptLex.LexTypes.Equal: return new ScriptVar(a == b);
					case ScriptLex.LexTypes.NEqual: return new ScriptVar(a != b);

					default: throw new ScriptException("Operation not supported on the Object datatype");
				}
			}

			string sda = a.GetString();
			string sdb = b.GetString();

			switch (opc)
			{
				case '+': return new ScriptVar(sda + sdb, Flags.String);
				case (char)ScriptLex.LexTypes.Equal: return new ScriptVar(sda == sdb);
				case (char)ScriptLex.LexTypes.NEqual: return new ScriptVar(sda != sdb);
				case '<': return new ScriptVar(String.CompareOrdinal(sda, sdb) < 0);
				case (char)ScriptLex.LexTypes.LEqual: return new ScriptVar((String.CompareOrdinal(sda, sdb) < 0) || sda == sdb);
				case '>': return new ScriptVar(String.CompareOrdinal(sda, sdb) > 0);
				case (char)ScriptLex.LexTypes.GEqual: return new ScriptVar((String.CompareOrdinal(sda, sdb) > 0) || sda == sdb);
				default: throw new ScriptException("Operation not supported on the String datatype");
			}
		}

		protected void CopySimpleData(ScriptVar val)
		{
			_data = val._data;
			_intData = val._intData;
			_doubleData = val._doubleData;
			_flags = (_flags & ~Flags.VarTypeMask) | (val._flags & Flags.VarTypeMask);
		}

		public void CopyValue(ScriptVar val)
		{
			if (val != null)
			{
				CopySimpleData(val);
				RemoveAllChildren();

				ScriptVarLink link = val.FirstChild;

				while (link != null)
				{
					ScriptVar copied = link.Name != PrototypeClassName ? link.Var.DeepCopy() : link.Var;

					AddChild(link.Name, copied);

					link = link.Next;
				}
			}
			else
			{
				SetUndefined();
			}
		}

		public ScriptVar DeepCopy()
		{
			ScriptVar newVar = new ScriptVar();
			newVar.CopySimpleData(this);

			ScriptVarLink link = FirstChild;
			while (link != null)
			{
				ScriptVar copied = link.Name != PrototypeClassName ? link.Var.DeepCopy() : link.Var;

				newVar.AddChild(link.Name, copied);

				link = link.Next;
			}

			return newVar;
		}

		public void SetCallback(ScriptEngine.ScriptCallbackCB callback, object userdata)
		{
			_callback = callback;
			_callbackUserData = userdata;
		}

		public void Trace(Int32 indent, String name)
		{
			System.Diagnostics.Trace.TraceInformation("{0}{1} = '{2}' ({3})", new String(' ', indent), name ?? "ROOT", GetString(), _flags);

			ScriptVarLink link = FirstChild;
			while(link != null)
			{
				link.Var.Trace(indent + 2, link.Name);
				link = link.Next;
			}
		}

		public static implicit operator String(ScriptVar d)
		{
			return d.GetString();
		}

		public override string ToString()
		{
			return String.Format("{0}", GetHashCode());
		}

		internal void SetData(object data)
		{
			_data = data;
		}

		internal ScriptEngine.ScriptCallbackCB GetCallback()
		{
			return _callback;
		}

		internal object GetCallbackUserData()
		{
			return _callbackUserData;
		}

		internal Type ClassType { get; set; }
		internal Object ClassInstance { get; set; }

	}
}
