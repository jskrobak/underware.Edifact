using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class EMP : Segment
    {
        public EMP() : base("EMP", "Employment details"){}

				[ElementInfo(0, "Employment qualifier", "M", "1", "an..3", "" )]
public string E9003 { get; set; }
		[ElementInfo(1, "EMPLOYMENT CATEGORY", "C", "1", "", "" )]
public C948 C948 { get; set; }
		[ElementInfo(2, "OCCUPATION", "C", "1", "", "" )]
public C951 C951 { get; set; }
		[ElementInfo(3, "QUALIFICATION CLASSIFICATION", "C", "1", "", "" )]
public C950 C950 { get; set; }
		[ElementInfo(4, "Job title", "C", "1", "an..35", "" )]
public string E3494 { get; set; }

		
    }
}