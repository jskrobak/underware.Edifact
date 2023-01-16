using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class EVT : Segment
    {
        public EVT() : base("EVT", "Event"){}

				[ElementInfo(0, "EVENT TYPE", "C", "1", "", "" )]
public C030 C030 { get; set; }
		[ElementInfo(1, "EVENT IDENTIFICATION", "C", "1", "", "" )]
public C063 C063 { get; set; }

		
    }
}