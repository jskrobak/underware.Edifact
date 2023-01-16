using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact
{
    public class DateTimeFormat
    {
        public string Code { get; set; }
        public string Format { get; set; }

        public static DateTimeFormat GetFromEdi(string code)
        {
            switch (code)
            {
                case "102":
                    return DT102;
                case "203":
                    return DT203;
                default:
                    return DEFAULT;
            }
        }

        public static DateTimeFormat DT102 { get => new DateTimeFormat() { Code = "102", Format = "yyyyMMdd" }; }
        public static DateTimeFormat DT203 { get => new DateTimeFormat() { Code = "203", Format = "yyyyMMddHHmm" }; }
        public static DateTimeFormat DEFAULT { get => new DateTimeFormat() { Code = "", Format = "yyyyMMdd" }; }
    }
}
