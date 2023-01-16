using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class MKS : Segment
    {
        public MKS() : base("MKS", "Market/sales channel information") { }

        [ElementInfo(0, "Sector area identification code qualifier", "M", "1", "an..3", "")]
        public string E7293 { get; set; }
        [ElementInfo(1, "SALES CHANNEL IDENTIFICATION", "M", "1", "", "")]
        public C332 C332 { get; set; }
        [ElementInfo(2, "Action request/notification description code", "C", "1", "an..3", "")]
        public string E1229 { get; set; }


    }
}