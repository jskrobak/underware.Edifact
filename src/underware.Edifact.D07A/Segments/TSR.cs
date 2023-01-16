using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class TSR : Segment
    {
        public TSR() : base("TSR", "TRANSPORT SERVICE REQUIREMENTS"){}

				[ElementInfo(0, "CONTRACT AND CARRIAGE CONDITION", "Conditional", "", "", "" )]
public C536 C536 { get; set; }
		[ElementInfo(1, "SERVICE", "Conditional", "", "", "" )]
public C233 C233 { get; set; }
		[ElementInfo(2, "TRANSPORT PRIORITY", "Conditional", "", "", "" )]
public C537 C537 { get; set; }
		[ElementInfo(3, "NATURE OF CARGO", "Conditional", "", "", "" )]
public C703 C703 { get; set; }

		
    }
}