using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95A.Composites;

namespace underware.Edifact.D95A.Segments
{
    public class TCC : Segment
    {
        public TCC() : base("TCC", "Transport charge/rate calculations"){}

				[ElementInfo(0, "CHARGE", "C", "1", "", "" )]
public C200 C200 { get; set; }
		[ElementInfo(1, "RATE/TARIFF CLASS", "C", "1", "", "" )]
public C203 C203 { get; set; }

		
    }
}