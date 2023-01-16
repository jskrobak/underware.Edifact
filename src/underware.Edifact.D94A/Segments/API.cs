using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class API : Segment
    {
        public API() : base("API", "Additional price information"){}

				[ElementInfo(0, "Class of trade, coded", "C", "1", "an..3", "" )]
public string E4043 { get; set; }
		[ElementInfo(1, "PRICE MULTIPLIER INFORMATION", "C", "1", "", "" )]
public C138 C138 { get; set; }
		[ElementInfo(2, "REASON FOR CHANGE", "C", "1", "", "" )]
public C262 C262 { get; set; }

		
    }
}