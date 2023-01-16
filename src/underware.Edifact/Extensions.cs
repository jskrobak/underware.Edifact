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
            DateTime dt = DateTime.MinValue;
            DateTime.TryParseExact(dateTimeString, format.Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

            return dt;
        }

        public static List<ElementInfo> GetElementInfoList(this Type type)
        {
            List<ElementInfo> list = new List<ElementInfo>();
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
            return string.Format("{0}00", dateIn.ToString("zz").Substring(1, 2));
        }
        public static List<string> SplitSegments(this string s, CharSpec spec)
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
            StringBuilder sb = new StringBuilder(data);

            //string[] esc = new string[] { "?:", "?+", "?'" };
            string[] esc = new string[] {   string.Concat(chars.ReleaseIndicator, chars.ElementSeparator),
                                            string.Concat(chars.ReleaseIndicator, chars.ComponentSeparator),
                                            string.Concat(chars.ReleaseIndicator, chars.SegmentSeparator) };

            string[] ctrls = new string[] { chars.ElementSeparator.ToString(),
                                            chars.ComponentSeparator.ToString(),
                                            chars.SegmentSeparator.ToString() };

            for (int i = 0; i < ctrls.Length; i++)
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
            string guid = Guid.NewGuid().ToString();
            string qq = String.Format("{0}{1}", chars.ReleaseIndicator, chars.ReleaseIndicator);

            string str = data.Replace(qq, guid);

            StringBuilder sb = new StringBuilder(str);

            string[] esc = new string[] {   String.Concat(chars.ReleaseIndicator, chars.ElementSeparator),
                                            String.Concat(chars.ReleaseIndicator, chars.ComponentSeparator),
                                            String.Concat(chars.ReleaseIndicator, chars.SegmentSeparator),
                                            String.Concat(chars.ReleaseIndicator, chars.DecimalNotification) };

            string[] ctrls = new string[] { chars.ElementSeparator.ToString(),
                                            chars.ComponentSeparator.ToString(),
                                            chars.SegmentSeparator.ToString(),
                                            chars.DecimalNotification.ToString() };

            for (int i = 0; i < esc.Length; i++)
            {
                sb.Replace(esc[i], ctrls[i]);
            }

            return sb.ToString().Replace(guid, chars.ReleaseIndicator.ToString());
        }

        public static SegmentGroup CreateTree(this Message msg)
        {
            return GetSegmentGroup("Message", msg.AllSegments, 0, msg.AllSegments.Count - 1, msg.UNH);
        }

        private static SegmentGroup GetSegmentGroup(string name, List<Segment> allSegments, int startSegment, int endSegment, IUNH unh)
        {
            string version = string.Concat(unh.Version, unh.Release);

            string xPath = string.Format("//segmentGroup[@code='{0}']/*", name);

            XDocument messageDesc = SpecificationManager.Instance.GetSpecification(version, unh.MessageType);

            var descItemList = messageDesc.XPathSelectElements(xPath);
            int descActItem = 0;
            int actSegment = startSegment;

            SegmentGroup group = new SegmentGroup(name);

            while (actSegment <= endSegment)
            {
                int beginIndex = FindNextItem(allSegments, actSegment, endSegment, descItemList, ref descActItem);


                XElement actDesc = descItemList.ElementAt(descActItem);
                string actDescCode = actDesc.Attribute("code").Value;

                if (IsGroup(actDesc))
                {
                    int endIndex = FindNextItem(allSegments, beginIndex + 1, endSegment, descItemList, descActItem) - 1;
                    group.Children.Add(GetSegmentGroup(actDescCode, allSegments, beginIndex, endIndex, unh));
                    actSegment = endIndex + 1;
                }
                else
                {
                    group.Children.Add(allSegments[actSegment]);
                    actSegment++;
                }
            }

            return group;
        }

        private static int FindNextItem(List<Segment> allSegments, int start, int end, IEnumerable<XElement> descItemList, int descStart)
        {
            return FindNextItem(allSegments, start, end, descItemList, ref descStart);
        }

        private static int FindNextItem(List<Segment> allSegments, int start, int end, IEnumerable<XElement> descItemList, ref int descStart)
        {
            XElement sgDescNode = descItemList.ElementAt(descStart);

            int i;
            for (i = start; i <= end; i++)
            {
                string currSegmentName = allSegments[i].Name;

                //find segment in description
                for (int j = descStart; j < descItemList.Count(); j++)
                {

                    string firstSegmentDesc = GetFirstSegmentDesc(descItemList.ElementAt(j));

                    XElement existing = null;
                    if (j > descStart && sgDescNode != null && sgDescNode.Name == "segmentGroup")
                        existing = sgDescNode.XPathSelectElement(string.Format(".//segment[@code='{0}']", firstSegmentDesc));

                    if (firstSegmentDesc == currSegmentName && existing == null)
                    {

                        descStart = j;
                        return i;
                    }
                }
            }

            return i;
        }

        private static string GetFirstSegmentDesc(XElement descNode)
        {
            if (IsGroup(descNode))
            {
                //return descNode.SelectSingleNode(".//segment[1]").Attributes["code"].Value;
                return descNode.XPathSelectElement(".//segment[1]").Attribute("code").Value;
            }
            else
                return descNode.Attribute("code").Value;
        }

        private static bool IsGroup(XElement descNode)
        {
            return (descNode.Name == "segmentGroup");
        }
    }
}
