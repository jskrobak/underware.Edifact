using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace underware.Edifact
{
    public class CharSpec
    {
        public static CharSpec Default
        {
            get
            {
                return new CharSpec()
                {
                    ComponentSeparator = ':',
                    ElementSeparator = '+',
                    ReleaseIndicator = '?',
                    SegmentSeparator = '\'',
                    DecimalNotification = '.'
                };
            }
        }

        public static CharSpec GetFromUNAOrDefault(string content)
        {
            if (content.StartsWith("UNA") && content.Length > 8)
            {
                return new CharSpec()
                {
                    ComponentSeparator = content[3],
                    ElementSeparator = content[4],
                    ReleaseIndicator = content[6],
                    SegmentSeparator = content[8],
                    DecimalNotification = content[5]
                };
            }

            return CharSpec.Default;
        }

        public char ComponentSeparator { get; set; }
        public char ElementSeparator { get; set; }
        public char SegmentSeparator { get; set; }
        public char ReleaseIndicator { get; set; }
        public char DecimalNotification { get; set; }


        public override string ToString()
        {
            return string.Format("UNA{0}{1}{2}{3} {4}", ComponentSeparator, ElementSeparator, DecimalNotification, ReleaseIndicator, SegmentSeparator);
        }
        public List<String> SplitSegments(string input)
        {
            List<String> list = Split(input, SegmentSeparator, ReleaseIndicator);
            //if (String.IsNullOrEmpty(list.Last()))
            //    list.RemoveAt(list.Count - 1);

            return list;
        }

        public string JoinSegments(List<Segment> segments)
        {
            return string.Join(SegmentSeparator.ToString(), segments.Select(s => s.ToString()));
        }

        public string JoinSegments(IEnumerable<string> segments)
        {
            return string.Join(SegmentSeparator.ToString(), segments);
        }

        public string JoinComponents(IEnumerable<string> components)
        {
            return string.Join(ComponentSeparator.ToString(), components);
        }

        public string JoinComponents(params object[] components)
        {
            return string.Join(ComponentSeparator.ToString(), components);
        }


        public string JoinElements(IEnumerable<string> elements)
        {
            return string.Join(ElementSeparator.ToString(), elements);
        }

        public string JoinElements(params object[] items)
        {
            return string.Join(ElementSeparator.ToString(), items);
        }

        public List<String> SplitElements(string input)
        {
            return Split(input, ElementSeparator, ReleaseIndicator);
        }

        public List<String> SplitComponents(string input)
        {
            return Split(input, ComponentSeparator, ReleaseIndicator);
        }

        private static List<string> Split(string input, char splitter, char releaseIndicator)
        {
            string escapedSplitter = String.Format("{0}{1}", releaseIndicator, splitter);
            string escapedRealease = String.Format("{0}{1}", releaseIndicator, releaseIndicator);

            string splitterGuid = Guid.NewGuid().ToString();
            string releaseGuid = Guid.NewGuid().ToString();

            input = input.Replace(escapedRealease, releaseGuid);
            input = input.Replace(escapedSplitter, splitterGuid);

            return input.Split(splitter).Select(s => s.Replace(splitterGuid, escapedSplitter).Replace(releaseGuid, escapedRealease)).ToList();
        }
    }
}
