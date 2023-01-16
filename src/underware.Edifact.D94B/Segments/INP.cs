using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class INP : Segment
    {
        public INP() : base("INP", "Parties to instruction"){}

				[ElementInfo(0, "PARTIES TO INSTRUCTION", "M", "1", "", "" )]
public C849 C849 { get; set; }
		[ElementInfo(1, "INSTRUCTION", "C", "1", "", "" )]
public C522 C522 { get; set; }
		[ElementInfo(2, "STATUS OF INSTRUCTION", "C", "1", "", "" )]
public C850 C850 { get; set; }

		
    }
}