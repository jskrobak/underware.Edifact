using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class CUX : Segment
    {
        public CUX() : base("CUX", "CURRENCIES"){}

				[ElementInfo(0, "CURRENCY DETAILS", "Conditional", "", "", "" )]
public C504 C504 { get; set; }
		[ElementInfo(1, "CURRENCY DETAILS", "Conditional", "", "", "" )]
public C504 C504_0 { get; set; }
		[ElementInfo(2, "CURRENCY EXCHANGE RATE", "Conditional", "", "", "" )]
public string E5402 { get; set; }
		[ElementInfo(3, "EXCHANGE RATE CURRENCY MARKET IDENTIFIER", "Conditional", "", "", "" )]
public string E6341 { get; set; }

		
    }
}