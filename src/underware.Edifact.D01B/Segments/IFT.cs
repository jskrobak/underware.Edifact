using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class IFT : Segment
    {
        public IFT() : base("IFT", "Interactive free text") { }

        [ElementInfo(0, "FREE TEXT QUALIFICATION", "C", "1", "", "")]
        public E971 E971 { get; set; }
        [ElementInfo(1, "Free text value", "C", "99", "an..512", "")]
        public string E4440 { get; set; }


    }
}