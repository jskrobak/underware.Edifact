using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class AJT : Segment
    {
        public AJT() : base("AJT", "Adjustment details"){}

				[ElementInfo(0, "Adjustment reason description code", "M", "1", "an..3", "" )]
public string E4465 { get; set; }
		[ElementInfo(1, "Line item identifier", "C", "1", "an..6", "" )]
public string E1082 { get; set; }

		
    }
}