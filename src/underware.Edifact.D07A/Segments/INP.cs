using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class INP : Segment
    {
        public INP() : base("INP", "PARTIES AND INSTRUCTION"){}

				[ElementInfo(0, "PARTIES TO INSTRUCTION", "Conditional", "", "", "" )]
public C849 C849 { get; set; }
		[ElementInfo(1, "INSTRUCTION", "Conditional", "", "", "" )]
public C522 C522 { get; set; }
		[ElementInfo(2, "STATUS OF INSTRUCTION", "Conditional", "", "", "" )]
public C850 C850 { get; set; }
		[ElementInfo(3, "ACTION CODE", "Conditional", "", "", "" )]
public string E1229 { get; set; }

		
    }
}