using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class UNT : Segment
    {
        public UNT() : base("UNT", "MESSAGE TRAILER"){}

				[ElementInfo(0, "NUMBER OF SEGMENTS IN A MESSAGE", "Mandatory", "", "", "" )]
public string E0074 { get; set; }
		[ElementInfo(1, "MESSAGE REFERENCE NUMBER", "Mandatory", "", "", "" )]
public string E0062 { get; set; }

		
    }
}