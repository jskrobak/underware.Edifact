using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class FCA : Segment
    {
        public FCA() : base("FCA", "Financial charges allocation"){}

				[ElementInfo(0, "Settlement, coded", "M", "1", "an..3", "" )]
public string E4471 { get; set; }
		[ElementInfo(1, "CHARGE/ALLOWANCE ACCOUNT", "C", "1", "", "" )]
public C878 C878 { get; set; }

		
    }
}