using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class APR : Segment
    {
        public APR() : base("APR", "ADDITIONAL PRICE INFORMATION"){}

				[ElementInfo(0, "TRADE CLASS CODE", "Conditional", "", "", "" )]
public string E4043 { get; set; }
		[ElementInfo(1, "PRICE MULTIPLIER INFORMATION", "Conditional", "", "", "" )]
public C138 C138 { get; set; }
		[ElementInfo(2, "REASON FOR CHANGE", "Conditional", "", "", "" )]
public C960 C960 { get; set; }

		
    }
}