using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using S3 = underware.Edifact.Structures.S3;
using S4 = underware.Edifact.Structures.S4;
using underware.Edifact.Structures.Common.Interfaces;

namespace underware.Edifact
{
    public class Message: IDocument, IEdiData
    {
        private List<Segment> _segments;
        private SegmentGroup _root;

        public Message()
        {
            _segments = [];
        }
        
        public List<Segment>Segments => _segments;
        
        public SegmentGroup Root => _root ??= CreateTree();

        public List<Segment> AllSegments
        {
            get
            {
                var s = new List<Segment> { UNH as Segment };
                s.AddRange(_segments);
                s.Add(UNT as Segment);
                return s;
            }
        }

        //public List<>

        public Message(int syntax, string messageType, string version, string release, string agency, string association, string refNo)
        {
            switch (syntax)
            {
                case 3:
                    UNH = new S3.Segments.UNH(messageType, version, release, agency, association, refNo);
                    UNT = new S3.Segments.UNT(0, refNo);
                    break;
                case 4:
                    UNH = new S4.Segments.UNH(messageType, version, release, agency, association, refNo);
                    UNT = new S4.Segments.UNT(0, refNo);
                    break;
                default:
                    throw new NotSupportedException($"Syntax version {version} is not supported.");
            }

            _segments = [];
        }

        public Interchange Interchange { get; set; }

        public IUNH UNH { get; set; }

        public IUNT UNT { get; set; }

        public override string ToString()
        {
            return ToString(CharSpec.Default);
        }
        
        public BaseDocument GetDocument()
        {
            try
            {
                var doc = GetBaseDocument();
                doc.Data = this;
                return doc;
            }
            catch (Exception e)
            {
                throw new ParseDocumentException(this, Interchange, e); 
            }
        }

        protected virtual BaseDocument GetBaseDocument()
        {
            throw new NotSupportedException(this.Interchange.Format);
        }

        public virtual void FromDocument(BaseDocument doc)
        {
            throw new NotImplementedException();
        }
        

        public string ToString(CharSpec charSpec)
        {
            var allSegments = AllSegments;
            UNT.OriginalContent = string.Empty;
            UNT.SegmentsCount = allSegments.Count;
            
            return charSpec.JoinSegments(allSegments);
        }
        
        private SegmentGroup CreateTree()
        {
            return GetSegmentGroup("Message", AllSegments, 0, AllSegments.Count - 1, UNH);
        }

        private static SegmentGroup GetSegmentGroup(string name, List<Segment> allSegments, int startSegment, int endSegment, IUNH unh)
        {
            var version = string.Concat(unh.Version, unh.Release);

            var xPath = $"//segmentGroup[@code='{name}']/*";

            var messageDesc = SpecificationManager.Instance.GetSpecification(version, unh.MessageType);
            
            var descItemList = messageDesc.XPathSelectElements(xPath);
            var descActItem = 0;
            var actSegment = startSegment;

            var group = new SegmentGroup(name);

            while (actSegment <= endSegment)
            {
                var beginIndex = FindNextItem(allSegments, actSegment, endSegment, descItemList, ref descActItem);


                var actDesc = descItemList.ElementAt(descActItem);
                var actDescCode = actDesc.Attribute("code").Value;

                if (IsGroup(actDesc))
                {
                    var endIndex = FindNextItem(allSegments, beginIndex + 1, endSegment, descItemList, descActItem) - 1;
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
            var sgDescNode = descItemList.ElementAt(descStart);

            int i;
            for (i = start; i <= end; i++)
            {
                var currSegmentName = allSegments[i].Name;

                //find segment in description
                for (var j = descStart; j < descItemList.Count(); j++)
                {

                    var firstSegmentDesc = GetFirstSegmentDesc(descItemList.ElementAt(j));

                    XElement existing = null;
                    if (j > descStart && sgDescNode != null && sgDescNode.Name == "segmentGroup")
                        existing = sgDescNode.XPathSelectElement($".//segment[@code='{firstSegmentDesc}']");

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


        public static Message Parse(CharSpec spec, int syntaxVersion, List<string> segments)
        {
            if (segments.Count < 2)
                throw new ArgumentOutOfRangeException("Message must have at least 2 segments (UNH, UNT)");

            if (!segments[0].StartsWith("UNH"))
                throw new ArgumentException("Message must start with UNH segment;");

            var unh = Segment.Parse(spec, syntaxVersion, segments.First()) as IUNH;
            var msgType = $"underware.Edifact.{unh.Version}{unh.Release}.Messages.{unh.MessageType}, underware.Edifact.{unh.Version}{unh.Release}";
            var type = Type.GetType(msgType);
            
            var msg = type == null ? new Message() : Activator.CreateInstance(type) as Message;
            
            msg.UNH = Segment.Parse(spec, syntaxVersion, segments.First()) as IUNH;
            msg.UNT = Segment.Parse(spec, syntaxVersion, segments.Last()) as IUNT;

            var msgVersion = $"{msg.UNH.Version}{msg.UNH.Release}";

            foreach (var s in segments.GetRange(1, segments.Count - 2)
                         .Select(segment => Segment.Parse(spec, syntaxVersion, msgVersion, segment)))
            {
                msg.Segments.Add(s);
            }

            return msg;
        }
    }
}
