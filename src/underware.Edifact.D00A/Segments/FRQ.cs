
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class FRQ : Segment
    {
        public FRQ() : base("FRQ", "Frequency"){}

				[ElementInfo(0, "FREQUENCY", "M", "99", "", "" )]
public E520 E520 { get; set; }

		
    }
}