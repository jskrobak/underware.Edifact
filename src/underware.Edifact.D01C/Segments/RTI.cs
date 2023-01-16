using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class RTI : Segment
    {
        public RTI() : base("RTI", "Rate details"){}

				[ElementInfo(0, "RATE CLASS DETAILS", "M", "99", "", "" )]
public E011 E011 { get; set; }

		
    }
}