using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class POP : Segment
    {
        public POP() : base("POP", "Period of operation"){}

				[ElementInfo(0, "DATE AND TIME INFORMATION", "M", "1", "", "" )]
public E013 E013 { get; set; }
		[ElementInfo(1, "Days of week set identifier", "C", "1", "an..7", "" )]
public string E2160 { get; set; }
		[ElementInfo(2, "Status description code", "C", "1", "an..3", "" )]
public string E4405 { get; set; }

		
    }
}