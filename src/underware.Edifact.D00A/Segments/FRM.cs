
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class FRM : Segment
    {
        public FRM() : base("FRM", "Follow-up action"){}

				[ElementInfo(0, "Object identifier", "M", "1", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Status reason description code", "M", "7", "an..3", "" )]
public string E9013 { get; set; }
		[ElementInfo(2, "Action request/notification description code", "C", "1", "an..3", "" )]
public string E1229 { get; set; }

		
    }
}