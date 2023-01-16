using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class CDV : Segment
    {
        public CDV() : base("CDV", "Code value definition"){}

				[ElementInfo(0, "Code value", "M", "1", "an..35", "" )]
public string E9426 { get; set; }
		[ElementInfo(1, "Code name", "C", "1", "an..70", "" )]
public string E9434 { get; set; }
		[ElementInfo(2, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}