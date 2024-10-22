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
            var element = new XElement(group.Name);

            foreach (var child in group.Children)
            {
                element.Add(child.ToXml());
            }

            return element;
        }

        private static XElement ToXml(this SegmentGroupItem item)
        {
            return item is SegmentGroup group ? group.ToXml() : ((Segment)item).ToXml();
        }

        private static XElement ToXml(this Segment segment)
        {
            var t = segment.GetType();
            var x = new XElement(segment.Name);
            x.Add(new XAttribute("type", t.FullName));

            foreach (var elementInfo in t.GetElementInfoList())
            {
                var property = t.GetProperty(elementInfo.PropertyName);
                var propValue = property.GetValue(segment);
                var propType = property.PropertyType;

                var e = new XElement(property.Name);// element.Name.ToXmlName("E"));
                e.Add(new XAttribute("type", propType.FullName));

                if (propType == typeof(string))
                {
                    e.Value = (propValue != null) ? propValue.ToString() : "";
                    //e.Add(new XAttribute("value", val));
                }
                else
                {
                    var value = "";
                    foreach (var componentProp in propType.GetElementInfoList()
                                 .Select(componentInfo => propType.GetProperty(componentInfo.PropertyName)))
                    {
                        if (propValue != null)
                        {
                            var componentValue = componentProp.GetValue(propValue);

                            //if (componentValue != null)
                            value = componentValue == null ? "" : componentValue.ToString();
                        }

                        var c = new XElement(componentProp.Name)
                        {
                            Value = value
                        }; // element.Name.ToXmlName("E"));
                        //c.Add(new XAttribute("value", value));

                        e.Add(c);
                    }
                }

                x.Add(e);
            }



            return x;
        }



        public static string ToXmlName(this string s, string prefix)
        {
            return s.StartsWithNumber() ? $"{prefix}{s}" : s;
        }

        public static bool StartsWithNumber(this string s)
        {
            return "0123456789".ToCharArray().Contains(s[0]);
        }
    }

}
