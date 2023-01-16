using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class APR : Segment
    {
        public APR() : base("APR", "Additional price information"){}

				[ElementInfo(0, "Trade class code", "C", "1", "an..3", "" )]
public string E4043 { get; set; }
		[ElementInfo(1, "PRICE MULTIPLIER INFORMATION", "C", "1", "", "" )]
public C138 C138 { get; set; }
		[ElementInfo(2, "REASON FOR CHANGE", "C", "1", "", "" )]
public C960 C960 { get; set; }

		
    }
}