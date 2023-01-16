using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class TRU : Segment
    {
        public TRU() : base("TRU", "Technical rules"){}

				[ElementInfo(0, "Identity number", "M", "1", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Version", "C", "1", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Release", "C", "1", "an..9", "" )]
public string E1058 { get; set; }
		[ElementInfo(3, "Rule part identification", "C", "1", "an..7", "" )]
public string E7175 { get; set; }
		[ElementInfo(4, "Code list responsible agency, coded", "C", "1", "an..3", "" )]
public string E3055 { get; set; }

		
    }
}