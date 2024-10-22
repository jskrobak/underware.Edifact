using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Reflection;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;
using System.Globalization;

namespace underware.Edifact
{
    public static class Extensions
    {
        public static DateTime ParseDateTime(this string dateTimeString, DateTimeFormat format)
        {
            return format.ParseDateTime(dateTimeString);
        }
        
        public static List<ElementInfo> GetElementInfoList(this Type type)
        {
            var list = new List<ElementInfo>();
            foreach (var prop in type.GetProperties())
            {
                var info = prop.GetCustomAttribute<ElementInfo>();

                if (info != null)
                {
                    info.PropertyName = prop.Name;
                    list.Add(info);
                }

            }

            return list.OrderBy(i => i.OrderIndex).ToList();
        }

        public static string SummerWinter(this DateTime dateIn)
        {
            return $"{dateIn.ToString("zz").Substring(1, 2)}00";
        }
        public static IEnumerable<string> SplitSegments(this string s, CharSpec spec)
        {
            return spec.SplitSegments(s);
        }

        public static bool EndsWith(this string s, char c)
        {
            return s.EndsWith(c.ToString());
        }

        public static string EDIEncode(this string data)
        {
            return EDIEncode(data, CharSpec.Default);
        }

        public static string EDIEncode(this string data, CharSpec chars)
        {
            var sb = new StringBuilder(data);

            //string[] esc = new string[] { "?:", "?+", "?'" };
            var esc = new string[]
            {
                string.Concat(chars.ReleaseIndicator, chars.ReleaseIndicator),
                string.Concat(chars.ReleaseIndicator, chars.ElementSeparator),
                string.Concat(chars.ReleaseIndicator, chars.ComponentSeparator),
                string.Concat(chars.ReleaseIndicator, chars.SegmentSeparator)
            };

            var ctrls = new string[]
            {
                chars.ReleaseIndicator.ToString(),
                chars.ElementSeparator.ToString(),
                chars.ComponentSeparator.ToString(),
                chars.SegmentSeparator.ToString()
            };

            for (var i = 0; i < ctrls.Length; i++)
            {
                sb.Replace(ctrls[i], esc[i]);

            }

            return sb.ToString();
        }

        public static string EDIDecode(this string data)
        {
            return EDIDecode(data, CharSpec.Default);
        }

        public static string EDIDecode(this string data, CharSpec chars)
        {
            var guid = Guid.NewGuid().ToString();
            var qq = $"{chars.ReleaseIndicator}{chars.ReleaseIndicator}";

            var str = data.Replace(qq, guid);

            var sb = new StringBuilder(str);

            var esc = new string[] {   string.Concat(chars.ReleaseIndicator, chars.ElementSeparator),
                                            string.Concat(chars.ReleaseIndicator, chars.ComponentSeparator),
                                            string.Concat(chars.ReleaseIndicator, chars.SegmentSeparator),
                                            string.Concat(chars.ReleaseIndicator, chars.DecimalNotification) };

            var ctrls = new string[] { chars.ElementSeparator.ToString(),
                                            chars.ComponentSeparator.ToString(),
                                            chars.SegmentSeparator.ToString(),
                                            chars.DecimalNotification.ToString() };

            for (var i = 0; i < esc.Length; i++)
            {
                sb.Replace(esc[i], ctrls[i]);
            }

            return sb.ToString().Replace(guid, chars.ReleaseIndicator.ToString());
        }

    }
}
