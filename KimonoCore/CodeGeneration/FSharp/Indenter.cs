using System;
namespace KimonoCore
{
	public enum IndentForm { Tabs, Spaces }

	public class Indenter
	{
		private int indentLevel = 0;
		private IndentForm indentForm = IndentForm.Spaces;
		private int indentSize = 3;

		public int Level { get { return indentLevel; } }

		public Indenter(IndentForm form, int indentInSpaces = 3)
		{
			this.indentForm = form;
			this.indentSize = indentInSpaces;
			if (form == IndentForm.Tabs && indentInSpaces != 3)
			{
				throw new ArgumentOutOfRangeException("Attempt to mix tabs with custom space size. What kind of monster _does_ that?");
			}
		}

		public Indenter(int indentInSpaces = 3)
		{
			this.indentSize = indentInSpaces;
			this.indentForm = IndentForm.Spaces;
		}

		public Indenter Push()
		{
			this.indentLevel += 1;
			return this;
		}

		public Indenter Pop()
		{
			this.indentLevel -= 1;
			if (indentLevel < 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this;
		}

		public string this[int level] 
		{
			get
			{
				var oldIndentLevel = this.indentLevel;
				this.indentLevel = level;
				var retval = this.ToString();
				this.indentLevel = oldIndentLevel;
				return retval;
			}
		}

		public override string ToString()
		{
			var spaces = this.indentForm == IndentForm.Tabs ? "\t" : new String(' ', this.indentSize);
			var ws = "";
			for (var i = 0; i < this.indentLevel; i++)
			{
				ws += spaces;
			}
			return ws;
		}
	}
}
