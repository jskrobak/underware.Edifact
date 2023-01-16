using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class PRE : Segment
    {
        public PRE() : base("PRE", "Price details") { }

        [ElementInfo(0, "PRICE INFORMATION", "C", "20", "", "")]
        public E018 E018 { get; set; }
        [ElementInfo(1, "Sub-line item price change operation code", "C", "1", "an..3", "")]
        public string E5213 { get; set; }


    }
}