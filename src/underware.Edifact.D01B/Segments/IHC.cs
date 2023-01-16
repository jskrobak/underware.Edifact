using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class IHC : Segment
    {
        public IHC() : base("IHC", "Person characteristic") { }

        [ElementInfo(0, "Person characteristic code qualifier", "M", "1", "an..3", "")]
        public string E3289 { get; set; }
        [ElementInfo(1, "PERSON INHERITED CHARACTERISTIC DETAILS", "C", "1", "", "")]
        public C818 C818 { get; set; }


    }
}