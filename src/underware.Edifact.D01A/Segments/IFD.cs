using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class IFD : Segment
    {
        public IFD() : base("IFD", "Information detail") { }

        [ElementInfo(0, "Information details code qualifier", "C", "1", "an..3", "")]
        public string E9633 { get; set; }
        [ElementInfo(1, "INFORMATION CATEGORY", "C", "1", "", "")]
        public C009 C009 { get; set; }
        [ElementInfo(2, "INFORMATION TYPE", "C", "1", "", "")]
        public C010 C010 { get; set; }
        [ElementInfo(3, "INFORMATION DETAIL", "C", "5", "", "")]
        public C011 C011 { get; set; }
        [ElementInfo(4, "Status description code", "C", "1", "an..3", "")]
        public string E4405 { get; set; }


    }
}