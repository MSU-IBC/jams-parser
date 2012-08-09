using System;

namespace JamsParser
{
    public static class StringExtensions
    {
        public static int? ToNullableInt(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            try
            {
                return int.Parse(str);
            }
            catch (FormatException)
            {
                return null;
            }
        }
    }
}