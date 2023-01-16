using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class AJT : Segment
    {
        public AJT() : base("AJT", "Adjustment details"){}

				[ElementInfo(0, "Adjustment reason, coded", "M", "1", "an..3", "" )]
public string E4465 { get; set; }
		[ElementInfo(1, "Line item number", "C", "1", "an..6", "" )]
public string E1082 { get; set; }

		
    }
}