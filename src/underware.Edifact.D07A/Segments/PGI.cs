using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PGI : Segment
    {
        public PGI() : base("PGI", "PRODUCT GROUP INFORMATION"){}

				[ElementInfo(0, "PRODUCT GROUP TYPE CODE", "Mandatory", "", "", "" )]
public string E5379 { get; set; }
		[ElementInfo(1, "PRODUCT GROUP", "Conditional", "", "", "" )]
public C288 C288 { get; set; }

		
    }
}