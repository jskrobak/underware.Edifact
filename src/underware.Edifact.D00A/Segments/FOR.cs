
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class FOR : Segment
    {
        public FOR() : base("FOR", "Formula"){}

				[ElementInfo(0, "Formula type code qualifier", "M", "1", "an..3", "" )]
public string E9501 { get; set; }
		[ElementInfo(1, "Object identifier", "C", "1", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(2, "Formula name", "C", "1", "an..35", "" )]
public string E9502 { get; set; }
		[ElementInfo(3, "Free text value", "C", "1", "an..512", "" )]
public string E4440 { get; set; }
		[ElementInfo(4, "FORMULA COMPLEXITY", "C", "1", "", "" )]
public C961 C961 { get; set; }

		
    }
}