using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class POC : Segment
    {
        public POC() : base("POC", "Purpose of conveyance call"){}

				[ElementInfo(0, "PURPOSE OF CONVEYANCE CALL", "M", "1", "", "" )]
public C525 C525 { get; set; }

		
    }
}