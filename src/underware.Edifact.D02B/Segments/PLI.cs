using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class PLI : Segment
    {
        public PLI() : base("PLI", "Product location information"){}

				[ElementInfo(0, "GEOGRAPHIC DETAILS", "M", "99", "", "" )]
public E008 E008 { get; set; }

		
    }
}