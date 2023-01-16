
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class APD : Segment
    {
        public APD() : base("APD", "Additional transport details"){}

				[ElementInfo(0, "TRANSPORT DETAILS", "C", "1", "", "" )]
public E961 E961 { get; set; }
		[ElementInfo(1, "TERMINAL INFORMATION", "C", "2", "", "" )]
public E962 E962 { get; set; }
		[ElementInfo(2, "DISTANCE OR TIME DETAILS", "C", "1", "", "" )]
public E963 E963 { get; set; }
		[ElementInfo(3, "TRAVELLER TIME DETAILS", "C", "1", "", "" )]
public E964 E964 { get; set; }
		[ElementInfo(4, "FACILITIES", "C", "10", "", "" )]
public E965 E965 { get; set; }

		
    }
}