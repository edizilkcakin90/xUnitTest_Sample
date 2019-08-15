using System;
using System.Globalization;

namespace xUnitExample
{
    public static class DateTimeExtensions
    {
        public static string ToPrettyDate(this DateTime date, CultureInfo culture)
        {
            if (culture == null)
            {
                throw new ArgumentNullException(nameof(culture));
            }

            return date.ToString("dd MMMM yyyy", culture);
        }
    }
}
