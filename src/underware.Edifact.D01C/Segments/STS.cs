using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class STS : Segment
    {
        public STS() : base("STS", "Status"){}

				[ElementInfo(0, "STATUS CATEGORY", "C", "1", "", "" )]
public C601 C601 { get; set; }
		[ElementInfo(1, "STATUS", "C", "1", "", "" )]
public C555 C555 { get; set; }
		[ElementInfo(2, "STATUS REASON", "C", "1", "", "" )]
public C556 C556 { get; set; }
		[ElementInfo(3, "STATUS REASON", "C", "1", "", "" )]
public C556 C556_0 { get; set; }
		[ElementInfo(4, "STATUS REASON", "C", "1", "", "" )]
public C556 C556_1 { get; set; }
		[ElementInfo(5, "STATUS REASON", "C", "1", "", "" )]
public C556 C556_2 { get; set; }
		[ElementInfo(6, "STATUS REASON", "C", "1", "", "" )]
public C556 C556_3 { get; set; }

		
    }
}