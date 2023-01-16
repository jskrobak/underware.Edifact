using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class SAL : Segment
    {
        public SAL() : base("SAL", "Remuneration type identification"){}

				[ElementInfo(0, "REMUNERATION TYPE IDENTIFICATION", "C", "1", "", "" )]
public C049 C049 { get; set; }

		
    }
}