using System;

namespace ManagementSystem.Common
{
    public static class CommonExtensions
    {
        public static string FormatWith(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNotNullOrEmpty(this string s)
        {
            return !string.IsNullOrEmpty(s);
        }

        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool IsNotNullOrWhiteSpace(this string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }

        public static int? AsInt(this string s)
        {
            int number;
            if (int.TryParse(s, out number))
            {
                return number;
            }
            else
            {
                return null;
            }
        }

        public static long? AsLong(this string s)
        {
            long number;
            if (long.TryParse(s, out number))
            {
                return number;
            }
            else
            {
                return null;
            }
        }

        public static short? AsShort(this string s)
        {
            short number;
            if (short.TryParse(s, out number))
            {
                return number;
            }
            else
            {
                return null;
            }
        }

        public static byte? AsByte(this string s)
        {
            byte number;
            if (byte.TryParse(s, out number))
            {
                return number;
            }
            else
            {
                return null;
            }
        }

        public static int? AsInt(this object o)
        {
            return o as int?;
        }

        public static short? AsShort(this object o)
        {
            return o as short?;
        }

        public static byte? AsByte(this object o)
        {
            return o as byte?;
        }

        public static decimal? AsDecimal(this string s)
        {
            decimal number;
            if (decimal.TryParse(s, out number))
            {
                return number;
            }
            else
            {
                return null;
            }
        }

        public static DateTime? AsDateTime(this string s)
        {
            DateTime date;
            if (DateTime.TryParse(s, out date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }

        public static DateTime? AsDateTime(this DateTime d)
        {
            return d as DateTime?;
        }
    }
}
