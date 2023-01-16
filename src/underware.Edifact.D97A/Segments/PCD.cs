using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class PCD : Segment
    {
        public PCD() : base("PCD", "Percentage details"){}

				[ElementInfo(0, "PERCENTAGE DETAILS", "M", "1", "", "" )]
public C501 C501 { get; set; }

		
    }
}