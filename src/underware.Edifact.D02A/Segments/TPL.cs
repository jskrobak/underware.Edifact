using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class TPL : Segment
    {
        public TPL() : base("TPL", "Transport placement"){}

				[ElementInfo(0, "TRANSPORT IDENTIFICATION", "M", "1", "", "" )]
public C222 C222 { get; set; }

		
    }
}