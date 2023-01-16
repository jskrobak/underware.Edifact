
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class CDV : Segment
    {
        public CDV() : base("CDV", "Code value definition"){}

				[ElementInfo(0, "Code value", "M", "1", "an..35", "" )]
public string E9426 { get; set; }
		[ElementInfo(1, "Code name", "C", "1", "an..70", "" )]
public string E9434 { get; set; }
		[ElementInfo(2, "Maintenance operation code", "C", "1", "an..3", "" )]
public string E4513 { get; set; }
		[ElementInfo(3, "Code value source code", "C", "1", "an..3", "" )]
public string E9453 { get; set; }
		[ElementInfo(4, "Requirement designator code", "C", "1", "an..3", "" )]
public string E7299 { get; set; }

		
    }
}