using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class CUX : Segment
    {
        public CUX() : base("CUX", "Currencies"){}

				[ElementInfo(0, "CURRENCY DETAILS", "C", "1", "", "" )]
public C504 C504 { get; set; }
		[ElementInfo(1, "CURRENCY DETAILS", "C", "1", "", "" )]
public C504 C504_0 { get; set; }
		[ElementInfo(2, "Rate of exchange", "C", "1", "n..12", "" )]
public string E5402 { get; set; }
		[ElementInfo(3, "Currency market exchange, coded", "C", "1", "an..3", "" )]
public string E6341 { get; set; }

		
    }
}