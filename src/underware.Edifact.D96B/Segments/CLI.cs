using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class CLI : Segment
    {
        public CLI() : base("CLI", "Clinical intervention"){}

				[ElementInfo(0, "Clinical intervention qualifier", "M", "1", "an..3", "" )]
public string E9441 { get; set; }
		[ElementInfo(1, "CLINICAL INTERVENTION DETAILS", "C", "1", "", "" )]
public C828 C828 { get; set; }

		
    }
}