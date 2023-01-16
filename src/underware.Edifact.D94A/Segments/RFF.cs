using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class RFF : Segment
    {
        public RFF() : base("RFF", "Reference"){}

				[ElementInfo(0, "REFERENCE", "M", "1", "", "" )]
public C506 C506 { get; set; }

		
    }
}