using System;

namespace TextBase
{
	public class DatabaseUnavailableException : Exception
	{
		public DatabaseUnavailableException ()
		{
		}

		public DatabaseUnavailableException(string message)
			: base(message)
		{
		}

		public DatabaseUnavailableException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}

