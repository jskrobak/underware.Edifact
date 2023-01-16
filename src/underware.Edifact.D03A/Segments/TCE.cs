using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class TCE : Segment
    {
        public TCE() : base("TCE", "Time and certainty"){}

				[ElementInfo(0, "Date or time or period text", "C", "1", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(1, "CERTAINTY", "C", "1", "", "" )]
public E946 E946 { get; set; }

		
    }
}