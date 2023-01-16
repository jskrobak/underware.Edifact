using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class CNT : Segment
    {
        public CNT() : base("CNT", "CONTROL TOTAL"){}

				[ElementInfo(0, "CONTROL", "Mandatory", "", "", "" )]
public C270 C270 { get; set; }

		
    }
}