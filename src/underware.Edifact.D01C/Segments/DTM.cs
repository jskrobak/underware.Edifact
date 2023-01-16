using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class DTM : Segment
    {
        public DTM() : base("DTM", "Date/time/period"){}

				[ElementInfo(0, "DATE/TIME/PERIOD", "M", "1", "", "" )]
public C507 C507 { get; set; }

		
    }
}