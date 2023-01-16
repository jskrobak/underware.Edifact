using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Reflection;

namespace underware.Edifact.Xml
{
    public static class Extensions
    {

        public static XElement ToXml(this SegmentGroup group)
        {
            XElement element = new XElement(group.Name);

            foreach (var child in group.Children)
            {
                element.Add(child.ToXml());
            }

            return element;
        }

        private static XElement ToXml(this SegmentGroupItem item)
        {
            if (item is SegmentGroup)
                return ((SegmentGroup)item).ToXml();
            else
                return ((Segment)item).ToXml();
        }

        private static XElement ToXml(this Segment segment)
        {
            Type t = segment.GetType();
            XElement x = new XElement(segment.Name);
            x.Add(new XAttribute("type", t.FullName));

            foreach (var elementInfo in t.GetElementInfoList())
            {
                PropertyInfo property = t.GetProperty(elementInfo.PropertyName);
                object propValue = property.GetValue(segment);
                Type propType = property.PropertyType;

                XElement e = new XElement(property.Name);// element.Name.ToXmlName("E"));
                e.Add(new XAttribute("type", propType.FullName));

                if (propType == typeof(string))
                {
                    string val = (propValue != null) ? propValue.ToString() : "";
                    e.Add(new XAttribute("value", val));
                }
                else
                {
                    foreach (var componentInfo in propType.GetElementInfoList())
                    {
                        PropertyInfo componentProp = propType.GetProperty(componentInfo.PropertyName);
                        string value = "";

                        if (propValue != null)
                        {
                            object componentValue = componentProp.GetValue(propValue);

                            if (componentValue != null)
                                value = componentValue.ToString();
                        }

                        XElement c = new XElement(componentProp.Name);// element.Name.ToXmlName("E"));
                        c.Add(new XAttribute("value", value));

                        e.Add(c);
                    }
                }

                x.Add(e);
            }



            return x;
        }



        public static string ToXmlName(this string s, string prefix)
        {
            return s.StartsWithNumber() ? string.Format("{0}{1}", prefix, s) : s;
        }

        public static bool StartsWithNumber(this string s)
        {
            return "0123456789".ToCharArray().Contains(s[0]);
        }
    }

}
