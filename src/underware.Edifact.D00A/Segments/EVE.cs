
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class EVE : Segment
    {
        public EVE() : base("EVE", "Event"){}

				[ElementInfo(0, "Event details code qualifier", "C", "1", "an..3", "" )]
public string E9635 { get; set; }
		[ElementInfo(1, "EVENT CATEGORY", "C", "1", "", "" )]
public C004 C004 { get; set; }
		[ElementInfo(2, "EVENT TYPE", "C", "1", "", "" )]
public C030 C030 { get; set; }
		[ElementInfo(3, "EVENT IDENTIFICATION", "C", "5", "", "" )]
public C063 C063 { get; set; }
		[ElementInfo(4, "Action request/notification description code", "C", "1", "an..3", "" )]
public string E1229 { get; set; }

		
    }
}