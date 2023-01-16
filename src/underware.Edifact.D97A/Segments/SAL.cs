using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class SAL : Segment
    {
        public SAL() : base("SAL", "Remuneration type identification"){}

				[ElementInfo(0, "REMUNERATION TYPE IDENTIFICATION", "C", "1", "", "" )]
public C049 C049 { get; set; }

		
    }
}