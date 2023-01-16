using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class CDI : Segment
    {
        public CDI() : base("CDI", "Physical or logical state"){}

				[ElementInfo(0, "Physical or logical state type code qualifier", "M", "1", "an..3", "" )]
public string E7001 { get; set; }
		[ElementInfo(1, "PHYSICAL OR LOGICAL STATE INFORMATION", "M", "1", "", "" )]
public C564 C564 { get; set; }

		
    }
}