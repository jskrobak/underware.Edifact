using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class APR : Segment
    {
        public APR() : base("APR", "Additional price information"){}

				[ElementInfo(0, "Class of trade, coded", "C", "1", "an..3", "" )]
public string E4043 { get; set; }
		[ElementInfo(1, "PRICE MULTIPLIER INFORMATION", "C", "1", "", "" )]
public C138 C138 { get; set; }
		[ElementInfo(2, "REASON FOR CHANGE", "C", "1", "", "" )]
public C960 C960 { get; set; }

		
    }
}