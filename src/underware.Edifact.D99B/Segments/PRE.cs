using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class PRE : Segment
    {
        public PRE() : base("PRE", "Price details"){}

				[ElementInfo(0, "PRICE INFORMATION", "C", "20", "", "" )]
public E018 E018 { get; set; }
		[ElementInfo(1, "Sub-line price change, coded", "C", "1", "an..3", "" )]
public string E5213 { get; set; }

		
    }
}