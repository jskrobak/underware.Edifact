using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class RFR : Segment
    {
        public RFR() : base("RFR", "Reference"){}

				[ElementInfo(0, "REFERENCE", "M", "1", "", "" )]
public E506 E506 { get; set; }

		
    }
}