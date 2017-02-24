using System;

namespace TextBase
{
	public class MissingForeignKeyException : Exception
	{
		public MissingForeignKeyException ()
		{
		}

		public MissingForeignKeyException(string message)
			: base(message)
		{
		}

		public MissingForeignKeyException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}

