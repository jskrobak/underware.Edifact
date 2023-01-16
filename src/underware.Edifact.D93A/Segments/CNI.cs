using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class CNI : Segment
    {
        public CNI() : base("CNI", "Consignment information"){}

				[ElementInfo(0, "Consolidation item number", "M", "1", "n..4", "" )]
public string E1490 { get; set; }
		[ElementInfo(1, "DOCUMENT/MESSAGE DETAILS", "C", "1", "", "" )]
public C503 C503 { get; set; }
		[ElementInfo(2, "Consignment load sequence number", "C", "1", "n..4", "" )]
public string E1312 { get; set; }

		
    }
}