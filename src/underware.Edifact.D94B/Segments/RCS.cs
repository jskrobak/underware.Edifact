using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class RCS : Segment
    {
        public RCS() : base("RCS", "Requirements and conditions"){}

				[ElementInfo(0, "Sector/subject identification qualifier", "M", "1", "an..3", "" )]
public string E7293 { get; set; }
		[ElementInfo(1, "REQUIREMENT/CONDITION IDENTIFICATION", "C", "1", "", "" )]
public C550 C550 { get; set; }
		[ElementInfo(2, "Action request/notification, coded", "C", "1", "an..3", "" )]
public string E1229 { get; set; }

		
    }
}