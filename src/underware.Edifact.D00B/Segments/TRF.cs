using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class TRF : Segment
    {
        public TRF() : base("TRF", "Traffic restriction details") { }

        [ElementInfo(0, "TRAFFIC RESTRICTION DETAILS", "M", "5", "", "")]
        public E007 E007 { get; set; }


    }
}