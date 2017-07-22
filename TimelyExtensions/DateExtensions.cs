using System;

namespace TimelyExtensions
{
    public static class DateExtensions
    {
        private static DateTime GetDate(int year, int month, int day) { return new DateTime(year, month, day); }

        public static DateTime Jan(this int day, int year) { return GetDate(day, 1, year); }
        public static DateTime Feb(this int day, int year) { return GetDate(day, 2, year); }
        public static DateTime Mar(this int day, int year) { return GetDate(day, 3, year); }
        public static DateTime Apr(this int day, int year) { return GetDate(day, 4, year); }
        public static DateTime May(this int day, int year) { return GetDate(day, 5, year); }
        public static DateTime Jun(this int day, int year) { return GetDate(day, 6, year); }
        public static DateTime Jul(this int day, int year) { return GetDate(day, 7, year); }
        public static DateTime Aug(this int day, int year) { return GetDate(day, 8, year); }
        public static DateTime Sep(this int day, int year) { return GetDate(day, 9, year); }
        public static DateTime Oct(this int day, int year) { return GetDate(day, 10, year); }
        public static DateTime Nov(this int day, int year) { return GetDate(day, 11, year); }
        public static DateTime Dec(this int day, int year) { return GetDate(day, 12, year); }

        public static DateTime January(this int day, int year) { return day.Jan(year); }
        public static DateTime February(this int day, int year) { return day.Feb(year); }
        public static DateTime March(this int day, int year) { return day.Mar(year); }
        public static DateTime April(this int day, int year) { return day.Apr(year); }
        // => We already have this (there is no short version of "May")
        //public static DateTime May (this int day, int year) { return day.May(year); }
        public static DateTime June(this int day, int year) { return day.Jun(year); }
        public static DateTime July(this int day, int year) { return day.Jul(year); }
        public static DateTime August(this int day, int year) { return day.Aug(year); }
        public static DateTime September(this int day, int year) { return day.Sep(year); }
        public static DateTime October(this int day, int year) { return day.Oct(year); }
        public static DateTime November(this int day, int year) { return day.Nov(year); }
        public static DateTime December(this int day, int year) { return day.Dec(year); }
    }
}
