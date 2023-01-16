using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class MES : Segment
    {
        public MES() : base("MES", "Measurements") { }

        [ElementInfo(0, "MEASUREMENT VALUE AND DETAILS", "M", "9", "", "")]
        public E175 E175 { get; set; }


    }
}