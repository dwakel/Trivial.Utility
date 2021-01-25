using System;

namespace Trivial.Utility
{
    public static class Moment
    {
        public static DateTime StartOfTheDay(this DateTime d) => new DateTime(d.Year, d.Month, d.Day, 0, 0, 0);
        public static DateTime EndOfTheDay(this DateTime d) => new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
        public static DateTime StartOfTheYear(this DateTime d) => new DateTime(d.Year, 1, 1, 0, 0, 0);
        public static DateTime EndOfTheYear(this DateTime d) => new DateTime(d.Year, 12, 31, 23, 59, 59);
    }
}
