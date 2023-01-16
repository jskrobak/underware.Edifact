using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class GIS : Segment
    {
        public GIS() : base("GIS", "General indicator"){}

				[ElementInfo(0, "PROCESSING INDICATOR", "M", "1", "", "" )]
public C529 C529 { get; set; }
		[ElementInfo(1, "Process type identification", "C", "1", "an..17", "" )]
public string E7187 { get; set; }

		
    }
}