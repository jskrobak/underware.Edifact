using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class PRC : Segment
    {
        public PRC() : base("PRC", "Process identification"){}

				[ElementInfo(0, "PROCESS TYPE AND DESCRIPTION", "C", "1", "", "" )]
public C242 C242 { get; set; }
		[ElementInfo(1, "PROCESS IDENTIFICATION DETAILS", "C", "1", "", "" )]
public C830 C830 { get; set; }

		
    }
}