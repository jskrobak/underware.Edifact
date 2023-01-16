using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class ELU : Segment
    {
        public ELU() : base("ELU", "Data element usage details"){}

				[ElementInfo(0, "Data element tag", "M", "1", "an..4", "" )]
public string E9162 { get; set; }
		[ElementInfo(1, "Requirement designator, coded", "C", "1", "an..3", "" )]
public string E7299 { get; set; }
		[ElementInfo(2, "Sequence number", "C", "1", "an..10", "" )]
public string E1050 { get; set; }
		[ElementInfo(3, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}