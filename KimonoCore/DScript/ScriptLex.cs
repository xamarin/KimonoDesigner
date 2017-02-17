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
	public class ScriptLex : IDisposable
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
					if (_dataOwned)
					{
						_data = string.Empty;
					}
				}

				// Indicate that the instance has been disposed.
				_disposed = true;
			}
		}
		#endregion

		private String _data;
		private readonly bool _dataOwned;
		private readonly Int32 _dataStart;
		private readonly Int32 _dataEnd;
		private Int32 _dataPos;
		private Int32 _currColumnNumber;

		public char CurrentChar { get; set; }
		public char NextChar { get; set; }
		public LexTypes TokenType { get; set; }
		public Int32 TokenStart { get; set; }
		public Int32 TokenEnd { get; set; }
		public Int32 TokenLastEnd { get; set; }
		public Int32 LineNumber { get; private set; }
		public int ColumnNumber { get; private set; }
		public String TokenString { get; set; }

		public enum LexTypes 
		{
			Eof = 0,
			Id = 256,
			Int,
			Float,
			Str,
			Equal,
			TypeEqual,
			NEqual,
			NTypeEqual,
			LEqual,
			LShift,
			LShiftEqual,
			GEqual,
			RShift,
			RShiftUnsigned,
			RShiftEqual,
			PlusEqual,
			MinusEqual,
			PlusPlus,
			MinusMinus,
			AndEqual,
			AndAnd,
			OrEqual,
			OrOr,
			XorEqual,
			RListStart,
			RIf = RListStart,
			RElse,
			RDo,
			RWhile,
			RFor,
			RBreak,
			RContinue,
			RFunction,
			RReturn,
			RVar,
			RTrue,
			RFalse,
			RNull,
			RUndefined,
			RNew,
			RListEnd
		}

		public ScriptLex(String input)
		{
			_data = input;
			_dataOwned = true;
			_dataStart = 0;
			_dataEnd = _data.Length;

			Reset();
		}

		public ScriptLex(ScriptLex owner, Int32 start, Int32 end)
		{
			_data = owner._data;
			_dataOwned = false;
			_dataStart = start;
			_dataEnd = end;

			Reset();
		}

		public void Reset()
		{
			_dataPos = _dataStart;
			TokenStart = 0;
			TokenEnd = 0;
			TokenLastEnd = 0;
			TokenType = 0;
			TokenString = "";

			GetNextChar();
			GetNextChar();
			GetNextToken();
		}

		public void GetNextChar()
		{
			CurrentChar = NextChar;

			if (_dataPos < _dataEnd)
			{
				NextChar = _data[_dataPos];
			}
			else
			{
				NextChar = (char)0;
			}

			_dataPos++;

			_currColumnNumber++;

			if(CurrentChar == '\n')
			{
				LineNumber++;
				_currColumnNumber = 0;
			}
		}

		public void GetNextToken()
		{
			ColumnNumber = _currColumnNumber;

			TokenType = LexTypes.Eof;
			TokenString = String.Empty;

			while (CurrentChar != (char)0 && CurrentChar.IsWhitespace())
			{
				GetNextChar();
			}

			//single line comment
			if (CurrentChar == '/' && NextChar == '/')
			{
				while (CurrentChar != 0 && CurrentChar != '\n') GetNextChar();
				GetNextChar();
				GetNextToken();
				return;
			}

			//multi line comment
			if (CurrentChar == '/' && NextChar == '*')
			{
				while (CurrentChar != '*' && CurrentChar != '/') GetNextChar();
				GetNextChar();
				GetNextChar();
				GetNextToken();
				return;
			}

			TokenStart = _dataPos - 2;

			if (CurrentChar.IsAlpha()) //IDs
			{
				while (CurrentChar.IsAlpha() || CurrentChar.IsNumeric())
				{
					TokenString += CurrentChar;
					GetNextChar();
				}

				TokenType = LexTypes.Id;
				switch (TokenString)
				{
					case "if": TokenType = LexTypes.RIf; break;
					case "else": TokenType = LexTypes.RElse; break;
					case "do": TokenType = LexTypes.RDo; break;
					case "while": TokenType = LexTypes.RWhile; break;
					case "for": TokenType = LexTypes.RFor; break;
					case "break": TokenType = LexTypes.RBreak; break;
					case "continue": TokenType = LexTypes.RContinue; break;
					case "function": TokenType = LexTypes.RFunction; break;
					case "return": TokenType = LexTypes.RReturn; break;
					case "var": TokenType = LexTypes.RVar; break;
					case "true": TokenType = LexTypes.RTrue; break;
					case "false": TokenType = LexTypes.RFalse; break;
					case "null": TokenType = LexTypes.RFalse; break;
					case "undefined": TokenType = LexTypes.RNull; break;
					case "new": TokenType = LexTypes.RNew; break;

				}
			}
			else if (CurrentChar.IsNumeric()) //Numbers
			{
				bool isHex = false;
				if (CurrentChar == '0')
				{
					TokenString += CurrentChar;
					GetNextChar();
				}

				if (CurrentChar == 'x')
				{
					isHex = true;
					TokenString += CurrentChar;
					GetNextChar();
				}

				TokenType = LexTypes.Int;

				while (CurrentChar.IsNumeric() || (isHex && CurrentChar.IsHexadecimal()))
				{
					TokenString += CurrentChar;
					GetNextChar();
				}

				if (!isHex && CurrentChar == '.')
				{
					TokenType = LexTypes.Float;
					TokenString += '.';
					GetNextChar();
					while (CurrentChar.IsNumeric())
					{
						TokenString += CurrentChar;
						GetNextChar();
					}
				}

				if (!isHex && (CurrentChar == 'e' || CurrentChar == 'E'))
				{
					TokenType = LexTypes.Float;
					TokenString += CurrentChar;
					GetNextChar();
					if (CurrentChar == '-')
					{
						TokenString += CurrentChar;
						GetNextChar();
					}
					while (CurrentChar.IsNumeric())
					{
						TokenString += CurrentChar;
						GetNextChar();
					}
				}
			}
			else if (CurrentChar == '"') //Strings
			{
				GetNextChar();
				while (CurrentChar != (char) 0 && CurrentChar != '"')
				{
					if (CurrentChar == '\\')
					{
						GetNextChar();
						switch (CurrentChar)
						{
							case 'n':
								TokenString += '\n';
								break;
							case '"':
								TokenString += '"';
								break;
							case '\\':
								TokenString += '\\';
								break;
							default:
								TokenString += CurrentChar;
								break;
						}
					}
					else
					{
						TokenString += CurrentChar;
					}

					GetNextChar();
				}

				GetNextChar();

				TokenType = LexTypes.Str;
			}
			else if (CurrentChar == '\'') //Strings again
			{
				GetNextChar();

				while (CurrentChar != (char) 0 && CurrentChar != '\'')
				{
					if (CurrentChar == '\\')
					{
						GetNextChar();

						switch (CurrentChar)
						{
							case 'n':
								TokenString += '\n';
								break;
							case 'a':
								TokenString += '\a';
								break;
							case 'r':
								TokenString += '\r';
								break;
							case 't':
								TokenString += '\t';
								break;
							case '\'':
								TokenString += '\'';
								break;
							case '\\':
								TokenString += '\\';
								break;
							case 'x':
							{
								String str = "";
								GetNextChar();
								str += CurrentChar;
								GetNextChar();
								str += CurrentChar;
								TokenString += (char) Convert.ToInt64(str);
							}
								break;
							default:
								if (CurrentChar >= '0' && CurrentChar <= '7')
								{
									String str = "";
									str += CurrentChar;
									GetNextChar();
									str += CurrentChar;
									GetNextChar();
									str += CurrentChar;
									TokenString += (char) Convert.ToInt64(str);
								}
								else
								{
									TokenString += CurrentChar;
								}
								break;
						}
					}
					else
					{
						TokenString += CurrentChar;
					}

					GetNextChar();
				}

				GetNextChar();

				TokenType = LexTypes.Str;
			}
			else //Single character
			{
				TokenType = (LexTypes) CurrentChar;

				if (CurrentChar != (char) 0)
				{
					GetNextChar();
				}

				if (TokenType == (LexTypes)'=' && CurrentChar == '=') // ==
				{
					TokenType = LexTypes.Equal;
					GetNextChar();

					if (CurrentChar == '=') //===
					{
						TokenType = LexTypes.TypeEqual;
						GetNextChar();
					}
				}
				else if (TokenType == (LexTypes)'!' && CurrentChar == '=') // !=
				{
					TokenType = LexTypes.NEqual;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'<' && CurrentChar == '=') // <=
				{
					TokenType = LexTypes.LEqual;
					GetNextChar();

					if (CurrentChar == '=') //!==
					{
						TokenType = LexTypes.NTypeEqual;
						GetNextChar();
					}
				}
				else if (TokenType == (LexTypes)'<' && CurrentChar == '<') // <<
				{
					TokenType = LexTypes.LShift;
					GetNextChar();
					if (CurrentChar == '=') //<<=
					{
						TokenType = LexTypes.LShiftEqual;
						GetNextChar();
					}
				}
				else if (TokenType == (LexTypes)'>' && CurrentChar == '=') // >=
				{
					TokenType = LexTypes.GEqual;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'>' && CurrentChar == '>') // >>
				{
					TokenType = LexTypes.RShift;
					GetNextChar();

					if (CurrentChar == '=') // >>=
					{
						TokenType = LexTypes.RShiftEqual;
						GetNextChar();
					}
					else if (CurrentChar == '>') // >>>
					{
						TokenType = LexTypes.RShiftUnsigned;
						GetNextChar();
					}
				}
				else if (TokenType == (LexTypes)'+' && CurrentChar == '=') // +=
				{
					TokenType = LexTypes.PlusEqual;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'-' && CurrentChar == '=') // -=
				{
					TokenType = LexTypes.MinusEqual;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'+' && CurrentChar == '+') // ++
				{
					TokenType = LexTypes.PlusPlus;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'-' && CurrentChar == '-') // --
				{
					TokenType = LexTypes.MinusMinus;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'&' && CurrentChar == '=') // &=
				{
					TokenType = LexTypes.AndEqual;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'&' && CurrentChar == '&') // &&
				{
					TokenType = LexTypes.AndAnd;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'|' && CurrentChar == '=') // |=
				{
					TokenType = LexTypes.OrEqual;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'|' && CurrentChar == '|') // ||
				{
					TokenType = LexTypes.OrOr;
					GetNextChar();
				}
				else if (TokenType == (LexTypes)'^' && CurrentChar == '=') // ^=
				{
					TokenType = LexTypes.XorEqual;
					GetNextChar();
				}
			}

			/* Something broke... */
			TokenLastEnd = TokenEnd;
			TokenEnd = _dataPos - 3;
		}

		public ScriptLex GetSubLex(Int32 lastPosition)
		{
			int lastCharIdx = TokenLastEnd + 1;

			if (lastCharIdx < _dataEnd)
			{
				return new ScriptLex(this, lastPosition, lastCharIdx);
			}

			return new ScriptLex(this, lastPosition, _dataEnd);
		}

		public String GetPosition(Int32 pos)
		{
			return String.Format("{0}", pos);
		}

		public String GetSubString(Int32 pos)
		{
			Int32 lastCharIndex = TokenLastEnd + 1;
			
			if (lastCharIndex < _dataEnd)
			{
				return _data.Substring(pos, lastCharIndex - pos);
			}

			return (_data.Substring(pos));
		}

		public void Match(LexTypes type)
		{
			if(TokenType != type)
			{
				String expectedName = Enum.GetName(typeof(LexTypes), type);
				if(String.IsNullOrEmpty(expectedName))
				{
					expectedName = String.Format("{0}", ((char)type));
				}

				String foundName = Enum.GetName(typeof(LexTypes), TokenType);
				if(String.IsNullOrEmpty(foundName))
				{
					foundName = String.Format("{0}", ((char)TokenType));
				}

				throw new ScriptException(String.Format("Unexpected token type. Expected {0}, found {1}", expectedName, foundName));
			}

			GetNextToken();
		}
	}
}
