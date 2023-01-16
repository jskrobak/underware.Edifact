using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class PRI : Segment
    {
        public PRI() : base("PRI", "Price details"){}

				[ElementInfo(0, "PRICE INFORMATION", "C", "1", "", "" )]
public C509 C509 { get; set; }
		[ElementInfo(1, "Sub-line item price change operation code", "C", "1", "an..3", "" )]
public string E5213 { get; set; }

		
    }
}