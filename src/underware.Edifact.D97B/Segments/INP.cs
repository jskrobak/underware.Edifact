using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97B.Composites;

namespace underware.Edifact.D97B.Segments
{
    public class INP : Segment
    {
        public INP() : base("INP", "Parties and instruction"){}

				[ElementInfo(0, "PARTIES TO INSTRUCTION", "C", "1", "", "" )]
public C849 C849 { get; set; }
		[ElementInfo(1, "INSTRUCTION", "C", "1", "", "" )]
public C522 C522 { get; set; }
		[ElementInfo(2, "STATUS OF INSTRUCTION", "C", "1", "", "" )]
public C850 C850 { get; set; }
		[ElementInfo(3, "Action request/notification, coded", "C", "1", "an..3", "" )]
public string E1229 { get; set; }

		
    }
}