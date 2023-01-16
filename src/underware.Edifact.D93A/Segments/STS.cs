using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class STS : Segment
    {
        public STS() : base("STS", "Transport status report"){}

				[ElementInfo(0, "STATUS DETAIL", "C", "1", "", "" )]
public C601 C601 { get; set; }
		[ElementInfo(1, "STATUS EVENT", "C", "1", "", "" )]
public C555 C555 { get; set; }
		[ElementInfo(2, "STATUS REASON", "C", "1", "", "" )]
public C556 C556 { get; set; }

		
    }
}