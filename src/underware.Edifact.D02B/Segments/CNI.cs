using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class CNI : Segment
    {
        public CNI() : base("CNI", "Consignment information"){}

				[ElementInfo(0, "Consolidation item number", "C", "1", "n..4", "" )]
public string E1490 { get; set; }
		[ElementInfo(1, "DOCUMENT/MESSAGE DETAILS", "C", "1", "", "" )]
public C503 C503 { get; set; }
		[ElementInfo(2, "Consignment load sequence identifier", "C", "1", "n..4", "" )]
public string E1312 { get; set; }

		
    }
}