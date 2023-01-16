using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using S3 = underware.Edifact.Structures.S3;
using S4 = underware.Edifact.Structures.S4;
using underware.Edifact.Structures.Common.Interfaces;

namespace underware.Edifact
{
    public class Message
    {
        private List<Segment> _segments;

        public Message()
        {
            _segments = new List<Segment>();
        }
        
        public List<Segment>Segments { get { return _segments; } }

        public List<Segment> AllSegments
        {
            get
            {
                List<Segment> s = new List<Segment>();
                s.Add(UNH as Segment);
                s.AddRange(_segments);
                s.Add(UNT as Segment);
                return s;
            }
        }


        //public List<>

        public Message(int syntax, string messageType, string version, string release, string agency, string association, string refNo)
        {
            if (syntax == 3)
            {
                UNH = new S3.Segments.UNH(messageType, version, release, agency, association, refNo);
                UNT = new S3.Segments.UNT(0, refNo);
            }
            else if (syntax == 4)
            {
                UNH = new S4.Segments.UNH(messageType, version, release, agency, association, refNo);
                UNT = new S4.Segments.UNT(0, refNo);
            }
            else
            {
                throw new NotSupportedException(string.Format("Syntax version {0} is not supported.", version));
            }

            _segments = new List<Segment>();
        }

        public Interchange Interchange { get; set; }

        public IUNH UNH { get; set; }

        public IUNT UNT { get; set; }

        public override string ToString()
        {
            return ToString(CharSpec.Default);
        }

        public string ToString(CharSpec charSpec)
        {
            List<Segment> allSegments = AllSegments;
            UNT.SegmentsCount = allSegments.Count;
            
            return charSpec.JoinSegments(allSegments);
        }


        public static Message Parse(CharSpec spec, int syntaxVersion, List<string> segments)
        {
            if (segments.Count < 2)
                throw new ArgumentOutOfRangeException("Message must have at least 2 segments (UNH, UNT)");

            if (!segments[0].StartsWith("UNH"))
                throw new ArgumentException("Message must start with UNH segment;");

            Message msg = new Message();
            msg.UNH = Segment.Parse(spec, syntaxVersion, segments.First()) as IUNH;
            msg.UNT = Segment.Parse(spec, syntaxVersion, segments.Last()) as IUNT;

            string msgVersion = string.Format("{0}{1}", msg.UNH.Version, msg.UNH.Release);

            foreach (string segment in segments.GetRange(1, segments.Count - 2))
            {
                Segment s = Segment.Parse(spec, syntaxVersion, msgVersion, segment);
                msg.Segments.Add(s);
            }


            return msg;

        }
    }
}
