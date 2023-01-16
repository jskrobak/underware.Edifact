using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class PLI : Segment
    {
        public PLI() : base("PLI", "Product location information"){}

				[ElementInfo(0, "GEOGRAPHIC DETAILS", "M", "99", "", "" )]
public E008 E008 { get; set; }

		
    }
}