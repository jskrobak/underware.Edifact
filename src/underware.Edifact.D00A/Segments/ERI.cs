
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class ERI : Segment
    {
        public ERI() : base("ERI", "Application error information"){}

				[ElementInfo(0, "APPLICATION ERROR DETAILS", "M", "1", "", "" )]
public E901 E901 { get; set; }

		
    }
}