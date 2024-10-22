using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace underware.Edifact
{
    public class DateTimeFormat
    {
        public DateTimeFormat(string code, string format)
        {
            Code = code;
            Format = format;
            Start = 0;
            Length = format.Length;
        }

        public string Code { get; set; }
        public string Format { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

        public static DateTimeFormat Parse(string code)
        {
            switch (code)
            {
                case "102":
                    return DT102;
                case "203":
                    return DT203;
                case "718":
                    return DT718;
                default:
                    return DEFAULT;
            }
        }
        
        public DateTime ParseDateTime(string dateTimeString)
        {
            if (dateTimeString.Length < Start + Length)
                return DateTime.MinValue;

            return DateTime.TryParseExact(dateTimeString.Substring(Start, Length), Format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out var dt)
                ? dt
                : DateTime.MinValue;
        }

        public static DateTimeFormat DT102 => new DateTimeFormat("102", "yyyyMMdd");

        public static DateTimeFormat DT203 => new DateTimeFormat("203", "yyyyMMddHHmm");

        public static DateTimeFormat DT718 => new DateTimeFormat("718", "yyyyMMdd") { Start = 8, Length = 8 };

        public static DateTimeFormat DEFAULT => new DateTimeFormat("102", "yyyyMMdd");
        
        
    }
}
