using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class GEI : Segment
    {
        public GEI() : base("GEI", "PROCESSING INFORMATION"){}

				[ElementInfo(0, "PROCESSING INFORMATION CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E9649 { get; set; }
		[ElementInfo(1, "PROCESSING INDICATOR", "Conditional", "", "", "" )]
public C012 C012 { get; set; }
		[ElementInfo(2, "PROCESS TYPE DESCRIPTION CODE", "Conditional", "", "", "" )]
public string E7187 { get; set; }

		
    }
}