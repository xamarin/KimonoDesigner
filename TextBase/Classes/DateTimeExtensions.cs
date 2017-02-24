using System;
using Foundation;

namespace TextBase
{
	/// <summary>
	/// Date time extensions.
	/// </summary>
	public static class DateTimeExtensions
	{
		/// <summary>
		/// Tos the date time.
		/// </summary>
		/// <returns>The date time.</returns>
		/// <param name="date">Date.</param>
		public static DateTime ToDateTime(this NSDate date)
		{
			// NSDate has a wider range than DateTime, so clip
			// the converted date to DateTime.Min|MaxValue.
			double secs = date.SecondsSinceReferenceDate;
			if (secs < -63113904000)
				return DateTime.MinValue;
			if (secs > 252423993599)
				return DateTime.MaxValue;
			return (DateTime) date;
		}

		/// <summary>
		/// Tos the NS date.
		/// </summary>
		/// <returns>The NS date.</returns>
		/// <param name="date">Date.</param>
		public static NSDate ToNSDate(this DateTime date)
		{
			if (date.Kind == DateTimeKind.Unspecified)
				date = DateTime.SpecifyKind (date, DateTimeKind.Local);
			return (NSDate) date;
		}
	}
}

