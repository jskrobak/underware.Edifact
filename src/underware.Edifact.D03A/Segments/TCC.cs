using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class TCC : Segment
    {
        public TCC() : base("TCC", "Charge/rate calculations"){}

				[ElementInfo(0, "CHARGE", "C", "1", "", "" )]
public C200 C200 { get; set; }
		[ElementInfo(1, "RATE/TARIFF CLASS", "C", "1", "", "" )]
public C203 C203 { get; set; }
		[ElementInfo(2, "COMMODITY/RATE DETAIL", "C", "1", "", "" )]
public C528 C528 { get; set; }
		[ElementInfo(3, "RATE/TARIFF CLASS DETAIL", "C", "1", "", "" )]
public C554 C554 { get; set; }

		
    }
}