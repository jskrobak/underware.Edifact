
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class SGP : Segment
    {
        public SGP() : base("SGP", "Split goods placement"){}

				[ElementInfo(0, "EQUIPMENT IDENTIFICATION", "M", "1", "", "" )]
public C237 C237 { get; set; }
		[ElementInfo(1, "Package quantity", "C", "1", "n..8", "" )]
public string E7224 { get; set; }

		
    }
}