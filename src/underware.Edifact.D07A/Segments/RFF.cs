using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class RFF : Segment
    {
        public RFF() : base("RFF", "REFERENCE"){}

				[ElementInfo(0, "REFERENCE", "Mandatory", "", "", "" )]
public C506 C506 { get; set; }

		
    }
}