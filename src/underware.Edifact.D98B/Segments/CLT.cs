using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class CLT : Segment
    {
        public CLT() : base("CLT", "Clear terminate information"){}

				[ElementInfo(0, "Action request/notification, coded", "M", "1", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(1, "Message function, coded", "C", "2", "an..3", "" )]
public string E1225 { get; set; }
		[ElementInfo(2, "Free text", "C", "1", "an..70", "" )]
public string E4440 { get; set; }

		
    }
}