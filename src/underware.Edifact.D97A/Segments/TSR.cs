using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class TSR : Segment
    {
        public TSR() : base("TSR", "Transport service requirements"){}

				[ElementInfo(0, "CONTRACT AND CARRIAGE CONDITION", "C", "1", "", "" )]
public C536 C536 { get; set; }
		[ElementInfo(1, "SERVICE", "C", "1", "", "" )]
public C233 C233 { get; set; }
		[ElementInfo(2, "TRANSPORT PRIORITY", "C", "1", "", "" )]
public C537 C537 { get; set; }
		[ElementInfo(3, "NATURE OF CARGO", "C", "1", "", "" )]
public C703 C703 { get; set; }

		
    }
}