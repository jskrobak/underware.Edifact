
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class PCC : Segment
    {
        public PCC() : base("PCC", "Premium calculation component details"){}

				[ElementInfo(0, "PREMIUM CALCULATION COMPONENT", "C", "1", "", "" )]
public C820 C820 { get; set; }
		[ElementInfo(1, "Premium calculation component value category identifier", "C", "1", "an..35", "" )]
public string E4522 { get; set; }

		
    }
}