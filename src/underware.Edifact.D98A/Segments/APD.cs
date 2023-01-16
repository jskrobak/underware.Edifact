using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class APD : Segment
    {
        public APD() : base("APD", "Additional transport details"){}

				[ElementInfo(0, "TRANSPORT DETAILS", "C", "1", "", "" )]
public E961 E961 { get; set; }

		
    }
}