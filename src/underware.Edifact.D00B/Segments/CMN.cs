using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class CMN : Segment
    {
        public CMN() : base("CMN", "Commission information") { }

        [ElementInfo(0, "COMMISSION DETAILS", "M", "9", "", "")]
        public E002 E002 { get; set; }


    }
}