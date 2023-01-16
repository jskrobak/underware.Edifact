using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class CLT : Segment
    {
        public CLT() : base("CLT", "Clear terminate information"){}

				[ElementInfo(0, "Action request/notification description code", "M", "1", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(1, "Message function code", "C", "2", "an..3", "" )]
public string E1225 { get; set; }
		[ElementInfo(2, "Free text", "C", "1", "an..512", "" )]
public string E4440 { get; set; }

		
    }
}