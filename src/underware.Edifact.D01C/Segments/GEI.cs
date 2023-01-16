using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class GEI : Segment
    {
        public GEI() : base("GEI", "Processing information"){}

				[ElementInfo(0, "Processing information code qualifier", "M", "1", "an..3", "" )]
public string E9649 { get; set; }
		[ElementInfo(1, "PROCESSING INDICATOR", "C", "1", "", "" )]
public C012 C012 { get; set; }
		[ElementInfo(2, "Process type description code", "C", "1", "an..17", "" )]
public string E7187 { get; set; }

		
    }
}