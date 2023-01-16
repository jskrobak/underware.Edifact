using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class SSR : Segment
    {
        public SSR() : base("SSR", "Special requirement details"){}

				[ElementInfo(0, "SPECIAL REQUIREMENT TYPE DETAILS", "M", "1", "", "" )]
public E980 E980 { get; set; }
		[ElementInfo(1, "SPECIAL REQUIREMENT DETAILS", "C", "999", "", "" )]
public E981 E981 { get; set; }

		
    }
}