using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class CUR : Segment
    {
        public CUR() : base("CUR", "Currencies"){}

				[ElementInfo(0, "CURRENCY DETAILS", "C", "1", "", "" )]
public E504 E504 { get; set; }
		[ElementInfo(1, "CURRENCY DETAILS", "C", "1", "", "" )]
public E504 E504_0 { get; set; }
		[ElementInfo(2, "Rate of exchange", "C", "1", "n..12", "" )]
public string E5402 { get; set; }
		[ElementInfo(3, "Currency market exchange, coded", "C", "1", "an..3", "" )]
public string E6341 { get; set; }

		
    }
}