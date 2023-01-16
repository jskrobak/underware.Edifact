using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97B.Composites;

namespace underware.Edifact.D97B.Segments
{
    public class HYN : Segment
    {
        public HYN() : base("HYN", "Hierarchy information"){}

				[ElementInfo(0, "Hierarchy object qualifier", "M", "1", "an..3", "" )]
public string E7173 { get; set; }
		[ElementInfo(1, "Hierarchical level, coded", "M", "1", "an..3", "" )]
public string E7171 { get; set; }
		[ElementInfo(2, "Action request/notification, coded", "C", "1", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(3, "ITEM NUMBER IDENTIFICATION", "C", "1", "", "" )]
public C212 C212 { get; set; }

		
    }
}