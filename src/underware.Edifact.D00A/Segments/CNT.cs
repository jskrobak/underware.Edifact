
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class CNT : Segment
    {
        public CNT() : base("CNT", "Control total"){}

				[ElementInfo(0, "CONTROL", "M", "1", "", "" )]
public C270 C270 { get; set; }

		
    }
}