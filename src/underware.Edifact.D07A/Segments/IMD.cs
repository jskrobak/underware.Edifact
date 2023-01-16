using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class IMD : Segment
    {
        public IMD() : base("IMD", "ITEM DESCRIPTION"){}

				[ElementInfo(0, "DESCRIPTION FORMAT CODE", "Conditional", "", "", "" )]
public string E7077 { get; set; }
		[ElementInfo(1, "ITEM CHARACTERISTIC", "Conditional", "", "", "" )]
public C272 C272 { get; set; }
		[ElementInfo(2, "ITEM DESCRIPTION", "Conditional", "", "", "" )]
public C273 C273 { get; set; }
		[ElementInfo(3, "SURFACE OR LAYER CODE", "Conditional", "", "", "" )]
public string E7383 { get; set; }

		
    }
}