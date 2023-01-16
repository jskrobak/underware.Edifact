using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class ELV : Segment
    {
        public ELV() : base("ELV", "Element value definition"){}

				[ElementInfo(0, "Value definition code qualifier", "M", "1", "an..3", "" )]
public string E9029 { get; set; }
		[ElementInfo(1, "Value text", "C", "1", "an..512", "" )]
public string E9422 { get; set; }
		[ElementInfo(2, "Requirement designator code", "C", "1", "an..3", "" )]
public string E7299 { get; set; }
		[ElementInfo(3, "Maintenance operation code", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}