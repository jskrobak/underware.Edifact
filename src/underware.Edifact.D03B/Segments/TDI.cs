using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class TDI : Segment
    {
        public TDI() : base("TDI", "Traveller document information"){}

				[ElementInfo(0, "DOCUMENT INFORMATION", "M", "1", "", "" )]
public E968 E968 { get; set; }
		[ElementInfo(1, "VALIDITY DATES", "C", "1", "", "" )]
public E969 E969 { get; set; }
		[ElementInfo(2, "Family name", "C", "1", "an..70", "" )]
public string E3500 { get; set; }
		[ElementInfo(3, "Given name", "C", "99", "an..70", "" )]
public string E3460 { get; set; }

		
    }
}