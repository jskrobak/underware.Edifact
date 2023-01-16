using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class GRU : Segment
    {
        public GRU() : base("GRU", "Segment group usage details"){}

				[ElementInfo(0, "Group identification", "M", "1", "an..4", "" )]
public string E9164 { get; set; }
		[ElementInfo(1, "Requirement designator, coded", "C", "1", "an..3", "" )]
public string E7299 { get; set; }
		[ElementInfo(2, "Maximum number of occurrences", "C", "1", "n..7", "" )]
public string E6176 { get; set; }
		[ElementInfo(3, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }
		[ElementInfo(4, "Sequence number", "C", "1", "an..10", "" )]
public string E1050 { get; set; }

		
    }
}