using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class ICD : Segment
    {
        public ICD() : base("ICD", "Insurance cover description"){}

				[ElementInfo(0, "INSURANCE COVER TYPE", "M", "1", "", "" )]
public C330 C330 { get; set; }
		[ElementInfo(1, "INSURANCE COVER DETAILS", "M", "1", "", "" )]
public C331 C331 { get; set; }

		
    }
}