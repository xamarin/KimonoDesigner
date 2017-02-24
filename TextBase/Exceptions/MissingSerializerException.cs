using System;

namespace TextBase
{
	public class MissingSerializerException : Exception
	{
		public MissingSerializerException ()
		{
		}

		public MissingSerializerException(string message)
			: base(message)
		{
		}

		public MissingSerializerException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}

