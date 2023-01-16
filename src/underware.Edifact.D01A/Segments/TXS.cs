using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class TXS : Segment
    {
        public TXS() : base("TXS", "Taxes") { }

        [ElementInfo(0, "TAX DETAILS", "M", "99", "", "")]
        public E020 E020 { get; set; }


    }
}