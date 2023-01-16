using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class GIS : Segment
    {
        public GIS() : base("GIS", "General indicator"){}

				[ElementInfo(0, "PROCESSING INDICATOR", "M", "1", "", "" )]
public C529 C529 { get; set; }

		
    }
}