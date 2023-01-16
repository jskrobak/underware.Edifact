using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class DIS : Segment
    {
        public DIS() : base("DIS", "Discount information") { }

        [ElementInfo(0, "DISCOUNT INFORMATION", "M", "20", "", "")]
        public E998 E998 { get; set; }


    }
}