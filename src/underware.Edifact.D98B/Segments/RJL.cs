using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class RJL : Segment
    {
        public RJL() : base("RJL", "Accounting journal identification"){}

				[ElementInfo(0, "ACCOUNTING JOURNAL IDENTIFICATION", "C", "1", "", "" )]
public C595 C595 { get; set; }
		[ElementInfo(1, "ACCOUNTING ENTRY TYPE DETAILS", "C", "1", "", "" )]
public C596 C596 { get; set; }

		
    }
}