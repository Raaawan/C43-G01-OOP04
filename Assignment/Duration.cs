using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Duration
    {
        #region properties
        //1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region constructor
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            normalizeNumber();
        }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;
            Minutes = seconds / 60;
            Seconds = seconds % 60;
        }

        public Duration()
        {
        }

        #endregion

        #region Methods

        private void normalizeNumber()
        {
            int totalSeconds = Hours * 3600 + Minutes * 60 + Seconds;
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        #region system methods
        //2-Override All System.Object Members[To String(), Equals(), GetHashCode()] .
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Duration duration)
            {
                return Hours == duration.Hours &&
                       Minutes == duration.Minutes &&
                       Seconds == duration.Seconds;
            }
            return false;
        }
        public override int GetHashCode() {
            return (Hours, Minutes, Seconds).GetHashCode();
        }
        #endregion

        #region operator overloading
        //4-Implement All required Operators overloading to enable this Code:
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hours = d1.Hours + d2.Hours,
                Minutes = d1.Minutes + d2.Minutes,
                Seconds = d1.Seconds + d2.Seconds
            };
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours * 3600 + d.Minutes * 60 + d.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator ++(Duration d)
        {
            d.Minutes += 1;
            d.normalizeNumber();
            return d;
        }
        public static Duration operator --(Duration d)
        {
            d.Minutes -= 1;
            d.normalizeNumber();
            return d;
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hours = d1.Hours - d2.Hours,
                Minutes = d1.Minutes - d2.Minutes,
                Seconds = d1.Seconds - d2.Seconds
            };
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1< d2);
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }
        public static bool operator true(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 || d.Minutes == 0 || d.Seconds == 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }
        #endregion



        #endregion
    }
}
