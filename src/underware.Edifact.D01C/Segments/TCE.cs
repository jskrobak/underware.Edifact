using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class TCE : Segment
    {
        public TCE() : base("TCE", "Time and certainty"){}

				[ElementInfo(0, "Date or time or period value", "C", "1", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(1, "CERTAINTY", "C", "1", "", "" )]
public E946 E946 { get; set; }

		
    }
}