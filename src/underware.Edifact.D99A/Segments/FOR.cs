using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class FOR : Segment
    {
        public FOR() : base("FOR", "Formula"){}

				[ElementInfo(0, "Formula type qualifier", "M", "1", "an..3", "" )]
public string E9501 { get; set; }
		[ElementInfo(1, "Identity number", "C", "1", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(2, "Formula name", "C", "1", "an..35", "" )]
public string E9502 { get; set; }
		[ElementInfo(3, "Free text", "C", "1", "an..70", "" )]
public string E4440 { get; set; }
		[ElementInfo(4, "FORMULA COMPLEXITY", "C", "1", "", "" )]
public C961 C961 { get; set; }

		
    }
}