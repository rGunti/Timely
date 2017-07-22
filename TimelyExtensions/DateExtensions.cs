using System;

namespace TimelyExtensions
{
    public static class DateExtensions
    {
        private static DateTime GetDate(int? year, int month, int day) { return new DateTime((year.HasValue ? year.Value : DateTime.Now.Year), month, day); }

        public static DateTime Jan(this int day, int? year = null) { return GetDate(year, 1, day); }
        public static DateTime Feb(this int day, int? year = null) { return GetDate(year, 2, day); }
        public static DateTime Mar(this int day, int? year = null) { return GetDate(year, 3, day); }
        public static DateTime Apr(this int day, int? year = null) { return GetDate(year, 4, day); }
        public static DateTime May(this int day, int? year = null) { return GetDate(year, 5, day); }
        public static DateTime Jun(this int day, int? year = null) { return GetDate(year, 6, day); }
        public static DateTime Jul(this int day, int? year = null) { return GetDate(year, 7, day); }
        public static DateTime Aug(this int day, int? year = null) { return GetDate(year, 8, day); }
        public static DateTime Sep(this int day, int? year = null) { return GetDate(year, 9, day); }
        public static DateTime Oct(this int day, int? year = null) { return GetDate(year, 10, day); }
        public static DateTime Nov(this int day, int? year = null) { return GetDate(year, 11, day); }
        public static DateTime Dec(this int day, int? year = null) { return GetDate(year, 12, day); }

        public static DateTime January(this int day, int? year = null) { return day.Jan(year); }
        public static DateTime February(this int day, int? year = null) { return day.Feb(year); }
        public static DateTime March(this int day, int? year = null) { return day.Mar(year); }
        public static DateTime April(this int day, int? year = null) { return day.Apr(year); }
        // => We already have this (there is no short version of "May")
        //public static DateTime May (this int day, int? year = null) { return day.May(year); }
        public static DateTime June(this int day, int? year = null) { return day.Jun(year); }
        public static DateTime July(this int day, int? year = null) { return day.Jul(year); }
        public static DateTime August(this int day, int? year = null) { return day.Aug(year); }
        public static DateTime September(this int day, int? year = null) { return day.Sep(year); }
        public static DateTime October(this int day, int? year = null) { return day.Oct(year); }
        public static DateTime November(this int day, int? year = null) { return day.Nov(year); }
        public static DateTime December(this int day, int? year = null) { return day.Dec(year); }
    }
}
