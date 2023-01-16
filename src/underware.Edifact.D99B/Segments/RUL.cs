using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class RUL : Segment
    {
        public RUL() : base("RUL", "Rule information"){}

				[ElementInfo(0, "RULE DETAILS", "C", "99", "", "" )]
public E004 E004 { get; set; }
		[ElementInfo(1, "RULE TEXT", "C", "9", "", "" )]
public E005 E005 { get; set; }
		[ElementInfo(2, "RULE STATUS", "C", "9", "", "" )]
public E006 E006 { get; set; }

		
    }
}