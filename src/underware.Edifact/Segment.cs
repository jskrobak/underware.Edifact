using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using underware.Edifact.Attributes;

namespace underware.Edifact
{
    public class Segment : SegmentGroupItem
    {
        private string _originalContent;

        public string Name { get; set; }
        public string Description { get; set; }

        public string OriginalContent
        {
            get { return _originalContent; }
            set { _originalContent = value; }
        }


        public Segment(string name, string desc)
        {
            Name = name;
            Description = desc;

            //InitStructure();
        }

        public Segment(string stringToFormat, params object[] parameters)
        {
            string segment = string.Format(stringToFormat, parameters);

            Name = segment.Substring(0, 3);

            ParseSegment(CharSpec.Default, segment);

            //InitStructure();
        }

        public Segment()
        {

        } 


        private void InitStructure()
        {
            /*
            Type type = GetType();
            foreach (var elementInfo in type.GetElementInfoList())
            {
                PropertyInfo prop = type.GetProperty(elementInfo.PropertyName);
                if (prop.GetValue(this) == null)
                {
                    if (prop.PropertyType == typeof(string))
                        prop.SetValue(this, "");
                    else
                        prop.SetValue(this, Activator.CreateInstance(prop.PropertyType));
                }
            }

            */
        }

        private static Type GetSegmentType(string segmentName)
        {
            return Type.GetType(string.Format("underware.Edifact.Structures.Common.Segments.{0}", segmentName));
        }

        private static Type GetSegmentType(string segmentName, int syntaxVersion)
        {
            return Type.GetType(string.Format("underware.Edifact.Structures.S{0}.Segments.{1}", syntaxVersion, segmentName));
        }

        private static Type GetSegmentType(string segmentName, string msgVersion)
        {
            string typeString = string.Format("underware.Edifact.{0}.Segments.{1}, underware.Edifact.{0}", msgVersion, segmentName);
            return Type.GetType(typeString);
        }

        public void ParseSegment(CharSpec spec, string content)
        {
            OriginalContent = content;

            Type type = this.GetType();

            List<ElementInfo> structure = type.GetElementInfoList();

            var elements = spec.SplitElements(content);


            for (int i = 0; i < elements.Count - 1; i++)
            {
                string element = elements[i + 1];

                if (structure.Count > i)
                {
                    PropertyInfo property = type.GetProperty(structure[i].PropertyName);

                    if (property.PropertyType == typeof(string))
                        property.SetValue(this, element.EDIDecode());
                    else
                        property.SetValue(this, ParseComposite(spec, property.PropertyType, element));
                }
            }
        }

        private object ParseComposite(CharSpec spec, Type type, string element)
        {
            var composite = Activator.CreateInstance(type);

            var components = spec.SplitComponents(element);

            List<ElementInfo> structure = type.GetElementInfoList();

            for (int i = 0; i < components.Count; i++)
            {
                string component = components[i];

                PropertyInfo property = type.GetProperty(structure[i].PropertyName);

                property.SetValue(composite, component.EDIDecode());
            }

            return composite;
        }

        public string ToString(CharSpec spec)
        {
            if (!string.IsNullOrEmpty(OriginalContent))
                return OriginalContent;

            var elements = new List<string> { Name };

            var t = GetType();
            foreach (var elementInfo in t.GetElementInfoList())
            {
                var property = t.GetProperty(elementInfo.PropertyName);
                var propValue = property.GetValue(this);
                var propType = property.PropertyType;

                if (propType == typeof(string))
                {
                    elements.Add(string.IsNullOrEmpty((string)propValue) ? "" : ((string)propValue).EDIEncode());
                }
                else
                {
                    var components = new List<string>();

                    foreach (var componentInfo in propType.GetElementInfoList())
                    {
                        var componentProp = propType.GetProperty(componentInfo.PropertyName);
                        var value = "";

                        if (propValue != null)
                        {
                            var componentValue = componentProp.GetValue(propValue);

                            if (componentValue != null)
                                value = componentValue.ToString();
                        }

                        components.Add(value.EDIEncode());
                    }

                    while (components.Count > 0 && string.IsNullOrEmpty(components.Last()))
                        components.RemoveAt(components.Count - 1);

                    elements.Add(spec.JoinComponents(components));
                }
            }

            while (string.IsNullOrEmpty(elements.Last()))
                elements.RemoveAt(elements.Count - 1);

            return spec.JoinElements(elements);
        }

        public override string ToString()
        {
            return ToString(CharSpec.Default);
        }

        public static Segment Parse(CharSpec spec, int syntaxVersion, string msgVersion, string content)
        {
            var segmentName = content.Substring(0, 3);

            var type = (GetSegmentType(segmentName, msgVersion) ?? 
                        GetSegmentType(segmentName, syntaxVersion)) ??
                        GetSegmentType(segmentName);

            if (type == null)
                throw new NullReferenceException(
                    $"No type found for segment name={segmentName}, messageVersion={msgVersion}, syntaxVersion={syntaxVersion}");
            
            return Parse(spec, type, content);
        }

        public static Segment Parse(CharSpec spec, int syntaxVersion, string content)
        {
            string segmentName = content.Substring(0, 3);

            Type type = GetSegmentType(segmentName, syntaxVersion);

            if (type == null)
                type = GetSegmentType(segmentName);

            return Parse(spec, type, content);
        }

        public static Segment Parse(CharSpec spec, string content)
        {
            var type = GetSegmentType(content.Substring(0, 3));

           // if (type == null)
           //     type = typeof(Segment);

            return Parse(spec, type, content);
        }

        public static Segment Parse(CharSpec spec, Type type, string content)
        {
            var segment = Activator.CreateInstance(type) as Segment;

            segment.ParseSegment(spec, content);

            return segment;
        }

        
    }
}
