using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class ERI : Segment
    {
        public ERI() : base("ERI", "Application error information"){}

				[ElementInfo(0, "APPLICATION ERROR DETAILS", "M", "1", "", "" )]
public E901 E901 { get; set; }

		
    }
}