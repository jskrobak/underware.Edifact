using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class ATR : Segment
    {
        public ATR() : base("ATR", "Attribute") { }

        [ElementInfo(0, "Attribute function code qualifier", "M", "1", "an..3", "")]
        public string E9017 { get; set; }
        [ElementInfo(1, "ATTRIBUTE INFORMATION", "M", "1", "", "")]
        public E003 E003 { get; set; }


    }
}