using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class DAV : Segment
    {
        public DAV() : base("DAV", "Daily availability"){}

				[ElementInfo(0, "Characteristic description code", "M", "1", "an..17", "" )]
public string E7037 { get; set; }
		[ElementInfo(1, "DAILY AVAILABILITY INFORMATION", "M", "31", "", "" )]
public E009 E009 { get; set; }

		
    }
}