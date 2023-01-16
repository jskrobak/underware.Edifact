using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class PRC : Segment
    {
        public PRC() : base("PRC", "Process identification"){}

				[ElementInfo(0, "PROCESS TYPE AND DESCRIPTION", "M", "1", "", "" )]
public C242 C242 { get; set; }

		
    }
}