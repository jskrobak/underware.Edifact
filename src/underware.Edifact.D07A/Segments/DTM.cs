using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class DTM : Segment
    {
        public DTM() : base("DTM", "DATE/TIME/PERIOD"){}

				[ElementInfo(0, "DATE/TIME/PERIOD", "Mandatory", "", "", "" )]
public C507 C507 { get; set; }

		
    }
}