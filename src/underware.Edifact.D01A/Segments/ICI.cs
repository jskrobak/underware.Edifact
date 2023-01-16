using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class ICI : Segment
    {
        public ICI() : base("ICI", "Insurance cover information") { }

        [ElementInfo(0, "INSURANCE COVER REQUIREMENT", "M", "1", "", "")]
        public E016 E016 { get; set; }
        [ElementInfo(1, "MONETARY AMOUNT", "C", "5", "", "")]
        public E017 E017 { get; set; }


    }
}