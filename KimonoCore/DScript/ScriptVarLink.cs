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
	public class ScriptVarLink : IDisposable
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
					Var.UnRef();
				}

				// Indicate that the instance has been disposed.
				_disposed = true;
			}
		}
		#endregion

		public String Name { get; set; }
		public ScriptVarLink Next { get; set; }
		public ScriptVarLink Prev { get; set; }
		public ScriptVar Var { get; set; }
		public bool Owned { get; set; }

		public ScriptVarLink(ScriptVar var, String name)
		{
			Name = name;
			Var = var.Ref();
			Next = null;
			Prev = null;
			Owned = false;
		}

		public ScriptVarLink(ScriptVarLink toCopy)
		{
			Name = toCopy.Name;
			Var = toCopy.Var.Ref();
			Next = toCopy.Next;
			Prev = toCopy.Prev;
			Owned = toCopy.Owned;
		}

		public void ReplaceWith(ScriptVar newVar)
		{
			ScriptVar oldVar = Var;
			Var = newVar.Ref();
			oldVar.UnRef();
		}

		public void ReplaceWith(ScriptVarLink newVar)
		{
			ReplaceWith(newVar != null ? newVar.Var : new ScriptVar());
		}

		public Int32 GetIntName()
		{
			int retVal = Convert.ToInt32(Name);

			return retVal;
		}

		public void SetIntName(Int32 n)
		{
			Name = String.Format("{0}", n);
		}
	}
}
