using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class AAI : Segment
    {
        public AAI() : base("AAI", "Accommodation allocation information"){}

				[ElementInfo(0, "ACCOMMODATION ALLOCATION INFORMATION", "M", "20", "", "" )]
public E997 E997 { get; set; }

		
    }
}