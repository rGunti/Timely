using System;

namespace TimelyExtensions
{
    public static class TimeExtensions
    {
        public static TimeSpan Milliseconds(this int ms) { return TimeSpan.FromMilliseconds(ms); }
        public static TimeSpan Seconds(this int sec) { return TimeSpan.FromSeconds(sec); }
        public static TimeSpan Minutes(this int min) { return TimeSpan.FromMinutes(min); }
        public static TimeSpan Hours(this int hrs) { return TimeSpan.FromHours(hrs); }
        public static TimeSpan Days(this int days) { return TimeSpan.FromDays(days); }
    }
}
