using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class PRI : Segment
    {
        public PRI() : base("PRI", "Price details"){}

				[ElementInfo(0, "PRICE INFORMATION", "C", "1", "", "" )]
public C509 C509 { get; set; }
		[ElementInfo(1, "Sub-line price change, coded", "C", "1", "an..3", "" )]
public string E5213 { get; set; }

		
    }
}