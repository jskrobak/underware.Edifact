using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97B.Composites;

namespace underware.Edifact.D97B.Segments
{
    public class CNT : Segment
    {
        public CNT() : base("CNT", "Control total"){}

				[ElementInfo(0, "CONTROL", "M", "1", "", "" )]
public C270 C270 { get; set; }

		
    }
}