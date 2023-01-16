using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class REL : Segment
    {
        public REL() : base("REL", "Relationship"){}

				[ElementInfo(0, "Relationship type code qualifier", "M", "1", "an..3", "" )]
public string E9141 { get; set; }
		[ElementInfo(1, "RELATIONSHIP", "C", "1", "", "" )]
public C941 C941 { get; set; }

		
    }
}