using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class GIR : Segment
    {
        public GIR() : base("GIR", "Related identification numbers"){}

				[ElementInfo(0, "Set identification qualifier", "M", "1", "an..3", "" )]
public string E7297 { get; set; }
		[ElementInfo(1, "IDENTIFICATION NUMBER", "M", "1", "", "" )]
public C206 C206 { get; set; }
		[ElementInfo(2, "IDENTIFICATION NUMBER", "C", "1", "", "" )]
public C206 C206_0 { get; set; }
		[ElementInfo(3, "IDENTIFICATION NUMBER", "C", "1", "", "" )]
public C206 C206_1 { get; set; }
		[ElementInfo(4, "IDENTIFICATION NUMBER", "C", "1", "", "" )]
public C206 C206_2 { get; set; }
		[ElementInfo(5, "IDENTIFICATION NUMBER", "C", "1", "", "" )]
public C206 C206_3 { get; set; }

		
    }
}