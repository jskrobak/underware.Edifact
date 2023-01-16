using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class CNX : Segment
    {
        public CNX() : base("CNX", "Connection details"){}

				[ElementInfo(0, "CONNECTION DETAILS", "C", "9", "", "" )]
public E999 E999 { get; set; }

		
    }
}