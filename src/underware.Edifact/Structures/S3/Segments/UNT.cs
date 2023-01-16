using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;

namespace underware.Edifact.Structures.S3.Segments
{
    public class UNT : Segment, IUNT
    {
        public UNT() : base("UNT", "Message trailer")
        {
            SegmentsCount = 0;
        }

        public UNT(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        public UNT(int segmentCnt, string refNo) : base("UNT", "Interchange trailer")
        {
            SegmentsCount = segmentCnt;
            MessageReferenceNumber = refNo;
        }

        [ElementInfo(0, "Number of segments in a message", "M", "1", "n..10", "")]
        public string E0074 { get; set; }

        [ElementInfo(1, "MESSAGE REFERENCE NUMBER", "M", "1", "n..10", "")]
        public string E0062 { get; set; }


        public int SegmentsCount { get => int.Parse(E0074); set => E0074 = value.ToString(); }
        public string MessageReferenceNumber { get => E0062; set => E0062 = value; }
    }
}
