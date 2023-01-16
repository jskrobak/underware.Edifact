using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class ATI : Segment
    {
        public ATI() : base("ATI", "Tour information"){}

				[ElementInfo(0, "TOUR DETAILS", "C", "1", "", "" )]
public E993 E993 { get; set; }
		[ElementInfo(1, "STOPOVER INFORMATION", "C", "99", "", "" )]
public E994 E994 { get; set; }

		
    }
}