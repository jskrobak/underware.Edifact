using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class AGR : Segment
    {
        public AGR() : base("AGR", "Agreement identification"){}

				[ElementInfo(0, "AGREEMENT TYPE IDENTIFICATION", "C", "1", "", "" )]
public C543 C543 { get; set; }
		[ElementInfo(1, "Service layer, coded", "C", "1", "an..3", "" )]
public string E9419 { get; set; }

		
    }
}